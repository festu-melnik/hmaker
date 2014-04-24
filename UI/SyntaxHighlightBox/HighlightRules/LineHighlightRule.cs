using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMaker.UI.SyntaxHighlightBox
{
    class LineHighlightRule : HighlightRule
    {
        public string LineStart { get; set; }
        public string LineEnd { get; set; }
    }
}
