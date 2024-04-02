namespace bromotestPT4.Master
{
    partial class UbahStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodePenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskapaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandara1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiPenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTrakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerakhirDiUbah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perubahanStatusJadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 679);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // maskTB
            // 
            this.maskTB.Location = new System.Drawing.Point(630, 555);
            this.maskTB.Mask = "00 J\\am 00 menit";
            this.maskTB.Name = "maskTB";
            this.maskTB.Size = new System.Drawing.Size(262, 22);
            this.maskTB.TabIndex = 20;
            this.maskTB.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Perkiraan Durasi Delay";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.statusPenerbanganBindingSource;
            this.comboBox1.DisplayMember = "Nama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 550);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusPenerbanganBindingSource
            // 
            this.statusPenerbanganBindingSource.DataSource = typeof(bromotestPT4.StatusPenerbangan);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodePenerbanganDataGridViewTextBoxColumn,
            this.maskapaiDataGridViewTextBoxColumn,
            this.bandaraDataGridViewTextBoxColumn,
            this.bandara1DataGridViewTextBoxColumn,
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn,
            this.WaktuKeberangkatan,
            this.durasiPenerbanganDataGridViewTextBoxColumn,
            this.StatusTrakhir,
            this.TerakhirDiUbah,
            this.btnUbah});
            this.dataGridView2.DataSource = this.jadwalPenerbanganBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(959, 435);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // kodePenerbanganDataGridViewTextBoxColumn
            // 
            this.kodePenerbanganDataGridViewTextBoxColumn.DataPropertyName = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.HeaderText = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePenerbanganDataGridViewTextBoxColumn.Name = "kodePenerbanganDataGridViewTextBoxColumn";
            // 
            // maskapaiDataGridViewTextBoxColumn
            // 
            this.maskapaiDataGridViewTextBoxColumn.DataPropertyName = "Maskapai";
            this.maskapaiDataGridViewTextBoxColumn.HeaderText = "Maskapai";
            this.maskapaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maskapaiDataGridViewTextBoxColumn.Name = "maskapaiDataGridViewTextBoxColumn";
            // 
            // bandaraDataGridViewTextBoxColumn
            // 
            this.bandaraDataGridViewTextBoxColumn.DataPropertyName = "Bandara";
            this.bandaraDataGridViewTextBoxColumn.HeaderText = "BandaraKeberangkatan";
            this.bandaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bandaraDataGridViewTextBoxColumn.Name = "bandaraDataGridViewTextBoxColumn";
            // 
            // bandara1DataGridViewTextBoxColumn
            // 
            this.bandara1DataGridViewTextBoxColumn.DataPropertyName = "Bandara1";
            this.bandara1DataGridViewTextBoxColumn.HeaderText = "BandaraTujuan";
            this.bandara1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bandara1DataGridViewTextBoxColumn.Name = "bandara1DataGridViewTextBoxColumn";
            // 
            // tanggalWaktuKeberangkatanDataGridViewTextBoxColumn
            // 
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.DataPropertyName = "TanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.HeaderText = "TanggalKeberangkatan";
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.Name = "tanggalWaktuKeberangkatanDataGridViewTextBoxColumn";
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.DataPropertyName = "ID";
            this.WaktuKeberangkatan.HeaderText = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.MinimumWidth = 6;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            // 
            // durasiPenerbanganDataGridViewTextBoxColumn
            // 
            this.durasiPenerbanganDataGridViewTextBoxColumn.DataPropertyName = "DurasiPenerbangan";
            this.durasiPenerbanganDataGridViewTextBoxColumn.HeaderText = "DurasiPenerbangan";
            this.durasiPenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durasiPenerbanganDataGridViewTextBoxColumn.Name = "durasiPenerbanganDataGridViewTextBoxColumn";
            // 
            // StatusTrakhir
            // 
            this.StatusTrakhir.DataPropertyName = "ID";
            this.StatusTrakhir.HeaderText = "StatusTerakhir";
            this.StatusTrakhir.MinimumWidth = 6;
            this.StatusTrakhir.Name = "StatusTrakhir";
            // 
            // TerakhirDiUbah
            // 
            this.TerakhirDiUbah.DataPropertyName = "ID";
            this.TerakhirDiUbah.HeaderText = "TerakhirDiUbah";
            this.TerakhirDiUbah.MinimumWidth = 6;
            this.TerakhirDiUbah.Name = "TerakhirDiUbah";
            // 
            // btnUbah
            // 
            this.btnUbah.DataPropertyName = "ID";
            this.btnUbah.HeaderText = "";
            this.btnUbah.MinimumWidth = 6;
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseColumnTextForButtonValue = true;
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataSource = typeof(bromotestPT4.JadwalPenerbangan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anda bisa mengubah status penerbangan disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // perubahanStatusJadwalPenerbanganBindingSource
            // 
            this.perubahanStatusJadwalPenerbanganBindingSource.DataSource = typeof(bromotestPT4.PerubahanStatusJadwalPenerbangan);
            // 
            // UbahStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UbahStatus";
            this.Size = new System.Drawing.Size(995, 679);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource perubahanStatusJadwalPenerbanganBindingSource;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskapaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandara1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuKeberangkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiPenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTrakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerakhirDiUbah;
        private System.Windows.Forms.DataGridViewButtonColumn btnUbah;
        private System.Windows.Forms.BindingSource statusPenerbanganBindingSource;
        private System.Windows.Forms.MaskedTextBox maskTB;
    }
}
