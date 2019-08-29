namespace PPOB
{
    partial class DBLPulsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLPulsa));
            this.dateTimePickerPulsa = new System.Windows.Forms.DateTimePicker();
            this.CBNominal = new System.Windows.Forms.ComboBox();
            this.CBProvider = new System.Windows.Forms.ComboBox();
            this.TextNohp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPulsa = new System.Windows.Forms.DataGridView();
            this.providerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTrxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_bagusnrDataSet = new PPOB.data_bagusnrDataSet();
            this.pTableAdapter = new PPOB.data_bagusnrDataSetTableAdapters.PTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPulsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerPulsa
            // 
            this.dateTimePickerPulsa.Location = new System.Drawing.Point(139, 150);
            this.dateTimePickerPulsa.Name = "dateTimePickerPulsa";
            this.dateTimePickerPulsa.Size = new System.Drawing.Size(218, 26);
            this.dateTimePickerPulsa.TabIndex = 16;
            // 
            // CBNominal
            // 
            this.CBNominal.FormattingEnabled = true;
            this.CBNominal.Items.AddRange(new object[] {
            "RP 5.000",
            "RP 10.000",
            "RP 20.000",
            "RP 50.000",
            "RP 100.000"});
            this.CBNominal.Location = new System.Drawing.Point(346, 114);
            this.CBNominal.Name = "CBNominal";
            this.CBNominal.Size = new System.Drawing.Size(150, 28);
            this.CBNominal.TabIndex = 15;
            // 
            // CBProvider
            // 
            this.CBProvider.FormattingEnabled = true;
            this.CBProvider.ItemHeight = 20;
            this.CBProvider.Items.AddRange(new object[] {
            "INDOSAT",
            "TELKOMSEL",
            "XL",
            "THREE"});
            this.CBProvider.Location = new System.Drawing.Point(93, 114);
            this.CBProvider.Name = "CBProvider";
            this.CBProvider.Size = new System.Drawing.Size(147, 28);
            this.CBProvider.TabIndex = 14;
            // 
            // TextNohp
            // 
            this.TextNohp.Location = new System.Drawing.Point(208, 185);
            this.TextNohp.Name = "TextNohp";
            this.TextNohp.Size = new System.Drawing.Size(216, 26);
            this.TextNohp.TabIndex = 13;
            this.TextNohp.TextChanged += new System.EventHandler(this.TextNohp_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Masukkan No.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Provider";
            // 
            // dataGridViewPulsa
            // 
            this.dataGridViewPulsa.AutoGenerateColumns = false;
            this.dataGridViewPulsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPulsa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerDataGridViewTextBoxColumn,
            this.noHPDataGridViewTextBoxColumn,
            this.nominalDataGridViewTextBoxColumn,
            this.tanggalTrxDataGridViewTextBoxColumn});
            this.dataGridViewPulsa.DataSource = this.pBindingSource;
            this.dataGridViewPulsa.Location = new System.Drawing.Point(12, 217);
            this.dataGridViewPulsa.Name = "dataGridViewPulsa";
            this.dataGridViewPulsa.Size = new System.Drawing.Size(488, 191);
            this.dataGridViewPulsa.TabIndex = 17;
            this.dataGridViewPulsa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPulsa_CellClick);
            // 
            // providerDataGridViewTextBoxColumn
            // 
            this.providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            this.providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            this.providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            // 
            // noHPDataGridViewTextBoxColumn
            // 
            this.noHPDataGridViewTextBoxColumn.DataPropertyName = "No_ HP";
            this.noHPDataGridViewTextBoxColumn.HeaderText = "No_ HP";
            this.noHPDataGridViewTextBoxColumn.Name = "noHPDataGridViewTextBoxColumn";
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
            // pBindingSource
            // 
            this.pBindingSource.DataMember = "P";
            this.pBindingSource.DataSource = this.data_bagusnrDataSet;
            // 
            // data_bagusnrDataSet
            // 
            this.data_bagusnrDataSet.DataSetName = "data_bagusnrDataSet";
            this.data_bagusnrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pTableAdapter
            // 
            this.pTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(177, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel6.Location = new System.Drawing.Point(-4, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 9);
            this.panel6.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel5.Location = new System.Drawing.Point(401, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 41);
            this.panel5.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(103, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 22);
            this.panel4.TabIndex = 36;
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
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEdit.Location = new System.Drawing.Point(200, 425);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(99, 37);
            this.BtnEdit.TabIndex = 42;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(74, 425);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 37);
            this.BtnDelete.TabIndex = 41;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSearch.Location = new System.Drawing.Point(325, 425);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 37);
            this.BtnSearch.TabIndex = 43;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // DBLPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 474);
            this.Controls.Add(this.dateTimePickerPulsa);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPulsa);
            this.Controls.Add(this.CBNominal);
            this.Controls.Add(this.CBProvider);
            this.Controls.Add(this.TextNohp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DBLPulsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Pulsa";
            this.Load += new System.EventHandler(this.DBLPulsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPulsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bagusnrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPulsa;
        private System.Windows.Forms.ComboBox CBNominal;
        private System.Windows.Forms.ComboBox CBProvider;
        private System.Windows.Forms.TextBox TextNohp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPulsa;
        private data_bagusnrDataSet data_bagusnrDataSet;
        private System.Windows.Forms.BindingSource pBindingSource;
        private data_bagusnrDataSetTableAdapters.PTableAdapter pTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTrxDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;

    }
}