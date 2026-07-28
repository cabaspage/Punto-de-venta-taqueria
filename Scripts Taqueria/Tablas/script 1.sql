USE [TaqueriaBD]
GO

-- Descripción: Tabla para indicar que roles existen para los usuarios 

CREATE TABLE [dbo].[RolesUsuariosSistemas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rol_usuario] [varchar](30) NOT NULL,
	[activo] [bit] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL
) ON [PRIMARY]
GO


