USE [TaqueriaBD]
GO

CREATE procedure [dbo].[sp_ObtenerUsuarios]
as
begin
set nocount on;
select Usuario from UsuariosSistema where Activo=1 order by id
end
GO


