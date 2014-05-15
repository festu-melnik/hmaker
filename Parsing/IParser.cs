using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HTMLCreator.Parsing
{
    interface IParser
    {
        Image Parse(string text);
    }
}
