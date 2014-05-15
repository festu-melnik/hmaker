using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HTMLCreator.Highlighting
{
    public class HTMLHighlighter : IHighlighter
    {
        private HighlightRule tagsRule;
        private HighlightRule commentsRule;
        private HighlightRule numbersRule;
        private HighlightRule stringsRule;
        private HighlightRule tokensRule;

        public List<string> TagNames { get; set; }

        public HTMLHighlighter()
        {
            tagsRule = new HighlightRule(new Regex("[a-zA-Z0-9_-]+"), "#3399FF");
            commentsRule = new HighlightRule(new Regex("<!--.*-->", RegexOptions.Singleline), "#339900");
            numbersRule = new HighlightRule(new Regex("\\b[0-9]+\\b"), "#FF4040");
            stringsRule = new HighlightRule(new Regex("\".*\""), "#FF4040");
            tokensRule = new HighlightRule(new Regex("<|>|</"), "#4C59D8");

            TagNames = new List<string>(0);
        }

        public void Highlight(RichTextBox text)
        {
            int originalIndex = text.SelectionStart;
            int originalLength = text.SelectionLength;

            // Сброс подсветки
            text.SelectAll();
            text.SelectionColor = Color.Black;

			// Теги.
			foreach (Match m in tagsRule.Expression.Matches(text.Text)) 
            {
                if (TagNames.Count > 0)
                {
                    foreach (string word in TagNames)
                    {
                        if (m.Value.Equals(word, StringComparison.InvariantCultureIgnoreCase))
                        {
                            text.SelectionStart = m.Index;
                            text.SelectionLength = m.Length;
                            text.SelectionColor = tagsRule.TextColor;
                        }
                    }
                }
                else
                {
                    text.SelectionStart = m.Index;
                    text.SelectionLength = m.Length;
                    text.SelectionColor = tagsRule.TextColor;
                }
			}

			// Числа.
            foreach (Match m in numbersRule.Expression.Matches(text.Text)) 
            {
                text.SelectionStart = m.Index;
                text.SelectionLength = m.Length;
                text.SelectionColor = numbersRule.TextColor;
			}

            // Строки.
            foreach (Match m in stringsRule.Expression.Matches(text.Text))
            {
                text.SelectionStart = m.Index;
                text.SelectionLength = m.Length;
                text.SelectionColor = numbersRule.TextColor;
            }

            // Знаки < и >.
            foreach (Match m in tokensRule.Expression.Matches(text.Text)) 
            {
                text.SelectionStart = m.Index;
                text.SelectionLength = m.Length;
                text.SelectionColor = tokensRule.TextColor;
			}

			// Комментарии.
            foreach (Match m in commentsRule.Expression.Matches(text.Text)) 
            {
                text.SelectionStart = m.Index;
                text.SelectionLength = m.Length;
                text.SelectionColor = commentsRule.TextColor;
			}

            text.SelectionStart = originalIndex;
            text.SelectionLength = originalLength;
        }
    }
}
