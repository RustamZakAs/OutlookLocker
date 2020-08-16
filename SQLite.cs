using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Linq;
using System.Data.SQLite.Generic;
using Dapper;

namespace OutlookLocker
{
    public static class SQLite
    {
        public static string FileName { get; set; } = "Params.db";

        public static List<SQLiteValue> LoadParams()
        {
            if (!System.IO.File.Exists(FileName))
            {
                SQLiteConnection.CreateFile(FileName);
            }

            SQLiteConnection m_dbConnection = new SQLiteConnection($@"Data Source={FileName};Version=3;");
            m_dbConnection.Open();

            string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name='params';";

            string table_name = m_dbConnection.QueryFirstOrDefault<string>(sql);

            if (table_name == null)
            {
                sql = "CREATE TABLE params (name NVARCHAR(50), value NVARCHAR(50));";
                m_dbConnection.ExecuteScalar(sql);
            }

            sql = "SELECT * FROM params;";
            List<SQLiteValue> _Params = m_dbConnection.Query<SQLiteValue>(sql).ToList();
            foreach (var item in _Params)
            {
                item.value = TIСryptographer.Cryptographer.Decrypt(item.value);
            }
            m_dbConnection.Dispose();
            if (!_Params.Exists(x => x.name == "Password"))
            {
                _Params.Add(new SQLiteValue
                {
                    name = "Password",
                    value = TIСryptographer.Cryptographer.Encrypt("123"),
                });
            }
            return _Params;
        }

        public static bool SaveParams(string password)
        {
            try
            {
                if (!System.IO.File.Exists(FileName))
                {
                    SQLiteConnection.CreateFile(FileName);
                }
                SQLiteConnection m_dbConnection = new SQLiteConnection($@"Data Source={FileName};Version=3;");
                m_dbConnection.Open();
                string sql = "SELECT name FROM sqlite_master WHERE type='table' AND name='params';";

                string table_name = m_dbConnection.QueryFirstOrDefault<string>(sql);

                if (table_name == null)
                {
                    sql = "CREATE TABLE params (name NVARCHAR(50), value NVARCHAR(50));";
                    m_dbConnection.ExecuteScalar(sql);
                }

                List<SQLiteValue> _Params = new List<SQLiteValue>();
                _Params.Add(new SQLiteValue
                {
                    name = "Password",
                    value = TIСryptographer.Cryptographer.Encrypt(password),
                });

                sql = "DELETE FROM params;";
                m_dbConnection.ExecuteScalar(sql);

                sql = "INSERT INTO params (name, value) VALUES (@name, @value)";
                foreach (var item in _Params)
                {
                    _ = m_dbConnection.Execute(sql, item);
                }

                m_dbConnection.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class SQLiteValue
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}
