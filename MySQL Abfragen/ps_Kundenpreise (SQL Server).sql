USE [CpmDB]
GO
/****** Object:  StoredProcedure [dbo].[ps_Kundenpreise]    Script Date: 27.07.2015 13:28:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ps_Kundenpreise]
	-- Add the parameters for the stored procedure here
	@Kundennr char(10)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @sql varchar(2000)
	DECLARE @nsql nvarchar(2000)

SET @sql ='SELECT * FROM OPENQUERY([SAGEODBC], ' + '''CALL `sagecl_mandant001`.`sp_Kundenpreise`(' + @Kundennr + ')'')' + ' AS Kundenpreise'
PRINT @sql
SET @nsql = CAST( @sql AS nvarchar(4000) )

EXEC sp_executesql @nsql
RETURN 0

END
