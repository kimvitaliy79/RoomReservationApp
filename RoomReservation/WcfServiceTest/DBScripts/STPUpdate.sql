USE [RoomReservation]
GO

/****** Object:  StoredProcedure [dbo].[Stp_UpdateBookDetails]    Script Date: 12/05/19 9:51:42 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Stp_UpdateBookDetails]
	-- Add the parameters for the stored procedure here
            @BookingID int,
			@RoomID int,		
	        @BookedDateFrom nvarchar(20) ,
	        @BookedDateTO nvarchar(20) ,
	        @BookingStatus int ,	       
	        @AdvancePayed nvarchar (100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	
	UPDATE BookingDetails
	Set RoomID=@RoomID,
	    BookedDateFrom=@BookedDateFrom,
		BookedDateTO=@BookedDateTO,
		BookingStatus=@BookingStatus,	
		AdvancePayed=@AdvancePayed
	where BookingID=@BookingID

END

GO


