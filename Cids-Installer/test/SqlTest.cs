using MySql.Data.MySqlClient;
using System.Text.Json;
using System.IO;
using System;

namespace Cids_Installer
{
    public class SqlTest
    {
        private static readonly DBInfo Info;
        private static readonly MySqlConnectionStringBuilder Builder;
        private static readonly StreamWriter Log;
        static SqlTest()
        {
            Info = JsonSerializer.Deserialize<DBInfo>(File.ReadAllText(Database.DataBaseInfo));
            Builder = Database.SqlStrBuilder(ref Info);
            Log = new StreamWriter(File.OpenWrite("./log"));
        }
        public static void QueryTestData(bool close=true)
        {
            using(MySqlConnection connection=new MySqlConnection(Builder.ConnectionString))
            {
                connection.Open();
                //Log.WriteLine("Open Database\n");
                using(MySqlCommand command=new MySqlCommand(MySql.QueryCmd, connection))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) { 
                            Log.WriteLine($"place:{reader.GetString(0)},Id:{reader.GetInt32(1)}");
                        }
                    }
                }
            }if(close)Log.Close();
        }
        public static void QueryTestEmpty(bool close = true)
        {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                connection.Open();
                //Log.WriteLine("Open Database\n");
                using (MySqlCommand command = new MySqlCommand(MySql.NullSql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Log.WriteLine($"place:{reader.GetString(0)},Id:{reader.GetInt32(1)}");
                        }
                    }
                }
            }
            if (close) Log.Close();
        }
#if DEBUG
        public static void QueryIdMap(bool close = true)
        {
            Database db = new Database();
            db.Fetch().ShowFetch(20,Log);
            if (close) Log.Close();
        }
#endif
    }
}