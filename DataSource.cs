using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;

namespace hmaker
{
    class DataSource
    {
        DbConnection connection = null;

        public void Connection(string connectionString)
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
            }

            DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SQLite");
            connection = fact.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public TagInfo[] ReceiveTagsInfo()
        {
            List<TagInfo> result = new List<TagInfo>();

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name, description FROM tags ORDER BY name";

            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TagInfo tag = new TagInfo(reader.GetString(0), reader.GetString(1));
                result.Add(tag);
            }

            return result.ToArray<TagInfo>();
        }
    }
}
