USE [p2716217]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblStaff_FilteredByStaffId]
		@StaffId = 3

SELECT	@return_value as 'Return Value'

GO
