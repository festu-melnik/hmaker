using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator.Parsing
{
    class GraphComponent
    {
        public string Name { get; private set; } // имя

        public bool Twin { get; private set; } // парность

        public Dictionary<string, string> Attributes { get; private set; } // атрибуты

        public GraphComponent Parent { get; private set; } // родитель

        public List<GraphComponent> Internals { get; private set; } // внутренние теги

        public GraphComponent(string name, bool twin, GraphComponent parent)
        {
            Name = name;
            Parent = parent;
            Twin = twin;

            Internals = new List<GraphComponent>();
            Attributes = new Dictionary<string, string>();
        }
    }

    class TextComponent : GraphComponent
    {
        public string InnerText { get; private set; } // текст

        public TextComponent(string innerText, GraphComponent parent)
            : base("text", false, parent)
        {
            InnerText = innerText;
        }
    }
}
