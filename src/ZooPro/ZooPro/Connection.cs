using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ZooPro
{
    class Connection
    {
        public static Connection instance = null;
        private SQLiteConnection conn = null;
        private SQLiteTransaction currTrans = null;
        private Connection()
        {

        }
        public static Connection getInstance()
        {
            if (instance == null)
                instance = new Connection();
            return instance;
        }
        public bool tryConnect()
        {
            if (conn == null)
                conn = new SQLiteConnection("Data Source=contact_zoo.db3;Version=3;");
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);
        }
        public SQLiteConnection getConnection()
        {
            return conn;
        }
        public bool isValid()
        {
            if (conn == null)
                return false;
            if (conn.State != System.Data.ConnectionState.Open)
                return false;
            SQLiteCommand cmd = new SQLiteCommand("select * from sqlite_master where type = 'table'", conn);
            Dictionary<string, bool> tables = new Dictionary<string, bool>()
            {
                {"animal", false },
                {"consumable", false },
                {"employee", false },
                {"food", false },
                {"food_distr", false },
                {"food_sale_pos", false },
                {"food_set", false },
                {"food_set_pos", false },
                {"food_set_ready", false },
                {"promo", false },
                {"purchase_pos_food", false },
                {"sale", false },
                {"service", false },
                {"service_pos", false },
                {"shift", false },
                {"ticket", false },
                {"ticket_pos", false },
                {"ticket_type", false },
                {"ticket_type_price", false },
                {"unit", false }
            };
            Dictionary<string, bool> ticketTypes = new Dictionary<string, bool>()
            {
                {"Взрослый", false },
                {"Детский", false },
            };
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                tables[reader["name"].ToString()] = true;
            }
            bool result = true;
            foreach (var key in tables.Keys)
            {
                result = result && tables[key];
            }
            if (result == true)
            {
                cmd = new SQLiteCommand("select * from ticket_type", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticketTypes[reader["name"].ToString()] = true;
                }
                foreach (var key in ticketTypes.Keys)
                {
                    if (!ticketTypes[key])
                    {
                        string cmdInsert = "insert into ticket_type (name) values (\'" + key + "\')";
                        cmd = new SQLiteCommand(cmdInsert, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return result;
        }
        public int execUpdate(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            if (currTrans != null)
                cmd.Transaction = currTrans;
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public SQLiteDataReader execQuery(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            if (currTrans != null)
                cmd.Transaction = currTrans;
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public object execScalar(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            if (currTrans != null)
                cmd.Transaction = currTrans;
            return cmd.ExecuteScalar();
        }
        public void begin()
        {
            currTrans = conn.BeginTransaction(System.Data.IsolationLevel.Serializable);
        }
        public void rollback()
        {
            if (currTrans == null)
                return;
            currTrans.Rollback();
            currTrans = null;
        }
        public void commit()
        {
            if (currTrans == null)
                return;
            currTrans.Commit();
            currTrans = null;
        }
    }
}
