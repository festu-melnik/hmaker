using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTMLCreator.DocumentHandling
{
    static class DocumentHandler
    {
        public static List<Document> OpenDocuments { get; private set; }

        public static int DocumentsTotal { get { return OpenDocuments.Count; } }

        static DocumentHandler()
        {
            OpenDocuments = new List<Document>();
        }

        public static void AddDocument(Document document)
        {
            OpenDocuments.Add(document);
        }

        public static void DeleteDocument(int index)
        {
            OpenDocuments.RemoveAt(index);
        }

        public static void Save()
        {
            string[] files = new string[OpenDocuments.Count];

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = OpenDocuments[i].PathToFile;
            }

            File.WriteAllLines("file-history", files);
        }

        public static void Load()
        {
            string[] files;

            OpenDocuments.Clear();

            if (File.Exists("file-history"))
            {
                files = File.ReadAllLines("file-history");
                for (int i = 0; i < files.Length; i++)
                {
                    Document doc = new Document("");
                    doc.Load(files[i]);
                    AddDocument(doc);
                }
            }
        }

        public static bool Exsists(Document doc)
        {
            foreach (Document d in OpenDocuments)
            {
                if (d.PathToFile == doc.PathToFile)
                    return true;
            }
            return false;
        }
    }
}
