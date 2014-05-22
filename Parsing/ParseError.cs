using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator.Parsing
{
    struct ParseError
    {
        int pos;
        string message;

        public int Position { get { return pos; } }
        public string Message { get { return message; } }

        public static ParseError NoError { get { return new ParseError(-1, ""); } }

        public ParseError(int pos, string message)
        {
            this.pos = pos;
            this.message = message;
        }
    }
}
