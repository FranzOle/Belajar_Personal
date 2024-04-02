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
    public partial class MasterKode : UserControl
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private int idKode = -1;
        public MasterKode()
        {
            InitializeComponent();

            load();
        }

        private void load()
        {
            kodePromoBindingSource.Clear();
            kodePromoBindingSource.DataSource = db.KodePromoes.ToList();
        }

        private void clear()
        {
            textBox1.Text = textBox4.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = numericUpDown2.Value = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kode = textBox1.Text;
            DateTime berlaku = dateTimePicker1.Value;
            int presentase = (int)numericUpDown1.Value;
            int maks = (int)numericUpDown2.Value;
            string desk = textBox4.Text;

            if (idKode == -1)
            {
                if (kode != kode.ToUpper())
                {
                    MessageBox.Show("Kode harus menggunakan huruf kapital!");
                    return;
                }
                else
                {
                    if (db.KodePromoes.Any(r => r.Kode == kode))
                    {
                        MessageBox.Show("Kode sudah terpakai, harap mengganti kode anda!");
                        return;
                    }
                }

                KodePromo kp = new KodePromo()
                {
                    Kode = kode,
                    BerlakuSampai = berlaku,
                    PersentaseDiskon = presentase,
                    MaksimumDiskon = maks,
                    Deskripsi = desk,
                };
                db.KodePromoes.Add(kp);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data sukses di tambahkan!");
                    load();
                    clear();
                }
            }
            else
            {
                if (kode != kode.ToUpper())
                {
                    MessageBox.Show("Kode harus menggunakan huruf kapital!");
                    return;
                }
                else
                {
                    if (db.KodePromoes.Any(r => r.Kode == kode && r.ID != idKode))
                    {
                        MessageBox.Show("Kode sudah terpakai, harap mengganti kode anda!");
                        return;
                    }
                }

                KodePromo kp = db.KodePromoes.Where(f => f.ID == idKode).First();
                kp.Kode = kode;
                kp.Deskripsi = desk;
                kp.BerlakuSampai = berlaku;
                kp.PersentaseDiskon = presentase;
                kp.MaksimumDiskon = maks;

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data sukses di update!");
                    load();
                    clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is KodePromo kodePromo)
            {
                if (e.ColumnIndex == btnHapus.Index)
                {
                    if (MessageBox.Show("Yakin menghapus data ini", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.KodePromoes.Remove(kodePromo);
                    }
                }

                if (e.ColumnIndex == btnUpdate.Index)
                {
                    idKode = kodePromo.ID;

                    textBox1.Text = kodePromo.Kode;
                    textBox4.Text = kodePromo.Deskripsi;
                    dateTimePicker1.Value = kodePromo.BerlakuSampai;
                    numericUpDown1.Value = (decimal)kodePromo.PersentaseDiskon;
                    numericUpDown2.Value = (decimal)kodePromo.MaksimumDiskon;
                }
            }
        }
    }
}
