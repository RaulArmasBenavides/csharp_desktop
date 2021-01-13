/*	Creacion de la BD: dbEncargos
	Fecha	:	02/08/2020
	Autor	:	Ing. Wiler Arturo Ponce Benites
*/

USE master
GO

CREATE DATABASE dbEncargos
ON PRIMARY
(	NAME = dbEncargos,
	FILENAME = 'C:\EFBD_ChalaAndré\dbEncargos\dbEncargos.mdf',
	SIZE = 8MB,
	MAXSIZE = unlimited,
	FILEGROWTH = 20%
)
LOG ON
(	NAME = dbEncargos_log,
	FILENAME = 'C:\EFBD_ChalaAndré\dbEncargos\dbEncargos_log.ldf',
	SIZE = 1MB,
	MAXSIZE = unlimited,
	FILEGROWTH = 2MB
)
GO
