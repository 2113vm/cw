CREATE TABLE [dbo].[User](
	[User_Id] [int] IDENTITY NOT NULL,
	[Role_Id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[ThirdName] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Passport] [int] NOT NULL,
	[Area] [float] NOT NULL,
	[Tenants] [int] NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[DateRegistration] [datetime2](7) NOT NULL
	)