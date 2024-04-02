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

namespace bromotestPT4.Master
{
    public partial class MasterBandara : UserControl
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private readonly Bandara bandara;
        private int idBand = -1;
        public MasterBandara()
        {
            InitializeComponent();

            negaraBindingSource.Clear();
            negaraBindingSource.DataSource = db.Negaras.ToList();
            
            comboBox1.SelectedItem = -1;

            loadTabel();
        }

        public void loadTabel()
        {
            bandaraBindingSource.Clear();
            bandaraBindingSource.DataSource = db.Bandaras.ToList();
        }

        public void clear()
        {
            tbNama.Text = tbKode.Text = tbKota.Text = tbAlamat.Text = string.Empty;
            comboBox1.SelectedItem = -1;
            numericUpDown1.Value = 1;

            idBand = -1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is Bandara bandara)
            {
                if (e.ColumnIndex == btnHapus.Index)
                {
                    if (MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Bandaras.Remove(bandara);

                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Success delete");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("delete failed");
                            return;
                        }
                    }
                }

                if (e.ColumnIndex == btnUbah.Index)
                {
                    idBand = bandara.ID;

                    tbNama.Text = bandara.Nama;
                    tbKode.Text = bandara.KodeIATA;
                    tbKota.Text = bandara.Kota;
                    comboBox1.SelectedValue = bandara.NegaraID;
                    numericUpDown1.Value = bandara.JumlahTerminal;
                    tbAlamat.Text = bandara.Alamat;
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is Bandara bandara)
            {
                if (e.ColumnIndex == negaraDataGridViewTextBoxColumn.Index)
                {
                    e.Value = bandara.Negara.Nama;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string kode = tbKode.Text.ToUpper();
            string kota = tbKota.Text;
            int negaraId = (int)comboBox1.SelectedValue;
            int terminal = (int)numericUpDown1.Value;
            string alamat = tbAlamat.Text;

            if (idBand == -1)
            {
                if (db.Bandaras.Any(f => f.Nama == nama))
                {
                    MessageBox.Show("Nama Bandara sudah terpakai, Harap mengganti Nama Bandara anda!");
                    return;
                }

                if (kode.Length < 3)
                {
                    MessageBox.Show("Kode IATA minimal 3 huruf!");
                    return;
                }
                else
                {
                    if (db.Bandaras.Any(d => d.KodeIATA == kode))
                    {
                        MessageBox.Show("Kode sudah terpakai, Harap mengganti Kode anda!");
                        return;
                    }
                }

                Bandara bandara = new Bandara()
                {
                    Nama = nama,
                    KodeIATA = kode,
                    Kota = kota,
                    NegaraID = negaraId,
                    JumlahTerminal = terminal,
                    Alamat = alamat,
                };
                db.Bandaras.Add(bandara);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data sukses ditambahkan!");
                    loadTabel();

                    clear();
                }
            }
            else
            {
                if (db.Bandaras.Any(f => f.Nama == nama && f.ID != idBand))
                {
                    MessageBox.Show("Nama Bandara sudah terpakai, Harap mengganti Nama Bandara anda!");
                    return;
                }

                if (kode.Length < 3)
                {
                    MessageBox.Show("Kode IATA minimal 3 huruf!");
                    return;
                }
                else
                {
                    if (db.Bandaras.Any(d => d.KodeIATA == kode && d.ID != idBand))
                    {
                        MessageBox.Show("Kode sudah terpakai, Harap mengganti Kode anda!");
                        return;
                    }
                }

                Bandara band = db.Bandaras.Where(d => d.ID == idBand).First();
                band.Nama = nama;
                band.KodeIATA = kode;
                band.Kota = kota;
                band.NegaraID = negaraId;
                band.JumlahTerminal = terminal;
                band.Alamat = alamat;


                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data success to Update!");

                    loadTabel();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to delete data!");
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
