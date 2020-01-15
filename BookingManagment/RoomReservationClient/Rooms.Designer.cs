namespace RoomReservationClient
{
    partial class Rooms
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
            this.ProgressBarRoms = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.ROOM100 = new System.Windows.Forms.Button();
            this.ROOM101 = new System.Windows.Forms.Button();
            this.ROOM103 = new System.Windows.Forms.Button();
            this.ROOM102 = new System.Windows.Forms.Button();
            this.BookingDetailsbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBarRoms
            // 
            this.ProgressBarRoms.Location = new System.Drawing.Point(75, 415);
            this.ProgressBarRoms.Name = "ProgressBarRoms";
            this.ProgressBarRoms.Size = new System.Drawing.Size(278, 23);
            this.ProgressBarRoms.TabIndex = 0;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ROOM100
            // 
            this.ROOM100.BackColor = System.Drawing.Color.Blue;
            this.ROOM100.Location = new System.Drawing.Point(75, 42);
            this.ROOM100.Name = "ROOM100";
            this.ROOM100.Size = new System.Drawing.Size(112, 121);
            this.ROOM100.TabIndex = 2;
            this.ROOM100.Text = "ROOM NO 100";
            this.ROOM100.UseVisualStyleBackColor = false;
            // 
            // ROOM101
            // 
            this.ROOM101.BackColor = System.Drawing.Color.Blue;
            this.ROOM101.Location = new System.Drawing.Point(211, 42);
            this.ROOM101.Name = "ROOM101";
            this.ROOM101.Size = new System.Drawing.Size(112, 121);
            this.ROOM101.TabIndex = 3;
            this.ROOM101.Text = "ROOM NO 101";
            this.ROOM101.UseVisualStyleBackColor = false;
            // 
            // ROOM103
            // 
            this.ROOM103.BackColor = System.Drawing.Color.Blue;
            this.ROOM103.Location = new System.Drawing.Point(203, 194);
            this.ROOM103.Name = "ROOM103";
            this.ROOM103.Size = new System.Drawing.Size(120, 121);
            this.ROOM103.TabIndex = 5;
            this.ROOM103.Text = "ROOM NO 103";
            this.ROOM103.UseVisualStyleBackColor = false;
            // 
            // ROOM102
            // 
            this.ROOM102.BackColor = System.Drawing.Color.Blue;
            this.ROOM102.Location = new System.Drawing.Point(75, 194);
            this.ROOM102.Name = "ROOM102";
            this.ROOM102.Size = new System.Drawing.Size(112, 121);
            this.ROOM102.TabIndex = 4;
            this.ROOM102.Text = "ROOM NO 102";
            this.ROOM102.UseVisualStyleBackColor = false;
            // 
            // BookingDetailsbtn
            // 
            this.BookingDetailsbtn.Location = new System.Drawing.Point(203, 345);
            this.BookingDetailsbtn.Name = "BookingDetailsbtn";
            this.BookingDetailsbtn.Size = new System.Drawing.Size(120, 26);
            this.BookingDetailsbtn.TabIndex = 6;
            this.BookingDetailsbtn.Text = "Booking Details";
            this.BookingDetailsbtn.UseVisualStyleBackColor = true;
            this.BookingDetailsbtn.Click += new System.EventHandler(this.BookingDetailsbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "%";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(75, 345);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 26);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookingDetailsbtn);
            this.Controls.Add(this.ROOM103);
            this.Controls.Add(this.ROOM102);
            this.Controls.Add(this.ROOM101);
            this.Controls.Add(this.ROOM100);
            this.Controls.Add(this.ProgressBarRoms);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarRoms;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button ROOM100;
        private System.Windows.Forms.Button ROOM101;
        private System.Windows.Forms.Button ROOM103;
        private System.Windows.Forms.Button ROOM102;
        private System.Windows.Forms.Button BookingDetailsbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

