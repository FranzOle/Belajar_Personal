
namespace WinFormsApp1
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            button6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnTambah = new Button();
            btnKurang = new Button();
            btnBagi = new Button();
            btnClear = new Button();
            btn0 = new Button();
            btnHasil = new Button();
            txtDisplay = new TextBox();
            txtDisplay2 = new TextBox();
            btnKoma = new Button();
            btnKali = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 61);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 34);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(93, 61);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 34);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(174, 61);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 34);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click_1;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 101);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 34);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(93, 101);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 34);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(174, 101);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 141);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 34);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(93, 141);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 34);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(174, 141);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 34);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(12, 181);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 34);
            btnTambah.TabIndex = 10;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnKurang
            // 
            btnKurang.Location = new Point(93, 181);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(75, 34);
            btnKurang.TabIndex = 11;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = true;
            // 
            // btnBagi
            // 
            btnBagi.Location = new Point(174, 181);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(75, 34);
            btnBagi.TabIndex = 12;
            btnBagi.Text = "/";
            btnBagi.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(255, 61);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(171, 34);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(255, 101);
            btn0.Name = "btn0";
            btn0.Size = new Size(171, 34);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnHasil
            // 
            btnHasil.Location = new Point(335, 141);
            btnHasil.Name = "btnHasil";
            btnHasil.Size = new Size(91, 74);
            btnHasil.TabIndex = 15;
            btnHasil.Text = "=";
            btnHasil.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(414, 43);
            txtDisplay.TabIndex = 16;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // txtDisplay2
            // 
            txtDisplay2.BorderStyle = BorderStyle.None;
            txtDisplay2.Location = new Point(24, 21);
            txtDisplay2.Multiline = true;
            txtDisplay2.Name = "txtDisplay2";
            txtDisplay2.Size = new Size(49, 25);
            txtDisplay2.TabIndex = 17;
            // 
            // btnKoma
            // 
            btnKoma.Location = new Point(255, 141);
            btnKoma.Name = "btnKoma";
            btnKoma.Size = new Size(75, 34);
            btnKoma.TabIndex = 18;
            btnKoma.Text = ".";
            btnKoma.UseVisualStyleBackColor = true;
            // 
            // btnKali
            // 
            btnKali.Location = new Point(254, 181);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(75, 34);
            btnKali.TabIndex = 19;
            btnKali.Text = "X";
            btnKali.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 246);
            Controls.Add(btnKali);
            Controls.Add(btnKoma);
            Controls.Add(txtDisplay2);
            Controls.Add(txtDisplay);
            Controls.Add(btnHasil);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btnBagi);
            Controls.Add(btnKurang);
            Controls.Add(btnTambah);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(button6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button button6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnTambah;
        private Button btnKurang;
        private Button btnBagi;
        private Button btnClear;
        private Button btn0;
        private Button btnHasil;
        private TextBox txtDisplay;
        private TextBox txtDisplay2;
        private Button btnKoma;
        private Button btnKali;
    }
}
