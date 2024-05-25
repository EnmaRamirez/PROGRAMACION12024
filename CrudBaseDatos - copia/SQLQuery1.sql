CREATE TABLE Venta(
id int primary key,
clientes varchar(100)not null,
cantidades varchar(100)not null,
Precio varchar(50)
);

ALTER TABLE Venta
ALTER COLUMN cantidades int not null;

ALTER TABLE Venta
ALTER COLUMN Precio decimal (18,2)

SELECT * FROM Venta;
