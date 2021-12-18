namespace SPZ6
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.moveOut_button = new System.Windows.Forms.Button();
            this.moveIn_button = new System.Windows.Forms.Button();
            this.free_label = new System.Windows.Forms.Label();
            this.occupied_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.all_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(145, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Сезон отпусков";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Обычный режим";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // moveOut_button
            // 
            this.moveOut_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveOut_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.moveOut_button.Location = new System.Drawing.Point(317, 49);
            this.moveOut_button.Name = "moveOut_button";
            this.moveOut_button.Size = new System.Drawing.Size(146, 65);
            this.moveOut_button.TabIndex = 8;
            this.moveOut_button.Text = "Выселиться";
            this.moveOut_button.UseVisualStyleBackColor = false;
            this.moveOut_button.Click += new System.EventHandler(this.moveOut_button_Click);
            // 
            // moveIn_button
            // 
            this.moveIn_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moveIn_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.moveIn_button.Location = new System.Drawing.Point(168, 49);
            this.moveIn_button.Name = "moveIn_button";
            this.moveIn_button.Size = new System.Drawing.Size(143, 65);
            this.moveIn_button.TabIndex = 6;
            this.moveIn_button.Text = "Заселиться";
            this.moveIn_button.UseVisualStyleBackColor = false;
            this.moveIn_button.Click += new System.EventHandler(this.moveIn_button_Click);
            // 
            // free_label
            // 
            this.free_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.free_label.AutoSize = true;
            this.free_label.Location = new System.Drawing.Point(567, 9);
            this.free_label.Name = "free_label";
            this.free_label.Size = new System.Drawing.Size(51, 20);
            this.free_label.TabIndex = 7;
            this.free_label.Text = "label6";
            // 
            // occupied_label
            // 
            this.occupied_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.occupied_label.AutoSize = true;
            this.occupied_label.Location = new System.Drawing.Point(358, 9);
            this.occupied_label.Name = "occupied_label";
            this.occupied_label.Size = new System.Drawing.Size(51, 20);
            this.occupied_label.TabIndex = 6;
            this.occupied_label.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(451, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Свободные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Занятые:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общее количество:";
            // 
            // all_label
            // 
            this.all_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_label.AutoSize = true;
            this.all_label.Location = new System.Drawing.Point(185, 9);
            this.all_label.Name = "all_label";
            this.all_label.Size = new System.Drawing.Size(51, 20);
            this.all_label.TabIndex = 5;
            this.all_label.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(469, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Доход:";
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(567, 71);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(51, 20);
            this.incomeLabel.TabIndex = 16;
            this.incomeLabel.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 130);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moveOut_button);
            this.Controls.Add(this.moveIn_button);
            this.Controls.Add(this.free_label);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.occupied_label);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.all_label);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button moveOut_button;
        private System.Windows.Forms.Button moveIn_button;
        public System.Windows.Forms.Label free_label;
        public System.Windows.Forms.Label occupied_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label all_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label incomeLabel;
    }
}

