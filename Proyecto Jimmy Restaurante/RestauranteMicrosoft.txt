-- Empresa        :  RESTAURANTE
-- Producto       :  SISTEMA RESTAURANTE          
-- Software       :  RESTAURANTE
-- DBMS           :  SQL Server
-- Base de Datos  :  RestauranteMicrosoft
-- Script         :  Crea los objetos de la base de datos y carga datos de prueba
-- Responsable    :  Raúl Marcelo Armas Benavides RMAB
-- Creado por     :  Raúl Marcelo Armas Benavides RMAB
-- Actualizaciones:  
--  10/11/2019 Se creó la base de datos 
-- 16/11/2019 Se actualizó la base de datos 
-- 18/11/2019
---------------------------------------------------------------------------------
-- Creación de la Base de Datos
---------------------------------------------------------------------------------
USE [Master]
GO

CREATE DATABASE RestauranteMicrosoft ON  PRIMARY
( NAME = N'RestauranteMicrosoft', FILENAME = N'D:\RestauranteMicrosoft.mdf' ,
  SIZE = 2GB , MAXSIZE = 8GB, FILEGROWTH = 2GB )
LOG ON
( NAME = N'RestauranteMicrosoft_log', FILENAME = N'D:\RestauranteMicrosoft_log.ldf' ,
SIZE = 1GB , MAXSIZE = 2GB , FILEGROWTH = 10%)
GO

use RestauranteMicrosoft
go

use RestauranteMicrosoft
go

IF EXISTS ( SELECT name FROM sysobjects
   WHERE type = 'U' AND name = 'Reservacion' )
   DROP TABLE Reservacion
IF EXISTS ( SELECT name FROM sysobjects
   WHERE type = 'U' AND name = 'Menu' )
   DROP TABLE Menu
IF EXISTS ( SELECT name FROM sysobjects
   WHERE type = 'U' AND name = 'Sucursal' )
   DROP TABLE Sucursal
IF EXISTS ( SELECT name FROM sysobjects
   WHERE type = 'U' AND name = 'Empleado' )
   DROP TABLE Empleado
IF EXISTS ( SELECT name FROM sysobjects
   WHERE type = 'U' AND name = 'Cliente' )
   DROP TABLE Cliente

create table Cliente 
( 
idCliente int IDENTITY NOT NULL,
nombreCliente nchar(20) NOT NULL,
cedulaCliente nchar(20) NOT NULL, 
dirCliente  nchar(100) DEFAULT '--',
telefonoCliente nchar(20) DEFAULT '--',
edadCliente int NOT NULL,
generoCliente nchar(20) DEFAULT '--',
PRIMARY KEY(idCliente)
)

create table Sucursal
(  
idSuc  int IDENTITY NOT NULL,
nombreSuc  nchar(20) NOT NULL,
capacidadSuc int NOT NULL,
establecimientoSuc nchar(20) NOT NULL,
ciudadSuc nchar(25) NOT NULL,
direccionSuc nvarchar(100) NOT NULL,
telefonoSuc  nchar(20) NOT NULL,
serieSuc  nchar(20) NOT NULL,
numAutorizacionSuc int, 
fechaVigenciaFactSuc DATE NOT NULL,
PRIMARY KEY(idSuc)
)

create table Empleado
(  
idEmp  int IDENTITY NOT NULL,
nombreEmp  nchar(20) NOT NULL,
generoEmp nchar(20) NOT NULL,
cargoEmp nchar(20) NOT NULL,
fechaNacEmp DATE NOT NULL,
PRIMARY KEY(idEmp)
) 

create table Menu
(  
idMenu int IDENTITY NOT NULL, 
nombreMenu nvarchar(50) NOT NULL, 
descripcionMenu nvarchar(100) NOT NULL,
precioMenu  real, 
disponibilidadMenu nvarchar(100),
PRIMARY KEY(idMenu)
) 

create table Reservacion
(  
idReservacion int IDENTITY NOT NULL, 
idCliente int FOREIGN KEY REFERENCES Cliente(idCliente) ON DELETE CASCADE,
fechaReservacion DATE NOT NULL,
estado nchar(5),
PRIMARY KEY(idReservacion)
) 


