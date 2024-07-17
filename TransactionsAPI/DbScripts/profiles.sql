USE [Transactions]
GO

/****** Object:  Table [dbo].[profiles]    Script Date: 17-07-2024 11:48:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[profiles](
	[id] [uniqueidentifier] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[img] [varchar](100) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[profiles] ADD  DEFAULT (newsequentialid()) FOR [id]
GO

ALTER TABLE [dbo].[profiles] ADD  DEFAULT (getdate()) FOR [created_at]
GO

ALTER TABLE [dbo].[profiles] ADD  DEFAULT (getdate()) FOR [updated_at]
GO


