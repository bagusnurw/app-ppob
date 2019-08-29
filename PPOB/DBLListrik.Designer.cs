namespace PPOB
{
    partial class DBLListrik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLListrik));
            this.dateTimePickerListrik = new System.Windows.Forms.DateTimePicker();
            this.TextMeter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ComboJenis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboNominalPLN = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jenisPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_bagusnrDataSet = new PPOB.data_bagusnrDataSet();
            this.lTableAdapter = new PPOB.data_bagusnrDataSetTableAdapters.LTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerListrik
            // 
            this.dateTimePickerListrik.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerListrik.Location = new System.Drawing.Point(233, 151);
            this.dateTimePickerListrik.Name = "dateTimePickerListrik";
            this.dateTimePickerListrik.Size = new System.Drawing.Size(228, 26);
            this.dateTimePickerListrik.TabIndex = 20;
            // 
            // TextMeter
            // 
            this.TextMeter.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMeter.Location = new System.Drawing.Point(212, 186);
            this.TextMeter.Multiline = true;
            this.TextMeter.Name = "TextMeter";
            this.TextMeter.Size = new System.Drawing.Size(241, 28);
            this.TextMeter.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "No. Meter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 83);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(28, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 69);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Location = new System.Drawing.Point(28, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 83);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(103, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 22);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel5.Location = new System.Drawing.Point(401, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 41);
            this.panel5.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Location = new System.Drawing.Point(-4, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 9);
            this.panel6.TabIndex = 28;
            // 
            // ComboJenis
            // 
            this.ComboJenis.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboJenis.FormattingEnabled = true;
            this.ComboJenis.ItemHeight = 20;
            this.ComboJenis.Items.AddRange(new object[] {
            "Pascabayar",
            "Prabayar"});
            this.ComboJenis.Location = new System.Drawing.Point(43, 148);
            this.ComboJenis.Name = "ComboJenis";
            this.ComboJenis.Size = new System.Drawing.Size(147, 28);
            this.ComboJenis.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Jenis Pembayaran";
            // 
            // ComboNominalPLN
            // 
            this.ComboNominalPLN.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboNominalPLN.FormattingEnabled = true;
            this.ComboNominalPLN.ItemHeight = 20;
            this.ComboNominalPLN.Items.AddRange(new object[] {
            "RP 20.000",
            "RP 50.000",
            "RP 100.000",
            "RP 500.000",
            "RP 1.000.000"});
            this.ComboNominalPLN.Location = new System.Drawing.Point(301, 114);
            this.ComboNominalPLN.Name = "ComboNominalPLN";
            this.ComboNominalPLN.Size = new System.Drawing.Size(160, 28);
            this.ComboNominalPLN.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nominal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEdit.Location = new System.Drawing.Point(207, 425);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(99, 37);
            this.BtnEdit.TabIndex = 23;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(82, 425);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 37);
            this.BtnDelete.TabIndex = 22;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSearch.Location = new System.Drawing.Point(332, 425);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 37);
            this.BtnSearch.TabIndex = 44;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jenisPembayaranDataGridViewTextBoxColumn,
            this.noMeterDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.tanggalTrxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 191);
            this.dataGridView1.TabIndex = 45;
            // 
            // jenisPembayaranDataGridViewTextBoxColumn
            // 
            this.jenisPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Jenis Pembayaran";
            this.jenisPembayaranDataGridViewTextBoxColumn.HeaderText = "Jenis Pembayaran";
            this.jenisPembayaranDataGridViewTextBoxColumn.Name = "jenisPembayaranDataGridViewTextBoxColumn";
            // 
            // noMeterDataGridViewTextBoxColumn
            // 
            this.noMeterDataGridViewTextBoxColumn.DataPropertyName = "No_ Meter";
            this.noMeterDataGridViewTextBoxColumn.HeaderText = "No_ Meter";
            this.noMeterDataGridViewTextBoxColumn.Name = "noMeterDataGridViewTextBoxColumn";
            // 
            // nominalDataGridViewTextBoxColumn
            // 
            this.nominalDataGridViewTextBoxColumn.DataPropertyName = "Nominal";
            this.nominalDataGridViewTextBoxColumn.HeaderText = "Nominal";
            this.nominalDataGridViewTextBoxColumn.Name = "nominalDataGridViewTextBoxColumn";
            // 
            // tanggalTrxDataGridViewTextBoxColumn
            // 
            this.tanggalTrxDataGridViewTextBoxColumn.DataPropertyName = "Tanggal Trx";
            this.tanggalTrxDataGridViewTextBoxColumn.HeaderText = "Tanggal Trx";
            this.tanggalTrxDataGridViewTextBoxColumn.Name = "tanggalTrxDataGridViewTextBoxColumn";
            // 
            // lBindingSource
            // 
            this.lBindingSource.DataMember = "L";
            this.lBindingSource.DataSource = this.data_bagusnrDataSet;
            // 
            // data_bagusnrDataSet
            // 
            this.data_bagusnrDataSet.DataSetName = "data_bagusnrDataSet";
            this.data_bagusnrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lTableAdapter
            // 
            this.lTableAdapter.ClearBeforeFill = true;
            // 
            // DBLListrik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 474);
            this.Controls.Add(this.dateTimePickerListrik);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboNominalPLN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboJenis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TextMeter);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DBLListrik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Listrik";
            this.Load += new System.EventHandler(this.DBLListrik_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerListrik;
        private System.Windows.Forms.TextBox TextMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox ComboJenis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboNominalPLN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private data_bagusnrDataSet data_bagusnrDataSet;
        private System.Windows.Forms.BindingSource lBindingSource;
        private data_bagusnrDataSetTableAdapters.LTableAdapter lTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisPembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTrxDataGridViewTextBoxColumn;

    }
}