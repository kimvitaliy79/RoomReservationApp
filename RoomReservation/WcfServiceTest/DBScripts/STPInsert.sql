USE [RoomReservation]
GO

/****** Object:  StoredProcedure [dbo].[Stp_InsertBookDetails]    Script Date: 12/05/19 9:51:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Stp_InsertBookDetails]
	-- Add the parameters for the stored procedure here            
			@RoomID int,		
	        @BookedDateFrom nvarchar(20),
	        @BookedDateTO nvarchar(20),
	        @BookingStatus int ,	      
	        @AdvancePayed nvarchar (100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	
	INSERT INTO [dbo].[BookingDetails]
           ([RoomID]
           ,[BookedDateFrom]
           ,[BookedDateTO]
           ,[BookingStatus]         
           ,[AdvancePayed])
	    values(@RoomID,	@BookedDateFrom, @BookedDateTO,	@BookingStatus,	@AdvancePayed)
	

END

GO


