-- EJECUTAR INSTRUCCION POR INSTRUCCION PARA 
--EVITAR ERRORES AL MOMENTO DE CREAR LA BASE DE DATOS

CREATE DATABASE TiendaMass;

USE TiendaMass;

CREATE TABLE Proveedor (
    IDProveedor int IDENTITY(1,1)NOT NULL,
    RUCProveedor VARCHAR(20)NULL,
    Categoria VARCHAR(20)NULL,
    NombreProveedor VARCHAR(100)NULL,
    FormaPago varchar(20)NULL,
	TelefonoProveedor VARCHAR(20)NULL,
	FechaRegistro DATETIME NULL);

--SOLO SON EJEMPLOS Y DATOS DE RELLENO PARA DEMOSTRAR FUNCIONALIDAD
--AUN FALTA IMPLEMENTACION
INSERT INTO Proveedor (RUCProveedor, Categoria, NombreProveedor, FormaPago, TelefonoProveedor, FechaRegistro)
VALUES
    ('1234567890', 'Electrónica', 'Proveedor A', 'Pago en efectivo', '123-456-7890', '2023-10-23 10:00:00'),
    ('9876543210', 'Muebles', 'Proveedor B', 'Pago con tarjeta', '987-654-3210', '2023-10-22 11:30:00'),
    ('1112223333', 'Ropa', 'Proveedor C', 'Pago en efectivo', '111-222-3333', '2023-10-21 14:15:00'),
    ('4445556666', 'Alimentos', 'Proveedor D', 'Pago con cheque', '444-555-6666', '2023-10-20 16:45:00'),
    ('7778889999', 'Electrónica', 'Proveedor E', 'Pago en efectivo', '777-888-9999', '2023-10-19 09:30:00'),
    ('2223334444', 'Muebles', 'Proveedor F', 'Pago con tarjeta', '222-333-4444', '2023-10-18 12:00:00'),
    ('5556667777', 'Ropa', 'Proveedor G', 'Pago en efectivo', '555-666-7777', '2023-10-17 13:45:00'),
    ('8889990000', 'Alimentos', 'Proveedor H', 'Pago con cheque', '888-999-0000', '2023-10-16 15:15:00'),
    ('1212121212', 'Electrónica', 'Proveedor I', 'Pago en efectivo', '121-212-1212', '2023-10-15 08:30:00'),
    ('3434343434', 'Muebles', 'Proveedor J', 'Pago con tarjeta', '343-434-3434', '2023-10-14 10:45:00');

CREATE TABLE Producto (
	IDProducto INT IDENTITY(1,1)NOT NULL,
	Nombre VARCHAR(30)NULL,
	Costo MONEY NULL,
	Descripcion VARCHAR(100) NULL,
	FechaEmision DATETIME NULL,
	FechaVencimiento DATETIME NULL
);

--SOLO SON EJEMPLOS Y DATOS DE RELLENO PARA DEMOSTRAR FUNCIONALIDAD
--AUN FALTA IMPLEMENTACION

INSERT INTO Producto (Nombre, Costo, Descripcion, FechaEmision, FechaVencimiento)
VALUES
    ('Producto 1', 19.99, 'Descripción del Producto 1', '2023-10-24 08:00:00', '2024-10-24 08:00:00'),
    ('Producto 2', 29.99, 'Descripción del Producto 2', '2023-10-25 08:00:00', '2024-10-25 08:00:00'),
    ('Producto 3', 39.99, 'Descripción del Producto 3', '2023-10-26 08:00:00', '2024-10-26 08:00:00'),
    ('Producto 4', 49.99, 'Descripción del Producto 4', '2023-10-27 08:00:00', '2024-10-27 08:00:00'),
    ('Producto 5', 59.99, 'Descripción del Producto 5', '2023-10-28 08:00:00', '2024-10-28 08:00:00'),
    ('Producto 6', 69.99, 'Descripción del Producto 6', '2023-10-29 08:00:00', '2024-10-29 08:00:00'),
    ('Producto 7', 79.99, 'Descripción del Producto 7', '2023-10-30 08:00:00', '2024-10-30 08:00:00'),
    ('Producto 8', 89.99, 'Descripción del Producto 8', '2023-10-31 08:00:00', '2024-10-31 08:00:00'),
    ('Producto 9', 99.99, 'Descripción del Producto 9', '2023-11-01 08:00:00', '2024-11-01 08:00:00'),
    ('Producto 10', 109.99, 'Descripción del Producto 10', '2023-11-02 08:00:00', '2024-11-02 08:00:00');

-- PROC. ALMACENADOS PROVEEDOR
CREATE PROCEDURE CrearProveedor
    @RUCProveedor VARCHAR(20),
    @Categoria VARCHAR(20),
    @NombreProveedor VARCHAR(100),
    @FormaPago VARCHAR(20),
    @TelefonoProveedor VARCHAR(20),
    @FechaRegistro DATETIME
AS
BEGIN
    INSERT INTO Proveedor (RUCProveedor, Categoria, NombreProveedor, FormaPago, TelefonoProveedor, FechaRegistro)
    VALUES (@RUCProveedor, @Categoria, @NombreProveedor, @FormaPago, @TelefonoProveedor, @FechaRegistro);
END



CREATE PROCEDURE LeerProveedor
AS
BEGIN
    SELECT * FROM Proveedor
END

CREATE PROCEDURE ActualizarProveedor
    @IDProveedor int,
    @RUCProveedor VARCHAR(20),
    @Categoria VARCHAR(20),
    @NombreProveedor VARCHAR(100),
    @FormaPago VARCHAR(20),
    @TelefonoProveedor VARCHAR(20),
    @FechaRegistro DATETIME
AS
BEGIN
    UPDATE Proveedor
    SET RUCProveedor = @RUCProveedor,
        Categoria = @Categoria,
        NombreProveedor = @NombreProveedor,
        FormaPago = @FormaPago,
        TelefonoProveedor = @TelefonoProveedor,
        FechaRegistro = @FechaRegistro
    WHERE IDProveedor = @IDProveedor;
END

CREATE PROCEDURE BorrarProveedor
    @IDProveedor int
AS
BEGIN
    DELETE FROM Proveedor
    WHERE IDProveedor = @IDProveedor;
END

-- PROC. ALMACENADOS PARA PRODUCTOS

CREATE PROCEDURE InsertarProducto
    @Nombre VARCHAR(30),
    @Costo MONEY,
    @Descripcion VARCHAR(100),
    @FechaEmision DATETIME,
    @FechaVencimiento DATETIME
AS
BEGIN
    INSERT INTO Producto (Nombre, Costo, Descripcion, FechaEmision, FechaVencimiento)
    VALUES (@Nombre, @Costo, @Descripcion, @FechaEmision, @FechaVencimiento);
END;

CREATE PROCEDURE ObtenerProductos
AS
BEGIN
    SELECT * FROM Producto
END;

CREATE PROCEDURE ActualizarProducto
    @IDProducto INT,
    @Nombre VARCHAR(30),
    @Costo MONEY,
    @Descripcion VARCHAR(100),
    @FechaEmision DATETIME,
    @FechaVencimiento DATETIME
AS
BEGIN
    UPDATE Producto
    SET Nombre = @Nombre,
        Costo = @Costo,
        Descripcion = @Descripcion,
        FechaEmision = @FechaEmision,
        FechaVencimiento = @FechaVencimiento
    WHERE IDProducto = @IDProducto;
END;


CREATE PROCEDURE BorrarProducto
    @IDProducto INT
AS
BEGIN
    DELETE FROM Producto
    WHERE IDProducto = @IDProducto;
END;

SELECT * FROM Producto