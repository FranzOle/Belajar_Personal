using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromotestPT4.Master
{
    public partial class MasterMaskapai : UserControl
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();

        private int idMas = -1;
        public MasterMaskapai()
        {
            InitializeComponent();

            loadTable();
        }

        public void loadTable()
        {

            maskapaiBindingSource.Clear();
            maskapaiBindingSource.DataSource = db.Maskapais.ToList();
        }

        public void clear()
        {
            tbNama.Text = tbPerusahaan.Text = tbDesk.Text = string.Empty;
            numericUpDown1.Value = 1;

            idMas = -1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = tbNama.Text;
            string perusahaan = tbPerusahaan.Text;
            int kru = (int)numericUpDown1.Value;
            string desk = tbDesk.Text;

            if (idMas == -1)
            {
                Maskapai mas = new Maskapai()
                {
                    Nama = name,
                    Perusahaan = perusahaan,
                    JumlahKru = kru,
                    Deskripsi = desk
                };
                db.Maskapais.Add(mas);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data success add!");

                    loadTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Filed to add!");
                    return;
                }
            }
            else
            {
                if (db.Maskapais.Any(d => d.Nama == name && d.ID != idMas))
                {
                    MessageBox.Show("Nama sudah terpakai, harap mengganti nama maskapai!");
                    return;
                }

                Maskapai mas = db.Maskapais.Where(d => d.ID == idMas).First();
                mas.Perusahaan = perusahaan;
                mas.Deskripsi = desk;
                mas.Nama = name;
                mas.JumlahKru = kru;

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data success to update!");
                    
                    loadTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Filed to update!");
                    return;

                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is Maskapai maskapai)
            {
                if (e.ColumnIndex == btnHapus.Index)
                {
                    if (MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Maskapais.Remove(maskapai);

                        loadTable();

                    }
                }

                if (e.ColumnIndex == btnUbah.Index)
                {
                    idMas = maskapai.ID;

                    tbNama.Text = maskapai.Nama;
                    tbDesk.Text = maskapai.Deskripsi;
                    tbPerusahaan.Text = maskapai.Perusahaan;
                    numericUpDown1.Value = maskapai.JumlahKru;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
