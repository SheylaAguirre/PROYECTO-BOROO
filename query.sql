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




CREATE TABLE Cotizacion (
	IDCotizacion iNT IDENTITY(1,1)NOT NULL,
	Nombre VARCHAR(30)NULL,
	OrdenDeCompra VARCHAR(7)NULL,
	Fecha DATETIME NULL, 
	Total MONEY NULL,
	Descripcion VARCHAR(150) NULL
);

--SOLO SON EJEMPLOS Y DATOS DE RELLENO PARA DEMOSTRAR FUNCIONALIDAD
--AUN FALTA IMPLEMENTACION
INSERT INTO Cotizacion (Nombre, OrdenDeCompra, Fecha, Total, Descripcion)
VALUES
    ('Cliente 1', 'OC001', '2023-10-23 09:00:00', 100.50, 'Cotización 1'),
    ('Cliente 2', 'OC002', '2023-10-24 10:15:00', 200.75, 'Cotización 2'),
    ('Cliente 3', 'OC003', '2023-10-25 11:30:00', 150.25, 'Cotización 3'),
    ('Cliente 4', 'OC004', '2023-10-26 12:45:00', 300.00, 'Cotización 4'),
    ('Cliente 5', 'OC005', '2023-10-27 14:00:00', 75.20, 'Cotización 5'),
    ('Cliente 6', 'OC006', '2023-10-28 15:15:00', 180.90, 'Cotización 6'),
    ('Cliente 7', 'OC007', '2023-10-29 16:30:00', 250.60, 'Cotización 7'),
    ('Cliente 8', 'OC008', '2023-10-30 17:45:00', 350.40, 'Cotización 8'),
    ('Cliente 9', 'OC009', '2023-10-31 19:00:00', 90.75, 'Cotización 9'),
    ('Cliente 10', 'OC010', '2023-11-01 20:15:00', 270.30, 'Cotización 10');


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

-- PROC. ALMACENADOS PARA COTIZACIONES

CREATE PROCEDURE CrearCotizacion
    @Nombre VARCHAR(30),
    @OrdenDeCompra VARCHAR(7),
    @Fecha DATETIME,
    @Total MONEY,
    @Descripcion VARCHAR(150)
AS
BEGIN
    INSERT INTO Cotizacion (Nombre, OrdenDeCompra, Fecha, Total, Descripcion)
    VALUES (@Nombre, @OrdenDeCompra, @Fecha, @Total, @Descripcion);
END

CREATE PROCEDURE LeerCotizacion
AS
BEGIN
    SELECT * FROM Cotizacion
END

CREATE PROCEDURE BorrarCotizacion
    @IDCotizacion INT
AS
BEGIN
    DELETE FROM Cotizacion
    WHERE IDCotizacion = @IDCotizacion;
END

