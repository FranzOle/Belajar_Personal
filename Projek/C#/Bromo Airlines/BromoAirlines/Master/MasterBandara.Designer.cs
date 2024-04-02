namespace bromotestPT4.Master
{
    partial class MasterBandara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUbah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tbAlamat);
            this.groupBox1.Controls.Add(this.tbKota);
            this.groupBox1.Controls.Add(this.tbKode);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 679);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jumlah Terminal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Negara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kode IATA";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(630, 396);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(262, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.negaraBindingSource;
            this.comboBox1.DisplayMember = "Nama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 534);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 25);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "ID";
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataSource = typeof(bromotestPT4.Negara);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(630, 442);
            this.tbAlamat.Multiline = true;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAlamat.Size = new System.Drawing.Size(262, 120);
            this.tbAlamat.TabIndex = 6;
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(129, 488);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(262, 23);
            this.tbKota.TabIndex = 5;
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(129, 442);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(262, 23);
            this.tbKode.TabIndex = 4;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(129, 396);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(262, 23);
            this.tbNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
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
            this.namaDataGridViewTextBoxColumn,
            this.kodeIATADataGridViewTextBoxColumn,
            this.kotaDataGridViewTextBoxColumn,
            this.negaraDataGridViewTextBoxColumn,
            this.jumlahTerminalDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.btnUbah,
            this.btnHapus});
            this.dataGridView2.DataSource = this.bandaraBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(959, 287);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // kodeIATADataGridViewTextBoxColumn
            // 
            this.kodeIATADataGridViewTextBoxColumn.DataPropertyName = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.HeaderText = "KodeIATA";
            this.kodeIATADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeIATADataGridViewTextBoxColumn.Name = "kodeIATADataGridViewTextBoxColumn";
            // 
            // kotaDataGridViewTextBoxColumn
            // 
            this.kotaDataGridViewTextBoxColumn.DataPropertyName = "Kota";
            this.kotaDataGridViewTextBoxColumn.HeaderText = "Kota";
            this.kotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kotaDataGridViewTextBoxColumn.Name = "kotaDataGridViewTextBoxColumn";
            // 
            // negaraDataGridViewTextBoxColumn
            // 
            this.negaraDataGridViewTextBoxColumn.DataPropertyName = "Negara";
            this.negaraDataGridViewTextBoxColumn.HeaderText = "Negara";
            this.negaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.negaraDataGridViewTextBoxColumn.Name = "negaraDataGridViewTextBoxColumn";
            // 
            // jumlahTerminalDataGridViewTextBoxColumn
            // 
            this.jumlahTerminalDataGridViewTextBoxColumn.DataPropertyName = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.HeaderText = "JumlahTerminal";
            this.jumlahTerminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahTerminalDataGridViewTextBoxColumn.Name = "jumlahTerminalDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // btnUbah
            // 
            this.btnUbah.HeaderText = "";
            this.btnUbah.MinimumWidth = 6;
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseColumnTextForButtonValue = true;
            // 
            // btnHapus
            // 
            this.btnHapus.HeaderText = "";
            this.btnHapus.MinimumWidth = 6;
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseColumnTextForButtonValue = true;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(bromotestPT4.Bandara);
            // 
            // MasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterBandara";
            this.Size = new System.Drawing.Size(995, 679);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnUbah;
        private System.Windows.Forms.DataGridViewButtonColumn btnHapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource negaraBindingSource;
    }
}
