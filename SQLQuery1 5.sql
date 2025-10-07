create database institucion_educativ
go
use institucion_educativ
go

------------------------------------------------tabla de roles--------------------------------------------------------
create table roles(
idRol int identity(1,1) primary key,
nombreRol varchar(50) not null
);

------------------------------------------------tabla de usuarios------------------------------------------------------
create table usuarios(
idUsuario int identity(1,1) primary key,
idRol int not null,
nombre varchar(100) not null,
correo varchar(100) unique not null,
telefono varchar(15),
contraseña varchar(255) not null,
constraint fk_usu_roles foreign key(idrol) references roles(idrol) on delete cascade
);

-----------------------------------------------------tabla de profesores-------------------------------------------------
create table profesores(
idProfesor int primary key identity(1,1),
idUsuario int unique not null,
constraint fk_profe_usu foreign key(idUsuario) references usuarios(idUsuario) on delete cascade
);

------------------------------------------------------tabla de estudiantes------------------------------------------------
create table estudiantes(
idEstudiante int primary key identity(1,1),
idUsuario int unique not null,
constraint fk_estu_usu foreign key(idusuario) references usuarios(idusuario) on delete cascade
);

-------------------------------------------------------tabla de materias---------------------------------------------------
create table materias(
idMateria int primary key identity(1,1),
nombreMateria varchar(100) not null,
idProfesor int not null,
constraint fk_mat_prof foreign key(idProfesor) references profesores(idProfesor) on delete cascade
);

--------------------------------------------------------tabla de calificaciones-----------------------------------------
create table calificaciones(
idCalificacion int primary key identity(1,1),
idEstudiante int not null,
idMateria int not null,
Calificacion decimal(5,2) check(calificacion between 0 and 10),
Fecharegistro datetime default getdate(),
constraint fk_califi_estu foreign key(idEstudiante) references estudiantes(idEstudiante) on delete cascade,
constraint fk_califi_mat foreign key(idMateria) references materias(idMateria)
);


insert into roles (nombreRol) values ('admin');
insert into roles (nombreRol) values ('profesor');
insert into roles (nombreRol) values ('estudiante');

insert into usuarios (idRol, nombre, correo, telefono, contraseña)
values (1, 'admin', 'admin@gmail.com', '77777777', 'admin123');

-- usuario profesor
insert into usuarios (idRol, nombre, correo, telefono, contraseña)
values (2, 'Sandor Osorio', 'sandor@instituto.com', '12345678', 'Sandor123');


SELECT C.idMateria, m.nombreMateria,C.idEstudiante, u.nombre from calificaciones C INNER JOIN materias m ON C.idMateria = m.idMateria INNER JOIN estudiantes E ON E.idEstudiante = C.idEstudiante INNER JOIN usuarios u On u.idUsuario = E.idUsuario; 
Select m.idMateria, m.nombreMateria from materias m ;
-- usuario estudiante
insert into usuarios (idRol, nombre, correo, telefono, contraseña)
values (3, 'Roberth Martinez', 'Roberth@instituto.com', '87654321', 'Roberth123');


-- materia asignada al profesor
insert into materias (nombreMateria, idProfesor)
values ('matemáticas', 1);

-- calificación para el estudiante
insert into calificaciones (idEstudiante, idMateria, Calificacion, Fecharegistro)
values (1, 1, 9.50, getdate());

select * from roles;
select * from usuarios;
select * from profesores;
select * from estudiantes;
select * from materias;
select * from calificaciones;

CREATE TRIGGER trg_InsertarProfesor
ON Usuarios
AFTER INSERT
AS
BEGIN
    INSERT INTO Profesores (idUsuario)
    SELECT idUsuario
    FROM inserted
    WHERE idRol = 2;
END;

CREATE TRIGGER trg_InsertarEstudiante
ON Usuarios
AFTER INSERT
AS
BEGIN
    INSERT INTO estudiantes (idUsuario)
    SELECT idUsuario
    FROM inserted
    WHERE idRol = 3;
END;


SELECT m.idProfesor, m.nombreMateria, u.nombre
FROM profesores p
INNER JOIN materias m ON m.idProfesor = p.idProfesor
INNER JOIN usuarios u ON u.idUsuario = p.idUsuario;

SELECT m.idMateria, m.nombreMateria, u.nombre FROM profesores p INNER JOIN materias m ON m.idProfesor = p.idProfesor INNER JOIN usuarios u ON u.idUsuario = p.idUsuario;