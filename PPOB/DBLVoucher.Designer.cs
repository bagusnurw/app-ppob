namespace PPOB
{
    partial class DBLVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLVoucher));
            this.dateTimePickerVoucher = new System.Windows.Forms.DateTimePicker();
            this.CBNominalVoucher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBProduk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewVoucher = new System.Windows.Forms.DataGridView();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_bagusnrDataSet = new PPOB.data_bagusnrDataSet();
            this.vTableAdapter = new PPOB.data_bagusnrDataSetTableAdapters.VTableAdapter();
            this.TextNoPemb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerVoucher
            // 
            this.dateTimePickerVoucher.Location = new System.Drawing.Point(142, 170);
            this.dateTimePickerVoucher.Name = "dateTimePickerVoucher";
            this.dateTimePickerVoucher.Size = new System.Drawing.Size(222, 26);
            this.dateTimePickerVoucher.TabIndex = 11;
            // 
            // CBNominalVoucher
            // 
            this.CBNominalVoucher.FormattingEnabled = true;
            this.CBNominalVoucher.Items.AddRange(new object[] {
            "RP 10.000",
            "RP 15.000",
            "RP 20.000",
            "RP 30.000",
            "RP 45.000",
            "RP 50.000",
            "RP 60.000",
            "RP 90.000",
            "RP 100.000",
            "RP 200.000",
            "RP 500.000",
            "RP 1.000.000"});
            this.CBNominalVoucher.Location = new System.Drawing.Point(341, 125);
            this.CBNominalVoucher.Name = "CBNominalVoucher";
            this.CBNominalVoucher.Size = new System.Drawing.Size(159, 28);
            this.CBNominalVoucher.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(245, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nominal";
            // 
            // CBProduk
            // 
            this.CBProduk.FormattingEnabled = true;
            this.CBProduk.Items.AddRange(new object[] {
            "GARENA",
            "STEAM",
            "MEGAXUS",
            "LYTO GAME",
            "INDOMOG",
            "GOOGLE PLAY"});
            this.CBProduk.Location = new System.Drawing.Point(80, 124);
            this.CBProduk.Name = "CBProduk";
            this.CBProduk.Size = new System.Drawing.Size(139, 28);
            this.CBProduk.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Location = new System.Drawing.Point(-4, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 9);
            this.panel6.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel5.Location = new System.Drawing.Point(401, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 41);
            this.panel5.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(103, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 22);
            this.panel4.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Location = new System.Drawing.Point(28, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 83);
            this.panel3.TabIndex = 26;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 83);
            this.panel1.TabIndex = 40;
            // 
            // dataGridViewVoucher
            // 
            this.dataGridViewVoucher.AutoGenerateColumns = false;
            this.dataGridViewVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.platformDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.tanggalTrxDataGridViewTextBoxColumn,
            this.noPembelianDataGridViewTextBoxColumn});
            this.dataGridViewVoucher.DataSource = this.vBindingSource;
            this.dataGridViewVoucher.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewVoucher.Name = "dataGridViewVoucher";
            this.dataGridViewVoucher.Size = new System.Drawing.Size(488, 150);
            this.dataGridViewVoucher.TabIndex = 45;
            this.dataGridViewVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
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
            // noPembelianDataGridViewTextBoxColumn
            // 
            this.noPembelianDataGridViewTextBoxColumn.DataPropertyName = "No_ Pembelian";
            this.noPembelianDataGridViewTextBoxColumn.HeaderText = "No_ Pembelian";
            this.noPembelianDataGridViewTextBoxColumn.Name = "noPembelianDataGridViewTextBoxColumn";
            // 
            // vBindingSource
            // 
            this.vBindingSource.DataMember = "V";
            this.vBindingSource.DataSource = this.data_bagusnrDataSet;
            // 
            // data_bagusnrDataSet
            // 
            this.data_bagusnrDataSet.DataSetName = "data_bagusnrDataSet";
            this.data_bagusnrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vTableAdapter
            // 
            this.vTableAdapter.ClearBeforeFill = true;
            // 
            // TextNoPemb
            // 
            this.TextNoPemb.Location = new System.Drawing.Point(228, 217);
            this.TextNoPemb.Name = "TextNoPemb";
            this.TextNoPemb.Size = new System.Drawing.Size(224, 26);
            this.TextNoPemb.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "No. Pembelian";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEdit.Location = new System.Drawing.Point(209, 421);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(99, 37);
            this.BtnEdit.TabIndex = 50;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(83, 421);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 37);
            this.BtnDelete.TabIndex = 49;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSearch.Location = new System.Drawing.Point(335, 421);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 37);
            this.BtnSearch.TabIndex = 51;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DBLVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 474);
            this.Controls.Add(this.dateTimePickerVoucher);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TextNoPemb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVoucher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBNominalVoucher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBProduk);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DBLVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Voucher";
            this.Load += new System.EventHandler(this.DBLVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerVoucher;
        private System.Windows.Forms.ComboBox CBNominalVoucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBProduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewVoucher;
        private data_bagusnrDataSet data_bagusnrDataSet;
        private System.Windows.Forms.BindingSource vBindingSource;
        private data_bagusnrDataSetTableAdapters.VTableAdapter vTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TextNoPemb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
    }
}