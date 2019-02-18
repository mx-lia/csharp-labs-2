namespace LR_1
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button18 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(304, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "С";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.control_buttons_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.control_buttons_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(168, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 47);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "√";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(246, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 47);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "∛";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(168, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 47);
            this.button5.TabIndex = 5;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(90, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(168, 239);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 47);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(90, 239);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 239);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 47);
            this.button10.TabIndex = 10;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(168, 292);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 47);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(90, 292);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 47);
            this.button12.TabIndex = 12;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 292);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 47);
            this.button13.TabIndex = 13;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 345);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 47);
            this.button14.TabIndex = 14;
            this.button14.Tag = "9";
            this.button14.Text = "±";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.control_buttons_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(90, 345);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 47);
            this.button15.TabIndex = 15;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(168, 345);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 47);
            this.button16.TabIndex = 16;
            this.button16.Tag = "10";
            this.button16.Text = ",";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.input_buttons_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(12, 70);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(72, 47);
            this.button17.TabIndex = 17;
            this.button17.Tag = "1";
            this.button17.Text = "x²";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(90, 70);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 47);
            this.button19.TabIndex = 19;
            this.button19.Tag = "2";
            this.button19.Text = "x³";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.Location = new System.Drawing.Point(246, 123);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 47);
            this.button21.TabIndex = 24;
            this.button21.Tag = "8";
            this.button21.Text = "ctg";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(168, 123);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 47);
            this.button22.TabIndex = 23;
            this.button22.Tag = "7";
            this.button22.Text = "tg";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(90, 123);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 47);
            this.button23.TabIndex = 22;
            this.button23.Tag = "6";
            this.button23.Text = "cos";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(12, 123);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 47);
            this.button24.TabIndex = 21;
            this.button24.Tag = "5";
            this.button24.Text = "sin";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.operation_buttons_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(246, 292);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 47);
            this.button18.TabIndex = 26;
            this.button18.Text = "save";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.control_buttons_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(246, 344);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 47);
            this.button20.TabIndex = 27;
            this.button20.Text = "extract";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.control_buttons_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(328, 403);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

