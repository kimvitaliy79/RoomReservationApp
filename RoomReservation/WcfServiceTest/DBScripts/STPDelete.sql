USE [RoomReservation]
GO

/****** Object:  StoredProcedure [dbo].[Stp_DeleteBookDetails]    Script Date: 12/05/19 7:00:30 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Stp_DeleteBookDetails]
	-- Add the parameters for the stored procedure here
            @BookingID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	DELETE FROM BookingDetails where BookingID=@BookingID

	
END

GO


