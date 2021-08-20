USE [bdcongreso]
GO

/****** Object:  Table [dbo].[sala]    Script Date: 19/08/2021 21:13:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sala](
	[idsala] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](80) NOT NULL,
	[ubicacion] [nvarchar](80) NOT NULL,
	[capacidad] [int] NULL,
	[fecha_creacion] [date] NULL,
	[estado] [nchar](2) NULL,
	[rol_creacion] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idsala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sala] ADD  DEFAULT ((0)) FOR [capacidad]
GO

ALTER TABLE [dbo].[sala] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO

ALTER TABLE [dbo].[sala] ADD  DEFAULT ('S') FOR [estado]
GO

