namespace SPZ3.View
{
    partial class ProgramDialog
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
            this.Input_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HDD_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CPU_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RAM_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.version_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.manufacturer_textBox = new System.Windows.Forms.TextBox();
            this.OS_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.version_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Input_button
            // 
            this.Input_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Input_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Input_button.Location = new System.Drawing.Point(187, 355);
            this.Input_button.Name = "Input_button";
            this.Input_button.Size = new System.Drawing.Size(109, 54);
            this.Input_button.TabIndex = 60;
            this.Input_button.Text = "Ввести";
            this.Input_button.UseVisualStyleBackColor = false;
            this.Input_button.Click += new System.EventHandler(this.Input_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(465, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 59;
            this.label11.Text = "GB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(465, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "ГГц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(465, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "GB";
            // 
            // HDD_numericUpDown
            // 
            this.HDD_numericUpDown.DecimalPlaces = 2;
            this.HDD_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HDD_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.HDD_numericUpDown.Location = new System.Drawing.Point(329, 311);
            this.HDD_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HDD_numericUpDown.Name = "HDD_numericUpDown";
            this.HDD_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.HDD_numericUpDown.TabIndex = 56;
            // 
            // CPU_numericUpDown
            // 
            this.CPU_numericUpDown.DecimalPlaces = 2;
            this.CPU_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPU_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.CPU_numericUpDown.Location = new System.Drawing.Point(329, 269);
            this.CPU_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CPU_numericUpDown.Name = "CPU_numericUpDown";
            this.CPU_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.CPU_numericUpDown.TabIndex = 55;
            // 
            // RAM_numericUpDown
            // 
            this.RAM_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_numericUpDown.Location = new System.Drawing.Point(329, 226);
            this.RAM_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RAM_numericUpDown.Name = "RAM_numericUpDown";
            this.RAM_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.RAM_numericUpDown.TabIndex = 54;
            // 
            // version_numericUpDown
            // 
            this.version_numericUpDown.DecimalPlaces = 2;
            this.version_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.version_numericUpDown.Location = new System.Drawing.Point(329, 186);
            this.version_numericUpDown.Name = "version_numericUpDown";
            this.version_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.version_numericUpDown.TabIndex = 53;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(288, 149);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 52;
            // 
            // manufacturer_textBox
            // 
            this.manufacturer_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer_textBox.Location = new System.Drawing.Point(307, 112);
            this.manufacturer_textBox.Name = "manufacturer_textBox";
            this.manufacturer_textBox.Size = new System.Drawing.Size(163, 26);
            this.manufacturer_textBox.TabIndex = 51;
            // 
            // OS_textBox
            // 
            this.OS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OS_textBox.Location = new System.Drawing.Point(307, 71);
            this.OS_textBox.Name = "OS_textBox";
            this.OS_textBox.Size = new System.Drawing.Size(163, 26);
            this.OS_textBox.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(29, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Занимаемое пространствo HDD:  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(29, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Необходимая частота ЦП:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Необходимая RAM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Версия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Дата установки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Изготовитель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "ОС:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Название приложения:";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(307, 25);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(163, 26);
            this.name_textBox.TabIndex = 41;
            // 
            // ProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 421);
            this.Controls.Add(this.Input_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HDD_numericUpDown);
            this.Controls.Add(this.CPU_numericUpDown);
            this.Controls.Add(this.RAM_numericUpDown);
            this.Controls.Add(this.version_numericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.manufacturer_textBox);
            this.Controls.Add(this.OS_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_textBox);
            this.Name = "ProgramDialog";
            this.Text = "AddProgram";
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.version_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Input_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown HDD_numericUpDown;
        private System.Windows.Forms.NumericUpDown CPU_numericUpDown;
        private System.Windows.Forms.NumericUpDown RAM_numericUpDown;
        private System.Windows.Forms.NumericUpDown version_numericUpDown;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox manufacturer_textBox;
        private System.Windows.Forms.TextBox OS_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_textBox;
    }
}