USE [bdcongreso]
GO

/****** Object:  Table [dbo].[actividades]    Script Date: 19/08/2021 21:12:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[actividades](
	[idactividad] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](80) NOT NULL,
	[fecha_creacion] [date] NULL,
	[rol_creacion] [nchar](10) NOT NULL,
	[estado] [nchar](2) NULL,
	[idlistaeq] [int] NULL,
	[idasistencias] [int] NULL,
	[idsala] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idactividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[actividades] ADD  DEFAULT (getdate()) FOR [fecha_creacion]
GO

ALTER TABLE [dbo].[actividades] ADD  DEFAULT ('S') FOR [estado]
GO

ALTER TABLE [dbo].[actividades]  WITH CHECK ADD FOREIGN KEY([idasistencias])
REFERENCES [dbo].[asistencias] ([idasistencias])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[actividades]  WITH CHECK ADD FOREIGN KEY([idlistaeq])
REFERENCES [dbo].[listaequipos] ([idlistaeq])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[actividades]  WITH CHECK ADD FOREIGN KEY([idsala])
REFERENCES [dbo].[sala] ([idsala])
ON DELETE CASCADE
GO

