USE [BankCredit]
GO
/****** Object:  Table [dbo].[People]    Script Date: 9/28/2018 12:01:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Surname] [nvarchar](30) NOT NULL,
	[Passportnumber] [nvarchar](12) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credit]    Script Date: 9/28/2018 12:01:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Disburs] [datetime] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Person] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[All_data]    Script Date: 9/28/2018 12:01:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[All_data] as
select Credit.Person, People.Name,Credit.Amount
from Credit,People
where Credit.ID=People.ID
GO
ALTER TABLE [dbo].[Credit]  WITH CHECK ADD FOREIGN KEY([Person])
REFERENCES [dbo].[People] ([ID])
GO
