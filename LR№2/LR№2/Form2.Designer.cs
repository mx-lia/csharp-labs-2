namespace LR_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TrackBar();
            this.reset = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.secondName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.ComboBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.experience = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.MinimumSize = new System.Drawing.Size(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(22, 29);
            this.surname.MaxLength = 20;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(276, 22);
            this.surname.TabIndex = 1;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharTextBoxes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Стаж";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(22, 74);
            this.name.MaxLength = 10;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(276, 22);
            this.name.TabIndex = 3;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharTextBoxes_KeyPress);
            // 
            // age
            // 
            this.age.LargeChange = 10;
            this.age.Location = new System.Drawing.Point(61, 167);
            this.age.Maximum = 65;
            this.age.Minimum = 18;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(237, 56);
            this.age.TabIndex = 8;
            this.age.Value = 18;
            this.age.Scroll += new System.EventHandler(this.Age_Scroll);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(22, 315);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(135, 40);
            this.reset.TabIndex = 13;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(163, 315);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 40);
            this.add.TabIndex = 14;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(22, 120);
            this.secondName.MaxLength = 15;
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(276, 22);
            this.secondName.TabIndex = 5;
            this.secondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharTextBoxes_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Должность";
            // 
            // work
            // 
            this.work.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.work.Items.AddRange(new object[] {
            "стюардесса",
            "первый пилот",
            "второй пилот",
            "бортмеханик",
            "бортовой радист",
            "штурман"});
            this.work.Location = new System.Drawing.Point(22, 229);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(276, 24);
            this.work.TabIndex = 10;
            this.work.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharTextBoxes_KeyPress);
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.Window;
            this.ageText.Enabled = false;
            this.ageText.Location = new System.Drawing.Point(22, 167);
            this.ageText.MaxLength = 4;
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(34, 22);
            this.ageText.TabIndex = 7;
            this.ageText.Text = "18";
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(22, 277);
            this.experience.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.experience.Name = "experience";
            this.experience.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.experience.Size = new System.Drawing.Size(276, 22);
            this.experience.TabIndex = 12;
            this.experience.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(322, 364);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(328, 411);
            this.Name = "Form2";
            this.Text = "Член экипажа";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TrackBar age;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox work;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.NumericUpDown experience;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}