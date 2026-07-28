USE [TaqueriaBD]
GO
-- Descripción: Tabla para los usuarios que podran manipular el sistema

CREATE TABLE [dbo].[UsuariosSistema](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[ApellidoPaterno] [varchar](40) NOT NULL,
	[ApellidoMaterno] [varchar](40) NULL,
	[Usuario] [varchar](15) NOT NULL,
	[Contrasena] [varchar](250) NOT NULL,
	[Activo] [bit] NOT NULL,
	[UltimoLogin] [datetime] NULL,
	[Vecesreintento] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Permisos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UsuariosSistema] ADD  DEFAULT ((0)) FOR [Activo]
GO

ALTER TABLE [dbo].[UsuariosSistema] ADD  DEFAULT ((0)) FOR [Vecesreintento]
GO

ALTER TABLE [dbo].[UsuariosSistema] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO

ALTER TABLE [dbo].[UsuariosSistema] ADD CONSTRAINT UQ_UsuariosSistema_Usuario UNIQUE ([Usuario]);
GO


