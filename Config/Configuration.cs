using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator.Config
{
    [Serializable()]
    class Configuration
    {
        public string FilesPath { get; set; } // место хранения файлов

        public bool SaveOpenedFiles { get; set; } // сохранять открытые файлы

        public bool ReplaceTabsBySpaces { get; set; } // заменять табы на пробелы
        public byte TabWidth { get; set; } // количество пробелов в табе

        public int RefreshRate { get; set; } // частота обновления в секундах

        public byte MaxTabs { get; set; } // максимум вкладок

        public byte FontSize { get; set; } // размер шрифта

        public ColorTheme Colors { get; set; } // цвета

        public Configuration()
        {
            this.FilesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            this.SaveOpenedFiles = true;
            this.ReplaceTabsBySpaces = true;
            this.TabWidth = 2;
            this.RefreshRate = 5;
            this.MaxTabs = 5;
            this.FontSize = 10;
            this.Colors = ColorTheme.Default;
        }
    }
}