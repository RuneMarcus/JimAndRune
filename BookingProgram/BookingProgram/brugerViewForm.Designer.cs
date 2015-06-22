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
            this.brugereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brugereTableAdapter = new BookingProgram._Context_BookingContextDataSet3TableAdapters.BrugereTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.fornavnColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.efternavnColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addresseColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brugerIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.administratorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Context_BookingContextDataSet1 = new BookingProgram._Context_BookingContextDataSet();
            this.redigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletBrugerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sletBrugerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this._Context_BookingContextDataSet3 = new BookingProgram._Context_BookingContextDataSet3();
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // brugereBindingSource
            // 
            this.brugereBindingSource.DataMember = "Brugere";
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
            this.button1.Text = "Tilbage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fornavnColumn,
            this.efternavnColumn,
            this.emailColumn,
            this.addresseColumn,
            this.brugerIDColumn,
            this.telefonColumn,
            this.administratorColumn});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(819, 293);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // fornavnColumn
            // 
            this.fornavnColumn.Text = "Fornavn";
            this.fornavnColumn.Width = 92;
            // 
            // efternavnColumn
            // 
            this.efternavnColumn.Text = "Efternavn";
            this.efternavnColumn.Width = 105;
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            this.emailColumn.Width = 162;
            // 
            // addresseColumn
            // 
            this.addresseColumn.Text = "Addresse";
            this.addresseColumn.Width = 173;
            // 
            // brugerIDColumn
            // 
            this.brugerIDColumn.Text = "BrugerID";
            // 
            // telefonColumn
            // 
            this.telefonColumn.Text = "TelefonNr";
            this.telefonColumn.Width = 135;
            // 
            // administratorColumn
            // 
            this.administratorColumn.Text = "Administrator";
            this.administratorColumn.Width = 86;
            // 
            // _Context_BookingContextDataSet1
            // 
            this._Context_BookingContextDataSet1.DataSetName = "_Context_BookingContextDataSet";
            this._Context_BookingContextDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redigerToolStripMenuItem
            // 
            this.redigerToolStripMenuItem.Name = "redigerToolStripMenuItem";
            this.redigerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sletBrugerToolStripMenuItem
            // 
            this.sletBrugerToolStripMenuItem.Name = "sletBrugerToolStripMenuItem";
            this.sletBrugerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // sletBrugerToolStripMenuItem1
            // 
            this.sletBrugerToolStripMenuItem1.Name = "sletBrugerToolStripMenuItem1";
            this.sletBrugerToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // _Context_BookingContextDataSet3
            // 
            this._Context_BookingContextDataSet3.DataSetName = "_Context_BookingContextDataSet3";
            this._Context_BookingContextDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brugerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 457);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "brugerViewForm";
            this.Text = "brugerViewForm";
            this.Load += new System.EventHandler(this.brugerViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brugereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Context_BookingContextDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource brugereBindingSource;
        private _Context_BookingContextDataSet3TableAdapters.BrugereTableAdapter brugereTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private _Context_BookingContextDataSet _Context_BookingContextDataSet1;
        private System.Windows.Forms.ColumnHeader fornavnColumn;
        private System.Windows.Forms.ColumnHeader efternavnColumn;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.ColumnHeader addresseColumn;
        private System.Windows.Forms.ColumnHeader brugerIDColumn;
        private System.Windows.Forms.ColumnHeader telefonColumn;
        private System.Windows.Forms.ColumnHeader administratorColumn;
        private System.Windows.Forms.ToolStripMenuItem redigerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletBrugerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sletBrugerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private _Context_BookingContextDataSet3 _Context_BookingContextDataSet3;
    }
}