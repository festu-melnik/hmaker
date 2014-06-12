namespace HTMLCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.hglUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.grfUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tools = new System.Windows.Forms.ToolStrip();
            this.newToolBtn = new System.Windows.Forms.ToolStripButton();
            this.openToolBtn = new System.Windows.Forms.ToolStripButton();
            this.saveToolBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshToolBtn = new System.Windows.Forms.ToolStripButton();
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.tagsToolBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolBtn = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab = new System.Windows.Forms.TabPage();
            this.container = new System.Windows.Forms.SplitContainer();
            this.view = new System.Windows.Forms.PictureBox();
            this.redactor = new System.Windows.Forms.RichTextBox();
            this.tools.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.container.Panel1.SuspendLayout();
            this.container.Panel2.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "html";
            this.saveFileDialog.FileName = "newfile.html";
            this.saveFileDialog.Filter = "HTML Files(*.html;*.htm)|*.html;*.htm";
            this.saveFileDialog.InitialDirectory = "Environment.SpecialFolders.MyDocuments";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "html";
            this.openFileDialog.Filter = "HTML Files(*.html;*.htm)|*.html;*.htm";
            this.openFileDialog.InitialDirectory = "Environment.SpecialFolders.MyDocuments";
            // 
            // hglUpdateTimer
            // 
            this.hglUpdateTimer.Interval = 500;
            this.hglUpdateTimer.Tick += new System.EventHandler(this.hglUpdateTimer_Tick);
            // 
            // grfUpdateTimer
            // 
            this.grfUpdateTimer.Interval = 5000;
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolBtn,
            this.openToolBtn,
            this.saveToolBtn,
            this.refreshToolBtn,
            this.separator,
            this.tagsToolBtn,
            this.settingsToolBtn});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tools.Size = new System.Drawing.Size(1062, 55);
            this.tools.TabIndex = 4;
            this.tools.Text = "Меню";
            // 
            // newToolBtn
            // 
            this.newToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolBtn.Image = global::HTMLCreator.Properties.Resources._new;
            this.newToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.newToolBtn.Name = "newToolBtn";
            this.newToolBtn.Size = new System.Drawing.Size(52, 52);
            this.newToolBtn.Text = "Новый";
            this.newToolBtn.Click += new System.EventHandler(this.newToolBtn_Click);
            // 
            // openToolBtn
            // 
            this.openToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolBtn.Image = global::HTMLCreator.Properties.Resources.edit;
            this.openToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.openToolBtn.Name = "openToolBtn";
            this.openToolBtn.Size = new System.Drawing.Size(52, 52);
            this.openToolBtn.Text = "Открыть";
            this.openToolBtn.Click += new System.EventHandler(this.openToolBtn_Click);
            // 
            // saveToolBtn
            // 
            this.saveToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolBtn.Image = global::HTMLCreator.Properties.Resources.save;
            this.saveToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.saveToolBtn.Name = "saveToolBtn";
            this.saveToolBtn.Size = new System.Drawing.Size(52, 52);
            this.saveToolBtn.Text = "Сохранить";
            this.saveToolBtn.Click += new System.EventHandler(this.saveToolBtn_Click);
            // 
            // refreshToolBtn
            // 
            this.refreshToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolBtn.Image = global::HTMLCreator.Properties.Resources.refresh;
            this.refreshToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.refreshToolBtn.Name = "refreshToolBtn";
            this.refreshToolBtn.Size = new System.Drawing.Size(52, 52);
            this.refreshToolBtn.Text = "Обновить";
            this.refreshToolBtn.Click += new System.EventHandler(this.refreshToolBtn_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(6, 55);
            // 
            // tagsToolBtn
            // 
            this.tagsToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tagsToolBtn.Image = global::HTMLCreator.Properties.Resources.tag_add;
            this.tagsToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tagsToolBtn.Name = "tagsToolBtn";
            this.tagsToolBtn.Size = new System.Drawing.Size(61, 52);
            this.tagsToolBtn.Text = "Добавить тег";
            this.tagsToolBtn.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tagsToolBtn_DropDownItemClicked);
            // 
            // settingsToolBtn
            // 
            this.settingsToolBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolBtn.Image = global::HTMLCreator.Properties.Resources.settings;
            this.settingsToolBtn.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.settingsToolBtn.Name = "settingsToolBtn";
            this.settingsToolBtn.Size = new System.Drawing.Size(52, 52);
            this.settingsToolBtn.Text = "Настройки";
            this.settingsToolBtn.Click += new System.EventHandler(this.settingsToolBtn_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabs.ItemSize = new System.Drawing.Size(100, 20);
            this.tabs.Location = new System.Drawing.Point(0, 55);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1062, 507);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 5;
            this.tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabs_DrawItem);
            this.tabs.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_Deselecting);
            this.tabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabs_MouseDown);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.container);
            this.tab.Location = new System.Drawing.Point(4, 24);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(1054, 479);
            this.tab.TabIndex = 0;
            this.tab.Text = "temp";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(3, 3);
            this.container.Name = "container";
            this.container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // container.Panel1
            // 
            this.container.Panel1.Controls.Add(this.view);
            // 
            // container.Panel2
            // 
            this.container.Panel2.Controls.Add(this.redactor);
            this.container.Size = new System.Drawing.Size(1048, 473);
            this.container.SplitterDistance = 328;
            this.container.TabIndex = 5;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Image = global::HTMLCreator.Properties.Resources.delete_hover;
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Margin = new System.Windows.Forms.Padding(2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1048, 328);
            this.view.TabIndex = 4;
            this.view.TabStop = false;
            // 
            // redactor
            // 
            this.redactor.AcceptsTab = true;
            this.redactor.BackColor = System.Drawing.Color.White;
            this.redactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redactor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redactor.Location = new System.Drawing.Point(0, 0);
            this.redactor.Margin = new System.Windows.Forms.Padding(2);
            this.redactor.Name = "redactor";
            this.redactor.Size = new System.Drawing.Size(1048, 141);
            this.redactor.TabIndex = 3;
            this.redactor.Text = "";
            this.redactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.redactor_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 562);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.tools);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "HTMLCreator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tab.ResumeLayout(false);
            this.container.Panel1.ResumeLayout(false);
            this.container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer hglUpdateTimer;
        private System.Windows.Forms.Timer grfUpdateTimer;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton newToolBtn;
        private System.Windows.Forms.ToolStripButton openToolBtn;
        private System.Windows.Forms.ToolStripButton saveToolBtn;
        private System.Windows.Forms.ToolStripButton refreshToolBtn;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripDropDownButton tagsToolBtn;
        private System.Windows.Forms.ToolStripButton settingsToolBtn;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.RichTextBox redactor;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.SplitContainer container;
    }
}

