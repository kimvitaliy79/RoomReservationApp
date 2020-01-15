using RoomReservationClient.Classes;
using RoomReservationClient.RoomReservationService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomReservationClient
{
   public enum BookingStatusEnum
    {
        Vacant=1,
        Reserved=2,
        Occupied=3
    }
    public partial class BookingDetailsForm : Form
    {
        public static int BookingID = 0;
        public static int RoomID = 0;
        public static int BookingStatus = 0;
        public static string AdvancePayed=string.Empty;    
        public static string BookedDateFrom = string.Empty;
        public static string BookedDateTO = string.Empty;


        public BookingDetailsForm()
        {
            InitializeComponent();           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {  
            try
            {
                e.Result = Helper.GetService().BookingRooms();
            }
            catch
            { }
        }

       
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<object> items = new List<object>();

            if(e.Result!=null)
            {
                IEnumerable<BookingDetails> resultItems = (IEnumerable<BookingDetails>)e.Result;

                foreach (BookingDetails item in resultItems)
                {

                    string bookingStatus = Enum.GetName(typeof(BookingStatusEnum), item.BookingStatus);

                    items.Add(new
                    {
                        BookingID = item.BookingID,
                        RoomID = item.RoomID,
                        BookedDateFrom = item.BookedDateFrom,
                        BookedDateTO = item.BookedDateTO,                        
                        AdvancePayed = item.AdvancePayed,
                        BookingStatus = bookingStatus
                    });
                }
                grdBooking.DataSource = items;
            }  
        }

        private void BookingDetailsForm_Load(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            addEditForm.ShowDialog();
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }

        private void grdBooking_SelectionChanged(object sender, EventArgs e)
        {
            //public static int BookingStatus = 0;           

            if (((DataGridView)sender).SelectedRows.Count>0)
            {
                BookingID = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["BookingID"].Value);
                RoomID = Convert.ToInt32(((DataGridView)sender).SelectedRows[0].Cells["RoomID"].Value);
                AdvancePayed = ((DataGridView)sender).SelectedRows[0].Cells["AdvancePayed"].Value.ToString();               
                BookedDateFrom = ((DataGridView)sender).SelectedRows[0].Cells["BookedDateFrom"].Value.ToString();
                BookedDateTO = ((DataGridView)sender).SelectedRows[0].Cells["BookedDateTO"].Value.ToString();
                BookingStatus= GetEnumValueByName(((DataGridView)sender).SelectedRows[0].Cells["BookingStatus"].Value.ToString());
            }         
        }
       
        private int GetEnumValueByName(string Name)
        {
            int returnValue = 0;
            switch(Name)
            {
                case "Vacant":
                    returnValue= (int)BookingStatusEnum.Vacant;
                    break;
                case "Reserved":
                    returnValue = (int)BookingStatusEnum.Reserved;
                    break;
                case "Occupied":
                    returnValue = (int)BookingStatusEnum.Occupied;
                    break;

            }

            return returnValue;
        }

        private void bgDeleteWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            if (BookingID > 0)
            {
                e.Result = (Object)Helper.GetService().DeleteBookingRoom(BookingID);
                BookingID = 0;
            }              
            else
                MessageBox.Show("Please, select item in grid");
        }

        private void bgDeleteWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Result!=null)
            {
                int resultItem = Convert.ToInt32(e.Result);
                if(resultItem > 0)
                    MessageBox.Show("Selected item was deleted");

                if (!bgWorker.IsBusy)
                {
                    // This method will start the execution asynchronously in the background
                    bgWorker.RunWorkerAsync();
                }
            }
           
        }

        private void bgDeleteWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgDeleteWorker.RunWorkerAsync();
            }
        }
    }
}
