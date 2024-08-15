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
    public partial class cartPenumpang : UserControl
    {
        public cartPenumpang(int pen)
        {
            InitializeComponent();

            label1.Text = $"Penumpang #{pen}";
        }

        public string Titel => comboBox2.SelectedIndex == 0 ? "Tuan" : "Nyonya";
        public string NamaL => textBox1.Text;
    }
}
