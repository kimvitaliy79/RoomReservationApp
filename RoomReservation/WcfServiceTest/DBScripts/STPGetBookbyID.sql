USE [RoomReservation]
GO

/****** Object:  StoredProcedure [dbo].[Stp_GetBookDetailsByID]    Script Date: 12/05/19 7:01:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Stp_GetBookDetailsByID]
	-- Add the parameters for the stored procedure here
     @BookingID int
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
	 FROM BookingDetails 	where [BookingID]= @BookingID
END

GO


