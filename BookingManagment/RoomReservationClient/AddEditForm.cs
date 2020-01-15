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
    public partial class AddEditForm : Form
    {
       
        public AddEditForm()
        {
            InitializeComponent();            
        }

        int cmdBookingStatusValue = 0;
        int cmbRoomNoValue = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!bgdWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgdWorker.RunWorkerAsync();
            }
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {  
         
            List<object> statusList = new List<object>();          

            statusList.Add(new { Name= Enum.GetName(typeof(BookingStatusEnum), 1), StatusId=1 });
            statusList.Add(new { Name = Enum.GetName(typeof(BookingStatusEnum), 2), StatusId = 2 });
            statusList.Add(new { Name = Enum.GetName(typeof(BookingStatusEnum), 3), StatusId = 3 });

            cmdBookingStatus.DisplayMember = "Name";
            cmdBookingStatus.ValueMember = "StatusId";
            cmdBookingStatus.DataSource = statusList;

           
            List<object> roomNoList = new List<object>();
            roomNoList.Add(new { Name = 100, RoomNo = 100 });
            roomNoList.Add(new { Name = 101, RoomNo = 101 });
            roomNoList.Add(new { Name = 102, RoomNo = 102 });
            roomNoList.Add(new { Name = 103, RoomNo = 103 });

            cmbRoomNo.DisplayMember = "Name";
            cmbRoomNo.ValueMember = "RoomNo";
            cmbRoomNo.DataSource= roomNoList;

            if(BookingDetailsForm.BookingID>0)
            { 
                
                txtBookingID.Text = BookingDetailsForm.BookingID.ToString();
                txtAdvancedPaid.Text = BookingDetailsForm.AdvancePayed.ToString();              
                txtBookingFrom.Text = BookingDetailsForm.BookedDateFrom.ToString();
                txtBookingTo.Text = BookingDetailsForm.BookedDateTO.ToString();

                cmbRoomNo.SelectedValue = BookingDetailsForm.RoomID;
                cmdBookingStatus.SelectedValue = BookingDetailsForm.BookingStatus;
            }           
        }

        private void bgdWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = Helper.GetService().AddEditBookingRoom(new BookingDetails()
                {
                    BookingID = BookingDetailsForm.BookingID,
                    AdvancePayed = txtAdvancedPaid.Text,                    
                    BookedDateFrom = txtBookingFrom.Text,
                    BookedDateTO = txtBookingTo.Text,
                    RoomID = cmbRoomNoValue,
                    BookingStatus = cmdBookingStatusValue
                });
                BookingDetailsForm.BookingID = 0;
            }
            catch
            { }
        
        }

        private void bgdWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Result!=null)
            {
                int result = Convert.ToInt32(e.Result);
                if (result > 0)
                {
                    MessageBox.Show("Record created or updated successfully");
                }
                   

                this.Close();
                this.Dispose(true);
            }
                      
        }

        private void bgdWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void cmdBookingStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if(sender!=null)
            {
                cmdBookingStatusValue = Convert.ToInt32(((ComboBox)sender).SelectedValue);
            }
          
        }

        private void cmbRoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(sender!=null)
            cmbRoomNoValue = Convert.ToInt32(((ComboBox)sender).SelectedValue);
        }
    }
}
