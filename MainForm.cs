using HTMLCreator.Highlighting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTMLCreator
{
    public partial class MainForm : Form
    {
        HTMLHighlighter hgl = new HTMLHighlighter();
        bool unsaved = false;

        public MainForm()
        {
            InitializeComponent();

            hgl.TagNames = new List<string>(new string[5] { "div", "a", "form", "h1", "h2" });
            hgl.TagNames.Add("html");
            hgl.TagNames.Add("head");
            hgl.TagNames.Add("body");
            hgl.TagNames.Add("title");
            hgl.TagNames.Add("meta");

            AddSkeleton();
        }

        private void redactor_TextChanged(object sender, EventArgs e)
        {
            hgl.Highlight((RichTextBox)sender);
            unsaved = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            if (unsaved)
            {
                SaveFile(true);
            }

            redactor.Clear();

            AddSkeleton();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(true);
                redactor.Text = File.ReadAllText(saveFileDialog.FileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFile(false);
            unsaved = false;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ParseHTML(redactor.Text);
        }

        private void ParseHTML(string text)
        {
            // Парсинг кода и отображение.
        }

        private void SaveFile(bool ask)
        {
            if (ask)
            {
                const string message = "Сохранить измененный файл?";
                const string caption = "Сохранение";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, redactor.Text);
            }
        }

        private void AddSkeleton()
        {
            redactor.Text +=
                "<!DOCTYPE html>\n" +
                "<html>\n" +
                "  <head>\n" +
                "    <title>untitled</title>\n" +
                "    <meta charset=\"utf-8\">\n" +
                "  </head>\n" +
                "  <body>\n" +
                "  </body>\n" +
                "</html>";

            unsaved = true;

            hgl.Highlight(redactor);
        }
    }
}
