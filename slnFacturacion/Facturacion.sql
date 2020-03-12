CREATE DATABASE dbFacturacion;
USE dbFacturacion;
GO
CREATE TABLE Cliente(
ID int IDENTITY(1,3) PRIMARY KEY,
Nombre varchar(50) NOT NULL,
Apellido varchar(50) NOT NULL,
Ciudad varchar(50) NOT NULL
);
INSERT INTO Cliente
VALUES	('Armando','Amarilla','Alaska'),
		('Blanca','Bernabeu','Buenos Aires'),
		('Cinthia','Cuarzo','Buenos Aires'),
		('Dario','Dominguez','La Matanza');

--Esto es lo que puse en los metodos de AdminCliente
SELECT id, nombre, apellido, ciudad FROM Cliente;
SELECT id, nombre, apellido, ciudad FROM Cliente WHERE ciudad='Alaska'


SELECT DISTINCT(Ciudad) FROM Cliente;