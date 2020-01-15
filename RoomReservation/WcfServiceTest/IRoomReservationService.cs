using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceTest.Model;

namespace WcfServiceTest
{
    [ServiceContract]
    public interface IRoomReservationService
    {
        [OperationContract]
        IEnumerable<BookingDetails> BookingRooms();

        [OperationContract]
        int AddEditBookingRoom(BookingDetails bookingRoom);

        [OperationContract]
        int DeleteBookingRoom(int bookingID);

        [OperationContract]
        BookingDetails GetBookingRoom(int bookingID);
    }   
}
