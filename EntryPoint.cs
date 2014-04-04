using System.Data.Common;

namespace hmaker
{
    class EntryPoint
    {
        public static void Main()
        {
            DbProviderFactory fact = DbProviderFactories.GetFactory("System.Data.SQLite");
            using (DbConnection cnn = fact.CreateConnection())
            {
                cnn.ConnectionString = "Data Source=test.db3";
                cnn.Open();
            }
        }
    }
}
