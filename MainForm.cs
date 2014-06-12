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
        int newFilesTotal = 0;

        const int maxTabName = 10;
        const string skeleton = "<!DOCTYPE html>\n" +
                                "<html>\n" +
                                "  <head>\n" +
                                "    <title>untitled</title>\n" +
                                "    <meta charset=\"utf-8\">\n" +
                                "  </head>\n" +
                                "  <body>\n" +
                                "  </body>\n" +
                                "</html>";

        public MainForm()
        {
            InitializeComponent();

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

            tabs.TabPages.Clear();

            DocumentHandler.Load();

            if (DocumentHandler.DocumentsTotal > 0)
            {
                for (int i = 0; i < DocumentHandler.DocumentsTotal; i++)
                {
                    string name = DocumentHandler.OpenDocuments[i].Name;

                    // добавление вкладки
                    tabs.TabPages.Add(CropName(name));
                }
                // выбор добавленной вкладки
                tabs.SelectedIndex = 0;
                tabs.TabPages[0].Controls.Add(container);
                // загрузка
                redactor.Text = DocumentHandler.OpenDocuments[0].Text;
            }
            else
            {
                NewDocument();
                UpdateOpenedDocument();
            }
            
            Highlight();

            UpdateVisual();
            

            hglUpdateTimer.Start();
        }

        private void redactor_TextChanged(object sender, EventArgs e)
        {
            UpdateOpenedDocument();
        }

        #region docs

        private void UpdateOpenedDocument()
        {
            int idx = tabs.SelectedIndex;

            // сохранение текста в документ
            if (DocumentHandler.OpenDocuments[idx].Text != redactor.Text)
                DocumentHandler.OpenDocuments[idx].Text = redactor.Text;
        }

        private void LoadText()
        {
            int idx = tabs.SelectedIndex;

            // загрузка текста
            if (redactor.Text != DocumentHandler.OpenDocuments[idx].Text)
                redactor.Text = DocumentHandler.OpenDocuments[idx].Text;
        }

        private void SaveDocument(bool ask)
        {
            Document openDoc = DocumentHandler.OpenDocuments[tabs.SelectedIndex];

            if (ask)
            {
                const string message = "Сохранить изменения?";
                const string caption = "Сохранение";
                var result = MessageBox.Show(message, caption,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }

            if (String.IsNullOrEmpty(openDoc.PathToFile))
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    openDoc.PathToFile = saveFileDialog.FileName;
                else
                    return;
            }

            openDoc.Save();

            tabs.SelectedTab.Text = CropName(openDoc.Name);
        }

        private void NewDocument()
        {
            Document doc = new Document();

            doc.Text = skeleton;

            AddDocument(doc);
        }

        private void AddDocument(Document doc)
        {
            // добавление нового документа
            DocumentHandler.OpenDocuments.Add(doc);

            // если есть открытые вкладки, очистка контролов
            if (tabs.TabCount > 0)
            {
                // обновление открытого документа
                UpdateOpenedDocument();
                // очистка выбранной вкладки
                tabs.SelectedTab.Controls.Clear();
            }

            // добавление вкладки
            if (String.IsNullOrWhiteSpace(doc.Name))
                tabs.TabPages.Add(CropName("new " + ++newFilesTotal));
            else
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
            Document doc = new Document(path);
            
            if(DocumentHandler.Exsists(doc))
                return;

            AddDocument(doc);
        }

        private void CloseDocument(int index)
        {
            int idx;

            // удаление вкладки
            tabs.TabPages.RemoveAt(index);

            if (tabs.TabPages.Count == 0)
                return;

            idx = tabs.SelectedIndex;

            // удаление документа
            DocumentHandler.DeleteDocument(index);
            // добавление контролов на вкладку
            tabs.SelectedTab.Controls.Add(container);
            redactor.TextChanged += redactor_TextChanged;
            // загрузка текста из документа
            LoadText();
        }

        private void CloseAllDocuments()
        {
            for (int i = 0; i < tabs.TabPages.Count; i++)
            {
                if (!DocumentHandler.OpenDocuments[i].Saved)
                {
                    SelectDocument(i);
                    SaveDocument(true);
                }
            }

            if (ConfigurationManager.CurrentConfig.SaveOpenedFiles)
            {
                DocumentHandler.Save();
            }
        }

        private void SelectDocument(int index)
        {
            // очистка выбранной вкладки
            tabs.SelectedTab.Controls.Clear();

            // выбор указанной вкладки
            tabs.SelectedIndex = index;

            // добавление контролов на вкладку
            tabs.SelectedTab.Controls.Add(container);
            redactor.TextChanged += redactor_TextChanged;
            // загрузка текста из документа
            LoadText();
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
            if (tabs.TabCount < ConfigurationManager.CurrentConfig.MaxTabs)
            {
                NewDocument();
                Highlight();
            }
            else
            {
                MessageBox.Show("Слишком много вкладок. Закройте лишние и попробуйте еще раз.");
            }
        }

        private void openToolBtn_Click(object sender, EventArgs e)
        {
            if (tabs.TabCount < ConfigurationManager.CurrentConfig.MaxTabs)
            {
                OpenDocument();
                Highlight();
            }
            else
            {
                MessageBox.Show("Слишком много вкладок. Закройте лишние и попробуйте еще раз.");
            }
        }

        private void saveToolBtn_Click(object sender, EventArgs e)
        {
            UpdateOpenedDocument();
            SaveDocument(false);
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
                        SaveDocument(true);
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

        private void tabs_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            //UpdateOpenDocument();
        }
    }
}
