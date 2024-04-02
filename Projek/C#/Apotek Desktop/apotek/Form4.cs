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
    public partial class Form4 : Form
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/dbapotek.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public Form4()
        {
            InitializeComponent();
            panel3.Visible = false;
            textBox1.Enabled = false;
            comboBox1.Focus();
           // ambilid();
            idobat();
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID_PENJUALAN";
            dataGridView1.Columns[1].Name = "ID_OBAT";
            dataGridView1.Columns[2].Name = "NAMA_OBAT";
            dataGridView1.Columns[3].Name = "JENIS_OBAT";
            dataGridView1.Columns[4].Name = "JUMLAH";
            dataGridView1.Columns[5].Name = "HARGA";
            dataGridView1.Columns[6].Name = "TOTAL";
            dataGridView1.Columns[7].Name = "EXPAYER";
            dataGridView1.Columns[8].Name = "TANGGAL";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
          retrieveee();
          ambilid();
          
        }

        private void idobat()
        {
            comboBox1.Items.Clear();
            string sql = "SELECT * FROM tbobat";
            cmd = new OleDbCommand(sql, con);
            try
            {
                OleDbDataAdapter adapter;
                DataTable dt = new DataTable();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row[0].ToString());
                }
                // con.Close();
            }
            catch (Exception)
            {
            }
        }
        

        private void add(string idpenjualan, string idobat, string namaobat, string jenis, string jumlah,string hargaobat, string total, string exp, string tglbeli)
        {
            //SQL STMT
            const string sql = "INSERT INTO penjualan(idpenjualan,idobat,namaobat,jenis,jumlah,hargaobat,total,exp,tglbeli) VALUES(@ID_PENJUALAN,@ID_OBAT,@NAMA_OBAT,@JENIS_OBAT,@JUMLAH,@HARGA,@TOTAL,@EXPAYER,@TANGGAL)";
            cmd = new OleDbCommand(sql, con);

            //ADD PARAMS
            cmd.Parameters.AddWithValue("@ID_PENJUALAN", idpenjualan);
            cmd.Parameters.AddWithValue("@ID_OBAT", idobat);
            cmd.Parameters.AddWithValue("@NAMA_OBAT", namaobat);
            cmd.Parameters.AddWithValue("@JENIS_OBAT", jenis);
            cmd.Parameters.AddWithValue("@JUMLAH", Convert.ToInt32(jumlah));
            cmd.Parameters.AddWithValue("@HARGA", Convert.ToInt32(hargaobat));
            cmd.Parameters.AddWithValue("@TOTAL", Convert.ToInt32(total));
            cmd.Parameters.AddWithValue("@EXPAYER", exp);
            cmd.Parameters.AddWithValue("@TANGGAL", tglbeli);


            //OPEN CON AND EXEC INSERT
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //clearTxts();
                    MessageBox.Show(@"Successfully Inserted");
                }
                con.Close();
               // retrieveee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void retrieveee()
        {
            dataGridView1.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM penjualan ";
            cmd = new OleDbCommand(sql, con);
            try
            {
                con.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
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

        private void ubahobat(string idobat, string namaobat, string jenisobat, string stok, string harga, string exp)
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
                   // clearTxts();
                   // MessageBox.Show(@"Successfully Updated");
                }
                con.Close();

                //REFRESH DATA
               // retrieveee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void dariobat()
        {
           // dataGridView2.Rows.Clear();
            //SQL STATEMENT
            String sql = "SELECT * FROM tbobat WHERE idobat = '"+ comboBox1.Text +"'";
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader read = null;
            try
            {
                con.Open();
                read = cmd.ExecuteReader();
                //adapter.Fill(dt);
                //LOOP THROUGH DATATABLE
                int n = 0;
                while (read.Read())
                {
                    textBox6.Text = read["namaobat"].ToString();
                    textBox7.Text = read["jenisobat"].ToString();
                    label6.Text = read["stok"].ToString();
                    textBox9.Text = read["harga"].ToString();
                    textBox10.Text = read["exp"].ToString();
               
                    n++;
                }
                
                if (n == 0)
                {
                    MessageBox.Show(@"Tidak ada ditemukan!");
                }
               

                con.Close();
                //CLEAR DATATABLE 
             
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            } 
        }

        private void delete(string idpenjualan)
        {
            //SQL STATEMENTT
            String sql = "DELETE FROM penjualan WHERE idpenjualan='" + idpenjualan + "'";
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
                retrieveee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        

        private void populate(string idpenjualan, string idobat, string namaobat, string jenis, string jumlah, string hargaobat, string total, string exp, string tglbeli)
        {
            dataGridView1.Rows.Add(idpenjualan, idobat, namaobat, jenis, jumlah, hargaobat, total, exp, tglbeli);
        }

       // private void populateobat(string idobat, string namaobat, string jenisobat, string stok, string harga, string exp)
        //{
          //  textBox6.Text = (namaobat);
          //  textBox7.Text = (jenisobat);
          //  textBox8.Text = (stok);
           // textBox9.Text = (harga);
           // textBox10.Text = (exp);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
           
           
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
                        string idpenjualan = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string idobat = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string namaobat = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        string jenis = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        string jumlah = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        string hargaobat = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        string total = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        string exp = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        string tglbeli = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                        textBox1.Text = idpenjualan;
                        comboBox1.Text = idobat;
                        textBox6.Text = namaobat;
                        textBox3.Text = jumlah;
                        textBox7.Text = jenis;
                        textBox9.Text = hargaobat;
                        textBox10.Text = exp;
                        label5.Text = total;
                        
                        dateTimePicker1.Text = tglbeli;
                    }

                }
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            delete(textBox1.Text);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dariobat();

                int jml, stk, stokobat, hrg, tol;

                jml = Convert.ToInt32(textBox3.Text);
                hrg = Convert.ToInt32(textBox9.Text);
                tol = Convert.ToInt32(label5.Text);

                tol = jml * hrg;
                label5.Text = tol.ToString();

                stokobat = Convert.ToInt32(label6.Text);

                stk = stokobat - jml;
                textBox8.Text = stk.ToString();

                add(textBox1.Text, comboBox1.Text, textBox6.Text, textBox7.Text, textBox3.Text, textBox9.Text, label5.Text, textBox10.Text, dateTimePicker1.Text);
                ubahobat(comboBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
                textBox2.Focus();
              //  retrieveee();
            }
        }

        private void ambilid()
        {
            String sql = "SELECT * FROM penjualan";
            cmd = new OleDbCommand(sql, con);
            OleDbDataReader read = null;
            try
            {
                con.Open();
                read = cmd.ExecuteReader();
                string id = "";
                while (read.Read())
                {
                    id = read["idpenjualan"].ToString();
                }
                int idobt = Convert.ToInt32(id) + 1;
                textBox1.Text = Convert.ToString(idobt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void clearTxts()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "0";
            textBox9.Text = "";
            textBox10.Text = "";
            label5.Text = "0";
            
            //dateTimePicker1.Text = " ";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            clearTxts();
            comboBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ambilid();
            hilangkembalian();
            textBox3.Text = "";
            label5.Text = "0";
            textBox2.Text = "";
            label16.Text = "0";
        }

        private void hilangkembalian()
        {
            textBox2.Text = "";
            label16.Text = "0";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            ambilid();
            label5.Text = "0";
            textBox3.Text = "";
            hilangkembalian();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int total, bayar, kembali;
                total = Convert.ToInt32(label5.Text);
                // kembali = Convert.ToInt32(label16.Text);
                bayar = Convert.ToInt32(textBox2.Text);
                kembali = bayar - total;

                label16.Text = kembali.ToString();

                if (e.KeyChar == (char)13)
                {
                    retrieveee();
                    clearTxts();
                   // label5.Text = "0";
                   // textBox9.Text = "";
                    comboBox1.Focus();
                    
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
