namespace Spring_Ball {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.g0 = new System.Windows.Forms.GroupBox();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.g11 = new System.Windows.Forms.GroupBox();
            this.n11 = new System.Windows.Forms.NumericUpDown();
            this.g2 = new System.Windows.Forms.GroupBox();
            this.g21 = new System.Windows.Forms.GroupBox();
            this.n21 = new System.Windows.Forms.NumericUpDown();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.g31 = new System.Windows.Forms.GroupBox();
            this.n31 = new System.Windows.Forms.NumericUpDown();
            this.g32 = new System.Windows.Forms.GroupBox();
            this.n32 = new System.Windows.Forms.NumericUpDown();
            this.g5 = new System.Windows.Forms.GroupBox();
            this.g6 = new System.Windows.Forms.GroupBox();
            this.g4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.g7 = new System.Windows.Forms.GroupBox();
            this.g0.SuspendLayout();
            this.g1.SuspendLayout();
            this.g11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n11)).BeginInit();
            this.g2.SuspendLayout();
            this.g21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n21)).BeginInit();
            this.g3.SuspendLayout();
            this.g31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n31)).BeginInit();
            this.g32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n32)).BeginInit();
            this.SuspendLayout();
            // 
            // g0
            // 
            this.g0.Controls.Add(this.g7);
            this.g0.Controls.Add(this.g1);
            this.g0.Controls.Add(this.g2);
            this.g0.Controls.Add(this.g3);
            this.g0.Controls.Add(this.g5);
            this.g0.Controls.Add(this.g6);
            this.g0.Controls.Add(this.g4);
            this.g0.Controls.Add(this.button2);
            this.g0.Controls.Add(this.button1);
            this.g0.Location = new System.Drawing.Point(12, 12);
            this.g0.Name = "g0";
            this.g0.Size = new System.Drawing.Size(300, 650);
            this.g0.TabIndex = 2;
            this.g0.TabStop = false;
            // 
            // g1
            // 
            this.g1.Controls.Add(this.g11);
            this.g1.Location = new System.Drawing.Point(6, 19);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(290, 80);
            this.g1.TabIndex = 10;
            this.g1.TabStop = false;
            this.g1.Text = "Інтервал оновлення системи, мс";
            // 
            // g11
            // 
            this.g11.Controls.Add(this.n11);
            this.g11.Location = new System.Drawing.Point(6, 19);
            this.g11.Name = "g11";
            this.g11.Size = new System.Drawing.Size(135, 50);
            this.g11.TabIndex = 0;
            this.g11.TabStop = false;
            this.g11.Text = "dt";
            // 
            // n11
            // 
            this.n11.Location = new System.Drawing.Point(6, 19);
            this.n11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.n11.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n11.Name = "n11";
            this.n11.Size = new System.Drawing.Size(120, 20);
            this.n11.TabIndex = 1;
            this.n11.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // g2
            // 
            this.g2.Controls.Add(this.g21);
            this.g2.Location = new System.Drawing.Point(6, 105);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(290, 80);
            this.g2.TabIndex = 9;
            this.g2.TabStop = false;
            this.g2.Text = "Коефіціент супротиву";
            // 
            // g21
            // 
            this.g21.Controls.Add(this.n21);
            this.g21.Location = new System.Drawing.Point(6, 19);
            this.g21.Name = "g21";
            this.g21.Size = new System.Drawing.Size(135, 50);
            this.g21.TabIndex = 0;
            this.g21.TabStop = false;
            this.g21.Text = "c";
            // 
            // n21
            // 
            this.n21.Location = new System.Drawing.Point(6, 19);
            this.n21.Name = "n21";
            this.n21.Size = new System.Drawing.Size(120, 20);
            this.n21.TabIndex = 1;
            // 
            // g3
            // 
            this.g3.Controls.Add(this.g31);
            this.g3.Controls.Add(this.g32);
            this.g3.Location = new System.Drawing.Point(6, 191);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(290, 80);
            this.g3.TabIndex = 8;
            this.g3.TabStop = false;
            this.g3.Text = "Кулі";
            // 
            // g31
            // 
            this.g31.Controls.Add(this.n31);
            this.g31.Location = new System.Drawing.Point(6, 19);
            this.g31.Name = "g31";
            this.g31.Size = new System.Drawing.Size(135, 50);
            this.g31.TabIndex = 3;
            this.g31.TabStop = false;
            this.g31.Text = "Кількість куль";
            // 
            // n31
            // 
            this.n31.Location = new System.Drawing.Point(6, 19);
            this.n31.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n31.Name = "n31";
            this.n31.Size = new System.Drawing.Size(120, 20);
            this.n31.TabIndex = 4;
            this.n31.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n31.ValueChanged += new System.EventHandler(this.CountValueChanged);
            // 
            // g32
            // 
            this.g32.Controls.Add(this.n32);
            this.g32.Location = new System.Drawing.Point(147, 19);
            this.g32.Name = "g32";
            this.g32.Size = new System.Drawing.Size(135, 50);
            this.g32.TabIndex = 4;
            this.g32.TabStop = false;
            this.g32.Text = "Розмір куль";
            // 
            // n32
            // 
            this.n32.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n32.Location = new System.Drawing.Point(6, 19);
            this.n32.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n32.Name = "n32";
            this.n32.Size = new System.Drawing.Size(120, 20);
            this.n32.TabIndex = 5;
            this.n32.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // g5
            // 
            this.g5.Location = new System.Drawing.Point(6, 363);
            this.g5.Name = "g5";
            this.g5.Size = new System.Drawing.Size(290, 80);
            this.g5.TabIndex = 7;
            this.g5.TabStop = false;
            this.g5.Text = "Відхилення куль, м";
            // 
            // g6
            // 
            this.g6.Location = new System.Drawing.Point(6, 449);
            this.g6.Name = "g6";
            this.g6.Size = new System.Drawing.Size(290, 80);
            this.g6.TabIndex = 6;
            this.g6.TabStop = false;
            this.g6.Text = "Коефіціенти жорсткості пружин, кг*м/(с^2) * 10^-3";
            // 
            // g4
            // 
            this.g4.Location = new System.Drawing.Point(6, 277);
            this.g4.Name = "g4";
            this.g4.Size = new System.Drawing.Size(290, 80);
            this.g4.TabIndex = 5;
            this.g4.TabStop = false;
            this.g4.Text = "Маси куль, кг";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(6, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Скасувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прийняти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // g7
            // 
            this.g7.Location = new System.Drawing.Point(6, 535);
            this.g7.Name = "g7";
            this.g7.Size = new System.Drawing.Size(290, 80);
            this.g7.TabIndex = 11;
            this.g7.TabStop = false;
            this.g7.Text = "Довжини пружин, м";
            // 
            // Form2
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(319, 671);
            this.ControlBox = false;
            this.Controls.Add(this.g0);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Налаштування";
            this.VisibleChanged += new System.EventHandler(this.Form2_VisibleChanged);
            this.g0.ResumeLayout(false);
            this.g1.ResumeLayout(false);
            this.g11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n11)).EndInit();
            this.g2.ResumeLayout(false);
            this.g21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n21)).EndInit();
            this.g3.ResumeLayout(false);
            this.g31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n31)).EndInit();
            this.g32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox g0;
        private System.Windows.Forms.GroupBox g32;
        private System.Windows.Forms.NumericUpDown n32;
        private System.Windows.Forms.GroupBox g31;
        private System.Windows.Forms.NumericUpDown n31;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.GroupBox g5;
        private System.Windows.Forms.GroupBox g6;
        private System.Windows.Forms.GroupBox g4;
        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.GroupBox g21;
        private System.Windows.Forms.NumericUpDown n21;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.GroupBox g11;
        private System.Windows.Forms.NumericUpDown n11;
        private System.Windows.Forms.GroupBox g7;
    }
}