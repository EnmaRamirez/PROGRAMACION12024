ALTER TABLE Venta
ALTER COLUMN cantidades int not null;

ALTER TABLE Venta
ALTER COLUMN Precio decimal (18,2)

EXEC sp_colums 'Venta';