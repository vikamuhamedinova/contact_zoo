using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPro
{
    public partial class SaleForm : UserControl
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void submitSaleButton_Click(object sender, EventArgs e)
        {
            if (Parent != null && Parent.GetType() == typeof(TabPage))
                Parent.Dispose();
            this.Dispose();
        }
    }
}
