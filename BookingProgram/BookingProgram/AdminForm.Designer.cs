namespace BookingProgram
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.OpretBrugerButton = new System.Windows.Forms.Button();
            this.OpretLokaleButton = new System.Windows.Forms.Button();
            this.SletBrugerButton = new System.Windows.Forms.Button();
            this.RedigerBrugerButton = new System.Windows.Forms.Button();
            this.SletLokaleButton = new System.Windows.Forms.Button();
            this.RedigerLokaleButton = new System.Windows.Forms.Button();
            this.BrugerViewButton = new System.Windows.Forms.Button();
            this.LokaleViewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrugerHistorikButton = new System.Windows.Forms.Button();
            this.LokaleHistorikButton = new System.Windows.Forms.Button();
            this.xml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logged ind som Administrator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log af";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LogAfButton_Click);
            // 
            // OpretBrugerButton
            // 
            this.OpretBrugerButton.Location = new System.Drawing.Point(76, 171);
            this.OpretBrugerButton.Name = "OpretBrugerButton";
            this.OpretBrugerButton.Size = new System.Drawing.Size(88, 23);
            this.OpretBrugerButton.TabIndex = 2;
            this.OpretBrugerButton.Text = "Opret Bruger";
            this.OpretBrugerButton.UseVisualStyleBackColor = true;
            this.OpretBrugerButton.Click += new System.EventHandler(this.BrugerOpretButton_Click);
            // 
            // OpretLokaleButton
            // 
            this.OpretLokaleButton.Location = new System.Drawing.Point(76, 200);
            this.OpretLokaleButton.Name = "OpretLokaleButton";
            this.OpretLokaleButton.Size = new System.Drawing.Size(88, 23);
            this.OpretLokaleButton.TabIndex = 3;
            this.OpretLokaleButton.Text = "Opret Lokale";
            this.OpretLokaleButton.UseVisualStyleBackColor = true;
            this.OpretLokaleButton.Click += new System.EventHandler(this.LokaleOpretButton_Click);
            // 
            // SletBrugerButton
            // 
            this.SletBrugerButton.Location = new System.Drawing.Point(170, 171);
            this.SletBrugerButton.Name = "SletBrugerButton";
            this.SletBrugerButton.Size = new System.Drawing.Size(88, 23);
            this.SletBrugerButton.TabIndex = 4;
            this.SletBrugerButton.Text = "Slet Bruger";
            this.SletBrugerButton.UseVisualStyleBackColor = true;
            this.SletBrugerButton.Click += new System.EventHandler(this.BrugerSletButton_Click);
            // 
            // RedigerBrugerButton
            // 
            this.RedigerBrugerButton.Location = new System.Drawing.Point(264, 171);
            this.RedigerBrugerButton.Name = "RedigerBrugerButton";
            this.RedigerBrugerButton.Size = new System.Drawing.Size(88, 23);
            this.RedigerBrugerButton.TabIndex = 5;
            this.RedigerBrugerButton.Text = "Rediger Bruger";
            this.RedigerBrugerButton.UseVisualStyleBackColor = true;
            this.RedigerBrugerButton.Click += new System.EventHandler(this.BrugerRedigerButton_Click);
            // 
            // SletLokaleButton
            // 
            this.SletLokaleButton.Location = new System.Drawing.Point(170, 200);
            this.SletLokaleButton.Name = "SletLokaleButton";
            this.SletLokaleButton.Size = new System.Drawing.Size(88, 23);
            this.SletLokaleButton.TabIndex = 6;
            this.SletLokaleButton.Text = "Slet Lokale";
            this.SletLokaleButton.UseVisualStyleBackColor = true;
            this.SletLokaleButton.Click += new System.EventHandler(this.LokaleSletButton_Click);
            // 
            // RedigerLokaleButton
            // 
            this.RedigerLokaleButton.Location = new System.Drawing.Point(264, 200);
            this.RedigerLokaleButton.Name = "RedigerLokaleButton";
            this.RedigerLokaleButton.Size = new System.Drawing.Size(88, 23);
            this.RedigerLokaleButton.TabIndex = 7;
            this.RedigerLokaleButton.Text = "Rediger Lokale";
            this.RedigerLokaleButton.UseVisualStyleBackColor = true;
            this.RedigerLokaleButton.Click += new System.EventHandler(this.LokaleRedigerButton_Click);
            // 
            // BrugerViewButton
            // 
            this.BrugerViewButton.Location = new System.Drawing.Point(122, 92);
            this.BrugerViewButton.Name = "BrugerViewButton";
            this.BrugerViewButton.Size = new System.Drawing.Size(88, 23);
            this.BrugerViewButton.TabIndex = 8;
            this.BrugerViewButton.Text = "Bruger View";
            this.BrugerViewButton.UseVisualStyleBackColor = true;
            this.BrugerViewButton.Click += new System.EventHandler(this.BrugerViewButton_Click);
            // 
            // LokaleViewButton
            // 
            this.LokaleViewButton.Location = new System.Drawing.Point(216, 92);
            this.LokaleViewButton.Name = "LokaleViewButton";
            this.LokaleViewButton.Size = new System.Drawing.Size(88, 23);
            this.LokaleViewButton.TabIndex = 9;
            this.LokaleViewButton.Text = "Lokale View";
            this.LokaleViewButton.UseVisualStyleBackColor = true;
            this.LokaleViewButton.Click += new System.EventHandler(this.LokaleViewButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Views";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Edits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Historik";
            // 
            // BrugerHistorikButton
            // 
            this.BrugerHistorikButton.Location = new System.Drawing.Point(122, 294);
            this.BrugerHistorikButton.Name = "BrugerHistorikButton";
            this.BrugerHistorikButton.Size = new System.Drawing.Size(88, 23);
            this.BrugerHistorikButton.TabIndex = 13;
            this.BrugerHistorikButton.Text = "Bruger Historik";
            this.BrugerHistorikButton.UseVisualStyleBackColor = true;
            this.BrugerHistorikButton.Click += new System.EventHandler(this.BrugerHistorikButton_Click);
            // 
            // LokaleHistorikButton
            // 
            this.LokaleHistorikButton.Location = new System.Drawing.Point(216, 294);
            this.LokaleHistorikButton.Name = "LokaleHistorikButton";
            this.LokaleHistorikButton.Size = new System.Drawing.Size(88, 23);
            this.LokaleHistorikButton.TabIndex = 14;
            this.LokaleHistorikButton.Text = "Lokale Historik";
            this.LokaleHistorikButton.UseVisualStyleBackColor = true;
            this.LokaleHistorikButton.Click += new System.EventHandler(this.LokaleHistorikButton_Click);
            // 
            // xml
            // 
            this.xml.Location = new System.Drawing.Point(171, 323);
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(94, 45);
            this.xml.TabIndex = 15;
            this.xml.Text = "Booking Output (XML)";
            this.xml.UseVisualStyleBackColor = true;
            this.xml.Click += new System.EventHandler(this.xml_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 457);
            this.Controls.Add(this.xml);
            this.Controls.Add(this.LokaleHistorikButton);
            this.Controls.Add(this.BrugerHistorikButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LokaleViewButton);
            this.Controls.Add(this.BrugerViewButton);
            this.Controls.Add(this.RedigerLokaleButton);
            this.Controls.Add(this.SletLokaleButton);
            this.Controls.Add(this.RedigerBrugerButton);
            this.Controls.Add(this.SletBrugerButton);
            this.Controls.Add(this.OpretLokaleButton);
            this.Controls.Add(this.OpretBrugerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button OpretBrugerButton;
        private System.Windows.Forms.Button OpretLokaleButton;
        private System.Windows.Forms.Button SletBrugerButton;
        private System.Windows.Forms.Button RedigerBrugerButton;
        private System.Windows.Forms.Button SletLokaleButton;
        private System.Windows.Forms.Button RedigerLokaleButton;
        private System.Windows.Forms.Button BrugerViewButton;
        private System.Windows.Forms.Button LokaleViewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrugerHistorikButton;
        private System.Windows.Forms.Button LokaleHistorikButton;
        private System.Windows.Forms.Button xml;
    }
}