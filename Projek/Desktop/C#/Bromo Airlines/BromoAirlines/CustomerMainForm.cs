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
    public partial class CustomerMainForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private Akun akun;
        public CustomerMainForm(int id)
        {
            akun = db.Akuns.Where(f => f.ID == id).FirstOrDefault();
            InitializeComponent();

            lblNama.Text = $"Mau terbang kemana hari ini, {akun.Nama}?";

            
            bandaraBindingSource.Clear();
            bandaraBindingSource.DataSource = db.Bandaras.ToList();
            
            bandaraBindingSource1.Clear();
            bandaraBindingSource1.DataSource = db.Bandaras.ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Bandara b)
            {
                e.Value = $"{b.Nama}, {b.Kota}({b.KodeIATA})";
            }
        }

        private void comboBox2_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Bandara b)
            {
                e.Value = $"{b.Nama}, {b.Kota}({b.KodeIATA})";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bandaraK = (int)comboBox1.SelectedValue;
            int bandaraT = (int)comboBox2.SelectedValue;
            DateTime tglK = dateTimePicker1.Value;
            int jmlP = (int)numericUpDown1.Value;

            if(bandaraK == bandaraT)
            {
                MessageBox.Show("Bandara keberangkatan tidak boleh sama!");
                return;
            }
            if (tglK < DateTime.Now)
            {
                MessageBox.Show("Tanggal keberangkatan tidak boleh kurang dari hari saat ini!");
                return;
            }

            if (jmlP == 0)
            {
                MessageBox.Show("Penumpang minimal 1");
                return;
            }

            ListPenerbanganForm lpf = new ListPenerbanganForm(akun.ID, bandaraK, bandaraT, tglK, jmlP);
            lpf.Show();

            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();

            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TiketSayaForm tsf = new TiketSayaForm(akun.ID);
            tsf.Show();

            Hide();
        }
    }
}
