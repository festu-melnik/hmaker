using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTMLCreator.DocumentHandling
{
    class Document
    {
        private string text;

        public string Text { get { return text; } set { Saved = false; text = value; } }

        public string PathToFile { get; set; }
        public string Name { get; private set; }
        public bool Saved { get; private set; }

        public Document()
        {
            Name = "";
            Text = "";
            Saved = true;
            PathToFile = "";
        }

        public Document(string path)
        {
            Name = Path.GetFileNameWithoutExtension(path);
            Text = File.ReadAllText(path);
            Saved = true;
            PathToFile = path;
        }

        public void Save()
        {
            File.WriteAllText(PathToFile, Text);
            Name = Path.GetFileNameWithoutExtension(PathToFile);
            Saved = true;
        }
    }
}
