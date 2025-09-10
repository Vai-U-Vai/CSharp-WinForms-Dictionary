namespace Dictionary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Dict_menuStrip = new System.Windows.Forms.MenuStrip();
            this.dictMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.word_richTextBox = new System.Windows.Forms.RichTextBox();
            this.translate_richTextBox = new System.Windows.Forms.RichTextBox();
            this.left_textBox = new System.Windows.Forms.TextBox();
            this.right_textBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.topicInfo_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_StripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Translate_button = new System.Windows.Forms.Button();
            this.changeLanguage_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.delWordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dict_menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dict_menuStrip
            // 
            this.Dict_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictMenuItem});
            this.Dict_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Dict_menuStrip.Name = "Dict_menuStrip";
            this.Dict_menuStrip.Size = new System.Drawing.Size(805, 24);
            this.Dict_menuStrip.TabIndex = 0;
            this.Dict_menuStrip.Text = "Загрузить";
            // 
            // dictMenuItem
            // 
            this.dictMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.createMenuItem,
            this.showAllMenuItem,
            this.redactMenuItem});
            this.dictMenuItem.Name = "dictMenuItem";
            this.dictMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dictMenuItem.Text = "Словарь";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMenuItem.Text = "Загрузить";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Сохранить";
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            this.createMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createMenuItem.Text = "Создать";
            // 
            // showAllMenuItem
            // 
            this.showAllMenuItem.Name = "showAllMenuItem";
            this.showAllMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllMenuItem.Text = "Показать";
            this.showAllMenuItem.Click += new System.EventHandler(this.showAllMenuItem_Click);
            // 
            // redactMenuItem
            // 
            this.redactMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordMenuItem,
            this.delWordMenuItem,
            this.редактироватьToolStripMenuItem});
            this.redactMenuItem.Name = "redactMenuItem";
            this.redactMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redactMenuItem.Text = "Редактировать";
            // 
            // addWordMenuItem
            // 
            this.addWordMenuItem.Name = "addWordMenuItem";
            this.addWordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addWordMenuItem.Text = "Добавить слово";
            this.addWordMenuItem.Click += new System.EventHandler(this.addWordMenuItem_Click);
            // 
            // word_richTextBox
            // 
            this.word_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.word_richTextBox.Location = new System.Drawing.Point(13, 56);
            this.word_richTextBox.Name = "word_richTextBox";
            this.word_richTextBox.Size = new System.Drawing.Size(370, 206);
            this.word_richTextBox.TabIndex = 1;
            this.word_richTextBox.Text = "";
            // 
            // translate_richTextBox
            // 
            this.translate_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translate_richTextBox.Location = new System.Drawing.Point(427, 56);
            this.translate_richTextBox.Name = "translate_richTextBox";
            this.translate_richTextBox.Size = new System.Drawing.Size(370, 206);
            this.translate_richTextBox.TabIndex = 2;
            this.translate_richTextBox.Text = "";
            // 
            // left_textBox
            // 
            this.left_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left_textBox.Location = new System.Drawing.Point(14, 27);
            this.left_textBox.Name = "left_textBox";
            this.left_textBox.ReadOnly = true;
            this.left_textBox.Size = new System.Drawing.Size(369, 23);
            this.left_textBox.TabIndex = 4;
            // 
            // right_textBox
            // 
            this.right_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right_textBox.Location = new System.Drawing.Point(428, 27);
            this.right_textBox.Name = "right_textBox";
            this.right_textBox.ReadOnly = true;
            this.right_textBox.Size = new System.Drawing.Size(369, 23);
            this.right_textBox.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicInfo_StatusLabel,
            this.info_StripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(805, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // topicInfo_StatusLabel
            // 
            this.topicInfo_StatusLabel.Name = "topicInfo_StatusLabel";
            this.topicInfo_StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // info_StripStatusLabel
            // 
            this.info_StripStatusLabel.Name = "info_StripStatusLabel";
            this.info_StripStatusLabel.Size = new System.Drawing.Size(34, 17);
            this.info_StripStatusLabel.Text = "Тема";
            // 
            // Translate_button
            // 
            this.Translate_button.Image = global::Dictionary.Properties.Resources.doubleRight;
            this.Translate_button.Location = new System.Drawing.Point(389, 135);
            this.Translate_button.Name = "Translate_button";
            this.Translate_button.Size = new System.Drawing.Size(32, 23);
            this.Translate_button.TabIndex = 9;
            this.Translate_button.UseVisualStyleBackColor = true;
            this.Translate_button.Click += new System.EventHandler(this.Translate_button_Click);
            // 
            // changeLanguage_button
            // 
            this.changeLanguage_button.Image = global::Dictionary.Properties.Resources.arrow3;
            this.changeLanguage_button.Location = new System.Drawing.Point(389, 27);
            this.changeLanguage_button.Name = "changeLanguage_button";
            this.changeLanguage_button.Size = new System.Drawing.Size(32, 23);
            this.changeLanguage_button.TabIndex = 3;
            this.changeLanguage_button.UseVisualStyleBackColor = true;
            this.changeLanguage_button.Click += new System.EventHandler(this.changeLanguage_button_Click);
            // 
            // delWordMenuItem
            // 
            this.delWordMenuItem.Name = "delWordMenuItem";
            this.delWordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delWordMenuItem.Text = "Удалить слово";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 285);
            this.Controls.Add(this.Translate_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.right_textBox);
            this.Controls.Add(this.left_textBox);
            this.Controls.Add(this.changeLanguage_button);
            this.Controls.Add(this.translate_richTextBox);
            this.Controls.Add(this.word_richTextBox);
            this.Controls.Add(this.Dict_menuStrip);
            this.MainMenuStrip = this.Dict_menuStrip;
            this.Name = "MainForm";
            this.Text = "Dictionary";
            this.Dict_menuStrip.ResumeLayout(false);
            this.Dict_menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Dict_menuStrip;
        private System.Windows.Forms.RichTextBox word_richTextBox;
        private System.Windows.Forms.RichTextBox translate_richTextBox;
        private System.Windows.Forms.Button changeLanguage_button;
        private System.Windows.Forms.ToolStripMenuItem dictMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.TextBox left_textBox;
        private System.Windows.Forms.TextBox right_textBox;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redactMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel topicInfo_StatusLabel;
        private System.Windows.Forms.Button Translate_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel info_StripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem delWordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
    }
}

