using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace apotek
{
    public partial class lap_penjualan : Form
    {

        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/dbapotek.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        // OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        readonly DataTable dt = new DataTable();

        public lap_penjualan()
        {
            InitializeComponent();
            Cetak();
        }

        private void lap_penjualan_Load(object sender, EventArgs e)
        {

        }

        void Cetak()
        {
            con.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM penjualan ORDER BY idpenjualan ASC", con);
            ds = new DataSet();
            adapter.Fill(ds, "penjualan");
            laporan_penjualan myreport = new laporan_penjualan();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            crystalReportViewer1.Refresh();
        }
    }
}
