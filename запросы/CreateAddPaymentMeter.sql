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
CREATE PROCEDURE addPaymentMeter 
	-- Add the parameters for the stored procedure here
	@User_Id int,
	@Service_Id int,
	@diff int,
	@Date datetime2
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT dbo.Payments (User_Id, Service_Id, Date, Amount) VALUES (@User_Id, @Service_Id, @Date, @diff*(SELECT Price
																										 FROM Services
																										 WHERE Services.Service_Id = @Service_Id)*(-1))
END
GO
