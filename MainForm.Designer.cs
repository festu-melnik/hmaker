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
            this.newBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.redactor = new System.Windows.Forms.RichTextBox();
            this.view = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.BackgroundImage = global::HTMLCreator.Properties.Resources._new;
            this.newBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newBtn.Location = new System.Drawing.Point(10, 20);
            this.newBtn.Margin = new System.Windows.Forms.Padding(0);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(40, 40);
            this.newBtn.TabIndex = 0;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::HTMLCreator.Properties.Resources.edit;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.Location = new System.Drawing.Point(60, 20);
            this.editBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 40);
            this.editBtn.TabIndex = 0;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::HTMLCreator.Properties.Resources.save;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Location = new System.Drawing.Point(110, 20);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(40, 40);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = global::HTMLCreator.Properties.Resources.refresh;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Location = new System.Drawing.Point(160, 20);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(40, 40);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // redactor
            // 
            this.redactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redactor.BackColor = System.Drawing.Color.White;
            this.redactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redactor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redactor.Location = new System.Drawing.Point(10, 360);
            this.redactor.Margin = new System.Windows.Forms.Padding(10);
            this.redactor.Name = "redactor";
            this.redactor.Size = new System.Drawing.Size(765, 197);
            this.redactor.TabIndex = 1;
            this.redactor.Text = "";
            this.redactor.TextChanged += new System.EventHandler(this.redactor_TextChanged);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view.Location = new System.Drawing.Point(10, 70);
            this.view.Margin = new System.Windows.Forms.Padding(10);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(765, 270);
            this.view.TabIndex = 2;
            this.view.TabStop = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.view);
            this.Controls.Add(this.redactor);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newBtn);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "HTMLCreator";
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.RichTextBox redactor;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

