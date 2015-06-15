namespace BookingProgram
{
    partial class lokaleSletForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._Context_BookingContextDataSet2 = new BookingProgram._Context_BookingContextDataSet2();
            this.lokalerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokalerTableAdapter = new BookingProgram._Context_BookingContextDataSet2TableAdapters.LokalerTableAdapter();
            this.lokaleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pladsTilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Søg";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Indtast Addresse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indtast LokaleID:";
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
            this.dataGridView1.Location = new System.Drawing.Point(112, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // _Context_BookingContextDataSet2
            // 
            this._Context_BookingContextDataSet2.DataSetName = "_Context_BookingContextDataSet2";
            this._Context_BookingContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lokalerBindingSource
            // 
            this.lokalerBindingSource.DataMember = "Lokaler";
            this.lokalerBindingSource.DataSource = this._Context_BookingContextDataSet2;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Slet Lokale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Opdater";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lokaleSletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lokaleSletForm";
            this.Text = "lokaleSletForm";
            this.Load += new System.EventHandler(this.lokaleSletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokalerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _Context_BookingContextDataSet2 _Context_BookingContextDataSet2;
        private System.Windows.Forms.BindingSource lokalerBindingSource;
        private _Context_BookingContextDataSet2TableAdapters.LokalerTableAdapter lokalerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokaleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pladsTilDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}