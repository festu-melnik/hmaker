using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLCreator.Config
{
    [Serializable]
    class ColorTheme
    {
        public string Foreground { get; set; }
        public string Background { get; set; }

        public string Token { get; set; }
        public string Tag { get; set; }
        public string String { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }

        public static ColorTheme Default { get { return new ColorTheme(); } }

        public static ColorTheme Oblivion
        {
            get
            {
                ColorTheme theme = new ColorTheme();

                theme.Foreground = "#D8D8D8";
                theme.Background = "#1E1E1E";
                theme.Token = "#79ABFF";
                theme.Tag = "#BED6FF";
                theme.Number = "#7FB347";
                theme.String = "#FFC600";
                theme.Comment = "#CCDF32";

                return theme;
            }
        }

        public ColorTheme()
        {
            Foreground = "#585858";
            Background = "#F5F5F5";
            Token = "#55AA55";
            Tag = "#AB2525";
            String = "#295F94";
            Number = "#AF0F91";
            Comment = "#AD95AF";
        }

        public bool Eqv(ColorTheme target)
        {
            if (this.Foreground != target.Foreground)
                return false;
            if (this.Background != target.Background)
                return false;
            if (this.Token != target.Token)
                return false;
            if (this.Tag != target.Tag)
                return false;
            if (this.String != target.String)
                return false;
            if (this.Number != target.Number)
                return false;
            if (this.Comment != target.Comment)
                return false;

            return true;
        }
    }
}
