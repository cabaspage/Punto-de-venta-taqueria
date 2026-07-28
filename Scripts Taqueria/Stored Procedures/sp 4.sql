USE [TaqueriaBD]
GO

CREATE PROCEDURE [dbo].[sp_ReintentosUsuario]
(
@IdUsuario int
)
as
begin
set nocount on;
update UsuariosSistema set Vecesreintento = Vecesreintento + 1
where id = @IdUsuario;

declare @intentos int;

select @intentos = VecesReintento
from UsuariosSistema where Usuario= @IdUsuario;

if @intentos >= 3
begin
select 0 as Resultado, 'Se alcanzo el limite de intentos' as Mensaje,
@intentos as Intentos;
end

end
GO


