namespace Cids_Installer{
    public class MySql {
        public static string QueryExact(string pos) {
            return $"select UUID from {Table} where place={pos}";
        }
        public static string AppendSql(string pos) {
            return $" values({pos},1)";
        }
        public const string Inc = "insert into places(place,background)";
        public static readonly string QueryCmd = Select("place", "UUID");
        public static readonly string NullSql = SelectLoc("UUID=900","place");
        private const string Table = "places";
        private const string DataBase = "scucids";
        static string SelectLoc(string location,params string[] vals) {
            return $"select {string.Join(',', vals)} from {DataBase}.{Table} where {location}";
        }
        static string Select(params string[] vals) {
            return $"select {string.Join(',', vals)} from {DataBase}.{Table}";
        }
    }
}
