USE [TaqueriaBD]
GO

CREATE procedure [dbo].[RegistrarUsuariosNuevos]
(
@Nombre nvarchar(50),
@Apellidop nvarchar(50),
@apellidom nvarchar(50),
@Usuario nvarchar(15),
@Contrasena nvarchar(250)
)
AS
BEGIN
set nocount on;
if exists (select 1 from UsuariosSistema where Usuario = @Usuario)
Begin
Select 0 as Resultado, 'El usuario ya existe' as Mensaje;
return;
end

insert into UsuariosSistema
(
Nombre,
ApellidoPaterno,
ApellidoMaterno,
Usuario,
Contrasena,
Activo,
FechaCreacion
)
Values (
@Nombre,
@Apellidop,
@apellidom,
@Usuario,
@Contrasena,
0,
GETDATE()
);
select 1 as Resultado, 'Usuario registrado con exito' as mensaje;
end
GO


