namespace Calcul
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
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(492, 98);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(144, 23);
            this.multiplication.TabIndex = 0;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(492, 152);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(144, 23);
            this.division.TabIndex = 1;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.button2_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(492, 204);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(144, 23);
            this.percent.TabIndex = 2;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.button3_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(659, 98);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(144, 23);
            this.square.TabIndex = 3;
            this.square.Text = "^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.button4_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(659, 152);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(144, 23);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button5_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(659, 204);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(144, 23);
            this.min.TabIndex = 5;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.button6_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(492, 254);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(144, 23);
            this.sqrt.TabIndex = 6;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "10";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Результат вычисления";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Первое число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Второе число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(605, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Операторы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(163, 267);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 58);
            this.button8.TabIndex = 14;
            this.button8.Text = "sqrt(sin(x)-tg(y-x)^2)/cos(x)+sin(x-y)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(659, 254);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(144, 23);
            this.exp.TabIndex = 15;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 374);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.min);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.square);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button exp;
    }
}

