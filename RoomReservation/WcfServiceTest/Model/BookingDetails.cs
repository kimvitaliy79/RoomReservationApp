using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceTest.Model
{
   public class BookingDetails
    {        
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int BookingStatus { get; set; }
        public string BookedDateFrom { get; set; }
        public string BookedDateTO { get; set; }  
        public string AdvancePayed { get; set; }
    }
}
