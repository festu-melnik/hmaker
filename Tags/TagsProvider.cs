using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SQLite;

namespace HTMLCreator.Tags
{
    class TagsProvider
    {
        private static SQLiteConnection connection = null;

        public TagsProvider()
        {
            connection = new SQLiteConnection();
            connection.ConnectionString = "Data Source = data.db3";
            connection.Open();
        }

        public List<string> ReceiveTagNames()
        {
            List<string> result = new List<string>();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM tags ORDER BY name";

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result.Add(reader.GetString(0));
            }

            return result;
        }

        public List<Tag> ReceiveTags()
        {
            List<Tag> result = new List<Tag>();

           SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name, twin, block, text_wrap, " +
                "auto_grow, width, height, out_fields, in_fields, text, image, image_align " +
                "FROM tags ORDER BY name";

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Tag t = new Tag();

                t.Name = reader.GetString(0);
                t.Twin = reader.GetBoolean(1);
                t.Block = reader.GetBoolean(2);
                t.TextWrap = reader.GetBoolean(3);
                t.AutoGrow = reader.GetBoolean(4);
                t.Width = reader.GetInt32(5);
                t.Height = reader.GetInt32(6);
                t.OutFields = reader.GetInt32(7);
                t.InFields = reader.GetInt32(8);
                t.Text = reader.GetString(9);
                t.Image = GetBytes(reader, 10);
                t.ImageAlign = (Tag.Align)reader.GetInt32(11);

                result.Add(t);
            }

            return result;
        }

        private byte[] GetBytes(SQLiteDataReader reader, int i)
        {
            const int CHUNK_SIZE = 2 * 1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(i, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }
    }
}
