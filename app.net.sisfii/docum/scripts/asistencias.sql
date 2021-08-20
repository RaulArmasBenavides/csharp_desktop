USE [bdcongreso]
GO

/****** Object:  Table [dbo].[asistencias]    Script Date: 19/08/2021 21:12:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[asistencias](
	[idasistencias] [int] IDENTITY(1,1) NOT NULL,
	[idparticipante] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idasistencias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[asistencias]  WITH CHECK ADD FOREIGN KEY([idparticipante])
REFERENCES [dbo].[participantes] ([idparticipante])
ON DELETE CASCADE
GO

