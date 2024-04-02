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
    public partial class ListPenerbanganForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private Akun akun;
        private Bandara banK;
        private Bandara banT;
        private int jml;
        private DateTime tgl;

        private List<JadwalPenerbangan> jp;
        public ListPenerbanganForm(int id, int keberangkatanId, int tujuanId, DateTime tglK, int jmlP)
        {
            tgl = tglK;
            jml = jmlP;
            akun = db.Akuns.Where(d => d.ID == id).FirstOrDefault();
            banK = db.Bandaras.Where(d => d.ID == keberangkatanId).FirstOrDefault();
            banT = db.Bandaras.Where(d => d.ID == tujuanId).FirstOrDefault();

            InitializeComponent();

            subtitle.Text = $"{banK.Nama} ({banK.KodeIATA})   ->   {banT.Nama} ({banT.KodeIATA})   ●   {tglK.ToString("ddd, dd MMMM yyyy")}   ●   {jmlP} Penumpang";

            load();
        }

        private void load()
        {
            jadwalPenerbanganBindingSource.Clear();
            jp = db.JadwalPenerbangans.Where(d => d.BandaraKeberangkatanID == banK.ID && d.BandaraTujuanID == banT.ID).ToList();


            if (waktu1.Checked) jp = jp.Where(d => d.TanggalWaktuKeberangkatan.Hour >= TimeSpan.Parse("00:00:00").Hours && d.TanggalWaktuKeberangkatan.Hour < TimeSpan.Parse("06:00:00").Hours).ToList();
            if (waktu2.Checked) jp = jp.Where(d => d.TanggalWaktuKeberangkatan.Hour >= TimeSpan.Parse("06:00:00").Hours && d.TanggalWaktuKeberangkatan.Hour < TimeSpan.Parse("12:00:00").Hours).ToList();
            if (waktu3.Checked) jp = jp.Where(d => d.TanggalWaktuKeberangkatan.Hour >= TimeSpan.Parse("12:00:00").Hours && d.TanggalWaktuKeberangkatan.Hour < TimeSpan.Parse("18:00:00").Hours).ToList();
            if (waktu4.Checked) jp = jp.Where(d => d.TanggalWaktuKeberangkatan.Hour >= TimeSpan.Parse("18:00:00").Hours && d.TanggalWaktuKeberangkatan.Hour < TimeSpan.Parse("24:00:00").Hours).ToList();

            jp = urutkanTb.SelectedIndex == 0 ? jp.OrderBy(d => d.HargaPerTiket).ToList() 
                : urutkanTb.SelectedIndex == 1 ? jp.OrderBy(d => d.TanggalWaktuKeberangkatan).ToList() 
                : urutkanTb.SelectedIndex == 2 ? jp.OrderByDescending(d => d.TanggalWaktuKeberangkatan).ToList()
                : urutkanTb.SelectedIndex == 3 ? jp.OrderBy(d => d.DurasiPenerbangan).ToList()
                : urutkanTb.SelectedIndex == 4 ? jp.OrderByDescending(d => d.DurasiPenerbangan).ToList()
                : jp.OrderBy(d => d.DurasiPenerbangan).ToList();


            jadwalPenerbanganBindingSource.DataSource = jp;
        }

        private void table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (table.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jp)
            {
                if (e.ColumnIndex == maskapaiDataGridViewTextBoxColumn.Index)
                {
                    e.Value = jp.Maskapai.Nama;
                }

                if(e.ColumnIndex == bandaraDataGridViewTextBoxColumn.Index)
                {
                    e.Value = jp.Bandara.Nama;
                }

                if (e.ColumnIndex == bandara1DataGridViewTextBoxColumn.Index)
                {
                    e.Value = jp.Bandara1.Nama;
                }

                if (e.ColumnIndex == tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.Index)
                {
                    var tgl = jp.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy");
                    e.Value = tgl;
                }

                if (e.ColumnIndex == WaktuPenerbangan.Index)
                {
                    int dur = jp.DurasiPenerbangan;

                    DateTime jamA = jp.TanggalWaktuKeberangkatan;
                    DateTime dt = jamA.Add(TimeSpan.FromMinutes(dur));

                    e.Value = $"{jamA.ToString("HH:mm")} - {dt.ToString("HH:mm")}";
                }
            }
        }

        private void terapkanButton_Click(object sender, EventArgs e)
        {
            load();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerMainForm cmf = new CustomerMainForm(akun.ID);
            cmf.Show();

            Hide();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jp)
            {
                if (e.ColumnIndex == btnBeli.Index)
                {
                    if (MessageBox.Show("Sudah yakin memilih?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BeliTiketForm btf = new BeliTiketForm(akun.ID, jp.ID, banK.ID, banT.ID, tgl, jml);
                        btf.Show();

                        Hide();
                    }
                }
            }
        }
    }
}
