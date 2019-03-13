namespace LR_2
{
    partial class info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TrackBar();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.read = new System.Windows.Forms.Button();
            this.addAirplane = new System.Windows.Forms.Button();
            this.infoCrew = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.seats = new System.Windows.Forms.NumericUpDown();
            this.table = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.NumericUpDown();
            this.clearCrew = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sortToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.sortModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.objects = new System.Windows.Forms.ToolStripStatusLabel();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID самолёта";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(28, 148);
            this.model.MaxLength = 20;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(224, 22);
            this.model.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название модели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество пассажирских мест";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Год выпуска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Грузоподъёмность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата посл. тех. обслуживания";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(298, 134);
            this.year.Maximum = 2019;
            this.year.Minimum = 2000;
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(228, 56);
            this.year.TabIndex = 15;
            this.year.Value = 2000;
            this.year.Scroll += new System.EventHandler(this.Year_Scroll);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(298, 213);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(224, 22);
            this.date.TabIndex = 17;
            this.date.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(596, 319);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(180, 29);
            this.read.TabIndex = 22;
            this.read.Text = "Чтение из файла";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.SaveOrRead_Click);
            // 
            // addAirplane
            // 
            this.addAirplane.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addAirplane.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconPadding(this.addAirplane, 18);
            this.addAirplane.Location = new System.Drawing.Point(790, 288);
            this.addAirplane.Name = "addAirplane";
            this.addAirplane.Size = new System.Drawing.Size(224, 60);
            this.addAirplane.TabIndex = 23;
            this.addAirplane.Text = "Добавить";
            this.addAirplane.UseVisualStyleBackColor = false;
            this.addAirplane.Click += new System.EventHandler(this.AddAirplane_Click);
            // 
            // infoCrew
            // 
            this.infoCrew.FormattingEnabled = true;
            this.infoCrew.HorizontalScrollbar = true;
            this.infoCrew.Location = new System.Drawing.Point(596, 102);
            this.infoCrew.Name = "infoCrew";
            this.infoCrew.Size = new System.Drawing.Size(418, 174);
            this.infoCrew.TabIndex = 20;
            this.infoCrew.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.InfoCrew_ItemCheck);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Экипаж";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
            this.add.Location = new System.Drawing.Point(926, 71);
            this.add.Name = "add";
            this.add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add.Size = new System.Drawing.Size(41, 27);
            this.add.TabIndex = 19;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.CrewButtons_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(298, 319);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(180, 29);
            this.reset.TabIndex = 21;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(128, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "кг";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(28, 102);
            this.ID.MaxLength = 6;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(224, 22);
            this.ID.TabIndex = 1;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDigitTextBoxes_KeyPress);
            // 
            // yearText
            // 
            this.yearText.BackColor = System.Drawing.SystemColors.Window;
            this.yearText.Enabled = false;
            this.yearText.Location = new System.Drawing.Point(298, 102);
            this.yearText.MaxLength = 4;
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(86, 22);
            this.yearText.TabIndex = 14;
            this.yearText.Text = "2000";
            // 
            // type
            // 
            this.type.Controls.Add(this.radioButton3);
            this.type.Controls.Add(this.radioButton2);
            this.type.Controls.Add(this.radioButton1);
            this.type.Location = new System.Drawing.Point(28, 268);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(224, 84);
            this.type.TabIndex = 9;
            this.type.TabStop = false;
            this.type.Tag = "";
            this.type.Text = "Тип";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "военный";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 21);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "грузовой";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "пассажирский";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // seats
            // 
            this.seats.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seats.Location = new System.Drawing.Point(28, 194);
            this.seats.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.seats.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(69, 22);
            this.seats.TabIndex = 5;
            this.seats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seats.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Location = new System.Drawing.Point(28, 358);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.table.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.RowTemplate.Height = 24;
            this.table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table.Size = new System.Drawing.Size(986, 256);
            this.table.TabIndex = 25;
            this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Table_RowsAdded);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.save.Location = new System.Drawing.Point(596, 288);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 29);
            this.save.TabIndex = 24;
            this.save.Text = "Сохранить в файл";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.SaveOrRead_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Serialization.json";
            this.saveFileDialog1.Filter = "JSON files (*.json)|*.json|XML files files(*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JSON files (*.json)|*.json|XML files files(*.xml)|*.xml";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchToolStripMenuItem,
            this.SortToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem
            // 
            this.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            this.SearchToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.SearchToolStripMenuItem.Tag = "search";
            this.SearchToolStripMenuItem.Text = "Поиск";
            this.SearchToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModelToolStripMenuItem,
            this.DateToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.SortToolStripMenuItem.Tag = "";
            this.SortToolStripMenuItem.Text = "Сортировка";
            // 
            // ModelToolStripMenuItem
            // 
            this.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem";
            this.ModelToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.ModelToolStripMenuItem.Tag = "sortModel";
            this.ModelToolStripMenuItem.Text = "по названию модели";
            this.ModelToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(351, 26);
            this.DateToolStripMenuItem.Tag = "sortDate";
            this.DateToolStripMenuItem.Text = "по дате последнего тех.обслуживания";
            this.DateToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.SaveToolStripMenuItem.Tag = "save";
            this.SaveToolStripMenuItem.Text = "Сохранить посл. поиск";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.AboutProgramToolStripMenuItem.Tag = "aboutProgram";
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // load
            // 
            this.load.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.load.Location = new System.Drawing.Point(28, 243);
            this.load.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(69, 22);
            this.load.TabIndex = 27;
            this.load.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearCrew
            // 
            this.clearCrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.6F);
            this.clearCrew.Location = new System.Drawing.Point(973, 71);
            this.clearCrew.Name = "clearCrew";
            this.clearCrew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearCrew.Size = new System.Drawing.Size(41, 27);
            this.clearCrew.TabIndex = 28;
            this.clearCrew.Text = "×";
            this.clearCrew.UseVisualStyleBackColor = true;
            this.clearCrew.Click += new System.EventHandler(this.CrewButtons_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripButton,
            this.sortToolStripButton,
            this.cleanToolStripButton,
            this.toolStripSeparator1,
            this.deleteToolStripButton,
            this.saveToolStripButton,
            this.aboutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1042, 27);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sortToolStripButton
            // 
            this.sortToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortModelToolStripMenuItem,
            this.sortDateToolStripMenuItem});
            this.sortToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripButton.Image")));
            this.sortToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortToolStripButton.Name = "sortToolStripButton";
            this.sortToolStripButton.Size = new System.Drawing.Size(34, 24);
            this.sortToolStripButton.Tag = "sort";
            // 
            // sortModelToolStripMenuItem
            // 
            this.sortModelToolStripMenuItem.Name = "sortModelToolStripMenuItem";
            this.sortModelToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.sortModelToolStripMenuItem.Tag = "sortModel";
            this.sortModelToolStripMenuItem.Text = "по названию модели";
            this.sortModelToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // sortDateToolStripMenuItem
            // 
            this.sortDateToolStripMenuItem.Name = "sortDateToolStripMenuItem";
            this.sortDateToolStripMenuItem.Size = new System.Drawing.Size(355, 26);
            this.sortDateToolStripMenuItem.Tag = "sortDate";
            this.sortDateToolStripMenuItem.Text = "по дате последнего тех. обслуживания";
            this.sortDateToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // cleanToolStripButton
            // 
            this.cleanToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cleanToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cleanToolStripButton.Image")));
            this.cleanToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cleanToolStripButton.Name = "cleanToolStripButton";
            this.cleanToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.cleanToolStripButton.Tag = "clear";
            this.cleanToolStripButton.Click += new System.EventHandler(this.ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.deleteToolStripButton.Tag = "delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.ToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Tag = "save";
            this.saveToolStripButton.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.aboutToolStripButton.Tag = "aboutProgram";
            this.aboutToolStripButton.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objects,
            this.time,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1042, 25);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // objects
            // 
            this.objects.Name = "objects";
            this.objects.Size = new System.Drawing.Size(0, 20);
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.searchToolStripButton.Tag = "search";
            this.searchToolStripButton.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1042, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.clearCrew);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.table);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.type);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.infoCrew);
            this.Controls.Add(this.addAirplane);
            this.Controls.Add(this.read);
            this.Controls.Add(this.date);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1037, 601);
            this.Name = "info";
            this.Text = "Самолёт";
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.type.ResumeLayout(false);
            this.type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar year;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button addAirplane;
        private System.Windows.Forms.CheckedListBox infoCrew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.GroupBox type;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown seats;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown load;
        private System.Windows.Forms.Button clearCrew;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel objects;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.ToolStripButton cleanToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton sortToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem sortModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
    }
}

