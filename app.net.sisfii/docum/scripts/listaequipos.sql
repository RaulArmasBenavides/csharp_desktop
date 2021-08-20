USE [bdcongreso]
GO

/****** Object:  Table [dbo].[listaequipos]    Script Date: 19/08/2021 21:13:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[listaequipos](
	[idlistaeq] [int] IDENTITY(1,1) NOT NULL,
	[estado] [nchar](2) NULL,
	[idEquipo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idlistaeq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[listaequipos] ADD  DEFAULT ('S') FOR [estado]
GO

ALTER TABLE [dbo].[listaequipos]  WITH CHECK ADD FOREIGN KEY([idEquipo])
REFERENCES [dbo].[Equipo] ([idEquipo])
ON DELETE CASCADE
GO

