namespace LR_2
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.seats = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.NumericUpDown();
            this.type = new System.Windows.Forms.ComboBox();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.ModelgroupBox = new System.Windows.Forms.GroupBox();
            this.partialSearch = new System.Windows.Forms.CheckBox();
            this.ignoreCase = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.ModelgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры поиска:";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(6, 21);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(353, 22);
            this.model.TabIndex = 1;
            // 
            // seats
            // 
            this.seats.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seats.Location = new System.Drawing.Point(157, 210);
            this.seats.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(220, 22);
            this.seats.TabIndex = 3;
            this.seats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип самолёта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество мест:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Грузоподъёмность:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(197, 298);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(180, 50);
            this.search.TabIndex = 24;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(11, 299);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(180, 49);
            this.reset.TabIndex = 25;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // load
            // 
            this.load.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.load.Location = new System.Drawing.Point(157, 254);
            this.load.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(220, 22);
            this.load.TabIndex = 26;
            this.load.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "пассажирский",
            "грузовой",
            "военный"});
            this.type.Location = new System.Drawing.Point(157, 168);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(220, 24);
            this.type.TabIndex = 2;
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchResult.DefaultCellStyle = dataGridViewCellStyle10;
            this.searchResult.Location = new System.Drawing.Point(399, 18);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.searchResult.RowHeadersWidth = 20;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.searchResult.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.searchResult.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.searchResult.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResult.RowTemplate.Height = 24;
            this.searchResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResult.Size = new System.Drawing.Size(630, 330);
            this.searchResult.TabIndex = 27;
            this.searchResult.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.searchResult_RowsAdded);
            // 
            // ModelgroupBox
            // 
            this.ModelgroupBox.Controls.Add(this.ignoreCase);
            this.ModelgroupBox.Controls.Add(this.partialSearch);
            this.ModelgroupBox.Controls.Add(this.model);
            this.ModelgroupBox.Location = new System.Drawing.Point(12, 37);
            this.ModelgroupBox.Name = "ModelgroupBox";
            this.ModelgroupBox.Size = new System.Drawing.Size(365, 113);
            this.ModelgroupBox.TabIndex = 28;
            this.ModelgroupBox.TabStop = false;
            this.ModelgroupBox.Text = "Название модели";
            // 
            // partialSearch
            // 
            this.partialSearch.AutoSize = true;
            this.partialSearch.Location = new System.Drawing.Point(7, 50);
            this.partialSearch.Name = "partialSearch";
            this.partialSearch.Size = new System.Drawing.Size(144, 21);
            this.partialSearch.TabIndex = 2;
            this.partialSearch.Text = "частичный поиск";
            this.partialSearch.UseVisualStyleBackColor = true;
            // 
            // ignoreCase
            // 
            this.ignoreCase.AutoSize = true;
            this.ignoreCase.Location = new System.Drawing.Point(7, 77);
            this.ignoreCase.Name = "ignoreCase";
            this.ignoreCase.Size = new System.Drawing.Size(153, 21);
            this.ignoreCase.TabIndex = 3;
            this.ignoreCase.Text = "игнорируя регистр";
            this.ignoreCase.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 363);
            this.Controls.Add(this.ModelgroupBox);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.load);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ModelgroupBox.ResumeLayout(false);
            this.ModelgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.NumericUpDown seats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.NumericUpDown load;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.DataGridView searchResult;
        private System.Windows.Forms.GroupBox ModelgroupBox;
        private System.Windows.Forms.CheckBox ignoreCase;
        private System.Windows.Forms.CheckBox partialSearch;
    }
}