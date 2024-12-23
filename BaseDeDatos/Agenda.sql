USE [Agenda]
GO
/****** Object:  Table [dbo].[Confirmaciones]    Script Date: 25/11/2024 8:22:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Confirmaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEvento] [int] NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_Confirmaciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eventos]    Script Date: 25/11/2024 8:22:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eventos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NULL,
	[Descripcion] [varchar](250) NULL,
	[Fecha] [datetime] NULL,
	[Ubicacion] [varchar](250) NULL,
	[Capacidad] [int] NULL,
	[Imagen] [varchar](500) NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_Eventos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/11/2024 8:22:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](250) NULL,
	[Clave] [varchar](250) NULL,
	[Mail] [varchar](250) NULL,
	[Nombre] [varchar](250) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Eventos] ON 

INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (1, N'Nombre Evento 1', N'Descripcion  Evento 1', CAST(N'2024-11-24T00:00:00.000' AS DateTime), N'Bogota', 50, N'./Presentaciones/Karaoke.jpg', 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (2, N'Nombre Evento 2', N'Descripcion  Evento 2', CAST(N'2024-11-24T00:00:00.000' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (3, N'Nombre Evento 3', N'Descripcion  Evento 3', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (4, N'Nombre Evento 4', N'Descripcion  Evento 4', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (5, N'Nombre Evento 5', N'Descripcion  Evento 5', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (6, N'Nombre Evento 6', N'Descripcion  Evento 6', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (7, N'Nombre Evento 7', N'Descripcion  Evento 7', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (8, N'Nombre Evento 8', N'Descripcion  Evento 8', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (9, N'Nombre Evento 9', N'Descripcion  Evento 9', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (10, N'Nombre Evento 10', N'Descripcion  Evento 10', CAST(N'2024-11-24T00:00:00.010' AS DateTime), N'Bogota', 50, NULL, 1)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (11, N'Nombre Evento 11', N'Descripcion  Evento 11', CAST(N'2024-11-24T00:00:00.000' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (12, N'Nombre Evento 12', N'Descripcion  Evento 12', CAST(N'2024-11-24T00:00:00.000' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (13, N'Nombre Evento 13', N'Descripcion  Evento 13', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (14, N'Nombre Evento 14', N'Descripcion  Evento 14', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (15, N'Nombre Evento 15', N'Descripcion  Evento 15', CAST(N'2024-11-24T00:00:00.003' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (16, N'Nombre Evento 16', N'Descripcion  Evento 16', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (17, N'Nombre Evento 17', N'Descripcion  Evento 17', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (18, N'Nombre Evento 18', N'Descripcion  Evento 18', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (19, N'Nombre Evento 19', N'Descripcion  Evento 19', CAST(N'2024-11-24T00:00:00.007' AS DateTime), N'Bogota', 50, NULL, 2)
INSERT [dbo].[Eventos] ([Id], [Nombre], [Descripcion], [Fecha], [Ubicacion], [Capacidad], [Imagen], [IdUsuario]) VALUES (20, N'Nombre Evento 20', N'Descripcion  Evento 20', CAST(N'2024-11-24T00:00:00.010' AS DateTime), N'Bogota', 50, NULL, 2)
SET IDENTITY_INSERT [dbo].[Eventos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Mail], [Nombre]) VALUES (1, N'Nico52105', N'123456', N'Nico52105@gmail.com', N'Nicolas Fiquitiva')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Mail], [Nombre]) VALUES (2, N'Usuario2', N'123456', N'Usuario2@mail.com', N'Usuario Dos')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Confirmaciones]  WITH CHECK ADD  CONSTRAINT [FK_Confirmaciones_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([Id])
GO
ALTER TABLE [dbo].[Confirmaciones] CHECK CONSTRAINT [FK_Confirmaciones_Eventos]
GO
ALTER TABLE [dbo].[Confirmaciones]  WITH CHECK ADD  CONSTRAINT [FK_Confirmaciones_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([Id])
GO
ALTER TABLE [dbo].[Confirmaciones] CHECK CONSTRAINT [FK_Confirmaciones_Usuarios]
GO
ALTER TABLE [dbo].[Eventos]  WITH CHECK ADD  CONSTRAINT [FK_Eventos_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([Id])
GO
ALTER TABLE [dbo].[Eventos] CHECK CONSTRAINT [FK_Eventos_Usuarios]
GO
