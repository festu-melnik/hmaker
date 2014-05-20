using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator
{
    class GraphComponent
    {
        public bool Block { get; set; } // блочный или нет

        public bool TextWrap { get; set; } // перенос текста внутри тега

        public bool AutoGrow { get; set; } // автоматическое увеличение размеров

        public int Width { get; set; } // ширина
        public int Height { get; set; } // высота

        public int OutFields { get; set; } // внешние поля
        public int InFields { get; set; } // внутренние поля

        public byte[] Image { get; set; } // изображение

        public Tag Parent { get; set; } // родитель

        public List<GraphComponent> Internals { get; private set; } // внутренние теги

        public GraphComponent(GraphComponent parent)
        {
            Internals = new List<GraphComponent>();
        }
    }
}
