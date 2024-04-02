using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apotek
{
    public partial class fromlogin : Form
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/dbapotek.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
       // OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public fromlogin()
        {
            InitializeComponent();
            //textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Select();
          
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("select * from admin where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0) 
            {
                label3.Text = "Username atau password anda salah";
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Password";

            }
            else if (dt.Rows.Count > 0)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
               
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("select * from admin where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                label3.Text = "Username atau password anda salah";
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Password";
            }
            else if (dt.Rows.Count > 0)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}