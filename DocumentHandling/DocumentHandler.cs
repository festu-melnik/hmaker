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
            string path;

            File.Create("file-history");

            using (StreamWriter sw = new StreamWriter("file-history"))
            {
                for (int i = 0; i < OpenDocuments.Count; i++)
                {
                    path = OpenDocuments[i].PathToFile;

                    if(!String.IsNullOrWhiteSpace(path))
                        sw.WriteLine(path);
                }
            }
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
                    AddDocument(new Document(files[i]));
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
