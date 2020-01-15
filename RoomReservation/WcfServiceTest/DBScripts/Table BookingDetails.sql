USE [RoomReservation]
GO

/****** Object:  Table [dbo].[BookingDetails]    Script Date: 12/05/19 6:59:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BookingDetails](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[RoomID] [int] NOT NULL,
	[BookedDateFrom] [nvarchar](20) NOT NULL,
	[BookedDateTO] [nvarchar](20) NOT NULL,
	[BookingStatus] [int] NOT NULL,	
	[AdvancePayed] [nvarchar](100) NULL,
 CONSTRAINT [PK_BookingDetails] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


