

CREATE DATABASE DBVenta
GO

USE DBVenta

GO

CREATE TABLE Venta(
id int primary key,
clientes varchar(100)not null,
cantidades int not null,
Precio decimal(18,2)
);