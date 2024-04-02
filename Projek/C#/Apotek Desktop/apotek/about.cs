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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void hilang()
        {
            panel2.Visible = false;
            panel1.Visible = false;
            panel4.Visible = false;
        }

        private void matikan()
        {
            button1.BackColor = Color.SkyBlue;
            button2.BackColor = Color.SkyBlue;

            button3.BackColor = Color.SkyBlue;


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hilang();
            panel4.Visible = true;
            matikan();
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hilang();
            panel1.Visible = true;
            matikan();
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hilang();
            panel2.Visible = true;
            matikan();
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void about_Load(object sender, EventArgs e)
        {
            hilang();
        }
    }
}
