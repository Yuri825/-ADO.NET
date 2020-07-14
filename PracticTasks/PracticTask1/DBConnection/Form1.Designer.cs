namespace DBConnection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСБазойДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяОтБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСБазойДанныхToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСБазойДанныхToolStripMenuItem
            // 
            this.работаСБазойДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБазеДанныхToolStripMenuItem,
            this.отключитьсяОтБазыДанныхToolStripMenuItem,
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem});
            this.работаСБазойДанныхToolStripMenuItem.Name = "работаСБазойДанныхToolStripMenuItem";
            this.работаСБазойДанныхToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.работаСБазойДанныхToolStripMenuItem.Text = "Работа с базой данных";
            // 
            // подключитьсяКБазеДанныхToolStripMenuItem
            // 
            this.подключитьсяКБазеДанныхToolStripMenuItem.Name = "подключитьсяКБазеДанныхToolStripMenuItem";
            this.подключитьсяКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.подключитьсяКБазеДанныхToolStripMenuItem.Text = "Подключиться к базе данных";
            this.подключитьсяКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКБазеДанныхToolStripMenuItem_Click);
            // 
            // отключитьсяОтБазыДанныхToolStripMenuItem
            // 
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Name = "отключитьсяОтБазыДанныхToolStripMenuItem";
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Text = "Отключиться от базы данных";
            this.отключитьсяОтБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяОтБазыДанныхToolStripMenuItem_Click);
            // 
            // асинхронноеПодключениеКБазеДанныхToolStripMenuItem
            // 
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Name = "асинхронноеПодключениеКБазеДанныхToolStripMenuItem";
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(308, 22);
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Text = "Асинхронное подключение к базе данных";
            this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.асинхронноеПодключениеКБазеДанныхToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСБазойДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяОтБазыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асинхронноеПодключениеКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
    }
}

