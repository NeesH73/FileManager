namespace FileManager
{
    partial class Form1
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
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsearchleft = new System.Windows.Forms.Button();
            this.btnsearchright = new System.Windows.Forms.Button();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.btnbackleft = new System.Windows.Forms.Button();
            this.btnbackright = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сжатьВАрхивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Location = new System.Drawing.Point(55, 48);
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.Size = new System.Drawing.Size(289, 20);
            this.textBoxLeft.TabIndex = 2;
            // 
            // textBoxRight
            // 
            this.textBoxRight.Location = new System.Drawing.Point(469, 48);
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.Size = new System.Drawing.Size(267, 20);
            this.textBoxRight.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.размерШрифтаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // размерШрифтаToolStripMenuItem
            // 
            this.размерШрифтаToolStripMenuItem.Name = "размерШрифтаToolStripMenuItem";
            this.размерШрифтаToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.размерШрифтаToolStripMenuItem.Text = "Размер шрифта";
            this.размерШрифтаToolStripMenuItem.Click += new System.EventHandler(this.размерШрифтаToolStripMenuItem_Click);
            // 
            // btnsearchleft
            // 
            this.btnsearchleft.Location = new System.Drawing.Point(350, 48);
            this.btnsearchleft.Name = "btnsearchleft";
            this.btnsearchleft.Size = new System.Drawing.Size(58, 20);
            this.btnsearchleft.TabIndex = 10;
            this.btnsearchleft.Text = "Перейти";
            this.btnsearchleft.UseVisualStyleBackColor = true;
            this.btnsearchleft.Click += new System.EventHandler(this.btnsearchleft_Click);
            // 
            // btnsearchright
            // 
            this.btnsearchright.Location = new System.Drawing.Point(742, 48);
            this.btnsearchright.Name = "btnsearchright";
            this.btnsearchright.Size = new System.Drawing.Size(58, 20);
            this.btnsearchright.TabIndex = 11;
            this.btnsearchright.Text = "Перейти";
            this.btnsearchright.UseVisualStyleBackColor = true;
            this.btnsearchright.Click += new System.EventHandler(this.btnsearchright_Click);
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.Location = new System.Drawing.Point(3, 74);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.Size = new System.Drawing.Size(405, 381);
            this.listBoxLeft.TabIndex = 12;
            this.listBoxLeft.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxLeft_MouseDoubleClick);
            this.listBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxLeft_MouseUp);
            // 
            // listBoxRight
            // 
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.Location = new System.Drawing.Point(414, 74);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(386, 381);
            this.listBoxRight.TabIndex = 13;
            this.listBoxRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRight_MouseDoubleClick);
            this.listBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxRight_MouseUp);
            // 
            // btnbackleft
            // 
            this.btnbackleft.Location = new System.Drawing.Point(0, 48);
            this.btnbackleft.Name = "btnbackleft";
            this.btnbackleft.Size = new System.Drawing.Size(49, 20);
            this.btnbackleft.TabIndex = 14;
            this.btnbackleft.Text = "Назад";
            this.btnbackleft.UseVisualStyleBackColor = true;
            this.btnbackleft.Click += new System.EventHandler(this.btnbackleft_Click);
            // 
            // btnbackright
            // 
            this.btnbackright.Location = new System.Drawing.Point(414, 48);
            this.btnbackright.Name = "btnbackright";
            this.btnbackright.Size = new System.Drawing.Size(49, 20);
            this.btnbackright.TabIndex = 15;
            this.btnbackright.Text = "Назад";
            this.btnbackright.UseVisualStyleBackColor = true;
            this.btnbackright.Click += new System.EventHandler(this.btnbackright_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПапкуToolStripMenuItem,
            this.создатьФайлToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.свойствоToolStripMenuItem,
            this.сжатьВАрхивToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 158);
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            this.создатьПапкуToolStripMenuItem.Click += new System.EventHandler(this.создатьПапкуToolStripMenuItem_Click);
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл";
            this.создатьФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьФайлToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // свойствоToolStripMenuItem
            // 
            this.свойствоToolStripMenuItem.Name = "свойствоToolStripMenuItem";
            this.свойствоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.свойствоToolStripMenuItem.Text = "Свойство";
            
            // 
            // сжатьВАрхивToolStripMenuItem
            // 
            this.сжатьВАрхивToolStripMenuItem.Name = "сжатьВАрхивToolStripMenuItem";
            this.сжатьВАрхивToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.сжатьВАрхивToolStripMenuItem.Text = "Сжать в архив";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 180);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem1.Text = "Создать папку";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "Создать файл";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem3.Text = "Удалить";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem4.Text = "Переименовать";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem5.Text = "Копировать";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Свойство";
            
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem7.Text = "Сжать в архив";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnbackright);
            this.Controls.Add(this.btnbackleft);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.Controls.Add(this.btnsearchright);
            this.Controls.Add(this.btnsearchleft);
            this.Controls.Add(this.textBoxRight);
            this.Controls.Add(this.textBoxLeft);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерШрифтаToolStripMenuItem;
        private System.Windows.Forms.Button btnsearchleft;
        private System.Windows.Forms.Button btnsearchright;
        private System.Windows.Forms.ListBox listBoxLeft;
        private System.Windows.Forms.ListBox listBoxRight;
        private System.Windows.Forms.Button btnbackleft;
        private System.Windows.Forms.Button btnbackright;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сжатьВАрхивToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

