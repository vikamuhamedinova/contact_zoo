using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ZooPro
{
    public partial class SaleForm : UserControl
    {
        private Connection connection;
        private ControlDisposer disposer;

        public struct PromoData
        {
            public Int64 key;
            public float discount;
            public string promoName;
        };

        private List<PromoData> promoAvailable;

        private Dictionary<string, float> ticketPrices = new Dictionary<string, float>()
        {
            {"Взрослый", -1.0f},
            {"Детский", -1.0f}
        };

        public SaleForm()
        {
            InitializeComponent();
        }

        public void initialize()
        {
            promoAvailable = new List<PromoData>();
            Dictionary<string, bool> ticketTypes = new Dictionary<string, bool>()
            {
                {"Взрослый", false },
                {"Детский", false },
            };
            connection = Connection.getInstance();
            // получение текущих цен билетов
            string scmd = "select p.price as price, t.name as name " +
                "from ticket_type t, ticket_type_price p " +
                "where p.id_ticket_type = t.id_ticket_type " +
                "and p.date_start <= date(\'now\') " +
                "and p.date_end >= date(\'now\')" +
                "order by p.date_start desc";
            SQLiteDataReader reader = connection.execQuery(scmd);
            while (reader.Read())
            {
                if (!ticketTypes[reader["name"].ToString()])
                {
                    ticketTypes[reader["name"].ToString()] = true;
                    ticketPrices[reader["name"].ToString()] = Decimal.ToSingle((Decimal)reader["price"]);
                }
            }
            bool arePricesDefined = true;
            foreach (var key in ticketTypes.Keys)
            {
                arePricesDefined &= ticketTypes[key];
            }
            if (!arePricesDefined)
            {
                MessageBox.Show("Для одного из типов не определены цены.\nПродажа билетов невозможна.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                disposer.commit();
            }
            priceValLabel.Text = ticketPrices["Взрослый"].ToString("C");
            priceValLabelAlt.Text = ticketPrices["Детский"].ToString("C");
            // получение доступных на данный момент акций
            string promoCmd = "select * from promo where promo_start <= date(\'now\') and promo_end >= date(\'now\')";
            SQLiteDataReader promoReader = connection.execQuery(promoCmd);
            while (promoReader.Read())
            {
                PromoData pData;
                pData.promoName = promoReader["name"].ToString();
                pData.discount = Decimal.ToSingle((Decimal)promoReader["discount"]);
                pData.key = (Int64)promoReader["id_promo"];
                promoAvailable.Add(pData);
            }
            promoComboBox.Items.Add("(нет)");
            promoComboBox.SelectedIndex = 0;
            promoComboBoxAlt.Items.Add("(нет)");
            promoComboBoxAlt.SelectedIndex = 0;
            foreach (PromoData pData in promoAvailable)
            {
                promoComboBox.Items.Add(pData.promoName);
                promoComboBoxAlt.Items.Add(pData.promoName);
            }
        }

        public float calculateTypeCost(bool second)
        {
            float result = 0.0f;
            long subres = 0;
            long cnt = second ? Decimal.ToInt64(quantityUpDownAlt.Value) : Decimal.ToInt64(quantityUpDown.Value);
            if (second)
                subres += cnt * (long)(ticketPrices["Детский"] * 100);
            else
                subres += cnt * (long)(ticketPrices["Взрослый"] * 100);
            int promoID = second ? promoComboBoxAlt.SelectedIndex : promoComboBox.SelectedIndex;
            if (promoID > 0)
            {
                long discount = (long)(promoAvailable[promoID - 1].discount * 100);
                subres -= (long)(subres * (promoAvailable[promoID - 1].discount)) / 100;
            }
            result = (float)subres;
            result /= 100.0f;
            return result;
        }

        public void calculateCost()
        {
            float result = calculateTypeCost(false) + calculateTypeCost(true);
            totalTicketCostBox.Text = result.ToString("C");
            totalCostValueLabel.Text = result.ToString("C");
        }

        public void setDisposer(ControlDisposer disp)
        {
            this.disposer = disp;
        }

        public void closePage()
        {
            disposer.commit();
            if (Parent != null && Parent.GetType() == typeof(TabPage))
                Parent.Dispose();
            this.Dispose();
        }

        public void submit()
        {
            connection.begin();
            // вставляем запись о продаже
            string saleSubmitCmd = "insert into sale (date_time) values (datetime(\'now\'))";
            string ticketSubmitCmd = "";
            connection.execUpdate(saleSubmitCmd);
            Int64 saleKey = (Int64)connection.execScalar("select last_insert_rowid()");
            object ticketPrev = connection.execScalar("select max(ticket_no) from ticket");
            Int64 ticketNum = 1 + (ticketPrev.GetType().Name == "DBNull" ? 0 : (Int64)ticketPrev);
            int sizeint = Decimal.ToInt32(quantityUpDown.Value);
            int promoID = promoComboBox.SelectedIndex == 0 ? -1 : promoComboBox.SelectedIndex - 1;
            for (int i = 0; i < sizeint; i++)
            {
                // вставляем запись о билете
                object newKeyReader = connection.execScalar("select max(id_ticket) maxk from ticket");
                Int64 newKey = (newKeyReader.GetType().Name == "DBNull" ? 0 : (Int64)newKeyReader);
                ticketSubmitCmd = String.Format("insert " +
                    "into ticket " +
                    "(id_ticket, ticket_no, " +
                    "id_ticket_type, id_promo) " +
                    "values " +
                    "({0}, {1}, " +
                    "(select id_ticket_type " +
                    "from ticket_type " +
                    "where name = \'Взрослый\' " +
                    "limit 1), {2})",
                    newKey + 1,
                    ticketNum++,
                    promoID);
                int succ = connection.execUpdate(ticketSubmitCmd);
                // связываем билет с продажей
                object newTicketPosPrev = connection.execScalar("select max(id_ticket_pos) " +
                    "from ticket_pos");
                Int64 newTicketPosKey = 1 + 
                    (newTicketPosPrev.GetType().Name == "DBNull" ? 0 : (Int64)newTicketPosPrev);
                string ticketAcceptCmd = String.Format("insert " +
                    "into ticket_pos " +
                    "(id_ticket_pos, id_ticket, id_sale) " +
                    "values " +
                    "({0}, {1}, {2})",
                    newTicketPosKey,
                    newKey + 1,
                    saleKey);
                connection.execUpdate(ticketAcceptCmd);
            }
            sizeint = Decimal.ToInt32(quantityUpDownAlt.Value);
            promoID = promoComboBoxAlt.SelectedIndex == 0 ? -1 : promoComboBoxAlt.SelectedIndex - 1;
            for (int i = 0; i < sizeint; i++)
            {
                object newKeyReader = connection.execScalar("select max(id_ticket) maxk from ticket");
                Int64 newKey = (newKeyReader.GetType().Name == "DBNull" ? 0 : (Int64)newKeyReader);
                ticketSubmitCmd = String.Format("insert " +
                    "into ticket " +
                    "(id_ticket, ticket_no, " +
                    "id_ticket_type, id_promo) " +
                    "values " +
                    "({0}, {1}, " +
                    "(select id_ticket_type " +
                    "from ticket_type " +
                    "where name = \'Детский\' " +
                    "limit 1), {2})",
                    newKey + 1,
                    ticketNum++,
                    promoID);
                int succ = connection.execUpdate(ticketSubmitCmd);
                object newTicketPosPrev = connection.execScalar("select max(id_ticket_pos) " +
                    "from ticket_pos");
                Int64 newTicketPosKey = 1 +
                    (newTicketPosPrev.GetType().Name == "DBNull" ? 0 : (Int64)newTicketPosPrev);
                string ticketAcceptCmd = String.Format("insert " +
                    "into ticket_pos " +
                    "(id_ticket_pos, id_ticket, id_sale) " +
                    "values " +
                    "({0}, {1}, {2})",
                    newTicketPosKey,
                    newKey + 1,
                    saleKey);
                connection.execUpdate(ticketAcceptCmd);
            }
            connection.commit();
        }

        private void submitSaleButton_Click(object sender, EventArgs e)
        {
            if (quantityUpDown.Value == 0 && quantityUpDownAlt.Value == 0)
            {
                MessageBox.Show("Не указано количество билетов для продажи.\n" +
                    "Возможно, вы не хотите оформлять продажу.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            else
                submit();
            MessageBox.Show("Продажа успешно оформлена.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            closePage();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            closePage();
        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            costValLabel.Text = (calculateTypeCost(false)).ToString("C");
            calculateCost();
        }

        private void quantityUpDownAlt_ValueChanged(object sender, EventArgs e)
        {
            costValLabelAlt.Text = (calculateTypeCost(true)).ToString("C");
            calculateCost();
        }

        private void promoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            costValLabel.Text = (calculateTypeCost(false)).ToString("C");
            calculateCost();
        }

        private void promoComboBoxAlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            costValLabelAlt.Text = (calculateTypeCost(true)).ToString("C");
            calculateCost();
        }
    }
}
