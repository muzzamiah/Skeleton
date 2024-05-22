USE [p2716217]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSupplier_SelectAll]
		@param2 = NULL

SELECT	@return_value as 'Return Value'

GO
