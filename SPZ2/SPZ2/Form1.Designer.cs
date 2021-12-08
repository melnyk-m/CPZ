namespace SPZ2
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.button_eviction = new System.Windows.Forms.Button();
            this.numericUpDown_increase = new System.Windows.Forms.NumericUpDown();
            this.button_increase_room = new System.Windows.Forms.Button();
            this.button_income_year = new System.Windows.Forms.Button();
            this.button_income_month = new System.Windows.Forms.Button();
            this.button_income_half_year = new System.Windows.Forms.Button();
            this.button_canteen = new System.Windows.Forms.Button();
            this.numericUpDown_settling = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_eviction = new System.Windows.Forms.NumericUpDown();
            this.button_settling = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.numericUpDown_staff = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_students = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_payment = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_rooms = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_increase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_settling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eviction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_payment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rooms)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(21, 582);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 198);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox_income
            // 
            this.textBox_income.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_income.Location = new System.Drawing.Point(414, 132);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.ReadOnly = true;
            this.textBox_income.Size = new System.Drawing.Size(129, 26);
            this.textBox_income.TabIndex = 5;
            this.textBox_income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_copy
            // 
            this.button_copy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_copy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_copy.Location = new System.Drawing.Point(384, 476);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(189, 36);
            this.button_copy.TabIndex = 14;
            this.button_copy.Text = "Создать копию";
            this.button_copy.UseVisualStyleBackColor = false;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // button_eviction
            // 
            this.button_eviction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_eviction.BackColor = System.Drawing.Color.Salmon;
            this.button_eviction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_eviction.Location = new System.Drawing.Point(378, 347);
            this.button_eviction.Name = "button_eviction";
            this.button_eviction.Size = new System.Drawing.Size(201, 37);
            this.button_eviction.TabIndex = 11;
            this.button_eviction.Text = "Выселить студентов";
            this.button_eviction.UseVisualStyleBackColor = false;
            this.button_eviction.Click += new System.EventHandler(this.button_eviction_Click);
            // 
            // numericUpDown_increase
            // 
            this.numericUpDown_increase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_increase.Location = new System.Drawing.Point(429, 218);
            this.numericUpDown_increase.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_increase.Name = "numericUpDown_increase";
            this.numericUpDown_increase.Size = new System.Drawing.Size(98, 29);
            this.numericUpDown_increase.TabIndex = 6;
            // 
            // button_increase_room
            // 
            this.button_increase_room.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_increase_room.BackColor = System.Drawing.Color.SandyBrown;
            this.button_increase_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_increase_room.Location = new System.Drawing.Point(346, 175);
            this.button_increase_room.Name = "button_increase_room";
            this.button_increase_room.Size = new System.Drawing.Size(264, 37);
            this.button_increase_room.TabIndex = 9;
            this.button_increase_room.Text = "Увеличить количество комнат";
            this.button_increase_room.UseVisualStyleBackColor = false;
            this.button_increase_room.Click += new System.EventHandler(this.button_increase_room_Click);
            // 
            // button_income_year
            // 
            this.button_income_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_income_year.BackColor = System.Drawing.Color.Bisque;
            this.button_income_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_income_year.Location = new System.Drawing.Point(361, 89);
            this.button_income_year.Name = "button_income_year";
            this.button_income_year.Size = new System.Drawing.Size(235, 37);
            this.button_income_year.TabIndex = 8;
            this.button_income_year.Text = "Вывести доход за год";
            this.button_income_year.UseVisualStyleBackColor = false;
            this.button_income_year.Click += new System.EventHandler(this.button_income_year_Click);
            // 
            // button_income_month
            // 
            this.button_income_month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_income_month.BackColor = System.Drawing.Color.Bisque;
            this.button_income_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_income_month.Location = new System.Drawing.Point(360, 3);
            this.button_income_month.Name = "button_income_month";
            this.button_income_month.Size = new System.Drawing.Size(237, 37);
            this.button_income_month.TabIndex = 6;
            this.button_income_month.Text = "Вывести доход за месяц";
            this.button_income_month.UseVisualStyleBackColor = false;
            this.button_income_month.Click += new System.EventHandler(this.button_income_month_Click);
            // 
            // button_income_half_year
            // 
            this.button_income_half_year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_income_half_year.BackColor = System.Drawing.Color.Bisque;
            this.button_income_half_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_income_half_year.Location = new System.Drawing.Point(359, 46);
            this.button_income_half_year.Name = "button_income_half_year";
            this.button_income_half_year.Size = new System.Drawing.Size(238, 37);
            this.button_income_half_year.TabIndex = 7;
            this.button_income_half_year.Text = "Вывести доход за полгода";
            this.button_income_half_year.UseVisualStyleBackColor = false;
            this.button_income_half_year.Click += new System.EventHandler(this.button_income_half_year_Click);
            // 
            // button_canteen
            // 
            this.button_canteen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_canteen.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_canteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_canteen.Location = new System.Drawing.Point(381, 433);
            this.button_canteen.Name = "button_canteen";
            this.button_canteen.Size = new System.Drawing.Size(194, 37);
            this.button_canteen.TabIndex = 11;
            this.button_canteen.Text = "Добавить столовую";
            this.button_canteen.UseVisualStyleBackColor = false;
            this.button_canteen.Click += new System.EventHandler(this.button_canteen_Click);
            // 
            // numericUpDown_settling
            // 
            this.numericUpDown_settling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_settling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_settling.Location = new System.Drawing.Point(429, 304);
            this.numericUpDown_settling.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_settling.Name = "numericUpDown_settling";
            this.numericUpDown_settling.Size = new System.Drawing.Size(98, 29);
            this.numericUpDown_settling.TabIndex = 12;
            // 
            // numericUpDown_eviction
            // 
            this.numericUpDown_eviction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_eviction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_eviction.Location = new System.Drawing.Point(429, 390);
            this.numericUpDown_eviction.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_eviction.Name = "numericUpDown_eviction";
            this.numericUpDown_eviction.Size = new System.Drawing.Size(98, 29);
            this.numericUpDown_eviction.TabIndex = 13;
            // 
            // button_settling
            // 
            this.button_settling.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_settling.BackColor = System.Drawing.Color.Yellow;
            this.button_settling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_settling.Location = new System.Drawing.Point(376, 261);
            this.button_settling.Name = "button_settling";
            this.button_settling.Size = new System.Drawing.Size(204, 37);
            this.button_settling.TabIndex = 10;
            this.button_settling.Text = "Заселить студентов";
            this.button_settling.UseVisualStyleBackColor = false;
            this.button_settling.Click += new System.EventHandler(this.button_settling_Click);
            // 
            // button_enter
            // 
            this.button_enter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_enter.BackColor = System.Drawing.Color.Chartreuse;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_enter.Location = new System.Drawing.Point(34, 519);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(228, 38);
            this.button_enter.TabIndex = 9;
            this.button_enter.Text = "Ввести данные";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(84, 46);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(129, 26);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_address
            // 
            this.textBox_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_address.Location = new System.Drawing.Point(84, 132);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(129, 26);
            this.textBox_address.TabIndex = 5;
            this.textBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_staff
            // 
            this.numericUpDown_staff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_staff.Location = new System.Drawing.Point(99, 304);
            this.numericUpDown_staff.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_staff.Name = "numericUpDown_staff";
            this.numericUpDown_staff.Size = new System.Drawing.Size(98, 29);
            this.numericUpDown_staff.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Количество студентов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown_students
            // 
            this.numericUpDown_students.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_students.Location = new System.Drawing.Point(88, 390);
            this.numericUpDown_students.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_students.Name = "numericUpDown_students";
            this.numericUpDown_students.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_students.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Оплата за проживание";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown_payment
            // 
            this.numericUpDown_payment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_payment.DecimalPlaces = 2;
            this.numericUpDown_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_payment.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_payment.Location = new System.Drawing.Point(88, 476);
            this.numericUpDown_payment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_payment.Name = "numericUpDown_payment";
            this.numericUpDown_payment.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_payment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название университета";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Количество персонала";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_rooms
            // 
            this.numericUpDown_rooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_rooms.Location = new System.Drawing.Point(100, 218);
            this.numericUpDown_rooms.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown_rooms.Name = "numericUpDown_rooms";
            this.numericUpDown_rooms.Size = new System.Drawing.Size(96, 29);
            this.numericUpDown_rooms.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество комнат";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.15103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.84897F));
            this.tableLayoutPanel2.Controls.Add(this.button_copy, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_canteen, 1, 10);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_eviction, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_settling, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.button_settling, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.button_eviction, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_increase, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox_address, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox_income, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_income_year, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_income_half_year, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_income_month, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_enter, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_payment, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_students, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_staff, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBox_name, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_rooms, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.button_increase_room, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 13;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 560);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 792);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_increase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_settling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eviction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_payment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rooms)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_income;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Button button_eviction;
        private System.Windows.Forms.Button button_settling;
        private System.Windows.Forms.NumericUpDown numericUpDown_increase;
        private System.Windows.Forms.Button button_increase_room;
        private System.Windows.Forms.Button button_income_year;
        private System.Windows.Forms.Button button_income_month;
        private System.Windows.Forms.Button button_income_half_year;
        private System.Windows.Forms.Button button_canteen;
        private System.Windows.Forms.NumericUpDown numericUpDown_settling;
        private System.Windows.Forms.NumericUpDown numericUpDown_eviction;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.NumericUpDown numericUpDown_payment;
        private System.Windows.Forms.NumericUpDown numericUpDown_students;
        private System.Windows.Forms.NumericUpDown numericUpDown_staff;
        private System.Windows.Forms.NumericUpDown numericUpDown_rooms;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

