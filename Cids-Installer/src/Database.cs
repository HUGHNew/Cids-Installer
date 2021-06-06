using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Cids_Installer
{
    class Database
    {
        #region Id Region
        public const int IdLen= 7;
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
                 prefix = new string('0',IdLen-raw.Length);
            }
            return prefix + raw;
        }
        #endregion

        #region SQL Data Source
        // where to get db info to connect
        public const string DataBaseInfo = "db.json";
        private readonly DBInfo Info;
        private readonly SqlConnectionStringBuilder Builder;
        private const string QueryCmd = "SELECT place,UUID FROM places";
        private Dictionary<String, int> IdMap;

        public Database() {
            Info = JsonSerializer.Deserialize<DBInfo>(File.ReadAllText(DataBaseInfo));
            Builder = new SqlConnectionStringBuilder
            {
                DataSource = Info.Ip,
                UserID = Info.User,
                Password = Info.Password,
                InitialCatalog = Info.Catalog
            };
            IdMap = new Dictionary<string, int>();
            //SqlCon = new SqlConnection(Builder.ConnectionString);
        }
        public Database Fetch() {
            using (SqlConnection connection=new SqlConnection(Builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command=new SqlCommand(QueryCmd,connection)) {
                    using (SqlDataReader reader = command.ExecuteReader()) {
                        // Read to map
                        while (reader.Read()) { 
                            IdMap.Add(reader.GetString(0),reader.GetInt32(1));
                        }
                    }
                }
            }
            return this;
        }
        #endregion
        /**
         * @brief get a id for place
         * if exist get existing one
         * or generate one
         */
        public String QueryAndAppend(String place) {
            int id = 0;
            if (!Query(place, ref id)) {
                id=Append(place);
            }
            return IDCompletion(id);
        }
        // query
        public bool Query(String place,ref int id)
        {
            bool exist = IdMap.ContainsKey(place);
            if (exist) {
                id = IdMap.GetValueOrDefault(place, 0);
            }
            return exist;
        }
        /**
         * @brief 向数据库中添加一个新地点 同时获得一个生成 UUID 每次添加后更新本地 IdMap
         * @warning 可能会有没想到部署时的数据库高并发导致的不同步问题
         */
        public int Append(string place)
        {
            int alloc = 0;
            Update(place);
            return alloc;
        }
        /**
         * @brief Query Database and Update locally
         */
        public Database Update()
        {
            return this;
        }
        /**
         * @brief Push the place 
         *      then Query Database and Update locally
         */
        public Database Update(String place)
        {
            PushPlace(place).Update();
            return this;
        }
        public Database PushPlace(String place) {
            return this;
        }
    }
}
