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
    public partial class LoginForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usrnm = textBox1.Text;
            string pass = textBox2.Text;

            if (usrnm == string.Empty)
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }
            if (pass == string.Empty)
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            Akun user =  db.Akuns.Where(d => d.Username == usrnm && d.Password == pass).FirstOrDefault();
            if (user != null)
            {
                if (user.MerupakanAdmin)
                {
                    AdmMainForm mainForm = new AdmMainForm();
                    mainForm.Show();

                    Hide();
                }
                else
                {
                    CustomerMainForm cmf = new CustomerMainForm(user.ID);
                    cmf.Show();

                    Hide();
                }
            }
            else
            {
                MessageBox.Show("User and Password cannot find!");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

        }
    }
}
