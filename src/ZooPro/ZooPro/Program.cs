using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooPro
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection conn = Connection.getInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (conn.tryConnect() && conn.isValid())
                Application.Run(new MainForm());
            else
                MessageBox.Show("Не удалось подключиться к базе данных.\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
