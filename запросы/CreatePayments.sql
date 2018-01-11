CREATE TABLE [dbo].[Payment](
	[Payment_Id] [int] IDENTITY NOT NULL,
	[User_Id] [int] NOT NULL,
	[Service_Id] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Amount] [float] NOT NULL
	)