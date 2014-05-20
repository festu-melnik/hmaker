using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator
{
    class Tag
    {
        public string Name { get; set; } // имя

        public bool Double { get; set; } // двойной или нет

        public bool Block { get; set; } // блочный или нет

        public bool TextWrap { get; set; } // перенос текста внутри тега

        public bool AutoGrow { get; set; } // автоматическое увеличение размеров

        public int Width { get; set; } // минимальная ширина
        public int Height { get; set; } // минимальная высота

        public int OutFields { get; set; } // внешние поля
        public int InFields { get; set; } // внутренние поля

        public string Text { get; set; } // текст

        public byte[] Image { get; set; } // изображение для тега

        public Tag ParentTag { get; set; } // родительский тег

        public List<Tag> InnerTags { get; private set; } // внутренние теги

        public Tag()
        {
            InnerTags = new List<Tag>();
        }
    }
}
