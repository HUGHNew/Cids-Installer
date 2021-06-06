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
        public bool Comfirm { get; private set; }
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
        public Database(string place) {
            Info = JsonSerializer.Deserialize<DBInfo>(File.ReadAllText(DataBaseInfo));
            Builder = SqlStrBuilder(ref Info);

            IdMap = new Dictionary<string, int>();
            position = place;
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
        #endregion
        #region SQL Command
        /**
         * @brief get a id for place
         * if exist get existing one
         * or generate one
         */
        public String QueryAndAppend() {
            int id = 0;
            if (!Query(ref id)) {
                id=Append();
            }
            return IDCompletion(id);
        }
        // query
        public bool Query(ref int id)
        {
#if FETCH
            return QueryByFetch(ref id);
#else
            return QueryBySelect(ref id);
#endif
        }
        public bool QueryByFetch(ref int id)
        {
            bool exist = IdMap.ContainsKey(position);
            if (exist) {
                id = IdMap.GetValueOrDefault(position, 0);
            }
            return exist;
        }
        public bool QueryBySelect(ref int id)
        {
            using (MySqlConnection connection = new MySqlConnection(Builder.ConnectionString))
            {
                string sql = QueryExact(position);
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
         * @brief 向数据库中添加一个新地点 同时获得一个生成 UUID 每次添加后更新本地 IdMap
         * @warning 可能会有没想到部署时的数据库高并发导致的不同步问题
         */
        public int Append()
        {
            int alloc = 0;
            Update();
            return alloc;
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
        public IEnumerable<String> Check(String loc)
        {
            List<String> choices = new List<String>();
            foreach(var it in IdMap.Keys)
            {
                if (it.Contains(loc))
                {
                    choices.Add(it);
                }
            }
            return choices;
        }
        #endregion//Search
    }
}
