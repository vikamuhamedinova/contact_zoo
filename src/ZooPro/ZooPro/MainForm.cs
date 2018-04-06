using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void saleMenuItem_Click(object sender, EventArgs e)
        {
            TabPage salePage = new TabPage("Продажа");
            SaleForm sf = new SaleForm();
            sf.Parent = salePage;
            sf.Dock = DockStyle.Fill;
            tabDesk.Controls.Add(salePage);
            salePage.Controls.Add(sf);
        }
    }
}
