using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomReservationClient.Classes;
using RoomReservationClient.RoomReservationService;

namespace RoomReservationClient
{
    public partial class Rooms : Form
    {
       
        public Rooms()
        {
            InitializeComponent();          
        }

        private void Rooms_Load(object sender, EventArgs e)
        {  
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarRoms.Value = e.ProgressPercentage;          
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Result!=null)
            {
                IEnumerable<BookingDetails> items = (IEnumerable<BookingDetails>)e.Result;
                IEnumerable<BookingDetails> distinctItems = items.Distinct();
                foreach (BookingDetails item in distinctItems)
                {

                    switch (item.RoomID)
                    {
                        case 100:
                            SetColorBtn(ref ROOM100, item);
                            break;
                        case 101:
                            SetColorBtn(ref ROOM101, item);
                            break;
                        case 102:
                            SetColorBtn(ref ROOM102, item);
                            break;
                        case 103:
                            SetColorBtn(ref ROOM103, item);
                            break;
                    }
                }
            }
         
        }

        private void SetColorBtn(ref Button btn, BookingDetails item)
        {
            if (item.BookingStatus == (int)BookingStatusEnum.Occupied)
                btn.BackColor = Color.Red;
            else if (item.BookingStatus == (int)BookingStatusEnum.Reserved)
                btn.BackColor = Color.Yellow;
            else
                btn.BackColor = Color.Blue;
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try {

                e.Result = Helper.GetService().BookingRooms();
            }
            catch
            {

            }
         

        }

        private void BookingDetailsbtn_Click(object sender, EventArgs e)
        {
            BookingDetailsForm detailsForm = new BookingDetailsForm();
            detailsForm.ShowDialog();
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }
    }
}
