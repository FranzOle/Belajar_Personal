using bromotestPT4.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromotestPT4
{
    public partial class AdmMainForm : Form
    {
        private int active = 1;
        public AdmMainForm()
        {
            InitializeComponent();
        }

        public void openControl(Control control)
        {
            control.Dock = DockStyle.Fill;
            panel8.Controls.Add(control);
            panel8.Controls.SetChildIndex(control, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openControl(new MasterBandara());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openControl(new MasterMaskapai());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openControl(new MasterJadwalPenerbangan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openControl(new MasterKode());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openControl(new UbahStatus());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            if (active == 1)
            {
                flowLayoutPanel1.Width = 65;
                active = 0;
            }
            else
            {
                flowLayoutPanel1.Width = 255;
                active = 1;
            }
            flowLayoutPanel1.ResumeLayout();
        }
    }
}
