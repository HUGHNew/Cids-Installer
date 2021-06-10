#define FETCH
using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using static Cids_Installer.MySql;

namespace Cids_Installer
{
    class Database
    {
        private string position;

        #region Variables For Form
        public bool Confirmed { get; private set; }
        private readonly List<String> ClassRooms;
        #endregion

        #region Id Region
        public const int IdLen = 7;
        /**
         * @brief ID Completion from Int
         * @warning Assume that id is less than 1000 0000
         */
        private static string IDCompletion(int id)
        {
            string raw = id.ToString();
            string prefix = "";
            if (raw.Length != IdLen)
            {
                prefix = new string('0', IdLen - raw.Length);
            }
            return prefix + raw;
        }
        #endregion

        #region SQL Data Source
        // where to get db info to connect
        public const string DataBaseInfo = "db.json";
        private readonly DBInfo Info;
        private readonly MySqlConnectionStringBuilder Builder;
        private int Id=-1;
#if FETCH
        private readonly Dictionary<String, int> IdMap;
#endif
        #region SQL Relative Func

        // useless function
        private Rel MySqlTodo<Rel>(string sql, Func<Rel>todo)
        {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sql))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        return todo();
                    }
                }
            }
        }
        private int GetId(bool update=false) {
            if (Id != -1) { return Id; }
            return QueryIdFromDatabase(update);
        }
        public int QueryIdFromDatabase(bool update=false)
        {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                string sql = QueryExact(position);
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    if (command.CommandText.Length != 0)
                    {
                        return Id = command.ExecuteReader().GetInt32(0);
                    }
                    else
                    {
                        return update ?Update(): Id=-1;
                    }
                }
            }
        }
        #endregion
        public Database() {
            Info = JsonSerializer.Deserialize<DBInfo>(File.ReadAllText(DataBaseInfo));
            Builder = SqlStrBuilder(ref Info);

            IdMap = new Dictionary<string, int>();
        }
        public static MySqlConnectionStringBuilder SqlStrBuilder(ref DBInfo Info)
        {
            return new MySqlConnectionStringBuilder
            {
                Database = Info.Database,
                Server = Info.Ip,
                UserID = Info.User,
                Password = Info.Password,
                Port = Info.Port,
                CharacterSet = "UTF8",
                Pooling = true,
            };
        }
#if FETCH
        public Database Fetch() {
            using (MySqlConnection connection=new MySqlConnection(Builder.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command=new MySqlCommand(QueryCmd,connection)) {
                    using (MySqlDataReader reader = command.ExecuteReader()) {
                        // Read to map
                        while (reader.Read()) {
                            IdMap.Add(reader.GetString(0), reader.GetInt32(1));
                        }
                    }
                }
            }
            return this;
        }
#endif//fetch
#if DEBUG
        public Database ShowFetch(int limit,StreamWriter writer)
        {
            int i = 0;
            writer.WriteLine($"IdMapSize:{IdMap.Count}");
            foreach(var it in IdMap)
            {
                writer.WriteLine($"|{ it.Key}|{it.Value}|");
                if (++i >= limit) break;
            }
            return this;
        }
#endif
#endregion
        #region SQL Command
        /**
         * @brief get a id for place
         * if exist get existing one
         * or generate one
         */
        public String QueryAndUpdate(string loc) {
            int id = 0;
            if (!Query(loc,ref id)) {
                id=Update();
            }
            return IDCompletion(id);
        }
        /**
         * @brief Query Place
         * @return exist or not
         */
        public bool Query(string loc, ref int id)
        {
#if FETCH
            return QueryByFetch(loc,ref id);
#else
            return QueryBySelect(ref id);
#endif
        }
        public bool QueryByFetch(string loc,ref int id)
        {
            bool exist = IdMap.ContainsKey(loc);
            if (exist) {
                id = IdMap.GetValueOrDefault(loc, -1);
            }
            return exist;
        }
        public bool QueryBySelect(string loc, ref int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                string sql = QueryExact(loc);
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    if (command.CommandText.Length != 0)
                    {
                        Id=id = command.ExecuteReader().GetInt32(0);
                        return true;
                    }
                    else Id=id = -1;
                }
            }
            return false;
        }
        /**
         * @brief Push the place 
         *      then Query Database and Update locally
         * @return return the id
         */
        public int Update()
        {
            return PushPlace().GetId();
        }
        public Database PushPlace() {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                string sql = Inc+AppendSql(position);
                using MySqlCommand command = new MySqlCommand(sql, connection);
            }
            return this;
        }
        #endregion
        #region Search For App
        /**
         * @brief Easy-imp using StartWith or EndWith
         */
        public IEnumerable<String> Check(String loc, String room)
        {
            return BuildingAndRoom(loc,room);
        }
        /**
         * @brief Using Fuzzy Matching
         */
        [Obsolete]
        public IEnumerable<String> Check(String loc)
        {
            return FuzzyMatching(loc);
        }
        #region Check Method
        public IEnumerable<String> BuildingAndRoom(String loc,String room)
        {
            List<String> choices = new List<String>();
            if (Query(loc+room, ref Id))
            {
                Confirmed = true;
                position = loc;
            }
            else
            {
                foreach (var it in IdMap.Keys)
                {
                    if (it.Contains(loc)|it.Contains(room))
                    {
                        choices.Add(it);
                    }
                }
            }
            return choices;
        }
        public IEnumerable<String> FuzzyMatching(String loc)
        {
            return new List<String>();
        }
        #endregion
        public String Confirm()
        {
            return IDCompletion(Id);
        }
        public String Insert(String loc)
        {
            position = loc;
            return IDCompletion(Update());
        }
        #endregion//Search
    }
}
