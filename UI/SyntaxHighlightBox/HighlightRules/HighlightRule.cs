using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMaker.UI.SyntaxHighlightBox
{
    enum FontWeight { Light, Normal, Bold };

    class HighlightRule
    {
        public bool IgnoreCase { get; set; }
        public string Foreground { get; set; }
        public FontWeight FontWeight { get; set; }
    }
}
