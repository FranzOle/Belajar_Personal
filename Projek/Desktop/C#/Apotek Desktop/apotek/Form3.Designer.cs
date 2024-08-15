namespace apotek
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_ubah = new System.Windows.Forms.Button();
            this.but_batal = new System.Windows.Forms.Button();
            this.but_kembali = new System.Windows.Forms.Button();
            this.but_hapus = new System.Windows.Forms.Button();
            this.but_tambah = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_simpan = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(-2, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(779, 532);
            this.panel7.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 364);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.but_ubah);
            this.groupBox1.Controls.Add(this.but_batal);
            this.groupBox1.Controls.Add(this.but_kembali);
            this.groupBox1.Controls.Add(this.but_hapus);
            this.groupBox1.Controls.Add(this.but_tambah);
            this.groupBox1.Controls.Add(this.but_edit);
            this.groupBox1.Controls.Add(this.but_simpan);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 141);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // but_ubah
            // 
            this.but_ubah.Location = new System.Drawing.Point(21, 108);
            this.but_ubah.Name = "but_ubah";
            this.but_ubah.Size = new System.Drawing.Size(75, 23);
            this.but_ubah.TabIndex = 6;
            this.but_ubah.Text = "Ubah";
            this.but_ubah.UseVisualStyleBackColor = true;
            this.but_ubah.Click += new System.EventHandler(this.but_ubah_Click);
            // 
            // but_batal
            // 
            this.but_batal.Location = new System.Drawing.Point(136, 51);
            this.but_batal.Name = "but_batal";
            this.but_batal.Size = new System.Drawing.Size(75, 23);
            this.but_batal.TabIndex = 5;
            this.but_batal.Text = "Batal";
            this.but_batal.UseVisualStyleBackColor = true;
            this.but_batal.Click += new System.EventHandler(this.but_batal_Click);
            // 
            // but_kembali
            // 
            this.but_kembali.Location = new System.Drawing.Point(136, 79);
            this.but_kembali.Name = "but_kembali";
            this.but_kembali.Size = new System.Drawing.Size(75, 23);
            this.but_kembali.TabIndex = 4;
            this.but_kembali.Text = "Kembali";
            this.but_kembali.UseVisualStyleBackColor = true;
            this.but_kembali.Click += new System.EventHandler(this.button5_Click);
            // 
            // but_hapus
            // 
            this.but_hapus.Location = new System.Drawing.Point(136, 22);
            this.but_hapus.Name = "but_hapus";
            this.but_hapus.Size = new System.Drawing.Size(75, 23);
            this.but_hapus.TabIndex = 3;
            this.but_hapus.Text = "Hapus";
            this.but_hapus.UseVisualStyleBackColor = true;
            this.but_hapus.Click += new System.EventHandler(this.but_hapus_Click);
            // 
            // but_tambah
            // 
            this.but_tambah.Location = new System.Drawing.Point(21, 79);
            this.but_tambah.Name = "but_tambah";
            this.but_tambah.Size = new System.Drawing.Size(75, 23);
            this.but_tambah.TabIndex = 2;
            this.but_tambah.Text = "Tambah";
            this.but_tambah.UseVisualStyleBackColor = true;
            this.but_tambah.Click += new System.EventHandler(this.but_tambah_Click);
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(21, 51);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(75, 23);
            this.but_edit.TabIndex = 1;
            this.but_edit.Text = "Edit";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_simpan
            // 
            this.but_simpan.Location = new System.Drawing.Point(21, 22);
            this.but_simpan.Name = "but_simpan";
            this.but_simpan.Size = new System.Drawing.Size(75, 23);
            this.but_simpan.TabIndex = 0;
            this.but_simpan.Text = "Simpan";
            this.but_simpan.UseVisualStyleBackColor = true;
            this.but_simpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(346, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "Data Obat";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(54, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(204, 81);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tablet",
            "Sirup",
            "Bubuk",
            "Suntik",
            "Botol"});
            this.comboBox1.Location = new System.Drawing.Point(113, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 22);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(113, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(113, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(113, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(113, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 27);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 14);
            this.label12.TabIndex = 10;
            this.label12.Text = "Expaier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "Harga Obat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 8;
            this.label10.Text = "Stok";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 7;
            this.label9.Text = "Jenis Obat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nama Obat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Id Obat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "© 2018 Apotek SisFo . All Rights Reserved | by Kelompok 5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 527);
            this.Controls.Add(this.panel7);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_kembali;
        private System.Windows.Forms.Button but_hapus;
        private System.Windows.Forms.Button but_tambah;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_simpan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button but_batal;
        private System.Windows.Forms.Button but_ubah;
    }
}