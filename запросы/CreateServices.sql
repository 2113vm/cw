CREATE TABLE [dbo].[Service](
	[Service_Id] [int] IDENTITY NOT NULL,
	[Price] [float] NOT NULL,
	[ProviderName] [nvarchar](50) NOT NULL,
	[ServiceName] [nvarchar](50) NOT NULL
	)