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
            LocalTest.WriteDBJson();
            Info = JsonSerializer.Deserialize<DBInfo>(File.ReadAllText(Database.DataBaseInfo));
            Builder = Database.SqlStrBuilder(ref Info);
            Log = new StreamWriter(File.OpenWrite(LocalTest.Log));
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
    }
}