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

        public string PathToFile { get; private set; }
        public string Name { get; private set; }
        public bool Saved { get; private set; }

        public Document(string name)
        {
            Name = name;
            Saved = true;
        }

        public void Save(string path)
        {
            File.WriteAllText(path, text);
            PathToFile = path;
            Name = Path.GetFileNameWithoutExtension(path);
            Saved = true;
        }

        public void Load(string path)
        {
            text = File.ReadAllText(path);
            PathToFile = path;
            Name = Path.GetFileNameWithoutExtension(path);
            Saved = true;
        }
    }
}
