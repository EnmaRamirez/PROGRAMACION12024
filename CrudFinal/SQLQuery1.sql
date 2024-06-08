
CREATE DATABASE DBMi_BaseAlumnos
GO
USE DBMi_BaseAlumnos


CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Alumnos (
    Carnet INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(15),
    Grado NVARCHAR(50),
    UsuarioID INT,
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

INSERT INTO Usuarios (Nombre)
VALUES ('Fredy Palma'), ('Estefany Ordoñez'), ('Carlos Ramirez');

INSERT INTO Alumnos (Nombre, Telefono, Grado, UsuarioID)
VALUES 
('Fredy Palma', '665432', 'Primero', 1),
('Estefany Ordoñez', '543217', 'Segundo', 2),
('Carlos Ramirez', '456123', 'Tercero', 3);

select * from Alumnos