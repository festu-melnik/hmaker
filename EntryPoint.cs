using System;
using System.Data.Common;

namespace hmaker
{
    class EntryPoint
    {
        public static void Main()
        {
            DataSource source = new DataSource();
            source.Connection("Data Source = tags.db3");
            TagInfo[] tags = source.ReceiveTagsInfo();

            foreach (TagInfo t in tags)
            {
                Console.WriteLine("{0} - {1}", t.Name, t.Description);
            }
            Console.ReadKey();
        }
    }
}
