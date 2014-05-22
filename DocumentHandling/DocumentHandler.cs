using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTMLCreator.DocumentHandling
{
    static class DocumentHandler
    {
        private static int selectedIndex;

        public static List<Document> OpenDocuments { get; private set; }

        public static int DocumentsTotal { get { return OpenDocuments.Count; } }

        public static Document Selected 
        { 
            get { return selectedIndex == -1 ? null : OpenDocuments[selectedIndex]; } 
        }

        public static int SelectedIndex 
        {
            get { return selectedIndex; }
            set { selectedIndex = value < 0 || value >= OpenDocuments.Count ? -1 : value; }
        }

        static DocumentHandler()
        {
            OpenDocuments = new List<Document>();

            selectedIndex = -1;
        }

        public static void AddDocument(Document document)
        {
            OpenDocuments.Add(document);
            SelectedIndex = OpenDocuments.Count - 1 ;
        }

        public static void DeleteDocument(int index)
        {
            OpenDocuments.RemoveAt(index);
            if (SelectedIndex == index)
                SelectedIndex = -1;
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
            string[] files = File.ReadAllLines("file-history");

            OpenDocuments.Clear();

            for (int i = 0; i < files.Length; i++)
            {
                Document doc = new Document(files[i]);
                doc.Text = File.ReadAllText(files[i]);
                AddDocument(doc);
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
