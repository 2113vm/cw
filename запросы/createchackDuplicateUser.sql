-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE checkDuplicateUser
	-- Add the parameters for the stored procedure here
	@FirstName nvarchar(50),
	@SecondName nvarchar(50),
	@ThirdName nvarchar(50),
	@Address nvarchar(50),
	@Passport int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT User_Id
	FROM Users 
	WHERE Address = @Address 
	  and FirstName = @FirstName
	  and LastName = @SecondName
	  and ThirdName = @ThirdName
	  and Passport = @Passport
END
GO
