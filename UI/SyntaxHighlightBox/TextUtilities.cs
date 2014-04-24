using System;
using System.Diagnostics.Contracts;

namespace HMaker.UI.SyntaxHighlightBox 
{
	public static class TextUtilities 
    {
		// Возвращает количество строк в блоке текста.
		public static int GetLinesQty(string text) 
        {
			int count = 1;
			for (int i = 0; i < text.Length; i++) 
            {
                if (text[i] == '\n')
                {
                    count += 1;
                }
			}
			return count;
		}

		// Возвращает глобальный индекс первого символа указанной строки.
		public static int GetFirstCharIndex(string text, int lineIndex) 
        {
			if (text == null)
				throw new ArgumentNullException("text");
			if (lineIndex <= 0)
				return 0;

			int currentLineIndex = 0;
			for (int i = 0; i < text.Length - 1; i++) 
            {
				if (text[i] == '\n') 
                {
					currentLineIndex += 1;
                    if (currentLineIndex == lineIndex)
                    {
                        return Math.Min(i + 1, text.Length - 1);
                    }
				}
			}

			return Math.Max(text.Length - 1, 0);
		}

		// Возвращает глобальный индекс последнего символа указанной строки.
		public static int GetLastCharIndex(string text, int lineIndex) 
        {
			if (text == null)
				throw new ArgumentNullException("text");
			if (lineIndex < 0)
				return 0;

			int currentLineIndex = 0;
			for (int i = 0; i < text.Length - 1; i++) 
            {
				if (text[i] == '\n') 
                {
                    if (currentLineIndex == lineIndex)
                    {
                        return i;
                    }
					currentLineIndex += 1;
				}
			}

			return Math.Max(text.Length - 1, 0);
		}
	}
}
