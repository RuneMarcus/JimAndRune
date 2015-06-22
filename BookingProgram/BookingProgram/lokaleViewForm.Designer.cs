namespace BookingProgram
{
    partial class lokaleViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lokalerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Context_BookingContextDataSet4 = new BookingProgram._Context_BookingContextDataSet4();
            this._Context_BookingContextDataSet1 = new BookingProgram._Context_BookingContextDataSet1();
            this.contextBookingContextDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokalerTableAdapter = new BookingProgram._Context_BookingContextDataSet4TableAdapters.LokalerTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addresseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postnummerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arealColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pladstilColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lokaleIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBookingContextDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lokale View";
            // 
            // lokalerBindingSource
            // 
            this.lokalerBindingSource.DataMember = "Lokaler";
            this.lokalerBindingSource.DataSource = this._Context_BookingContextDataSet4;
            // 
            // _Context_BookingContextDataSet4
            // 
            this._Context_BookingContextDataSet4.DataSetName = "_Context_BookingContextDataSet4";
            this._Context_BookingContextDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _Context_BookingContextDataSet1
            // 
            this._Context_BookingContextDataSet1.DataSetName = "_Context_BookingContextDataSet1";
            this._Context_BookingContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextBookingContextDataSet1BindingSource
            // 
            this.contextBookingContextDataSet1BindingSource.DataSource = this._Context_BookingContextDataSet1;
            this.contextBookingContextDataSet1BindingSource.Position = 0;
            // 
            // lokalerTableAdapter
            // 
            this.lokalerTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addresseColumn,
            this.postnummerColumn,
            this.arealColumn,
            this.pladstilColumn,
            this.lokaleIDColumn});
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 293);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addresseColumn
            // 
            this.addresseColumn.Text = "Addresse";
            this.addresseColumn.Width = 199;
            // 
            // postnummerColumn
            // 
            this.postnummerColumn.Text = "Postnummer";
            this.postnummerColumn.Width = 146;
            // 
            // arealColumn
            // 
            this.arealColumn.Text = "Areal";
            this.arealColumn.Width = 82;
            // 
            // pladstilColumn
            // 
            this.pladstilColumn.Text = "Plads til";
            this.pladstilColumn.Width = 108;
            // 
            // lokaleIDColumn
            // 
            this.lokaleIDColumn.Text = "LokaleID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tilbage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lokaleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 457);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "lokaleViewForm";
            this.Text = "lokaleViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBookingContextDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource contextBookingContextDataSet1BindingSource;
        private _Context_BookingContextDataSet1 _Context_BookingContextDataSet1;
        private _Context_BookingContextDataSet4 _Context_BookingContextDataSet4;
        private System.Windows.Forms.BindingSource lokalerBindingSource;
        private _Context_BookingContextDataSet4TableAdapters.LokalerTableAdapter lokalerTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader addresseColumn;
        private System.Windows.Forms.ColumnHeader postnummerColumn;
        private System.Windows.Forms.ColumnHeader arealColumn;
        private System.Windows.Forms.ColumnHeader pladstilColumn;
        private System.Windows.Forms.ColumnHeader lokaleIDColumn;
        private System.Windows.Forms.Button button1;
    }
}