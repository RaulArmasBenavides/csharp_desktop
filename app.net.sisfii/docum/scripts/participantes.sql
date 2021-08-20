USE [bdcongreso]
GO

/****** Object:  Table [dbo].[participantes]    Script Date: 19/08/2021 21:13:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[participantes](
	[idparticipante] [int] IDENTITY(1,1) NOT NULL,
	[ap_paterno] [varchar](30) NOT NULL,
	[ap_materno] [varchar](30) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[telefono] [nchar](20) NULL,
	[sexo] [nchar](1) NOT NULL,
	[correo] [nvarchar](80) NOT NULL,
	[DNI] [nchar](8) NOT NULL,
	[carrera] [nvarchar](80) NULL,
	[direccion] [nvarchar](80) NULL,
	[estado] [nchar](2) NULL,
	[tipo_participante] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idparticipante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[participantes] ADD  DEFAULT ('--') FOR [telefono]
GO

ALTER TABLE [dbo].[participantes] ADD  DEFAULT ('S') FOR [estado]
GO

