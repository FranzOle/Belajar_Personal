using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            buthilang();
            button1.Visible = false;
        }

        private void buthilang()
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void butada()
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;

            Form3 frm = new Form3();
            frm.Show();
        
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            fromlogin frm = new fromlogin();
            frm.Show();
            this.Hide();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            fromlogin frm = new fromlogin();
            frm.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;

            Form3 frm = new Form3();
            frm.Show();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.SkyBlue;
            panel5.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;
           // FormBorderStyle = FormBorderStyle.None;
           // WindowState = FormWindowState.Maximized;
           // TopMost = true;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Red;
            panel5.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;

            Form3 frm = new Form3();
            frm.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

            panel5.BackColor = Color.Red;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

            panel5.BackColor = Color.Red;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();

            panel5.BackColor = Color.Red;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.SkyBlue;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            butada();
            

            panel5.BackColor = Color.SkyBlue;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            butada();
            panel1.Enabled = false;
            panel5.BackColor = Color.SkyBlue;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.Red;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            butada();
            panel1.Enabled = false;
            panel5.BackColor = Color.SkyBlue;
            panel4.BackColor = Color.SkyBlue;
            panel6.BackColor = Color.Red;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            about frm = new about();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lap_obat frm = new lap_obat();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lap_penjualan frm = new lap_penjualan();
            frm.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buthilang();
            panel1.Enabled = true;
        }
    }
}
