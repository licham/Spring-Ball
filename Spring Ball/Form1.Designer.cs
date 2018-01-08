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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Відновлення";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numericUpDown10);
            this.groupBox11.Location = new System.Drawing.Point(6, 131);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(99, 50);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Відхилення x3";
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown10.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown10.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown10.TabIndex = 2;
            this.numericUpDown10.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numericUpDown9);
            this.groupBox10.Location = new System.Drawing.Point(6, 75);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(99, 50);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Відхилення x2";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown9.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown9.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown9.TabIndex = 2;
            this.numericUpDown9.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numericUpDown8);
            this.groupBox9.Location = new System.Drawing.Point(6, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(99, 50);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Відхилення x1";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown8.TabIndex = 2;
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.NumericUpDownX_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(131, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Налаштування";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Стоп";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 657);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Пружини та м\'ячі";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

