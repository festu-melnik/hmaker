using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace HTMLCreator.Parsing
{
    class HTMLParser : IParser
    {
        private string html;
        private int pos;

        private bool EOF { get { return pos >= html.Length; } }

        public GraphComponent Parse(string text)
        {
            string tagName;
            GraphComponent current = null;

            // корневой тег
            GraphComponent root = null;

            // преобразование входного текста в одну строку
            html = text.Trim();
            html = html.Replace("\r\n", " ");
            html = html.Replace('\n', ' ');

            // курсор на первую позицию
            pos = 0;

            // к следующему открывающему токену
            ToNextOpenToken();
            Move();

            // проверка наличия DOCTYPE
            if(GetChar() == '!')
            {
                Move();

                tagName = ParseTagName();

                if(tagName == "DOCTYPE")
                {
                    // Разбор DOCTYPE.
                }
                else
                {
                    return null;
                }

                ToNextOpenToken();
            }

            while(!EOF)
            {
                SkipSpaces();

                if(GetChar() == '<')
                {
                    Move();
                    if(GetChar(0) == '!' 
                        && GetChar(1) == '-' && GetChar(2) == '-')
                    {
                        Move(3);
                        ToCommentEnd();
                    }
                    else if(GetChar() == '/')
                    {
                        if(root == null)
                            return null;
                        if(current == root)
                            return root;

                        current = current.Parent;
                    }
                    else
                    {
                        tagName = ParseTagName();
                        if(root == null)
                        {
                            root = new GraphComponent(tagName, true, null);
                            current = root;
                        }
                        else
                        {
                            GraphComponent comp;

                            if(html.IndexOf("</" + tagName, pos) < 0)
                                comp = new GraphComponent(tagName, false, current);             
                            else
                                comp = new GraphComponent(tagName, true, current);

                            current.Internals.Add(comp);
                            
                            if(comp.Twin)
                                current = comp;
                        }
                    }
                    ToNextCloseToken();
                    Move();
                }
                else
                {
                    TextComponent comp;

                    // добавление текста
                    comp = new TextComponent(ParseRawText(), current);

                    current.Internals.Add(comp);
                }
            }

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
            int start;
            
            start = pos;

            while (!EOF)
            {
                if (SpaceHere() || GetChar() == '>')
                    break;
                else
                    Move();
            }

            return html.Substring(start, pos - start);
        }

        private string ParseAttributeName()
        {
            int start;

            start = pos;

            while (!EOF)
            {
                if (SpaceHere() || GetChar() == '>' || GetChar() == '=')
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
                char q = (char)GetChar();
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
                    if (SpaceHere() || GetChar() == '>')
                        Move();
                }

                end = pos;
            }

            return html.Substring(start, end - start);
        }

        private string ParseRawText()
        {
            int start, end;
            
            start = pos;

            while (!EOF)
            {
                if (GetChar(1) == '<')
                    break;
                else
                    Move();
            }

            end = pos;

            Move();

            return html.Substring(start, pos - start);
        }

        private int GetChar(int skip)
        {
            int cpos = pos + skip;

            if (cpos < html.Length)
                return html[pos + skip];
            else
                return -1;
        }

        private int GetChar()
        {
            return GetChar(0);
        }

        private string GetChars(int skip, int length)
        {
            int start = pos + skip;
            int end = start + length;

            if (start < html.Length)
            {
                if(end < html.Length)
                    return html.Substring(start, length);
                else
                    return html.Substring(start, html.Length - start);
            }
            else
            {
                return "";
            }
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
            while (!EOF && SpaceHere())
                Move();
        }

        private void ToCommentEnd()
        {
            SetPosition(html.IndexOf("--", pos));
        }

        private void SetPosition(int p)
        {
            if (p < 0 || p > html.Length)
                pos = html.Length;
            else
                pos = p;
        }

        private bool SpaceHere()
        {
            if (EOF)
                return false;
            return Char.IsWhiteSpace((char)GetChar());
        }

        private bool QuoteHere()
        {
            return GetChar() == '"' || GetChar() == '\'';
        }
    }
}
