-- Creación de la base de datos
CREATE DATABASE ControlMigracion;
GO

USE ControlMigracion;
GO

-- Tabla Usuario
CREATE TABLE Usuario (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);

-- Tabla Viajero
CREATE TABLE Viajero (
    ViajeroID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Pasaporte NVARCHAR(20) NOT NULL UNIQUE,
    FechaNacimiento DATE NOT NULL,
    Nacionalidad NVARCHAR(50) NOT NULL
);

-- Tabla Pais
CREATE TABLE Pais (
    PaisID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL UNIQUE,
    CodigoISO NVARCHAR(3) NOT NULL UNIQUE
);

-- Tabla Viaje
CREATE TABLE Viaje (
    ViajeID INT PRIMARY KEY IDENTITY(1,1),
    ViajeroID INT NOT NULL,
    FechaInicio DATE NOT NULL,
    FechaFin DATE,
    FOREIGN KEY (ViajeroID) REFERENCES Viajero(ViajeroID)
);

-- Tabla EntradaSalida
CREATE TABLE EntradaSalida (
    EntradaSalidaID INT PRIMARY KEY IDENTITY(1,1),
    ViajeID INT NOT NULL,
    PaisID INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Tipo NVARCHAR(10) NOT NULL CHECK (Tipo IN ('Entrada', 'Salida')),
    FOREIGN KEY (ViajeID) REFERENCES Viaje(ViajeID),
    FOREIGN KEY (PaisID) REFERENCES Pais(PaisID)
);

-- Inserción de datos de ejemplo
INSERT INTO Usuario (Nombre, Apellido, Email, Password) VALUES 
('Admin', 'Sistema', 'admin@migracion.com', 'hashed_password_here'),
('Juan', 'Pérez', 'juan@email.com', 'hashed_password_here');

INSERT INTO Viajero (Nombre, Apellido, Pasaporte, FechaNacimiento, Nacionalidad) VALUES 
('María', 'González', 'AB123456', '1990-05-15', 'Mexicana'),
('Carlos', 'Rodríguez', 'CD789012', '1985-11-22', 'Colombiana');

INSERT INTO Pais (Nombre, CodigoISO) VALUES 
('México', 'MEX'),
('Colombia', 'COL'),
('Estados Unidos', 'USA');

INSERT INTO Viaje (ViajeroID, FechaInicio, FechaFin) VALUES 
(1, '2023-01-10', '2023-01-20'),
(2, '2023-02-15', '2023-02-28');

INSERT INTO EntradaSalida (ViajeID, PaisID, Fecha, Tipo) VALUES 
(1, 1, '2023-01-10 08:00:00', 'Salida'),
(1, 3, '2023-01-10 12:00:00', 'Entrada'),
(1, 3, '2023-01-20 10:00:00', 'Salida'),
(1, 1, '2023-01-20 14:00:00', 'Entrada'),
(2, 2, '2023-02-15 09:00:00', 'Salida'),
(2, 3, '2023-02-15 13:00:00', 'Entrada'),
(2, 3, '2023-02-28 11:00:00', 'Salida'),
(2, 2, '2023-02-28 15:00:00', 'Entrada');