namespace HTMLCreator
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filesPath = new System.Windows.Forms.TextBox();
            this.lookBtn = new System.Windows.Forms.Button();
            this.saveOpenedFiles = new System.Windows.Forms.CheckBox();
            this.replaceTabBySpaces = new System.Windows.Forms.CheckBox();
            this.refreshRate = new System.Windows.Forms.NumericUpDown();
            this.maxTabs = new System.Windows.Forms.NumericUpDown();
            this.tabWidth = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colors = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.numbers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.strings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tags = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tokens = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.foreground = new System.Windows.Forms.Button();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.themes = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabWidth)).BeginInit();
            this.colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(366, 403);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(217, 403);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить и закрыть";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь по-умолчанию:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сохранять открытые файлы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Заменять символы табуляции пробелами:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Количество пробелов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Частота обновления (в сек.):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Максимальное количество вкладок:";
            // 
            // filesPath
            // 
            this.filesPath.Location = new System.Drawing.Point(240, 10);
            this.filesPath.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.filesPath.Name = "filesPath";
            this.filesPath.Size = new System.Drawing.Size(154, 20);
            this.filesPath.TabIndex = 2;
            this.filesPath.TextChanged += new System.EventHandler(this.filesPath_TextChanged);
            // 
            // lookBtn
            // 
            this.lookBtn.Location = new System.Drawing.Point(410, 9);
            this.lookBtn.Margin = new System.Windows.Forms.Padding(0);
            this.lookBtn.Name = "lookBtn";
            this.lookBtn.Size = new System.Drawing.Size(30, 20);
            this.lookBtn.TabIndex = 0;
            this.lookBtn.Text = "...";
            this.lookBtn.UseVisualStyleBackColor = true;
            this.lookBtn.Click += new System.EventHandler(this.lookBtn_Click);
            // 
            // saveOpenedFiles
            // 
            this.saveOpenedFiles.AutoSize = true;
            this.saveOpenedFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveOpenedFiles.Location = new System.Drawing.Point(240, 47);
            this.saveOpenedFiles.Name = "saveOpenedFiles";
            this.saveOpenedFiles.Size = new System.Drawing.Size(13, 12);
            this.saveOpenedFiles.TabIndex = 3;
            this.saveOpenedFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.saveOpenedFiles.UseVisualStyleBackColor = true;
            this.saveOpenedFiles.CheckedChanged += new System.EventHandler(this.saveOpenedFiles_CheckedChanged);
            // 
            // replaceTabBySpaces
            // 
            this.replaceTabBySpaces.AutoSize = true;
            this.replaceTabBySpaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replaceTabBySpaces.Location = new System.Drawing.Point(240, 80);
            this.replaceTabBySpaces.Name = "replaceTabBySpaces";
            this.replaceTabBySpaces.Size = new System.Drawing.Size(13, 12);
            this.replaceTabBySpaces.TabIndex = 3;
            this.replaceTabBySpaces.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.replaceTabBySpaces.UseVisualStyleBackColor = true;
            this.replaceTabBySpaces.CheckedChanged += new System.EventHandler(this.replaceTabBySpaces_CheckedChanged);
            // 
            // refreshRate
            // 
            this.refreshRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refreshRate.Location = new System.Drawing.Point(240, 110);
            this.refreshRate.Margin = new System.Windows.Forms.Padding(0);
            this.refreshRate.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.refreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshRate.Name = "refreshRate";
            this.refreshRate.Size = new System.Drawing.Size(73, 20);
            this.refreshRate.TabIndex = 4;
            this.refreshRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.refreshRate.ValueChanged += new System.EventHandler(this.refreshRate_ValueChanged);
            // 
            // maxTabs
            // 
            this.maxTabs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTabs.Location = new System.Drawing.Point(240, 143);
            this.maxTabs.Margin = new System.Windows.Forms.Padding(0);
            this.maxTabs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxTabs.Name = "maxTabs";
            this.maxTabs.Size = new System.Drawing.Size(73, 20);
            this.maxTabs.TabIndex = 4;
            this.maxTabs.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxTabs.ValueChanged += new System.EventHandler(this.maxTabs_ValueChanged);
            // 
            // tabWidth
            // 
            this.tabWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabWidth.Location = new System.Drawing.Point(400, 77);
            this.tabWidth.Margin = new System.Windows.Forms.Padding(0);
            this.tabWidth.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.tabWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tabWidth.Name = "tabWidth";
            this.tabWidth.Size = new System.Drawing.Size(40, 20);
            this.tabWidth.TabIndex = 4;
            this.tabWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tabWidth.ValueChanged += new System.EventHandler(this.tabWidth_ValueChanged);
            // 
            // colors
            // 
            this.colors.Controls.Add(this.themes);
            this.colors.Controls.Add(this.label14);
            this.colors.Controls.Add(this.label13);
            this.colors.Controls.Add(this.label12);
            this.colors.Controls.Add(this.comments);
            this.colors.Controls.Add(this.label11);
            this.colors.Controls.Add(this.numbers);
            this.colors.Controls.Add(this.label10);
            this.colors.Controls.Add(this.strings);
            this.colors.Controls.Add(this.label15);
            this.colors.Controls.Add(this.label7);
            this.colors.Controls.Add(this.tags);
            this.colors.Controls.Add(this.label8);
            this.colors.Controls.Add(this.tokens);
            this.colors.Controls.Add(this.background);
            this.colors.Controls.Add(this.foreground);
            this.colors.Location = new System.Drawing.Point(29, 216);
            this.colors.Margin = new System.Windows.Forms.Padding(20);
            this.colors.Name = "colors";
            this.colors.Padding = new System.Windows.Forms.Padding(10);
            this.colors.Size = new System.Drawing.Size(392, 167);
            this.colors.TabIndex = 5;
            this.colors.TabStop = false;
            this.colors.Text = "Настройки цветов";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 141);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Коментарии:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Числа:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Строки:";
            // 
            // comments
            // 
            this.comments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comments.Location = new System.Drawing.Point(347, 137);
            this.comments.Margin = new System.Windows.Forms.Padding(0);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(30, 20);
            this.comments.TabIndex = 0;
            this.comments.Text = "...";
            this.comments.UseVisualStyleBackColor = true;
            this.comments.Click += new System.EventHandler(this.comments_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Теги:";
            // 
            // numbers
            // 
            this.numbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numbers.Location = new System.Drawing.Point(347, 104);
            this.numbers.Margin = new System.Windows.Forms.Padding(0);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(30, 20);
            this.numbers.TabIndex = 0;
            this.numbers.Text = "...";
            this.numbers.UseVisualStyleBackColor = true;
            this.numbers.Click += new System.EventHandler(this.numbers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Токены:";
            // 
            // strings
            // 
            this.strings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strings.Location = new System.Drawing.Point(347, 71);
            this.strings.Margin = new System.Windows.Forms.Padding(0);
            this.strings.Name = "strings";
            this.strings.Size = new System.Drawing.Size(30, 20);
            this.strings.TabIndex = 0;
            this.strings.Text = "...";
            this.strings.UseVisualStyleBackColor = true;
            this.strings.Click += new System.EventHandler(this.strings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Текст:";
            // 
            // tags
            // 
            this.tags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tags.Location = new System.Drawing.Point(223, 104);
            this.tags.Margin = new System.Windows.Forms.Padding(0);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(30, 20);
            this.tags.TabIndex = 0;
            this.tags.Text = "...";
            this.tags.UseVisualStyleBackColor = true;
            this.tags.Click += new System.EventHandler(this.tags_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Фон:";
            // 
            // tokens
            // 
            this.tokens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tokens.Location = new System.Drawing.Point(223, 71);
            this.tokens.Margin = new System.Windows.Forms.Padding(0);
            this.tokens.Name = "tokens";
            this.tokens.Size = new System.Drawing.Size(30, 20);
            this.tokens.TabIndex = 0;
            this.tokens.Text = "...";
            this.tokens.UseVisualStyleBackColor = true;
            this.tokens.Click += new System.EventHandler(this.tokens_Click);
            // 
            // background
            // 
            this.background.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.background.Location = new System.Drawing.Point(60, 104);
            this.background.Margin = new System.Windows.Forms.Padding(0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(30, 20);
            this.background.TabIndex = 0;
            this.background.Text = "...";
            this.background.UseVisualStyleBackColor = true;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // foreground
            // 
            this.foreground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreground.Location = new System.Drawing.Point(60, 71);
            this.foreground.Margin = new System.Windows.Forms.Padding(0);
            this.foreground.Name = "foreground";
            this.foreground.Size = new System.Drawing.Size(30, 20);
            this.foreground.TabIndex = 0;
            this.foreground.Text = "...";
            this.foreground.UseVisualStyleBackColor = true;
            this.foreground.Click += new System.EventHandler(this.foreground_Click);
            // 
            // fontSize
            // 
            this.fontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fontSize.Location = new System.Drawing.Point(240, 176);
            this.fontSize.Margin = new System.Windows.Forms.Padding(0);
            this.fontSize.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(73, 20);
            this.fontSize.TabIndex = 4;
            this.fontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Размер шрифта:";
            // 
            // themes
            // 
            this.themes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themes.FormattingEnabled = true;
            this.themes.Items.AddRange(new object[] {
            "Standart",
            "Oblivion"});
            this.themes.Location = new System.Drawing.Point(60, 19);
            this.themes.Name = "themes";
            this.themes.Size = new System.Drawing.Size(121, 21);
            this.themes.TabIndex = 2;
            this.themes.SelectedIndexChanged += new System.EventHandler(this.themes_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Схема:";
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(450, 435);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.maxTabs);
            this.Controls.Add(this.tabWidth);
            this.Controls.Add(this.refreshRate);
            this.Controls.Add(this.replaceTabBySpaces);
            this.Controls.Add(this.saveOpenedFiles);
            this.Controls.Add(this.filesPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lookBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.refreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabWidth)).EndInit();
            this.colors.ResumeLayout(false);
            this.colors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filesPath;
        private System.Windows.Forms.Button lookBtn;
        private System.Windows.Forms.CheckBox saveOpenedFiles;
        private System.Windows.Forms.CheckBox replaceTabBySpaces;
        private System.Windows.Forms.NumericUpDown refreshRate;
        private System.Windows.Forms.NumericUpDown maxTabs;
        private System.Windows.Forms.NumericUpDown tabWidth;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox colors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Button background;
        private System.Windows.Forms.Button foreground;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button tokens;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button comments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button numbers;
        private System.Windows.Forms.Button strings;
        private System.Windows.Forms.Button tags;
        private System.Windows.Forms.ComboBox themes;
        private System.Windows.Forms.Label label15;
    }
}