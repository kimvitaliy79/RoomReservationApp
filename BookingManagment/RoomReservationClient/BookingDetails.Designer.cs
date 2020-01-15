namespace RoomReservationClient
{
    partial class BookingDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grdBooking = new System.Windows.Forms.DataGridView();
            this.AddEditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.bgDeleteWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // grdBooking
            // 
            this.grdBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooking.Location = new System.Drawing.Point(12, 83);
            this.grdBooking.Name = "grdBooking";
            this.grdBooking.Size = new System.Drawing.Size(754, 314);
            this.grdBooking.TabIndex = 1;
            this.grdBooking.SelectionChanged += new System.EventHandler(this.grdBooking_SelectionChanged);
            // 
            // AddEditBtn
            // 
            this.AddEditBtn.Location = new System.Drawing.Point(36, 35);
            this.AddEditBtn.Name = "AddEditBtn";
            this.AddEditBtn.Size = new System.Drawing.Size(109, 23);
            this.AddEditBtn.TabIndex = 2;
            this.AddEditBtn.Text = "Add/Edit";
            this.AddEditBtn.UseVisualStyleBackColor = true;
            this.AddEditBtn.Click += new System.EventHandler(this.AddEditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(166, 35);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(115, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // bgDeleteWorker
            // 
            this.bgDeleteWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDeleteWorker_DoWork);
            this.bgDeleteWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgDeleteWorker_ProgressChanged);
            this.bgDeleteWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDeleteWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "%";
            // 
            // BookingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddEditBtn);
            this.Controls.Add(this.grdBooking);
            this.Controls.Add(this.progressBar1);
            this.Name = "BookingDetailsForm";
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.BookingDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView grdBooking;
        private System.Windows.Forms.Button AddEditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.ComponentModel.BackgroundWorker bgDeleteWorker;
        private System.Windows.Forms.Label label1;
    }
}