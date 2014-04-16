using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmaker
{
    class TagInfo
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public TagInfo(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
