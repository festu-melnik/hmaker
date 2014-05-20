using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HTMLCreator.Parsing
{
    class HTMLParser : IParser
    {
        private Tag[] knownTags;

        private string html;
        private int pos;

        private bool EOF { get { return pos >= html.Length; } }

        public int ErrorPosition { get; private set; } // место, где произошла ошибка. -1, если ошибок нет.

        public HTMLParser(Tag[] knownTags)
        {
            this.knownTags = knownTags;
            this.ErrorPosition = 0;
        }

        public GraphComponent Parse(string text)
        {
            string tagName = "";
            GraphComponent current = null;

            // корневой тег
            GraphComponent root = null;

            html = text.Trim();
            html = html.Replace("\r\n", " ");
            html = html.Replace('\n', ' ');

            // поиск тега body
            pos = 0;

            ToNextOpenToken();

            while (!EOF)
            {
                // пропуск открывающего токена
                Move();
                // проверка имени
                tagName = ParseTagName();
                if (tagName == "body")
                {
                    root = new GraphComponent(null);
                    root.Block = false;
                    root.AutoGrow = true;
                    root.Width = 100;
                    root.Height = 100;
                    root.TextWrap = false;
                    root.OutFields = 0;
                    root.InFields = 2;
                    root.Image = null;

                    // переход на закрывающий токен
                    ToNextCloseToken();
                    // пропуск закрывающего токена
                    Move();

                    break;
                }
                ToNextOpenToken();
            }

            if (root == null)
                return null;

            current = root;

            // когда корневой элемент найден, можно искать остальные

            return root;
        }

        private void ToNextOpenToken()
        {
            SetPosition(html.IndexOf('<', pos));
        }

        private void ToNextCloseToken()
        {
            SetPosition(html.IndexOf('>', pos));
        }

        private string ParseTagName()
        {
            int start = pos;

            while (!EOF)
            {
                if (SpaceNext() || GetChar(1) == '>')
                    break;
                else
                    Move();
            }

            return html.Substring(start, pos - start);
        }

        private string ParseAttributeName()
        {
            int start = pos;

            while (!EOF)
            {
                if (SpaceNext() || GetChar(1) == '>' || GetChar(1) == '=')
                    break;
                else
                    Move();
            }

            return html.Substring(start, pos - start);
        }

        private string ParseAttributeValue()
        {
            int start, end;

            if (QuoteHere())
            {
                char q = GetChar();
                // пропуск открывающей кавычки
                Move();
                // парсинг значения
                start = pos;
                SetPosition(html.IndexOf(q, pos));
                end = pos;
                // пропуск закрывающей кавычки, если она есть
                if (GetChar() == q)
                    Move();
            }
            else
            {
                // парсинг значения
                start = pos;
                while (!EOF)
                {
                    if (SpaceNext() || GetChar() == '>')
                        Move();
                }
                end = pos;
            }

            return html.Substring(start, end - start);
        }

        private string ParseRawText()
        {
            int start = pos;

            while (!EOF)
            {
                if (GetChar(1) == '<')
                    break;
                else
                    Move();
            }

            return html.Substring(start, pos - start);
        }

        private char GetChar(int skip)
        {
            return html[pos + skip];
        }

        private char GetChar()
        {
            return GetChar(0);
        }

        private void Move(int step)
        {
            pos = Math.Min(pos + step, html.Length);
        }

        private void Move()
        {
            Move(1);
        }

        private void SkipSpaces()
        {
            while (!EOF && Char.IsWhiteSpace(GetChar()))
                Move();
        }

        private void SetPosition(int p)
        {
            if (p < 0 || p > html.Length)
                pos = html.Length;
            else
                pos = p;
        }

        private bool SpaceNext()
        {
            return Char.IsWhiteSpace(GetChar(1));
        }

        private bool QuoteHere()
        {
            return GetChar(1) == '"' || GetChar(1) == '\'';
        }
    }
}
