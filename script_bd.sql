-- ============================================================================
-- Proyecto: HotelZormat - Sistema de Gestión Hotelera
-- Asignatura: ISW-123 Programación Media
-- Estudiante: Anthony Buitrago
-- Pasaporte / ID: 143540342
-- Matrícula: 2024-2047
-- ============================================================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HotelZormatDB')
BEGIN
    CREATE DATABASE HotelZormatDB;
END
GO

USE HotelZormatDB;
GO

-- 1. Tabla Usuarios
IF OBJECT_ID('dbo.Usuarios', 'U') IS NOT NULL DROP TABLE dbo.Usuarios;
CREATE TABLE dbo.Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    ClaveHash NVARCHAR(256) NOT NULL,
    Rol NVARCHAR(30) NOT NULL -- 'Administrador' o 'Recepcionista'
);

-- 2. Tabla Habitaciones
IF OBJECT_ID('dbo.Habitaciones', 'U') IS NOT NULL DROP TABLE dbo.Habitaciones;
CREATE TABLE dbo.Habitaciones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Numero INT NOT NULL UNIQUE,
    Tipo NVARCHAR(30) NOT NULL, -- 'Sencilla', 'Doble', 'Suite'
    Piso NVARCHAR(10) NOT NULL,
    Estado NVARCHAR(30) NOT NULL DEFAULT 'Disponible', -- 'Disponible', 'Ocupada', 'Reservada', 'Limpieza'
    Capacidad INT NOT NULL DEFAULT 2,
    TarifaBase DECIMAL(18,2) NOT NULL DEFAULT 50.00
);

-- 3. Tabla Huespedes
IF OBJECT_ID('dbo.Huespedes', 'U') IS NOT NULL DROP TABLE dbo.Huespedes;
CREATE TABLE dbo.Huespedes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TipoDocumento NVARCHAR(20) NOT NULL, -- 'Cédula' o 'Pasaporte'
    NumeroDocumento NVARCHAR(30) NOT NULL UNIQUE,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL
);

-- 4. Tabla Reservas
IF OBJECT_ID('dbo.Reservas', 'U') IS NOT NULL DROP TABLE dbo.Reservas;
CREATE TABLE dbo.Reservas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HuespedId INT NOT NULL FOREIGN KEY REFERENCES dbo.Huespedes(Id),
    HabitacionId INT NOT NULL FOREIGN KEY REFERENCES dbo.Habitaciones(Id),
    FechaCheckIn DATETIME NOT NULL,
    FechaCheckOut DATETIME NOT NULL,
    Temporada NVARCHAR(20) NOT NULL DEFAULT 'Alta', -- 'Alta', 'Media', 'Baja'
    Estado NVARCHAR(30) NOT NULL DEFAULT 'Pendiente', -- 'Pendiente', 'Confirmada', 'Cancelada', 'Completada'
    TotalNoches INT NOT NULL,
    MontoTotal DECIMAL(18,2) NOT NULL
);

-- 5. Tabla Facturas
IF OBJECT_ID('dbo.Facturas', 'U') IS NOT NULL DROP TABLE dbo.Facturas;
CREATE TABLE dbo.Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ReservaId INT NOT NULL FOREIGN KEY REFERENCES dbo.Reservas(Id),
    NCF NVARCHAR(20) NOT NULL UNIQUE, -- ej: B0200000001
    FechaEmision DATETIME NOT NULL DEFAULT GETDATE(),
    Subtotal DECIMAL(18,2) NOT NULL,
    ITBIS DECIMAL(18,2) NOT NULL, -- 18%
    PropinaLegal DECIMAL(18,2) NOT NULL, -- 10%
    Total DECIMAL(18,2) NOT NULL
);

-- 6. Tabla Bitacora
IF OBJECT_ID('dbo.Bitacora', 'U') IS NOT NULL DROP TABLE dbo.Bitacora;
CREATE TABLE dbo.Bitacora (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioNombre NVARCHAR(100) NOT NULL,
    Accion NVARCHAR(100) NOT NULL,
    FechaHora DATETIME NOT NULL DEFAULT GETDATE(),
    Detalles NVARCHAR(255) NULL
);
GO

-- ============================================================================
-- INSERT DE DATOS INICIALES
-- Contraseña de admin: "admin123" -> Hash SHA256: 240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9
-- Contraseña de recep: "recep123" -> Hash SHA256: 529b4e5480572e428e21bc19e59af3ddff93d7c570b281f62c0eb424fcf88f28
-- ============================================================================

INSERT INTO dbo.Usuarios (Nombre, Usuario, ClaveHash, Rol) VALUES
('Administrador Principal', 'admin', '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Administrador'),
('Recepcionista Turno A', 'recep', '5d37ed314cf2b5c8462b52b12cd512e2ac4a180e75598da4f12bfb0dea6d0a67', 'Recepcionista');

INSERT INTO dbo.Habitaciones (Numero, Tipo, Piso, Estado, Capacidad, TarifaBase) VALUES
(101, 'Sencilla', '1', 'Disponible', 1, 50.00),
(102, 'Sencilla', '1', 'Disponible', 1, 50.00),
(201, 'Doble', '2', 'Ocupada', 2, 80.00),
(202, 'Doble', '2', 'Reservada', 2, 80.00),
(301, 'Suite', '3', 'Limpieza', 4, 150.00),
(302, 'Suite', '3', 'Disponible', 4, 150.00);

INSERT INTO dbo.Huespedes (TipoDocumento, NumeroDocumento, Nombre, Telefono, Email) VALUES
('Cédula', '40212345678', 'Juan Pérez', '8095550101', 'juan.perez@email.com'),
('Pasaporte', '143540342', 'Anthony Buitrago', '8295550202', 'anthony@email.com');

INSERT INTO dbo.Bitacora (UsuarioNombre, Accion, Detalles) VALUES
('Sistema', 'Inicialización', 'Base de datos y datos iniciales creados exitosamente');
GO
