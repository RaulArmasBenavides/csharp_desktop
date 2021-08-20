USE [bdcongreso]
GO

/****** Object:  Table [dbo].[usuarios]    Script Date: 19/08/2021 21:13:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nchar](10) NULL,
	[clave] [nchar](10) NULL,
	[estado] [nchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ('S') FOR [estado]
GO

