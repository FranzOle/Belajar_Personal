namespace bromotestPT4
{
    partial class TiketSayaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSayaForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KodePenerbanganC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaskapaiC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPenerbanganC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhirC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiHeaderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.Location = new System.Drawing.Point(48, 71);
            this.subtitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(417, 25);
            this.subtitle.TabIndex = 35;
            this.subtitle.Text = "Semua tiket anda yang aktif akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tiket Saya";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodePenerbanganC,
            this.MaskapaiC,
            this.BandaraKeberangkatanC,
            this.BandaraTujuanC,
            this.TanggalKeberangkatanC,
            this.WaktuPenerbanganC,
            this.StatusTerakhirC});
            this.dataGridView1.DataSource = this.transaksiHeaderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 419);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataSource = typeof(bromotestPT4.JadwalPenerbangan);
            // 
            // transaksiHeaderBindingSource
            // 
            this.transaksiHeaderBindingSource.DataSource = typeof(bromotestPT4.TransaksiHeader);
            // 
            // KodePenerbanganC
            // 
            this.KodePenerbanganC.HeaderText = "KodePenerbangan";
            this.KodePenerbanganC.MinimumWidth = 6;
            this.KodePenerbanganC.Name = "KodePenerbanganC";
            // 
            // MaskapaiC
            // 
            this.MaskapaiC.HeaderText = "Maskapai";
            this.MaskapaiC.MinimumWidth = 6;
            this.MaskapaiC.Name = "MaskapaiC";
            // 
            // BandaraKeberangkatanC
            // 
            this.BandaraKeberangkatanC.HeaderText = "BandaraKeberangkatan";
            this.BandaraKeberangkatanC.MinimumWidth = 6;
            this.BandaraKeberangkatanC.Name = "BandaraKeberangkatanC";
            // 
            // BandaraTujuanC
            // 
            this.BandaraTujuanC.HeaderText = "BandaraTujuan";
            this.BandaraTujuanC.MinimumWidth = 6;
            this.BandaraTujuanC.Name = "BandaraTujuanC";
            // 
            // TanggalKeberangkatanC
            // 
            this.TanggalKeberangkatanC.HeaderText = "TanggalKeberangkatan";
            this.TanggalKeberangkatanC.MinimumWidth = 6;
            this.TanggalKeberangkatanC.Name = "TanggalKeberangkatanC";
            // 
            // WaktuPenerbanganC
            // 
            this.WaktuPenerbanganC.HeaderText = "WaktuPenerbangan";
            this.WaktuPenerbanganC.MinimumWidth = 6;
            this.WaktuPenerbanganC.Name = "WaktuPenerbanganC";
            // 
            // StatusTerakhirC
            // 
            this.StatusTerakhirC.HeaderText = "StatusTerakhir";
            this.StatusTerakhirC.MinimumWidth = 6;
            this.StatusTerakhirC.Name = "StatusTerakhirC";
            // 
            // TiketSayaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TiketSayaForm";
            this.Text = "TiketSayaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiHeaderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbanganC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaskapaiC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKeberangkatanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuPenerbanganC;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhirC;
        private System.Windows.Forms.BindingSource transaksiHeaderBindingSource;
    }
}