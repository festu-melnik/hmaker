using HTMLCreator.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTMLCreator
{
    public partial class ConfigForm : Form
    {
        private Configuration newConfig;

        public ConfigForm()
        {
            InitializeComponent();

            newConfig = ConfigurationManager.CurrentConfig;

            LoadConfig();
            LoadColors();

            if (newConfig.Colors.Eqv(ColorTheme.Default))
                themes.SelectedIndex = 0;
            else if (newConfig.Colors.Eqv(ColorTheme.Oblivion))
                themes.SelectedIndex = 1;
            else
                themes.SelectedIndex = -1;
        }

        private void lookBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                filesPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void LoadConfig()
        {
            filesPath.Text = newConfig.FilesPath;
            saveOpenedFiles.Checked = newConfig.SaveOpenedFiles;
            replaceTabBySpaces.Checked = newConfig.ReplaceTabsBySpaces;
            tabWidth.Value = newConfig.TabWidth;
            tabWidth.Visible = newConfig.ReplaceTabsBySpaces;
            label4.Visible = newConfig.ReplaceTabsBySpaces;
            refreshRate.Value = newConfig.RefreshRate;
            maxTabs.Value = newConfig.MaxTabs;
            fontSize.Value = newConfig.FontSize;
        }

        private void LoadColors()
        {
            foreground.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Foreground);
            background.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Background);
            tokens.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Token);
            tags.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Tag);
            strings.BackColor = ColorTranslator.FromHtml(newConfig.Colors.String);
            numbers.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Number);
            comments.BackColor = ColorTranslator.FromHtml(newConfig.Colors.Comment);
        }

        private void filesPath_TextChanged(object sender, EventArgs e)
        {
            newConfig.FilesPath = filesPath.Text;
        }

        private void saveOpenedFiles_CheckedChanged(object sender, EventArgs e)
        {
            newConfig.SaveOpenedFiles = saveOpenedFiles.Checked;
        }

        private void replaceTabBySpaces_CheckedChanged(object sender, EventArgs e)
        {
            newConfig.ReplaceTabsBySpaces = replaceTabBySpaces.Checked;

            tabWidth.Visible = newConfig.ReplaceTabsBySpaces;
            label4.Visible = newConfig.ReplaceTabsBySpaces;
        }

        private void tabWidth_ValueChanged(object sender, EventArgs e)
        {
            newConfig.TabWidth = (byte)tabWidth.Value;
        }

        private void refreshRate_ValueChanged(object sender, EventArgs e)
        {
            newConfig.RefreshRate = (int)refreshRate.Value;
        }

        private void maxTabs_ValueChanged(object sender, EventArgs e)
        {
            newConfig.MaxTabs = (byte)maxTabs.Value;
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            newConfig.FontSize = (byte)fontSize.Value;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ConfigurationManager.CurrentConfig = newConfig;
            ConfigurationManager.SaveConfig();
            this.Close();
        }

        private void foreground_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Foreground = SetColor(foreground);
        }

        private void background_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Background = SetColor(background);
        }

        private void tokens_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Token = SetColor(tokens);
        }

        private void tags_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Tag = SetColor(tags);
        }

        private void strings_Click(object sender, EventArgs e)
        {
            newConfig.Colors.String = SetColor(strings);
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Number = SetColor(numbers);
        }

        private void comments_Click(object sender, EventArgs e)
        {
            newConfig.Colors.Comment = SetColor(comments);
        }

        private string SetColor(Button btn)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (btn.BackColor != colorDialog.Color)
                    themes.SelectedIndex = -1;
                btn.BackColor = colorDialog.Color;
            }

            return ColorTranslator.ToHtml(btn.BackColor);
        }

        private void themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (themes.SelectedIndex)
            {
                case 0:
                    newConfig.Colors = ColorTheme.Default;
                    break;
                case 1:
                    newConfig.Colors = ColorTheme.Oblivion;
                    break;
            }
            LoadColors();
        }
    }
}
