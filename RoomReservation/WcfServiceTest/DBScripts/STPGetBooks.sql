USE [RoomReservation]
GO
/****** Object:  StoredProcedure [dbo].[Stp_GetBookDetails]    Script Date: 12/05/19 9:53:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Stp_GetBookDetails]
	-- Add the parameters for the stored procedure here
     
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT 
		   [BookingID]
		  ,[RoomID]
		  ,[BookedDateFrom]
		  ,[BookedDateTO]
		  ,[BookingStatus]		
		  ,[AdvancePayed]
	 FROM BookingDetails	
END
