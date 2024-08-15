using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromotestPT4
{
    public partial class RegisterForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();

            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernm = textBox1.Text;
            string nama = textBox2.Text;
            string no = textBox3.Text;
            string pw = textBox4.Text;
            DateTime dt = dateTimePicker1.Value;

            if (usernm == string.Empty)
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }
            else
            {
                if (db.Akuns.Any(d => d.Username == usernm))
                {
                    MessageBox.Show("Username must unik!");
                    return;
                }
            }

            if (nama == string.Empty)
            {
                MessageBox.Show("Nama cannot be empty!");
                return;
            }

            if (no == string.Empty)
            {
                MessageBox.Show("Nomor cannot be empty!");
                return;
            }
            else
            {
                if (no.Length < 10 || no.Length > 15)
                {
                    MessageBox.Show("Nomor telpon must minimal 10 characters & maksimal 15 characters");
                    return;
                }
            }

            if (pw == string.Empty)
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }
            else
            {
                if (pw.Length < 8)
                {
                    MessageBox.Show("Password cannot be empty!");
                    return;
                }
            }


            Akun ak = new Akun() {
                Username = usernm,
                Password = pw,
                Nama = nama,
                TanggalLahir = dt,
                NomorTelepon = no,
                MerupakanAdmin = false,
            };

            db.Akuns.Add(ak);

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Data success to add!", "Information", MessageBoxButtons.OK);
                
                CustomerMainForm customerForm = new CustomerMainForm(ak.ID);
                customerForm.Show();

                Hide();
            }
        }
    }
}
