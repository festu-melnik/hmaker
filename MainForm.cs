using HTMLCreator.Config;
using HTMLCreator.DocumentHandling;
using HTMLCreator.Highlighting;
using HTMLCreator.Parsing;
using HTMLCreator.Tags;
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
        List<string> tagNames;
        int newFilesTotal;
        const int maxTabName = 10;

        public MainForm()
        {
            InitializeComponent();

            newFilesTotal = 0;

            tabs.TabPages.RemoveAt(0);

            TagsProvider prov = new TagsProvider();

            tagNames = prov.ReceiveTagNames();

            foreach (string str in tagNames)
                tagsToolBtn.DropDownItems.Add(str);

            tagNames.Add("html");
            tagNames.Add("head");
            tagNames.Add("body");
            tagNames.Add("title");
            tagNames.Add("meta");

            ConfigurationManager.LoadConfig();

            DocumentHandler.Load();

            if (DocumentHandler.DocumentsTotal > 0)
            {
                Document doc = new Document("");
                for (int i = 0; i < DocumentHandler.DocumentsTotal; i++)
                {
                    doc = DocumentHandler.OpenDocuments[i];

                    // добавление вкладки
                    tabs.TabPages.Add(CropName(doc.Name));
                }
                // выбор добавленной вкладки
                tabs.SelectedIndex = tabs.TabCount - 1;
                tabs.SelectedTab.Controls.Add(container);
                redactor.Text = doc.Text;
            }
            else
            {
                NewDocument();
                AddSkeleton();
                UpdateOpenDocument();
            }
            
            Highlight();

            UpdateVisual();
            

            hglUpdateTimer.Start();
        }

        private void redactor_TextChanged(object sender, EventArgs e)
        {
            UpdateOpenDocument();
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
        }

        #region docs

        private void UpdateOpenDocument()
        {
            int idx = tabs.SelectedIndex;
            // сохранение текста в документ
            if (DocumentHandler.OpenDocuments[idx].Text != redactor.Text)
                DocumentHandler.OpenDocuments[idx].Text = redactor.Text;
        }

        private void SaveDocument()
        {
            Document openDoc = DocumentHandler.OpenDocuments[tabs.SelectedIndex];
            string path = openDoc.PathToFile;

            if (String.IsNullOrEmpty(path))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    path = saveFileDialog.FileName;
                else
                    return;
            }

            openDoc.Save(path);

            tabs.SelectedTab.Text = CropName(openDoc.Name);
        }

        private void NewDocument()
        {
            Document doc = new Document("new_" + ++newFilesTotal);
            if(DocumentHandler.DocumentsTotal > 0)
                UpdateOpenDocument();
            AddDocument(doc);
        }

        private void AddDocument(Document doc)
        {
            // добавление нового документа
            DocumentHandler.OpenDocuments.Add(doc);

            // если есть открытые вкладки, очистка контролов
            if (tabs.TabCount > 0)
            {
                // очистка выбранной вкладки
                tabs.SelectedTab.Controls.Clear();
                // очистка редактора
                redactor.Clear();
            }

            // добавление вкладки
            tabs.TabPages.Add(CropName(doc.Name));
            // выбор добавленной вкладки
            tabs.SelectedIndex = tabs.TabCount - 1;
            tabs.SelectedTab.Controls.Add(container);
            redactor.Text = doc.Text;
        }

        private void OpenDocument()
        {
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                OpenDocument(openFileDialog.FileName);
        }

        private void OpenDocument(string path)
        {
            Document doc = new Document("");
            doc.Load(path);
            
            if(DocumentHandler.Exsists(doc))
                return;

            UpdateOpenDocument();

            AddDocument(doc);
        }

        private void CloseDocument(int index)
        {
            int idx;

            UpdateOpenDocument();

            if (!DocumentHandler.OpenDocuments[index].Saved)
            {
                const string message = "Сохранить измененный файл?";
                const string caption = "Сохранение";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveDocument();
            }

            // удаление вкладки
            tabs.TabPages.RemoveAt(index);

            if (tabs.TabPages.Count == 0)
                return;

            idx = tabs.SelectedIndex;

            // удаление документа
            DocumentHandler.DeleteDocument(index);
            // добавление контролов на вкладку
            tabs.SelectedTab.Controls.Add(container);
            // загрузка текста из документа
            redactor.Text = DocumentHandler.OpenDocuments[idx].Text;
        }

        private void CloseAllDocuments()
        {
            while (tabs.TabPages.Count > 0)
            {
                CloseDocument(tabs.SelectedIndex);
            }
        }

        private void SelectDocument(int index)
        {
            // очистка выбранной вкладки
            tabs.SelectedTab.Controls.Clear();
            // очистка редактора
            redactor.Clear();

            // выбор указанной вкладки
            tabs.SelectedIndex = index;

            // добавление контролов на вкладку
            tabs.SelectedTab.Controls.Add(container);
            // загрузка текста из документа
            redactor.Text = DocumentHandler.OpenDocuments[index].Text;
        }

        #endregion

        

        private void UpdateVisual()
        {
            redactor.Font = new Font("Consolas", ConfigurationManager.CurrentConfig.FontSize);
            Highlight();

            saveFileDialog.InitialDirectory = ConfigurationManager.CurrentConfig.FilesPath;
            openFileDialog.InitialDirectory = ConfigurationManager.CurrentConfig.FilesPath;

            grfUpdateTimer.Interval = ConfigurationManager.CurrentConfig.RefreshRate;
        }

        private void Highlight()
        {
            HTMLHighlighter highlighter = new HTMLHighlighter(tagNames.ToArray());

            view.Focus();
            highlighter.Highlight(redactor);
            redactor.Focus();
        }

        private string CropName(string name)
        {
            string newName = name;
            if (newName.Length > maxTabName)
                newName = newName.Substring(0, maxTabName - 3) + "...";
            return newName;
        }

        #region handlers

        private void hglUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (redactor.Focused)
                Highlight();
        }

        private void newToolBtn_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.CurrentConfig.MaxTabs < tabs.TabCount)
            {
                NewDocument();
                AddSkeleton();
                UpdateOpenDocument();
                Highlight();
            }
            else
            {
                MessageBox.Show("Слишком много вкладок. Закройте лишнее и попробуйте еще раз.");
            }
        }

        private void openToolBtn_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.CurrentConfig.MaxTabs < tabs.TabCount)
            {
                OpenDocument();
                Highlight();
            }
            else
            {
                MessageBox.Show("Слишком много вкладок. Закройте лишнее и попробуйте еще раз.");
            }
        }

        private void saveToolBtn_Click(object sender, EventArgs e)
        {
            UpdateOpenDocument();
            SaveDocument();
            Highlight();
        }

        private void refreshToolBtn_Click(object sender, EventArgs e)
        {
            HTMLParser parser = new HTMLParser();
            GraphComponent root = parser.Parse(redactor.Text);

        }

        private void settingsToolBtn_Click(object sender, EventArgs e)
        {
            using (ConfigForm confForm = new ConfigForm())
            {
                confForm.ShowDialog(this);
            }
            UpdateVisual();
        }

        private void tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabs.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabs.TabPages.Count; i++)
            {
                Rectangle r = tabs.GetTabRect(i);
                // получение расположения 'х'
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 5, 15, 15);
                if (r.Contains(e.Location))
                {
                    SelectDocument(i);
                    Highlight();
                }
                if (closeButton.Contains(e.Location))
                {
                    const string message = "Закврыть вкладку?";
                    const string caption = "Закрытие вкладки";
                    var result = MessageBox.Show(message, caption,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CloseDocument(i);
                        break;
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfigurationManager.CurrentConfig.SaveOpenedFiles)
                DocumentHandler.Save();
            CloseAllDocuments();
        } 

        #endregion

        private void tagsToolBtn_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TagsProvider tags = new TagsProvider();
            string name = e.ClickedItem.Text;
            bool twin = (bool)tags.IsTwin(name);

            if (twin)
                Clipboard.SetText(String.Format("<{0}></{0}>", name));
            else
                Clipboard.SetText(String.Format("<{0}>", name));

            redactor.Paste();

            if (twin)
                redactor.SelectionStart = redactor.SelectionStart - name.Length - 3;

            Highlight();
        }

        private void redactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ConfigurationManager.CurrentConfig.ReplaceTabsBySpaces)
            {
                if (e.KeyChar == (char)Keys.Tab)
                {
                    e.Handled = true;
                    redactor.SelectedText = new string(' ', ConfigurationManager.CurrentConfig.TabWidth);
                }
            }
        }
    }
}
