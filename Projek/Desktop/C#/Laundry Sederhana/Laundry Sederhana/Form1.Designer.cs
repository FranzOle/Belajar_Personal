namespace Laundry_Sederhana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNama = new TextBox();
            txtBerat = new TextBox();
            txtHargatotal = new TextBox();
            txtHarga = new TextBox();
            txtUang = new TextBox();
            txtKembali = new TextBox();
            comboBox1 = new ComboBox();
            btnProses = new Button();
            btnReset = new Button();
            btnSimpan = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnHitung = new Button();
            label10 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 42);
            label1.TabIndex = 0;
            label1.Text = "Laundry SMK";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnHitung);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(btnSimpan);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnProses);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtKembali);
            groupBox1.Controls.Add(txtUang);
            groupBox1.Controls.Add(txtHarga);
            groupBox1.Controls.Add(txtHargatotal);
            groupBox1.Controls.Add(txtBerat);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(117, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 464);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Pelanggan";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(94, 13);
            label2.TabIndex = 0;
            label2.Text = "Nama Pelanggan";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 78);
            label3.Name = "label3";
            label3.Size = new Size(55, 13);
            label3.TabIndex = 1;
            label3.Text = "Berat (kg)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 155);
            label4.Name = "label4";
            label4.Size = new Size(38, 13);
            label4.TabIndex = 2;
            label4.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(32, 13);
            label5.TabIndex = 3;
            label5.Text = "Jenis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(66, 13);
            label6.TabIndex = 4;
            label6.Text = "Harga Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 296);
            label7.Name = "label7";
            label7.Size = new Size(93, 13);
            label7.TabIndex = 5;
            label7.Text = "Uang Pelanggan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 332);
            label8.Name = "label8";
            label8.Size = new Size(60, 13);
            label8.TabIndex = 6;
            label8.Text = "Kembalian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 365);
            label9.Name = "label9";
            label9.Size = new Size(118, 13);
            label9.TabIndex = 7;
            label9.Text = "Tanngal Pengambilan";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(138, 32);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(147, 27);
            txtNama.TabIndex = 8;
            // 
            // txtBerat
            // 
            txtBerat.Location = new Point(138, 70);
            txtBerat.Name = "txtBerat";
            txtBerat.Size = new Size(147, 27);
            txtBerat.TabIndex = 9;
            // 
            // txtHargatotal
            // 
            txtHargatotal.Location = new Point(138, 187);
            txtHargatotal.Name = "txtHargatotal";
            txtHargatotal.Size = new Size(147, 27);
            txtHargatotal.TabIndex = 10;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(138, 147);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(147, 27);
            txtHarga.TabIndex = 11;
            // 
            // txtUang
            // 
            txtUang.Location = new Point(138, 288);
            txtUang.Name = "txtUang";
            txtUang.Size = new Size(147, 27);
            txtUang.TabIndex = 12;
            // 
            // txtKembali
            // 
            txtKembali.Location = new Point(138, 324);
            txtKembali.Name = "txtKembali";
            txtKembali.Size = new Size(147, 27);
            txtKembali.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 100;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "KARPET", "BONEKA", "PAKAIAN", "SELIMUT" });
            comboBox1.Location = new Point(138, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 14;
            // 
            // btnProses
            // 
            btnProses.Location = new Point(163, 234);
            btnProses.Name = "btnProses";
            btnProses.Size = new Size(98, 31);
            btnProses.TabIndex = 15;
            btnProses.Text = "PROSES";
            btnProses.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(42, 412);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 31);
            btnReset.TabIndex = 16;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(318, 412);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(98, 31);
            btnSimpan.TabIndex = 17;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 357);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(318, 314);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(98, 31);
            btnHitung.TabIndex = 19;
            btnHitung.Text = "HITUNG";
            btnHitung.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(351, 35);
            label10.Name = "label10";
            label10.Size = new Size(117, 20);
            label10.TabIndex = 2;
            label10.Text = "Kualitas Laundry";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(351, 70);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Standar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(435, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 19);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kilat";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 555);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private TextBox txtHarga;
        private TextBox txtHargatotal;
        private TextBox txtBerat;
        private TextBox txtNama;
        private ComboBox comboBox1;
        private TextBox txtKembali;
        private TextBox txtUang;
        private Button btnSimpan;
        private Button btnReset;
        private Button btnProses;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label10;
        private Button btnHitung;
        private DateTimePicker dateTimePicker1;
    }
}
