﻿CREATE PROCEDURE [dbo].[DepartamentosInsertar]
	@Descripcion VARCHAR(250),
	@Ubicacion VARCHAR(250),
	@Estado BIT
AS

	BEGIN
		SET NOCOUNT ON
		BEGIN TRANSACTION TRASA

		BEGIN TRY

		INSERT INTO Departamentos(Descripcion,Ubicacion,Estado)
		VALUES (@Descripcion,@Ubicacion,@Estado)

		COMMIT TRANSACTION TRASA

		SELECT 0 AS CodeError, '' AS MsgError

		END TRY

		BEGIN CATCH 

		SELECT ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MagError

		ROLLBACK TRANSACTION TRASA

		END CATCH

	END