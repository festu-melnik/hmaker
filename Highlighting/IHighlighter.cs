using System.Windows.Forms;

namespace HTMLCreator.Highlighting 
{
	public interface IHighlighter 
    {
		void Highlight(RichTextBox text);
	}
}
