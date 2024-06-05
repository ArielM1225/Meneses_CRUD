CREATE DATABASE Meneses_CRUD

USE Meneses_CRUD

CREATE TABLE Clientes(
Id int identity(1,1) primary key,
Nombre varchar(50),
Apellido varchar(50),
Num_Tel varchar(15)
)