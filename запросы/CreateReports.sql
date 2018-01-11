CREATE TABLE [dbo].[Report](
	[Report_Id] [int] IDENTITY NOT NULL,
	[Serivce_Id] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Meterage] [int] NOT NULL
	)