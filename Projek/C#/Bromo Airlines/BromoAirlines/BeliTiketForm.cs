using bromotestPT4.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromotestPT4
{
    public partial class BeliTiketForm : Form
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private List<cartPenumpang> cartPenumpangs = new List<cartPenumpang>();

        private Akun akun;
        private JadwalPenerbangan jp;

        private int jmlPen;
        private double totPri = 0;
        private DateTime tgll;

        private int idPromo = -1;
        public BeliTiketForm(int idA, int jadId, int banK, int banT, DateTime tgl, int jmlP)
        {
            akun = db.Akuns.Where(d => d.ID == idA).FirstOrDefault();
            jmlPen = jmlP;
            tgll = tgl;
            InitializeComponent();

            jp = db.JadwalPenerbangans.Where(d => d.ID == jadId).FirstOrDefault();

            lblJuanda.Text = $"{jp.Bandara.Nama} ({jp.Bandara.KodeIATA})  ->  {jp.Bandara1.Nama} ({jp.Bandara1.KodeIATA})";
            lblMaskp.Text = $"{jp.Maskapai.Nama}";

            lblTgl.Text = $"{jp.TanggalWaktuKeberangkatan.ToString("dddd, dd MMM yyyy")}";

            DateTime jamAkh = jp.TanggalWaktuKeberangkatan.AddMinutes(jp.DurasiPenerbangan);

            lblJam.Text = $"{jp.TanggalWaktuKeberangkatan.ToString("HH:mm")} - {jamAkh.ToString("HH:mm")}";
            lblJmlP.Text = $"{jmlP} Penumpang";

            totPri = jp.HargaPerTiket * jmlP;

            lblHarga.Text = $"IDR {totPri.ToString("N0", new CultureInfo("id-ID"))}";

            loadCard(jmlP);
        }

        private void loadCard(int jmlP)
        {
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            for (int i = 1; i <= jmlP; i++)
            {
                cartPenumpang cp = new cartPenumpang(i);

                tableLayoutPanel1.Controls.Add(cp);
                cartPenumpangs.Add(cp);
            }
            tableLayoutPanel1.Height = jmlP * 180 + 10;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KodePromo kp = db.KodePromoes.Where(d => d.Kode == textBox1.Text && d.BerlakuSampai >= DateTime.Now).FirstOrDefault();
            if (kp == null)
            {
                MessageBox.Show("Kode tidak ditemukan atau Kode sudah Kadaluarsa!");
                return;
            }
            else
            {
                idPromo = kp.ID;

                double potongan = totPri * kp.PersentaseDiskon / 100;
                if (potongan > kp.MaksimumDiskon)
                {
                    potongan = kp.MaksimumDiskon;
                }
                totPri = totPri - potongan;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idPromo != -1)
            {
                TransaksiHeader th = new TransaksiHeader()
                {
                    AkunID = akun.ID,
                    JadwalPenerbanganID = jp.ID,
                    TanggalTransaksi = DateTime.Now,
                    JumlahPenumpang = jmlPen,
                    TotalHarga = totPri,
                    KodePromoID = idPromo
                };
                db.TransaksiHeaders.Add(th);

                foreach (var item in cartPenumpangs)
                {
                    TransaksiDetail td = new TransaksiDetail()
                    {
                        TransaksiHeaderID = th.ID,
                        TitelPenumpang = item.Titel,
                        NamaLengkapPenumpang = item.NamaL
                    };
                    db.TransaksiDetails.Add(td);
                }

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Berhasil memesan tiket!", "Success", MessageBoxButtons.OK);

                    CustomerMainForm cmf = new CustomerMainForm(akun.ID);
                    cmf.Show();

                    Hide();
                }
            }
            else
            {
                TransaksiHeader th = new TransaksiHeader()
                {
                    AkunID = akun.ID,
                    JadwalPenerbanganID = jp.ID,
                    TanggalTransaksi = DateTime.Now,
                    JumlahPenumpang = jmlPen,
                    TotalHarga = totPri,
                };
                db.TransaksiHeaders.Add(th);

                foreach (var item in cartPenumpangs)
                {
                    TransaksiDetail td = new TransaksiDetail()
                    {
                        TransaksiHeaderID = th.ID,
                        TitelPenumpang = item.Titel,
                        NamaLengkapPenumpang = item.NamaL
                    };
                    db.TransaksiDetails.Add(td);
                }

                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Berhasil memesan tiket!", "Success", MessageBoxButtons.OK);

                    CustomerMainForm cmf = new CustomerMainForm(akun.ID);
                    cmf.Show();

                    Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListPenerbanganForm lp = new ListPenerbanganForm(akun.ID, jp.BandaraKeberangkatanID, jp.BandaraTujuanID, tgll, jmlPen);
            lp.Show();
            Hide();
        }
    }
}
