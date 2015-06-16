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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._Context_BookingContextDataSet1 = new BookingProgram._Context_BookingContextDataSet1();
            this.contextBookingContextDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Context_BookingContextDataSet4 = new BookingProgram._Context_BookingContextDataSet4();
            this.lokalerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokalerTableAdapter = new BookingProgram._Context_BookingContextDataSet4TableAdapters.LokalerTableAdapter();
            this.lokaleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pladsTilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBookingContextDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lokale View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lokaleIDDataGridViewTextBoxColumn,
            this.addresseDataGridViewTextBoxColumn,
            this.postnummerDataGridViewTextBoxColumn,
            this.arealDataGridViewTextBoxColumn,
            this.pladsTilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lokalerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(109, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 341);
            this.dataGridView1.TabIndex = 3;
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
            // _Context_BookingContextDataSet4
            // 
            this._Context_BookingContextDataSet4.DataSetName = "_Context_BookingContextDataSet4";
            this._Context_BookingContextDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lokalerBindingSource
            // 
            this.lokalerBindingSource.DataMember = "Lokaler";
            this.lokalerBindingSource.DataSource = this._Context_BookingContextDataSet4;
            // 
            // lokalerTableAdapter
            // 
            this.lokalerTableAdapter.ClearBeforeFill = true;
            // 
            // lokaleIDDataGridViewTextBoxColumn
            // 
            this.lokaleIDDataGridViewTextBoxColumn.DataPropertyName = "lokaleID";
            this.lokaleIDDataGridViewTextBoxColumn.HeaderText = "lokaleID";
            this.lokaleIDDataGridViewTextBoxColumn.Name = "lokaleIDDataGridViewTextBoxColumn";
            this.lokaleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            // 
            // postnummerDataGridViewTextBoxColumn
            // 
            this.postnummerDataGridViewTextBoxColumn.DataPropertyName = "postnummer";
            this.postnummerDataGridViewTextBoxColumn.HeaderText = "postnummer";
            this.postnummerDataGridViewTextBoxColumn.Name = "postnummerDataGridViewTextBoxColumn";
            // 
            // arealDataGridViewTextBoxColumn
            // 
            this.arealDataGridViewTextBoxColumn.DataPropertyName = "areal";
            this.arealDataGridViewTextBoxColumn.HeaderText = "areal";
            this.arealDataGridViewTextBoxColumn.Name = "arealDataGridViewTextBoxColumn";
            // 
            // pladsTilDataGridViewTextBoxColumn
            // 
            this.pladsTilDataGridViewTextBoxColumn.DataPropertyName = "pladsTil";
            this.pladsTilDataGridViewTextBoxColumn.HeaderText = "pladsTil";
            this.pladsTilDataGridViewTextBoxColumn.Name = "pladsTilDataGridViewTextBoxColumn";
            // 
            // lokaleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "lokaleViewForm";
            this.Text = "lokaleViewForm";
            this.Load += new System.EventHandler(this.lokaleViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBookingContextDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contextBookingContextDataSet1BindingSource;
        private _Context_BookingContextDataSet1 _Context_BookingContextDataSet1;
        private _Context_BookingContextDataSet4 _Context_BookingContextDataSet4;
        private System.Windows.Forms.BindingSource lokalerBindingSource;
        private _Context_BookingContextDataSet4TableAdapters.LokalerTableAdapter lokalerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokaleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pladsTilDataGridViewTextBoxColumn;
    }
}