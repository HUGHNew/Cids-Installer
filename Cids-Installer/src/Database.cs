using System;
using System.Collections.Generic;
using System.Linq;

namespace Cids_Installer
{
    class Database
    {
        #region Id Region
        public const int IdLen= 7;
        /**
         * @brief Get the UUID from database
         */
        public static string GetId=
            IDCompletion(GetIdFromDatabase());
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
        /**
         * @brief Get ID from DataBase as Int indeed
         */
        private static int GetIdFromDatabase()
        {
            return 0;
        }
        #endregion

        // Need to Access SQL Database
        // something to store data
        public Database() { }
        public Database Fetch() {
            return this;
        }

        // query

        // append
    }
}
