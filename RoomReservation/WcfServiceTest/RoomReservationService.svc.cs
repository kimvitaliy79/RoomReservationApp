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
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single,
        InstanceContextMode = InstanceContextMode.PerSession)]
    public class RoomReservationService : IRoomReservationService
    {
        BookingRepository bookRep;
        public RoomReservationService()
        {
            bookRep = new BookingRepository();
        }

        public int AddEditBookingRoom(BookingDetails bookingRoom)
        {
            int result = 0;
            if (bookingRoom.BookingID == 0)
            {
                result= bookRep.InsertItem(bookingRoom);
            }
            else
            {
                result= bookRep.UpdateItem(bookingRoom);
            }


            return result;
        }

        public IEnumerable<BookingDetails> BookingRooms()
        {
            return bookRep.GetItems();
        }

        public int DeleteBookingRoom(int bookingID)
        {
          return bookRep.DeleteItem(bookingID);
        }

        public BookingDetails GetBookingRoom(int bookingID)
        {
            return bookRep.GetItemByID(bookingID);
        }
    }
}
