namespace BookingProgram
{
    partial class BookingForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Booking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DayDrop = new System.Windows.Forms.ComboBox();
            this.MonthDrop = new System.Windows.Forms.ComboBox();
            this.YearDrop = new System.Windows.Forms.ComboBox();
            this.FromDrop = new System.Windows.Forms.ComboBox();
            this.ToDrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Booking
            // 
            this.Booking.Location = new System.Drawing.Point(192, 182);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(75, 23);
            this.Booking.TabIndex = 1;
            this.Booking.Text = "Book";
            this.Booking.UseVisualStyleBackColor = true;
            this.Booking.Click += new System.EventHandler(this.Booking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LokaleID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lokale Booking";
            // 
            // DayDrop
            // 
            this.DayDrop.FormattingEnabled = true;
            this.DayDrop.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayDrop.Location = new System.Drawing.Point(24, 133);
            this.DayDrop.Name = "DayDrop";
            this.DayDrop.Size = new System.Drawing.Size(73, 21);
            this.DayDrop.TabIndex = 4;
            this.DayDrop.SelectedIndexChanged += new System.EventHandler(this.FromDrop_SelectedIndexChanged);
            // 
            // MonthDrop
            // 
            this.MonthDrop.FormattingEnabled = true;
            this.MonthDrop.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthDrop.Location = new System.Drawing.Point(103, 133);
            this.MonthDrop.Name = "MonthDrop";
            this.MonthDrop.Size = new System.Drawing.Size(68, 21);
            this.MonthDrop.TabIndex = 5;
            // 
            // YearDrop
            // 
            this.YearDrop.FormattingEnabled = true;
            this.YearDrop.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017"});
            this.YearDrop.Location = new System.Drawing.Point(177, 133);
            this.YearDrop.Name = "YearDrop";
            this.YearDrop.Size = new System.Drawing.Size(90, 21);
            this.YearDrop.TabIndex = 6;
            // 
            // FromDrop
            // 
            this.FromDrop.FormattingEnabled = true;
            this.FromDrop.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.FromDrop.Location = new System.Drawing.Point(24, 184);
            this.FromDrop.Name = "FromDrop";
            this.FromDrop.Size = new System.Drawing.Size(73, 21);
            this.FromDrop.TabIndex = 7;
            this.FromDrop.SelectedIndexChanged += new System.EventHandler(this.FromDrop_SelectedIndexChanged);
            // 
            // ToDrop
            // 
            this.ToDrop.FormattingEnabled = true;
            this.ToDrop.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.ToDrop.Location = new System.Drawing.Point(103, 184);
            this.ToDrop.Name = "ToDrop";
            this.ToDrop.Size = new System.Drawing.Size(68, 21);
            this.ToDrop.TabIndex = 8;
            this.ToDrop.SelectedIndexChanged += new System.EventHandler(this.ToDrop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "To";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 223);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToDrop);
            this.Controls.Add(this.FromDrop);
            this.Controls.Add(this.YearDrop);
            this.Controls.Add(this.MonthDrop);
            this.Controls.Add(this.DayDrop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.comboBox1);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DayDrop;
        private System.Windows.Forms.ComboBox MonthDrop;
        private System.Windows.Forms.ComboBox YearDrop;
        private System.Windows.Forms.ComboBox FromDrop;
        private System.Windows.Forms.ComboBox ToDrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}