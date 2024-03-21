CREATE DATABASE CONTRATAREMPLEADOS

CREATE TABLE PERSONA
(
	IDPERSONA INT IDENTITY (1,1) NOT NULL,
	NOMBRE NVARCHAR (50) NOT NULL,
	APELLIDO NVARCHAR (50) NOT NULL,
	ESTADO NVARCHAR (50) NOT NULL,
	PRIMARY KEY (IDPERSONA), 

);
CREATE TABLE EMPLEADO
(
	IDEMPLEADO INT IDENTITY (1,1) NOT NULL,
	IDPERSONA INT NOT NULL,
	PUESTO NVARCHAR (50) NOT NULL,
	SALARIO NVARCHAR (50) NOT NULL,
	FECHADECONTRATACION DATETIME NOT NULL,
	PRIMARY KEY (IDEMPLEADO),
	FOREIGN KEY (IDPERSONA) REFERENCES PERSONA (IDPERSONA)
);

insert into persona values('Manuel' ,'Chorolque ','Activo');
insert into persona values('Bob' ,'Construye' ,'Activo');
insert into persona values('Setch','Valverde' ,'Activo');
insert into persona values('Carlos' ,'Mendoza' ,'Activo');
insert into persona values('Kevin','Mamani','Activo');

select * from persona

insert into empleado values(1,'Carpintero','2000','1990-12-24 23:58:00');
insert into empleado values(2,'Publicista','2000','2016-05-10 10:00:00');
insert into empleado values(3,'Cantante','2500','2006-05-15 10:45:00');
insert into empleado values(4,'Cobrador','3000','2024-01-07 22:30:00');
insert into empleado values(5,'Contador','2000','2022-02-12 10:10:00');

select * from empleado