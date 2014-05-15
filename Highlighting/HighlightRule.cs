using System.Drawing;
using System.Text.RegularExpressions;

namespace HTMLCreator.Highlighting
{
    class HighlightRule
    {
        public Color TextColor { get; private set; }
        public Regex Expression { get; private set; }

        public HighlightRule(Regex exp, Color textColor)
        {
            this.Expression = exp;
            this.TextColor = textColor;
        }

        public HighlightRule(Regex exp, string textColor)
        {
            this.Expression = exp;
            this.TextColor = ColorTranslator.FromHtml(textColor);
        }
    }
}
