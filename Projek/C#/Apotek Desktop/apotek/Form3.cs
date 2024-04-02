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
    public partial class Form3 : Form
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/dbapotek.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public Form3()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID_OBAT";
            dataGridView1.Columns[1].Name = "NAMA_OBAT";
            dataGridView1.Columns[2].Name = "JENIS_OBAT";
            dataGridView1.Columns[3].Name = "STOK";
            dataGridView1.Columns[4].Name = "HARGA";
            dataGridView1.Columns[5].Name = "EXPAYER";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            retrieve();
           // ambilid();

        }

        private void add(string idobat, string namaobat, string jenisobat, string stok, string harga, string exp)
        {
            //SQL STMT
            const string sql = "INSERT INTO tbOBAT(idobat,namaobat,jenisobat,stok,harga,exp) VALUES(@ID_OBAT,@NAMA_OBAT,@JENIS_OBAT,@STOK,@HARGA,@EXP)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@ID_OBAT", idobat);
            cmd.Parameters.AddWithValue("@NAMA_OBAT", namaobat);
            cmd.Parameters.AddWithValue("@JENIS_OBAT", jenisobat);
            cmd.Parameters.AddWithValue("@STOK", Convert.ToInt32(stok));
            cmd.Parameters.AddWithValue("@HARGA", Convert.ToInt32(harga));
            cmd.Parameters.AddWithValue("@EXP", exp);
           

            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM tbobat ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }

                con.Close();
                //CLEAR DATATABLE 
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void ambilid()
        {
            String sql = "SELECT * FROM tbobat";
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader read = null;
            try
            {
                con.Open();
                read = cmd.ExecuteReader();
                string id = "";
                while (read.Read())
                {
                    id = read["idobat"].ToString();
                }
                int idobt = Convert.ToInt32(id) + 1;
                textBox1.Text =Convert.ToString(idobt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

       

        private void populate(string idobat, string namaobat, string jenisobat, string stok, string harga, string exp)
        {
            dataGridView1.Rows.Add(idobat,namaobat,jenisobat,stok,harga,exp);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);
            clearTxts();
            ambilid();
            textBox2.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        string namaobat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string jenisobat = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string stok = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        string idobat = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string harga = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        string exp = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                        textBox1.Text = idobat;
                        textBox2.Text = namaobat;
                        comboBox1.Text = jenisobat;
                        textBox3.Text = stok;
                        textBox4.Text = harga;
                        dateTimePicker1.Text = exp;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void update(string idobat, string namaobat, string jenisobat, string stok, string harga, string exp)
        {
            //SQL STATEMENT
            string sql = "UPDATE tbobat SET idobat='" + idobat + "',namaobat='" + namaobat + "',jenisobat='" + jenisobat + "',stok='" + Convert.ToInt32(stok) + "',harga='" + Convert.ToInt32(harga) + "' WHERE idobat='" + idobat + "'";
            cmd = new OleDbCommand(sql, con);

            //OPEN CONNECTION,UPDATE,RETRIEVE DATAGRIDVIEW
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd)
                {
                    UpdateCommand = con.CreateCommand()
                };
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTxts();
                    MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void delete(string idobat)
        {
            //SQL STATEMENTT
            String sql = "DELETE FROM tbobat WHERE idobat='" + idobat + "'";
            cmd = new OleDbCommand(sql, con);

            //'OPEN CONNECTION,EXECUTE DELETE,CLOSE CONNECTION
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                //PROMPT FOR CONFIRMATION BEFORE DELETING
                if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully deleted");
                    }
                }
                con.Close();
                //retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nonaktifkan();
            clearTxts();
            but_batal.Enabled = true;
            but_tambah.Enabled = true;
            but_kembali.Enabled = true;
            but_edit.Enabled = true;
           // textBox1.Text = "01";
        }

        private void but_tambah_Click(object sender, EventArgs e)
        {
            ambilid();
            aktifkan();
            clearTxts();
            textBox2.Focus();
            but_kembali.Enabled = false;
            but_edit.Enabled = false;
            but_hapus.Enabled = false;
            but_ubah.Enabled = false;
            but_tambah.Enabled = false;
        }

        private void but_batal_Click(object sender, EventArgs e)
        {
            nonaktifkan();
            clearTxts();
            but_batal.Enabled = true;
            but_tambah.Enabled = true;
            but_kembali.Enabled = true;
            but_edit.Enabled = true;

        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            aktifkan();
            clearTxts();
            but_kembali.Enabled = false;
            but_tambah.Enabled = false;
            but_simpan.Enabled = false;
            but_edit.Enabled = false;
        }

        private void but_hapus_Click(object sender, EventArgs e)
        {
            delete(textBox1.Text);
            nonaktifkan();
            clearTxts();
            but_tambah.Enabled = true;
            but_kembali.Enabled = true;
            but_edit.Enabled = true;
            retrieve();
        }

        private void but_ubah_Click(object sender, EventArgs e)
        {
            update(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);
            
            nonaktifkan();
            clearTxts();
            but_tambah.Enabled = true;
            but_kembali.Enabled = true;
            but_edit.Enabled = true;
        }

        public void nonaktifkan()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            dateTimePicker1.Enabled = false;
            but_hapus.Enabled = false;
            but_batal.Enabled = false;
            but_kembali.Enabled = false;
            but_simpan.Enabled = false;
            but_tambah.Enabled = false;
            but_edit.Enabled = false;
            but_ubah.Enabled = false;
        }

        public void aktifkan()
        {
           // textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            but_hapus.Enabled = true;
            but_batal.Enabled = true;
            but_kembali.Enabled = true;
            but_simpan.Enabled = true;
            but_tambah.Enabled = true;
            but_edit.Enabled = true;
            but_ubah.Enabled = true;
        }

        private void clearTxts()
        {
          //  textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            //dateTimePicker1.Text = " ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearTxts();
            ambilid();
        }
    }
}
