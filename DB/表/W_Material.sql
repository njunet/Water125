USE [Codematic]
GO
/****** 对象:  Table [dbo].[W_Material]    脚本日期: 03/27/2010 09:52:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[W_Material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) COLLATE Chinese_PRC_CI_AS NULL,
	[Begindate] [datetime] NULL,
	[Enddate] [datetime] NULL,
	[Number] [varchar](150) COLLATE Chinese_PRC_CI_AS NULL,
	[Address] [varchar](150) COLLATE Chinese_PRC_CI_AS NULL,
 CONSTRAINT [PK_W_Material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF