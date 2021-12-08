namespace SPZ3.View
{
    partial class PCSpecificationEditor
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
            this.change_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HDD_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CPU_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RAM_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OS_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // change_button
            // 
            this.change_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.change_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.change_button.Location = new System.Drawing.Point(199, 201);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(109, 54);
            this.change_button.TabIndex = 41;
            this.change_button.Text = "Изменить";
            this.change_button.UseVisualStyleBackColor = false;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(461, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "GB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(461, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "ГГц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 38;
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
            this.HDD_numericUpDown.Location = new System.Drawing.Point(325, 156);
            this.HDD_numericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.HDD_numericUpDown.Name = "HDD_numericUpDown";
            this.HDD_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.HDD_numericUpDown.TabIndex = 37;
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
            this.CPU_numericUpDown.Location = new System.Drawing.Point(325, 114);
            this.CPU_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CPU_numericUpDown.Name = "CPU_numericUpDown";
            this.CPU_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.CPU_numericUpDown.TabIndex = 36;
            // 
            // RAM_numericUpDown
            // 
            this.RAM_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAM_numericUpDown.Location = new System.Drawing.Point(325, 71);
            this.RAM_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.RAM_numericUpDown.Name = "RAM_numericUpDown";
            this.RAM_numericUpDown.Size = new System.Drawing.Size(120, 26);
            this.RAM_numericUpDown.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Свободное пространствo HDD:  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Частота ЦП:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "RAM:";
            // 
            // OS_textBox
            // 
            this.OS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OS_textBox.Location = new System.Drawing.Point(303, 28);
            this.OS_textBox.Name = "OS_textBox";
            this.OS_textBox.Size = new System.Drawing.Size(163, 26);
            this.OS_textBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "ОС:";
            // 
            // PCSpecificationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 276);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HDD_numericUpDown);
            this.Controls.Add(this.CPU_numericUpDown);
            this.Controls.Add(this.RAM_numericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OS_textBox);
            this.Controls.Add(this.label2);
            this.Name = "PCSpecificationEditor";
            this.Text = "PCSpecificationEditor";
            ((System.ComponentModel.ISupportInitialize)(this.HDD_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown HDD_numericUpDown;
        private System.Windows.Forms.NumericUpDown CPU_numericUpDown;
        private System.Windows.Forms.NumericUpDown RAM_numericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OS_textBox;
        private System.Windows.Forms.Label label2;
    }
}