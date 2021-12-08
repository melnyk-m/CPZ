namespace SPZ4
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
            this.writeOutput_button = new System.Windows.Forms.Button();
            this.write_button = new System.Windows.Forms.Button();
            this.read_button = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeOutput_button
            // 
            this.writeOutput_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.writeOutput_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeOutput_button.Location = new System.Drawing.Point(13, 187);
            this.writeOutput_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.writeOutput_button.Name = "writeOutput_button";
            this.writeOutput_button.Size = new System.Drawing.Size(270, 61);
            this.writeOutput_button.TabIndex = 8;
            this.writeOutput_button.Text = "Записать результат в файл";
            this.writeOutput_button.UseVisualStyleBackColor = false;
            this.writeOutput_button.Click += new System.EventHandler(this.writeOutput_button_Click);
            // 
            // write_button
            // 
            this.write_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.write_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.write_button.Location = new System.Drawing.Point(13, 14);
            this.write_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(270, 65);
            this.write_button.TabIndex = 7;
            this.write_button.Text = "Сгенерировать начальную последовательность";
            this.write_button.UseVisualStyleBackColor = false;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // read_button
            // 
            this.read_button.BackColor = System.Drawing.SystemColors.Info;
            this.read_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_button.Location = new System.Drawing.Point(13, 87);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(270, 63);
            this.read_button.TabIndex = 9;
            this.read_button.Text = "Прочитать содержимое файла";
            this.read_button.UseVisualStyleBackColor = false;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_label.Location = new System.Drawing.Point(21, 157);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(0, 20);
            this.output_label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.writeOutput_button);
            this.Controls.Add(this.write_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button writeOutput_button;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Label output_label;
    }
}

