namespace Spring_Ball
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.керуванняСистемоюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроСтанСистемиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графікиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальніВідхиленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роботаЗФайламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиПротоколToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиПротоколToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 142);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 38);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Час, с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.керуванняСистемоюToolStripMenuItem,
            this.інформаціяПроСтанСистемиToolStripMenuItem,
            this.роботаЗФайламиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // керуванняСистемоюToolStripMenuItem
            // 
            this.керуванняСистемоюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.стопToolStripMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.керуванняСистемоюToolStripMenuItem.Name = "керуванняСистемоюToolStripMenuItem";
            this.керуванняСистемоюToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.керуванняСистемоюToolStripMenuItem.Text = "Керування системою";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.стартToolStripMenuItem.Text = "Старт";
            this.стартToolStripMenuItem.Click += new System.EventHandler(this.стартToolStripMenuItem_Click);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Enabled = false;
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.паузаToolStripMenuItem.Text = "Пауза";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // стопToolStripMenuItem
            // 
            this.стопToolStripMenuItem.Enabled = false;
            this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            this.стопToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.стопToolStripMenuItem.Text = "Стоп";
            this.стопToolStripMenuItem.Click += new System.EventHandler(this.стопToolStripMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // інформаціяПроСтанСистемиToolStripMenuItem
            // 
            this.інформаціяПроСтанСистемиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графікиToolStripMenuItem,
            this.протоколToolStripMenuItem,
            this.максимальніВідхиленняToolStripMenuItem});
            this.інформаціяПроСтанСистемиToolStripMenuItem.Name = "інформаціяПроСтанСистемиToolStripMenuItem";
            this.інформаціяПроСтанСистемиToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.інформаціяПроСтанСистемиToolStripMenuItem.Text = "Інформація про стан системи";
            // 
            // графікиToolStripMenuItem
            // 
            this.графікиToolStripMenuItem.Enabled = false;
            this.графікиToolStripMenuItem.Name = "графікиToolStripMenuItem";
            this.графікиToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.графікиToolStripMenuItem.Text = "Графіки";
            this.графікиToolStripMenuItem.Click += new System.EventHandler(this.графікиToolStripMenuItem_Click);
            // 
            // протоколToolStripMenuItem
            // 
            this.протоколToolStripMenuItem.Enabled = false;
            this.протоколToolStripMenuItem.Name = "протоколToolStripMenuItem";
            this.протоколToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.протоколToolStripMenuItem.Text = "Протокол";
            this.протоколToolStripMenuItem.Click += new System.EventHandler(this.протоколToolStripMenuItem_Click);
            // 
            // максимальніВідхиленняToolStripMenuItem
            // 
            this.максимальніВідхиленняToolStripMenuItem.Enabled = false;
            this.максимальніВідхиленняToolStripMenuItem.Name = "максимальніВідхиленняToolStripMenuItem";
            this.максимальніВідхиленняToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.максимальніВідхиленняToolStripMenuItem.Text = "Максимальні відхилення";
            this.максимальніВідхиленняToolStripMenuItem.Click += new System.EventHandler(this.максимальніВідхиленняToolStripMenuItem_Click);
            // 
            // роботаЗФайламиToolStripMenuItem
            // 
            this.роботаЗФайламиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиПротоколToolStripMenuItem,
            this.завантажитиПротоколToolStripMenuItem});
            this.роботаЗФайламиToolStripMenuItem.Name = "роботаЗФайламиToolStripMenuItem";
            this.роботаЗФайламиToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.роботаЗФайламиToolStripMenuItem.Text = "Робота з файлами";
            // 
            // зберегтиПротоколToolStripMenuItem
            // 
            this.зберегтиПротоколToolStripMenuItem.Enabled = false;
            this.зберегтиПротоколToolStripMenuItem.Name = "зберегтиПротоколToolStripMenuItem";
            this.зберегтиПротоколToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.зберегтиПротоколToolStripMenuItem.Text = "Зберегти протокол";
            this.зберегтиПротоколToolStripMenuItem.Click += new System.EventHandler(this.зберегтиПротоколToolStripMenuItem_Click);
            // 
            // завантажитиПротоколToolStripMenuItem
            // 
            this.завантажитиПротоколToolStripMenuItem.Name = "завантажитиПротоколToolStripMenuItem";
            this.завантажитиПротоколToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.завантажитиПротоколToolStripMenuItem.Text = "Завантажити протокол";
            this.завантажитиПротоколToolStripMenuItem.Click += new System.EventHandler(this.завантажитиПротоколToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(663, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Пружини та м\'ячі";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem керуванняСистемоюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стопToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроСтанСистемиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графікиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роботаЗФайламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиПротоколToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиПротоколToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальніВідхиленняToolStripMenuItem;
    }
}

