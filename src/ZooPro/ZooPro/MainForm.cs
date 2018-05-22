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

        // Вкладки
        private Dictionary<string, TabPage> pages;

        public MainForm()
        {
            InitializeComponent();
            pages = new Dictionary<string, TabPage>();
        }

        // Проверка, открыта ли такая вкладка
        private bool checkTab(string tabID)
        {
            if (!pages.Keys.Contains(tabID))
                pages[tabID] = null;
            if (pages[tabID] != null)
                return true;
            return false;
        }

        // Добавление вкладки
        private void addTab(string tabName, string tabID, UserControl control)
        {
            TabPage page = new TabPage(tabName);
            control.Parent = page;
            control.Dock = DockStyle.Fill;
            tabDesk.Controls.Add(page);
            page.Controls.Add(control);
            pages[tabID] = page;
        }

        public void disposeTabByID(string tabID)
        {
            TabPage page = pages[tabID];
            if (page != null)
            {
                page.Dispose();
                pages[tabID] = null;
            }
        }

        
        private void saleMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkTab("sale"))
            {
                SaleForm sf = new SaleForm();
                ControlDisposer disp = new ControlDisposer(sf, this, "sale");
                sf.setDisposer(disp);
                addTab("Продажа", "sale", sf);
                sf.initialize();
            }
        }

        private void promoMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkTab("promo"))
            {
                PromoForm pf = new PromoForm();
                ControlDisposer disp = new ControlDisposer(pf, this, "promo");
                pf.setDisposer(disp);
                addTab("Акции", "promo", pf);
                pf.initialize();
            }
        }

        private void ticketTypeMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkTab("ticketType"))
            {
                TicketTypeForm tf = new TicketTypeForm();
                ControlDisposer disp = new ControlDisposer(tf, this, "ticketType");
                tf.setDisposer(disp);
                addTab("Типы билетов", "ticketType", tf);
                tf.initialize();
            }
        }

        private void saleStatMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkTab("saleStat"))
            {
                SaleStatForm ssf = new SaleStatForm();
                ControlDisposer disp = new ControlDisposer(ssf, this, "saleStat");
                ssf.setDisposer(disp);
                addTab("Отчетность по продажам", "saleStat", ssf);
                ssf.initialize();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dRes = MessageBox.Show("Вы уверены?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dRes == DialogResult.Yes)
                this.Dispose();
        }
    }
}
