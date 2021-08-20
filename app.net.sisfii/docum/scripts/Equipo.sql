USE [bdcongreso]
GO

/****** Object:  Table [dbo].[Equipo]    Script Date: 19/08/2021 21:12:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Equipo](
	[idEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](20) NULL,
	[SO] [nchar](10) NULL,
	[Procesador] [nchar](30) NULL,
	[RAM] [nchar](10) NULL,
	[TarjetaMadre] [nchar](10) NULL,
	[estado] [nchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Equipo] ADD  DEFAULT ('S') FOR [estado]
GO

