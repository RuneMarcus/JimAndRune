namespace BookingProgram
{
    partial class brugerRedigerForm
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
            this.components = new System.ComponentModel.Container();
            this.brugereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Context_BookingContextDataSet1 = new BookingProgram._Context_BookingContextDataSet1();
            this.brugereTableAdapter = new BookingProgram._Context_BookingContextDataSet1TableAdapters.BrugereTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brugereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Context_BookingContextDataSet9 = new BookingProgram._Context_BookingContextDataSet9();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.brugereTableAdapter1 = new BookingProgram._Context_BookingContextDataSet9TableAdapters.BrugereTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // brugereBindingSource
            // 
            this.brugereBindingSource.DataMember = "Brugere";
            this.brugereBindingSource.DataSource = this._Context_BookingContextDataSet1;
            // 
            // _Context_BookingContextDataSet1
            // 
            this._Context_BookingContextDataSet1.DataSetName = "_Context_BookingContextDataSet1";
            this._Context_BookingContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugereTableAdapter
            // 
            this.brugereTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 277);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // brugereBindingSource1
            // 
            this.brugereBindingSource1.DataMember = "Brugere";
            this.brugereBindingSource1.DataSource = this._Context_BookingContextDataSet9;
            // 
            // _Context_BookingContextDataSet9
            // 
            this._Context_BookingContextDataSet9.DataSetName = "_Context_BookingContextDataSet9";
            this._Context_BookingContextDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Tilbage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Rediger Bruger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // brugereTableAdapter1
            // 
            this.brugereTableAdapter1.ClearBeforeFill = true;
            // 
            // brugerRedigerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "brugerRedigerForm";
            this.Text = "brugerRedigerForm";
            this.Load += new System.EventHandler(this.brugerRedigerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _Context_BookingContextDataSet1 _Context_BookingContextDataSet1;
        private System.Windows.Forms.BindingSource brugereBindingSource;
        private _Context_BookingContextDataSet1TableAdapters.BrugereTableAdapter brugereTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private _Context_BookingContextDataSet9 _Context_BookingContextDataSet9;
        private System.Windows.Forms.BindingSource brugereBindingSource1;
        private _Context_BookingContextDataSet9TableAdapters.BrugereTableAdapter brugereTableAdapter1;
    }
}