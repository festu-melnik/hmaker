using HTMLCreator.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HTMLCreator.Highlighting
{
    public class HTMLHighlighter : IHighlighter
    {
        private ColorTheme colors;

        private HighlightRule tagsRule;
        private HighlightRule commentsRule;
        private HighlightRule numbersRule;
        private HighlightRule stringsRule;
        private HighlightRule tokensRule;

        private string buffer;

        private string[] tagNames;

        public HTMLHighlighter(string[] tagNames)
        {
            colors = ConfigurationManager.CurrentConfig.Colors;

            tokensRule = new HighlightRule(new Regex("<|>|</"), colors.Token);
            tagsRule = new HighlightRule(new Regex("[a-zA-Z0-9_-]+"), colors.Tag);
            
            numbersRule = new HighlightRule(new Regex("\\b[0-9]+\\b"), colors.Number);
            stringsRule = new HighlightRule(new Regex("\".*\""), colors.String);

            commentsRule = new HighlightRule(new Regex("<!--.*?-->", RegexOptions.Singleline), colors.Comment);

            buffer = "";

            this.tagNames = tagNames;
        }

        public void Highlight(RichTextBox textBox)
        {
            int originalIndex; 
            int originalLength;

            string text = textBox.Text.Trim();

            if (buffer == text)
                return;

            buffer = text;
 
            originalIndex = textBox.SelectionStart;
            originalLength= textBox.SelectionLength;

            // Сброс подсветки
            textBox.BackColor = ColorTranslator.FromHtml(colors.Background);
            textBox.SelectAll();
            textBox.SelectionColor = ColorTranslator.FromHtml(colors.Foreground);

			// Теги.
			foreach (Match m in tagsRule.Expression.Matches(textBox.Text)) 
            {
                if (tagNames.Length > 0)
                {
                    foreach (string word in tagNames)
                    {
                        if (m.Value.Equals(word, StringComparison.InvariantCultureIgnoreCase))
                        {
                            textBox.SelectionStart = m.Index;
                            textBox.SelectionLength = m.Length;
                            textBox.SelectionColor = tagsRule.TextColor;
                        }
                    }
                }
                else
                {
                    textBox.SelectionStart = m.Index;
                    textBox.SelectionLength = m.Length;
                    textBox.SelectionColor = tagsRule.TextColor;
                }
			}

			// Числа.
            foreach (Match m in numbersRule.Expression.Matches(textBox.Text)) 
            {
                textBox.SelectionStart = m.Index;
                textBox.SelectionLength = m.Length;
                textBox.SelectionColor = numbersRule.TextColor;
			}

            // Строки.
            foreach (Match m in stringsRule.Expression.Matches(textBox.Text))
            {
                textBox.SelectionStart = m.Index;
                textBox.SelectionLength = m.Length;
                textBox.SelectionColor = numbersRule.TextColor;
            }

            // Знаки < и >.
            foreach (Match m in tokensRule.Expression.Matches(textBox.Text)) 
            {
                textBox.SelectionStart = m.Index;
                textBox.SelectionLength = m.Length;
                textBox.SelectionColor = tokensRule.TextColor;
			}

			// Комментарии.
            foreach (Match m in commentsRule.Expression.Matches(textBox.Text)) 
            {
                textBox.SelectionStart = m.Index;
                textBox.SelectionLength = m.Length;
                textBox.SelectionColor = commentsRule.TextColor;
			}

            textBox.SelectionStart = originalIndex;
            textBox.SelectionLength = originalLength;
        }
    }
}
