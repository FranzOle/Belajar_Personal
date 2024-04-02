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
    public partial class MasterJadwalPenerbangan : UserControl
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private int idJad = -1;
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();

            bandaraBindingSource.Clear();
            bandaraBindingSource.DataSource = db.Bandaras.ToList();

            bandaraBindingSource1.Clear();
            bandaraBindingSource1.DataSource = db.Bandaras.ToList();

            comboBox1.SelectedItem = comboBox2.SelectedItem = comboBox3.SelectedItem = -1;

            maskapaiBindingSource.Clear();
            maskapaiBindingSource.DataSource = db.Maskapais.ToList();

            load();

        }

        private void load()
        {
            jadwalPenerbanganBindingSource.Clear();
            jadwalPenerbanganBindingSource.DataSource = db.JadwalPenerbangans.OrderByDescending(c => c.TanggalWaktuKeberangkatan).ToList();

        }

        private void clear()
        {
            maskedTextBox1.Text = maskedTextBox2.Text = maskedTextBox3.Text = string.Empty;
            comboBox1.SelectedValue = comboBox2.SelectedValue = comboBox3.SelectedValue = -1;
            numericUpDown2.Value = 1;
            dateTimePicker1.Value = DateTime.Now;

            idJad = -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jadwal)
            {
                if (e.ColumnIndex == bandaraDataGridViewTextBoxColumn.Index)
                {
                    e.Value = jadwal.Bandara.Nama;
                }

                if (e.ColumnIndex == bandara1DataGridViewTextBoxColumn.Index)
                {
                    e.Value = jadwal.Bandara1.Nama;
                }

                if (e.ColumnIndex == maskapaiDataGridViewTextBoxColumn.Index)
                {
                    e.Value = jadwal.Maskapai.Nama;
                }

                if (e.ColumnIndex == waktuKeberangkatan.Index)
                {
                    DateTime dt = jadwal.TanggalWaktuKeberangkatan;
                    e.Value = $"{dt.Hour:00}:{dt.Minute:00}";
                }

                if (e.ColumnIndex == durasiPenerbanganDataGridViewTextBoxColumn.Index)
                {
                    TimeSpan ts = TimeSpan.FromMinutes(jadwal.DurasiPenerbangan);
                    e.Value = $"{ts.Hours:00} jam {ts.Minutes:00} menit";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kode = maskedTextBox1.Text.ToUpper();
            int bandaraK = (int)comboBox2.SelectedValue;
            int bandaraT = (int)comboBox3.SelectedValue;
            int maskap = (int)comboBox1.SelectedValue;
            DateTime tgl = dateTimePicker1.Value;
            string waktuK = maskedTextBox2.Text;
            string durasiP = maskedTextBox3.Text;
            int harga = (int)numericUpDown2.Value;

            string jamStr = durasiP.Split(' ')[0];
            string mntStr = durasiP.Split(' ')[2];

            if (int.Parse(waktuK.Split(':')[0]) > 23)
            {
                MessageBox.Show("Format Salah, Maksimal 23:59!");
                return;
            }
            if (int.Parse(waktuK.Split(':')[1]) > 59)
            {
                MessageBox.Show("Format Salah, Maksimal 23:59!");
                return;
            }


            if (!int.TryParse(jamStr, out int _))
            {
                MessageBox.Show("Format Durasi salah!");
            }
            if (!int.TryParse(mntStr, out int _))
            {
                MessageBox.Show("Format Durasi salah!");
            }


            if (bandaraK == bandaraT)
            {
                MessageBox.Show("Bandara keberangkatan dan bandara tujuan tidak boleh sama!");
                return;
            }

            DateTime tglwaktu = DateTime.Parse($"{tgl.Year}-{tgl.Month}-{tgl.Day} {waktuK}");

            int durasiPenerbangan = int.Parse(jamStr) * 60 + int.Parse(mntStr);

            if (idJad == -1)
            {
                JadwalPenerbangan jadwalPenerbangan = new JadwalPenerbangan()
                {
                    KodePenerbangan = kode,
                    BandaraKeberangkatanID = bandaraK,
                    BandaraTujuanID = bandaraT,
                    MaskapaiID = maskap,
                    TanggalWaktuKeberangkatan = tglwaktu,
                    DurasiPenerbangan = durasiPenerbangan,
                    HargaPerTiket = harga
                };
                db.JadwalPenerbangans.Add(jadwalPenerbangan);

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data sukses ditambahkan!");

                    load();
                    clear();
                }
            }
            else
            {
                JadwalPenerbangan jp = db.JadwalPenerbangans.Where(d => d.ID == idJad).First();
                jp.KodePenerbangan = kode;
                jp.BandaraKeberangkatanID = bandaraK;
                jp.BandaraTujuanID = bandaraT;
                jp.MaskapaiID = maskap;
                jp.TanggalWaktuKeberangkatan = tglwaktu;
                jp.DurasiPenerbangan = durasiPenerbangan;
                jp.HargaPerTiket = harga;

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Data berhasil di ubah!");
                    load();
                    clear();
                }
            }


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Format masukan tidak valid. Kode penerbangan harus diawali dengan dua huruf, diikuti oleh tanda strip (-), dan diakhiri dengan empat digit angka.");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jadwal)
            {
                if (e.ColumnIndex == btnHapus.Index)
                {
                    if (MessageBox.Show("Yakin menghapus item ini?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.JadwalPenerbangans.Remove(jadwal);
                    }
                }

                if (e.ColumnIndex == btnUbah.Index)
                {
                    idJad = jadwal.ID;

                    maskedTextBox1.Text = jadwal.KodePenerbangan;
                    comboBox1.SelectedValue = jadwal.MaskapaiID;
                    comboBox2.SelectedValue = jadwal.BandaraKeberangkatanID;
                    comboBox3.SelectedValue = jadwal.BandaraTujuanID;
                    dateTimePicker1.Value = jadwal.TanggalWaktuKeberangkatan;

                    var waktuK = jadwal.TanggalWaktuKeberangkatan;
                    maskedTextBox2.Text = $"{waktuK.Hour:00}:{waktuK.Minute:00}";

                    TimeSpan ts = TimeSpan.FromMinutes(jadwal.DurasiPenerbangan);
                    maskedTextBox3.Text = $"{ts.Hours:00} jam {ts.Minutes:00} menit";

                    numericUpDown2.Value = (decimal)jadwal.HargaPerTiket;
                }
            }
        }
    }
}
