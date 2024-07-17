USE [Transactions]
GO

/****** Object:  Table [dbo].[transactions]    Script Date: 17-07-2024 11:48:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transactions](
	[tid] [int] IDENTITY(1,1) NOT NULL,
	[profileid] [uniqueidentifier] NOT NULL,
	[name] [varchar](100) NULL,
	[category] [int] NULL,
	[summary] [varchar](200) NULL,
	[amount] [int] NULL,
	[payment_gateway] [varchar](10) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[transactions] ADD  DEFAULT (getdate()) FOR [created_at]
GO

ALTER TABLE [dbo].[transactions] ADD  DEFAULT (getdate()) FOR [updated_at]
GO

ALTER TABLE [dbo].[transactions]  WITH CHECK ADD FOREIGN KEY([profileid])
REFERENCES [dbo].[profiles] ([id])
GO


USE [Transactions]
GO

/****** Object:  Table [dbo].[transactions]    Script Date: 17-07-2024 11:48:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[transactions](
	[tid] [int] IDENTITY(1,1) NOT NULL,
	[profileid] [uniqueidentifier] NOT NULL,
	[name] [varchar](100) NULL,
	[category] [int] NULL,
	[summary] [varchar](200) NULL,
	[amount] [int] NULL,
	[payment_gateway] [varchar](10) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[transactions] ADD  DEFAULT (getdate()) FOR [created_at]
GO

ALTER TABLE [dbo].[transactions] ADD  DEFAULT (getdate()) FOR [updated_at]
GO

ALTER TABLE [dbo].[transactions]  WITH CHECK ADD FOREIGN KEY([profileid])
REFERENCES [dbo].[profiles] ([id])
GO


