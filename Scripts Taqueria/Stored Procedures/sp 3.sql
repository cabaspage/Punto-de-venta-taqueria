USE [TaqueriaBD]
GO

CREATE PROCEDURE [dbo].[sp_Login]
(
    @Usuario VARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        id,
        Usuario,
        Contrasena
    FROM UsuariosSistema
    WHERE Usuario = @Usuario;
END
GO


