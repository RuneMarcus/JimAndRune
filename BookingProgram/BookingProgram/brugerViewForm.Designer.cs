namespace BookingProgram
{
    partial class brugerViewForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brugerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.brugereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Context_BookingContextDataSet3 = new BookingProgram._Context_BookingContextDataSet3();
            this.brugereTableAdapter = new BookingProgram._Context_BookingContextDataSet3TableAdapters.BrugereTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brugerIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addresseDataGridViewTextBoxColumn,
            this.administratorDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.brugereBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // brugerIDDataGridViewTextBoxColumn
            // 
            this.brugerIDDataGridViewTextBoxColumn.DataPropertyName = "brugerID";
            this.brugerIDDataGridViewTextBoxColumn.HeaderText = "brugerID";
            this.brugerIDDataGridViewTextBoxColumn.Name = "brugerIDDataGridViewTextBoxColumn";
            this.brugerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "fornavn";
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "efternavn";
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addresseDataGridViewTextBoxColumn
            // 
            this.addresseDataGridViewTextBoxColumn.DataPropertyName = "addresse";
            this.addresseDataGridViewTextBoxColumn.HeaderText = "addresse";
            this.addresseDataGridViewTextBoxColumn.Name = "addresseDataGridViewTextBoxColumn";
            // 
            // administratorDataGridViewCheckBoxColumn
            // 
            this.administratorDataGridViewCheckBoxColumn.DataPropertyName = "administrator";
            this.administratorDataGridViewCheckBoxColumn.HeaderText = "administrator";
            this.administratorDataGridViewCheckBoxColumn.Name = "administratorDataGridViewCheckBoxColumn";
            // 
            // brugereBindingSource
            // 
            this.brugereBindingSource.DataMember = "Brugere";
            this.brugereBindingSource.DataSource = this._Context_BookingContextDataSet3;
            // 
            // _Context_BookingContextDataSet3
            // 
            this._Context_BookingContextDataSet3.DataSetName = "_Context_BookingContextDataSet3";
            this._Context_BookingContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugereTableAdapter
            // 
            this.brugereTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bruger View";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brugerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "brugerViewForm";
            this.Text = "brugerViewForm";
            this.Load += new System.EventHandler(this.brugerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Context_BookingContextDataSet3 _Context_BookingContextDataSet3;
        private System.Windows.Forms.BindingSource brugereBindingSource;
        private _Context_BookingContextDataSet3TableAdapters.BrugereTableAdapter brugereTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn brugerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn administratorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}