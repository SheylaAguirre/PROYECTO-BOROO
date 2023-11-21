CREATE DATABASE Supermercado
USE [Supermercado]
GO
/****** Object:  Table [dbo].[Entrada]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrada](
	[IDEntrada] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[Cant_entradas] [int] NULL,
	[NroDocCal] [varchar](50) NULL,
	[idSucursal] [int] NULL,
	[IDProveedor] [int] NULL,
	[fecRegProduct] [date] NULL,
 CONSTRAINT [PK_Entrada] PRIMARY KEY CLUSTERED 
(
	[IDEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenCompra]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenCompra](
	[nroOrden] [int] IDENTITY(1,1) NOT NULL,
	[fecOrden] [date] NULL,
	[nroCotizacion] [varchar](4) NULL,
	[IDProveedor] [int] NULL,
	[nroReq] [int] NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[nroOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRESUPUESTO]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRESUPUESTO](
	[IdPresupuesto] [int] IDENTITY(1,1) NOT NULL,
	[Factura] [varchar](50) NULL,
	[IDProveedor] [int] NULL,
	[Monto] [float] NULL,
	[MetodoDePago] [varchar](26) NULL,
	[Saldo] [int] NULL,
	[dtp_fecha] [date] NULL,
 CONSTRAINT [PK_Presupuesto] PRIMARY KEY CLUSTERED 
(
	[IdPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](30) NULL,
	[Categoria] [varchar](30) NULL,
	[IDProveedor] [int] NULL,
	[stock] [int] NULL,
	[precioProducto] [float] NULL,
	[tamaño] [varchar](30) NULL,
	[FecVencimiento] [date] NULL,
	[estProducto] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IDProveedor] [int] IDENTITY(1,1) NOT NULL,
	[RUCProveedor] [varchar](20) NULL,
	[Categoria] [varchar](20) NULL,
	[NombreProveedor] [varchar](100) NULL,
	[FormaPago] [varchar](20) NULL,
	[DireccionProveedor] [varchar](200) NULL,
	[TelefonoProveedor] [varchar](20) NULL,
	[CorreoElectronicoProveedor] [varchar](100) NULL,
	[FechaRegistro] [date] NULL,
	[EstadoProveedor] [bit] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IDProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requerimiento]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requerimiento](
	[nroReq] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[cantReq] [int] NULL,
	[fecReq] [date] NULL,
 CONSTRAINT [PK_Requerimiento] PRIMARY KEY CLUSTERED 
(
	[nroReq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salida]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salida](
	[IdSalida] [int] IDENTITY(1,1) NOT NULL,
	[idProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[idSucursal] [int] NULL,
	[DocSalida] [varchar](50) NULL,
	[FecSalida] [date] NULL,
 CONSTRAINT [PK_Salida] PRIMARY KEY CLUSTERED 
(
	[IdSalida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[NombreSucursal] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Pais] [varchar](50) NULL,
	[Departamento] [varchar](50) NULL,
	[Distrito] [varchar](50) NULL,
	[estSucursal] [bit] NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Entrada] ON 
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (1, 8, 40, N'C00281920', 1, 2, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (2, 2, 50, N'C00281921', 3, 1, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (3, 11, 30, N'C00567823', 4, 4, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (4, 4, 20, N'C00256455', 2, 4, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (5, 15, 30, N'C00546454', 2, 5, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Entrada] ([IDEntrada], [idProducto], [Cant_entradas], [NroDocCal], [idSucursal], [IDProveedor], [fecRegProduct]) VALUES (6, 8, 20, N'C00272134', 6, 2, CAST(N'2023-06-29' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Entrada] OFF
GO
SET IDENTITY_INSERT [dbo].[OrdenCompra] ON 
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (2, CAST(N'2023-06-29' AS Date), N'C012', 2, 3)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (3, CAST(N'2023-06-29' AS Date), N'C013', 8, 1)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (4, CAST(N'2023-06-29' AS Date), N'C013', 9, 6)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (5, CAST(N'2023-06-29' AS Date), N'C014', 2, 10)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (6, CAST(N'2023-06-29' AS Date), N'C015', 6, 7)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (7, CAST(N'2023-06-29' AS Date), N'C016', 4, 2)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (8, CAST(N'2023-06-29' AS Date), N'C017', 1, 4)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (9, CAST(N'2023-06-29' AS Date), N'C018', 5, 5)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (10, CAST(N'2023-06-29' AS Date), N'C019', 10, 8)
GO
INSERT [dbo].[OrdenCompra] ([nroOrden], [fecOrden], [nroCotizacion], [IDProveedor], [nroReq]) VALUES (11, CAST(N'2023-06-29' AS Date), N'C020', 6, 9)
GO
SET IDENTITY_INSERT [dbo].[OrdenCompra] OFF
GO
SET IDENTITY_INSERT [dbo].[PRESUPUESTO] ON 
GO
INSERT [dbo].[PRESUPUESTO] ([IdPresupuesto], [Factura], [IDProveedor], [Monto], [MetodoDePago], [Saldo], [dtp_fecha]) VALUES (1, N'F00256121', 2, 2500, N'Transferencia Bancaria', 4000, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[PRESUPUESTO] ([IdPresupuesto], [Factura], [IDProveedor], [Monto], [MetodoDePago], [Saldo], [dtp_fecha]) VALUES (2, N'F00232341', 1, 3500, N'Transferencia Bancaria', 5000, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[PRESUPUESTO] ([IdPresupuesto], [Factura], [IDProveedor], [Monto], [MetodoDePago], [Saldo], [dtp_fecha]) VALUES (3, N'F00334121', 10, 1200, N'Transferencia Bancaria', 3000, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[PRESUPUESTO] ([IdPresupuesto], [Factura], [IDProveedor], [Monto], [MetodoDePago], [Saldo], [dtp_fecha]) VALUES (5, N'F00651217', 7, 2400, N'Transferencia Bancaria', 4000, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[PRESUPUESTO] ([IdPresupuesto], [Factura], [IDProveedor], [Monto], [MetodoDePago], [Saldo], [dtp_fecha]) VALUES (6, N'F00249912', 3, 4222, N'Efectivo', 4222, CAST(N'2023-11-20' AS Date))
GO
SET IDENTITY_INSERT [dbo].[PRESUPUESTO] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (1, N'PanBlanco Bimbo', N'Productos de panadería y confi', 1, 40, 8.8999996185302734, N'500gr', CAST(N'2023-08-15' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (2, N'Rapiditas Bimbo', N'Productos de panadería y confi', 1, 30, 6.4000000953674316, N'120gr', CAST(N'2023-08-24' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (3, N'Bimboletes', N'Productos de panadería y confi', 1, 60, 3.5, N'12gr', CAST(N'2023-08-10' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (4, N'Pinguinos', N'Productos de panadería y confi', 1, 30, 5.5999999046325684, N'40gr', CAST(N'2023-08-26' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (5, N'Yogurt Fresa Gloria', N'Productos lácteos', 2, 40, 8.5, N'1L', CAST(N'2023-09-26' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (6, N'BatiMix Gloria', N'Productos lácteos', 2, 60, 3.5, N'250 ml', CAST(N'2023-09-28' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (7, N'Leche Evaporada Gloria', N'Productos lácteos', 2, 30, 3.5999999046325684, N'500 ml', CAST(N'2023-09-30' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (8, N'Pro Gloria', N'Productos lácteos', 2, 70, 6.5, N'250 ml', CAST(N'2023-09-01' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (9, N'Yogurt Sbelt Laive', N'Productos lácteos', 1, 30, 8.5, N'1L', CAST(N'2023-10-17' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (10, N'Yogurt Proteico Laive', N'Productos lácteos', 3, 20, 12.199999809265137, N'800 ml', CAST(N'2023-10-18' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (11, N'Angel Flakes', N'Productos envasados', 4, 120, 2.5, N'150 gr', CAST(N'2023-10-30' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (12, N'Mel Angel', N'Productos envasados', 4, 80, 2.5, N'150 gr', CAST(N'2023-10-30' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (13, N'Almohaditas Angel', N'Productos envasados', 4, 40, 2.5, N'150 gr', CAST(N'2023-10-30' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (14, N'Jamon San fernando', N'Alimentos frescos', 5, 30, 6.1999998092651367, N'250 gr', CAST(N'2023-07-10' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (15, N'Pavita San Fernando', N'Alimentos frescos', 5, 28, 15.800000190734863, N'500 gr', CAST(N'2023-07-10' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (16, N'Hot Dog San Fernando', N'Alimentos frescos', 5, 30, 8.6000003814697266, N'300 gr', CAST(N'2023-07-10' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (17, N'Mayones Alacena', N'Productos envasados', 6, 40, 6.6999998092651367, N'250 ml', CAST(N'2023-08-25' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (18, N'Fideos Don Vitorio', N'Productos envasados', 6, 55, 8.6000003814697266, N'400 gr', CAST(N'2023-08-25' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (19, N'Aceite Primor', N'Productos envasados', 6, 40, 6.6999998092651367, N'800 ml', CAST(N'2023-08-25' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (20, N'Chocolate Sublime', N'Productos envasados', 7, 40, 2.5, N'45 gr', CAST(N'2023-10-26' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (21, N'Nescafe', N'Productos envasados', 7, 60, 8.5, N'120 gr', CAST(N'2023-10-26' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (22, N'Pesi Duri Chocochips Donofrio', N'Alimentos congelados', 7, 70, 15.5, N'1L', CAST(N'2023-10-31' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (23, N'Inka cola', N'Bebidas', 8, 200, 3, N'500 ml', CAST(N'2023-10-31' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (24, N'Coca Cola', N'Bebidas', 8, 100, 5.5, N'1L', CAST(N'2023-10-31' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (25, N'Papas Lay''s', N'Productos envasados', 9, 50, 3.5, N'150gr', CAST(N'2023-11-20' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (26, N'Piqueos Snacks', N'Productos envasados', 9, 80, 3.5, N'150 gr', CAST(N'2023-11-20' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (27, N'Vainilla Field', N'Productos envasados', 10, 40, 1.2000000476837158, N'45 gr', CAST(N'2023-11-30' AS Date), 1)
GO
INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [Categoria], [IDProveedor], [stock], [precioProducto], [tamaño], [FecVencimiento], [estProducto]) VALUES (28, N'Cua Cua Field', N'Productos envasados', 10, 40, 1.6000000238418579, N'45 gr', CAST(N'2023-11-30' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (1, N'20734038', N'Persona Natural', N'Bimbo S.A.', N'Transferencia Bancar', N'Av. Panderos #56', N'982345675', N'bimbo.ositos@bimbo,pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (2, N'20763019', N'Persona Juridica', N'Gloria', N'Cheque', N'Av. Vacunos #24', N'912375340', N'gloria.lacteos@gloria.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (3, N'20562342', N'Persona Juridica', N'Laive', N'Credito', N'Av. Lactea #23', N'931967465', N'lacteos.laive@laive.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (4, N'20344576', N'Persona Juridica', N'Cereales Angel', N'Debito', N'Av. Flakes #666', N'923897123', N'angel.cereales@angel.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (5, N'20141751', N'Persona Juridica', N'San Fernando', N'Cheque', N'Av. Pavitas #12', N'935678276', N'san.fernando@sfernando.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (6, N'20455678', N'Persona Juridica', N'Alicorp', N'Transferencia Bancar', N'Av. Alianza #56', N'984567032', N'alicorp.s.a.@alicorp.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (7, N'20781214', N'Persona Juridica', N'Nestle', N'Credito', N'Av. Ingenieria #78', N'955343678', N'nestle@nestle.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (8, N'20576532', N'Persona Juridica', N'LINDLEY', N'Cheque', N'Av. Coca #23', N'912564891', N'lindley.cocacola@lindley.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (9, N'20173476', N'Persona Juridica', N'Frito Lay', N'Efectivo', N'Av. Frituras #87', N'945262924', N'frito.lay@fritolay.pe', CAST(N'2023-06-29' AS Date), 1)
GO
INSERT [dbo].[Proveedor] ([IDProveedor], [RUCProveedor], [Categoria], [NombreProveedor], [FormaPago], [DireccionProveedor], [TelefonoProveedor], [CorreoElectronicoProveedor], [FechaRegistro], [EstadoProveedor]) VALUES (10, N'20141567', N'Persona Juridica', N'FIELD', N'Efectivo', N'Av. Galleteros#45', N'912786654', N'galletas.field@field.pe', CAST(N'2023-06-29' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Requerimiento] ON 
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (1, 23, 120, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (2, 12, 50, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (3, 6, 20, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (4, 2, 60, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (5, 16, 40, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (6, 26, 80, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (7, 18, 30, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (8, 28, 20, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (9, 19, 100, CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Requerimiento] ([nroReq], [idProducto], [cantReq], [fecReq]) VALUES (10, 5, 30, CAST(N'2023-06-29' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Requerimiento] OFF
GO
SET IDENTITY_INSERT [dbo].[Salida] ON 
GO
INSERT [dbo].[Salida] ([IdSalida], [idProducto], [Cantidad], [idSucursal], [DocSalida], [FecSalida]) VALUES (1, 19, 30, 5, N'S0028912', CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Salida] ([IdSalida], [idProducto], [Cantidad], [idSucursal], [DocSalida], [FecSalida]) VALUES (2, 23, 50, 10, N'S00281517', CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Salida] ([IdSalida], [idProducto], [Cantidad], [idSucursal], [DocSalida], [FecSalida]) VALUES (3, 11, 20, 6, N'S00345689', CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Salida] ([IdSalida], [idProducto], [Cantidad], [idSucursal], [DocSalida], [FecSalida]) VALUES (4, 5, 40, 6, N'S00214576', CAST(N'2023-06-29' AS Date))
GO
INSERT [dbo].[Salida] ([IdSalida], [idProducto], [Cantidad], [idSucursal], [DocSalida], [FecSalida]) VALUES (5, 20, 30, 4, N'S00121415', CAST(N'2023-06-29' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Salida] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (1, N'Sede Trujillo', N'Av. Larco #433', N'Peru', N'La Libertad', N'Trujillo', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (2, N'Sede Victor Larco', N'Av. Los Angeles #51', N'Peru', N'La Libertad', N'Victor Larco', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (3, N'Sede Moche', N'Jr. Miguel Grau', N'Peru', N'La Libertad', N'Moche', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (4, N'Sede Chimbote', N'Av. Arequipeña', N'Peru', N'Ancash', N'Nuevo Chimbote', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (5, N'Sede Los Olivos', N'Av. Caceres #67', N'Peru', N'Lima', N'Los Olivos', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (6, N'Sede Miraflores', N'Av. Kennedy #12', N'Peru', N'Lima', N'Miraflores', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (7, N'Sede San Borja', N'Av. Rosa Toro #12', N'Peru', N'Lima', N'San Borja', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (8, N'Sede Comas', N'Av. Villegas #54', N'Peru', N'Lima', N'Comas', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (9, N'Sede Ate', N'Av, Ugarte #45', N'Peru', N'Lima', N'Ate', 1)
GO
INSERT [dbo].[Sucursal] ([idSucursal], [NombreSucursal], [Direccion], [Pais], [Departamento], [Distrito], [estSucursal]) VALUES (10, N'Sede Barranco', N'Av. Granda #81', N'Peru', N'Lima', N'Barranco', 1)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[Proveedor] ([IDProveedor])
GO
ALTER TABLE [dbo].[Entrada]  WITH CHECK ADD FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
ALTER TABLE [dbo].[OrdenCompra]  WITH CHECK ADD FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[Proveedor] ([IDProveedor])
GO
ALTER TABLE [dbo].[OrdenCompra]  WITH CHECK ADD FOREIGN KEY([nroReq])
REFERENCES [dbo].[Requerimiento] ([nroReq])
GO
ALTER TABLE [dbo].[PRESUPUESTO]  WITH CHECK ADD FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[Proveedor] ([IDProveedor])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[Proveedor] ([IDProveedor])
GO
ALTER TABLE [dbo].[Requerimiento]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
/****** Object:  StoredProcedure [dbo].[InsertarSalida]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[InsertarSalida]
(
    @idProducto INT,
    @Cantidad int,
    @idSucursal int,
	@DocSalida varchar(50),
    @FecSalida DATE
)
AS
BEGIN
    INSERT INTO Salida(idProducto, Cantidad, idSucursal,DocSalida, FecSalida)
    VALUES (@idProducto, @Cantidad, @idSucursal,@DocSalida, @FecSalida)
END
GO
/****** Object:  StoredProcedure [dbo].[ListarSalida]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[ListarSalida]
AS
BEGIN
    SELECT IdSalida, idProducto, Cantidad, idSucursal, DocSalida, FecSalida
    FROM Salida
	
END
GO
/****** Object:  StoredProcedure [dbo].[spBuscarNroReq]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[spBuscarNroReq]
(@prmintnroReq int
)
as
	begin
		select
		req.nroReq,
		req.idProducto,
		prod.nombreProducto,
		req.cantReq,
		req.fecReq
	from Requerimiento req 
	inner join Producto prod 
	on req.idProducto= prod.idProducto 
	where nroReq = @prmintnroReq
	END
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarOrden]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spDeshabilitarOrden]
(@nroOrden int)
as
BEGIN
    DELETE FROM OrdenCompra
    WHERE nroOrden  = @nroOrden;
END;
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarProducto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[spDeshabilitarProducto]
(@idProducto int
)
as
begin
update Producto set
estProducto = 0
where idProducto = @idProducto
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarProveedor]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[spDeshabilitarProveedor]
(@IDProveedor int
)
as
begin
update Proveedor set
EstadoProveedor = 0
where IDProveedor = @IDProveedor
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarRequerimiento]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spDeshabilitarRequerimiento]
(@nroReq int
)
as
BEGIN
    DELETE FROM Requerimiento
    WHERE nroReq  = @nroReq ;
END;
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarSucursal]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   PROCEDURE [dbo].[spDeshabilitarSucursal]
(@idSucursal int
)
as
begin
update Sucursal set
estSucursal = 0
where idSucursal = @idSucursal
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabiltarEntradas]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeshabiltarEntradas]
    @IDEntrada INT
AS
BEGIN
    DELETE FROM Entrada
    WHERE IDEntrada = @IDEntrada;
END;
GO
/****** Object:  StoredProcedure [dbo].[spEditarProducto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spEditarProducto]
(@idProducto int,
@nombreProducto varchar(30),
@Categoria varchar(30),
@IDProveedor varchar(30),
@stock int,
@precioProducto float,
@tamaño varchar(30),
@FecVencimiento date,
@estProducto bit
)as
begin
    update Producto set
    nombreProducto = @nombreProducto,
    Categoria = @Categoria,
    IDProveedor = @IDProveedor,
    stock = @stock,
	precioProducto = @precioProducto,
    tamaño = @tamaño,
    FecVencimiento = @FecVencimiento,
	estProducto = @estProducto
    where idProducto = @idProducto
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarProveedor]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spEditarProveedor]
(@IDProveedor int,
@RUCProveedor varchar(20),
@Categoria VARCHAR(20),
@NombreProveedor varchar(100),
@FormaPago varchar(20),
@DireccionProveedor varchar(200),
@TelefonoProveedor varchar(20),
@CorreoElectronicoProveedor VARCHAR(100),
@FechaRegistro date,
@EstadoProveedor bit
)as
begin
    update Proveedor set
    RUCProveedor = @RUCProveedor,
	Categoria = @Categoria,
    NombreProveedor = @NombreProveedor,
	FormaPago = @FormaPago,
    DireccionProveedor = @DireccionProveedor,
    TelefonoProveedor = @TelefonoProveedor,
	CorreoElectronicoProveedor = @CorreoElectronicoProveedor,
	FechaRegistro = @FechaRegistro,
    EstadoProveedor = @EstadoProveedor
    where IDProveedor = @IDProveedor
end
GO
/****** Object:  StoredProcedure [dbo].[spEditarSucursal]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spEditarSucursal]
(@idSucursal int,
 @NombreSucursal varchar(50), 
@Direccion varchar(50), 
@Pais varchar(50),
@Departamento varchar(50),
@Distrito varchar(50),
@estSucursal bit
)
as
begin
    update Sucursal set
    NombreSucursal = @NombreSucursal,
    Direccion = @Direccion,
	Pais = @Pais,
	Departamento = @Departamento,
	Distrito = @Distrito,
    estSucursal = @estSucursal
    
    where idSucursal = @idSucursal
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarPresupuesto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarPresupuesto]
    @IdPresupuesto INT
AS
BEGIN
    DELETE FROM PRESUPUESTO
    WHERE IdPresupuesto = @IdPresupuesto;
END;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarSalida]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spEliminarSalida]
    @IdSalida INT
AS
BEGIN
    DELETE FROM Salida
    WHERE IdSalida = @IdSalida;
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertaEntradas]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spInsertaEntradas]
(@idProducto int,
@Cant_entradas nvarchar(50),
@NroDocCal varchar (50),
@idSucursal int,
@IDProveedor int,
@fecRegProduct date
)
as
begin 

    insert into Entrada(idProducto,Cant_entradas,NroDocCal,idSucursal,IDProveedor,fecRegProduct) values
    (@idProducto,@Cant_entradas, @NroDocCal,@idSucursal,@IDProveedor,@fecRegProduct)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarOrden]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spInsertarOrden]
(@fecOrden date,
@nroCotizacion varchar(6),
@IDProveedor int,
@nroReq int
)
as
	begin
	insert into OrdenCompra(fecOrden,
	nroCotizacion,
	IDProveedor,
	nroReq) values
	(@fecOrden,
	@nroCotizacion,
	@IDProveedor,
	@nroReq
	)end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPresupuesto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spInsertarPresupuesto]
    @Factura varchar(50),
    @IDProveedor int,
    @Monto Float,
    @MetodoDePago VARCHAR(26),
    @Saldo int,
    @dtp_fecha Date
AS
BEGIN
    INSERT INTO PRESUPUESTO (Factura, IDProveedor, Monto, MetodoDePago, Saldo, dtp_fecha)
    VALUES (@Factura, @IDProveedor, @Monto, @MetodoDePago, @Saldo, @dtp_fecha);
END;
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProducto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spInsertarProducto]
(@nombreProducto varchar(30),
@Categoria varchar(30),
@IDProveedor varchar(30),
@stock int,
@precioProducto float,
@tamaño varchar(30),
@FecVencimiento date,
@estProducto bit
)
as
begin
    insert into Producto(nombreProducto,
    Categoria,
    IDProveedor,
    stock,
	precioProducto,
    tamaño,
    FecVencimiento,
	estProducto) values
    (@nombreProducto,
    @Categoria,
    @IDProveedor,
    @stock,
	@precioProducto,
    @tamaño,
    @FecVencimiento,
    @estProducto)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProveedor]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spInsertarProveedor]
(@RUCProveedor varchar(20),
@Categoria VARCHAR(20),
@NombreProveedor varchar(100),
@FormaPago varchar(20),
@DireccionProveedor varchar(200),
@TelefonoProveedor varchar(20),
@CorreoElectronicoProveedor VARCHAR(100),
@FechaRegistro date,
@EstadoProveedor bit
)
as
begin
    insert into Proveedor(RUCProveedor,
	Categoria,
    NombreProveedor,
	FormaPago,
    DireccionProveedor,
    TelefonoProveedor,
	CorreoElectronicoProveedor,
	FechaRegistro,
    EstadoProveedor
    ) values
    (@RUCProveedor,
	@Categoria,
    @NombreProveedor,
	@FormaPago,
    @DireccionProveedor,
	
    @TelefonoProveedor,
	@CorreoElectronicoProveedor,
	@FechaRegistro,
    @EstadoProveedor
    )
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarRequerimiento]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spInsertarRequerimiento]
(@idProducto varchar(30),
@cantReq int,
@fecreq date
)
as
begin
	 insert into Requerimiento(idProducto,
	 cantReq,
	 fecreq
	 ) values(@idProducto,
	 @cantReq,
	 @fecReq
	 )
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSucursal]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spInsertarSucursal]
( 
 @NombreSucursal varchar(50), 
@Direccion varchar(50), 
@Pais varchar(50),
@Departamento varchar(50),
@Distrito varchar(50),
@estSucursal bit
)
as
begin
    insert into Sucursal( 
        NombreSucursal, 
        Direccion,
		Pais,
		Departamento,
		Distrito,
        estSucursal) values
    (@NombreSucursal, 
        @Direccion,
		@Pais,
		@Departamento,
		@Distrito,
        @estSucursal)
end
GO
/****** Object:  StoredProcedure [dbo].[spListaEntradas]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spListaEntradas] 
AS
    SELECT IDEntrada, idProducto, Cant_entradas, NroDocCal, idSucursal, IDProveedor,fecRegProduct
    from Entrada
GO
/****** Object:  StoredProcedure [dbo].[spListaPresupuesto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[spListaPresupuesto]
AS
BEGIN
    SELECT IdPresupuesto, Factura, IDProveedor, Monto, MetodoDePago, Saldo, dtp_fecha
    FROM PRESUPUESTO;
END;
GO
/****** Object:  StoredProcedure [dbo].[spListarOrden]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListarOrden]
as
	select
		nroOrden,
		fecOrden,
		nroCotizacion,
		IDProveedor,
		nroReq
	From OrdenCompra
GO
/****** Object:  StoredProcedure [dbo].[spListarProducto]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[spListarProducto]
as 
    Select 
        idProducto, 
        nombreProducto, 
        Categoria, 
        IDProveedor,
        stock,
		precioProducto,
        tamaño,
        FecVencimiento,
		estProducto
    FROM Producto
    Where estProducto = '1'
GO
/****** Object:  StoredProcedure [dbo].[spListarProveedor]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListarProveedor]
as 
    Select 
        IDProveedor, 
        RUCProveedor,
		Categoria,
        NombreProveedor,
		FormaPago,
        DireccionProveedor,
        TelefonoProveedor,
		CorreoElectronicoProveedor,
		FechaRegistro,
        EstadoProveedor
    FROM Proveedor
    Where EstadoProveedor = '1'
GO
/****** Object:  StoredProcedure [dbo].[spListarRequerimiento]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   procedure [dbo].[spListarRequerimiento]
as
	select
		nroReq,
		idProducto,
		cantReq,
		fecReq
	from Requerimiento
GO
/****** Object:  StoredProcedure [dbo].[spListarSucursal]    Script Date: 21/11/2023 01:29:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[spListarSucursal]
as 
    Select 
        idSucursal, 
        NombreSucursal, 
        Direccion, 
		Pais,
		Departamento,
		Distrito,
        estSucursal
    FROM Sucursal
    Where estSucursal = '1'
GO

