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
    public partial class TiketSayaForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();

        private Akun akun = new Akun();
        public TiketSayaForm(int id)
        {
            akun = db.Akuns.Where(d => d.ID == id).FirstOrDefault();
            InitializeComponent();

            transaksiHeaderBindingSource.Clear();
            //transaksiHeaderBindingSource.DataSource = db.TransaksiHeaders.Where(d => d.AkunID == akun.ID && d.JadwalPenerbangan.TanggalWaktuKeberangkatan <= DateTime.Now);
            transaksiHeaderBindingSource.DataSource = db.TransaksiHeaders.Where(d => d.AkunID == akun.ID && d.JadwalPenerbangan.TanggalWaktuKeberangkatan <= DateTime.Now).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is TransaksiHeader th)
            {
                if (e.ColumnIndex == KodePenerbanganC.Index)
                {
                    e.Value = th.JadwalPenerbangan.KodePenerbangan;
                }

                if (e.ColumnIndex == MaskapaiC.Index)
                {
                    e.Value = th.JadwalPenerbangan.Maskapai.Nama;
                }
                
                if (e.ColumnIndex == BandaraKeberangkatanC.Index)
                {
                    e.Value = th.JadwalPenerbangan.Bandara.Nama;
                }
                
                if (e.ColumnIndex == BandaraTujuanC.Index)
                {
                    e.Value = th.JadwalPenerbangan.Bandara1.Nama;
                }

                if (e.ColumnIndex == TanggalKeberangkatanC.Index)
                {
                    e.Value = th.JadwalPenerbangan.TanggalWaktuKeberangkatan.ToString("hh-MM-yyyy");
                }

                if (e.ColumnIndex == WaktuPenerbanganC.Index)
                {
                    DateTime dt = th.JadwalPenerbangan.TanggalWaktuKeberangkatan;
                    DateTime jamAkh = dt.AddMinutes(th.JadwalPenerbangan.DurasiPenerbangan);

                    e.Value = $"{dt.Hour:00}:{dt.Minute:00} - {jamAkh.Hour:00}:{jamAkh.Minute:00}";
                }

                if (e.ColumnIndex == StatusTerakhirC.Index)
                {
                    var status = db.PerubahanStatusJadwalPenerbangans.Where(d => d.JadwalPenerbanganID == th.JadwalPenerbanganID).FirstOrDefault();

                    if (status != null)
                    {
                        if (status.StatusPenerbanganID == 3)
                        {
                            TimeSpan selama = TimeSpan.FromMinutes((double)status.PerkiraanDurasiDelay);

                            e.Value = $"{status.StatusPenerbangan.Nama} (selama -+ {selama.Hours:00} jam {selama.Minutes:00} menit)";
                        }
                        else
                        {
                            e.Value = $"{status.StatusPenerbangan.Nama}";
                        }
                    }
                    else
                    {
                        e.Value = "Sesuai Jadwal";
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerMainForm cmf = new CustomerMainForm(akun.ID);
            cmf.Show();

            Hide();
        }
    }
}
