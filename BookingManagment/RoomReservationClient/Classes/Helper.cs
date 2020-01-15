using RoomReservationClient.RoomReservationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationClient.Classes
{
   
    public static class Helper
    {
        static RoomReservationServiceClient service;
        static Helper()
        {
           service = new RoomReservationServiceClient();
        }

        public static RoomReservationServiceClient GetService()
        {            
            return service;
        }
    }
}
