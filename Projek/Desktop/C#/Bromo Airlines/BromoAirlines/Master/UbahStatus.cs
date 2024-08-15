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
    public partial class UbahStatus : UserControl
    {
        private readonly BromoAirlinesEntities db = new BromoAirlinesEntities();
        private int idJad = -1;
        public UbahStatus()
        {
            InitializeComponent();

            load();

            statusPenerbanganBindingSource.Clear();
            statusPenerbanganBindingSource.DataSource = db.StatusPenerbangans.ToList();

            comboBox1.SelectedIndex = 0;

        }

        private void load()
        {
            jadwalPenerbanganBindingSource.Clear();
            jadwalPenerbanganBindingSource.DataSource = db.JadwalPenerbangans.ToList();
        }

        private void clear()
        {
            label3.Visible = false;
            comboBox1.Visible = false;
            label4.Visible = false;
            maskTB.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

            comboBox1.SelectedValue = 1;
            idJad = -1;
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan penerbangan)
            {
                if (e.ColumnIndex == bandaraDataGridViewTextBoxColumn.Index)
                {
                    e.Value = penerbangan.Bandara.Nama;
                }

                if (e.ColumnIndex == bandara1DataGridViewTextBoxColumn.Index)
                {
                    e.Value = penerbangan.Bandara1.Nama;
                }

                if (e.ColumnIndex == maskapaiDataGridViewTextBoxColumn.Index)
                {
                    e.Value = penerbangan.Maskapai.Nama;
                }

                if (e.ColumnIndex == WaktuKeberangkatan.Index)
                {
                    DateTime dt = penerbangan.TanggalWaktuKeberangkatan;
                    e.Value = $"{dt.Hour:00}:{dt.Minute:00}";
                }

                if (e.ColumnIndex == durasiPenerbanganDataGridViewTextBoxColumn.Index)
                {
                    TimeSpan ts = TimeSpan.FromMinutes(penerbangan.DurasiPenerbangan);
                    e.Value = $"{ts.Hours:00} jam {ts.Minutes:00} menit";
                }

                if (e.ColumnIndex == StatusTrakhir.Index)
                {
                    PerubahanStatusJadwalPenerbangan ch = db.PerubahanStatusJadwalPenerbangans.Where(d => d.JadwalPenerbanganID == penerbangan.ID).FirstOrDefault();
                    if (ch != null)
                    {
                        if (ch.StatusPenerbanganID == 3)
                        {
                            TimeSpan ts = TimeSpan.FromMinutes((double)ch.PerkiraanDurasiDelay);
                            e.Value = ch.StatusPenerbangan.Nama + $" (selama -+ {ts.Hours} jam {ts.Minutes} menit)";
                        }
                        else
                        {
                            e.Value = ch.StatusPenerbangan.Nama;
                        }
                    }
                    else
                    {
                        e.Value = "Sesuai Jadwal";
                    }

                }

                if (e.ColumnIndex == TerakhirDiUbah.Index)
                {
                    var ch = db.PerubahanStatusJadwalPenerbangans.Where(d => d.JadwalPenerbanganID == penerbangan.ID).FirstOrDefault();

                    if (ch != null)
                    {
                        e.Value = ch.WaktuPerubahanTerjadi;
                    }
                    else
                    {
                        e.Value = "-";
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jadwal)
            {
                if (e.ColumnIndex == btnUbah.Index)
                {
                    label3.Visible = true;
                    comboBox1.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;

                    idJad = jadwal.ID;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idst = Convert.ToInt32(comboBox1.SelectedValue);


            if (idst == 3)
            {
                label4.Visible = true;
                maskTB.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {

                label4.Visible = false;
                maskTB.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int status = (int)comboBox1.SelectedValue;
            string delay = maskTB.Text;

            DateTime n = DateTime.Now;

            if (idJad != -1)
            {
                if (status == 3)
                {
                    string jamStr = delay.Split(' ')[0];
                    string mntStr = delay.Split(' ')[2];


                    if (!int.TryParse(jamStr, out int _))
                    {
                        MessageBox.Show("Format Delay salah");
                    }

                    if (!int.TryParse(mntStr, out int _))
                    {
                        MessageBox.Show("Format Delay salah");
                    }

                    var perkiraan = int.Parse(jamStr) * 60 + int.Parse(mntStr);
                    PerubahanStatusJadwalPenerbangan psj = new PerubahanStatusJadwalPenerbangan()
                    {
                        JadwalPenerbanganID = idJad,
                        PerkiraanDurasiDelay = perkiraan,
                        StatusPenerbanganID = status,
                        WaktuPerubahanTerjadi = n,
                    };
                    db.PerubahanStatusJadwalPenerbangans.Add(psj);

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Jadwal berhasil diubah");

                        load();
                        clear();
                    }
                }
                else
                {
                    PerubahanStatusJadwalPenerbangan psj = new PerubahanStatusJadwalPenerbangan()
                    {
                        JadwalPenerbanganID = idJad,
                        PerkiraanDurasiDelay = 0,
                        StatusPenerbanganID = status,
                        WaktuPerubahanTerjadi = n,
                    };
                    db.PerubahanStatusJadwalPenerbangans.Add(psj);

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Jadwal berhasil diubah");

                        load();
                        clear();
                    }
                }
            }
        }
    }
}
