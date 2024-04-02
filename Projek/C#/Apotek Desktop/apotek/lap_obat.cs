using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace apotek
{
    public partial class lap_obat : Form
    {
        private const string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/dbapotek.mdb;";
        readonly OleDbConnection con = new OleDbConnection(conString);
        // OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataSet ds;
        readonly DataTable dt = new DataTable();

        public lap_obat()
        {
            InitializeComponent();
            Cetak();
        }

        private void lap_obat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbapotekDataSet2.tbobat' table. You can move, or remove it, as needed.
          //  this.tbobatTableAdapter.Fill(this.dbapotekDataSet2.tbobat);

          //  this.reportViewer1.RefreshReport();
         
        }

        void Cetak()
        {
            con.Open();
            adapter = new OleDbDataAdapter("SELECT * FROM tbobat ORDER BY idobat ASC", con);
            ds = new DataSet();
            adapter.Fill(ds, "tbobat");
            laporan_obat myreport = new laporan_obat();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;
            crystalReportViewer1.Refresh();
        }
    }
}
