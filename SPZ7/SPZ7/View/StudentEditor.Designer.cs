namespace SPZ7.View
{
    partial class StudentEditor
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
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname_label = new System.Windows.Forms.Label();
            this.lastname_label = new System.Windows.Forms.Label();
            this.firstname_textBox = new System.Windows.Forms.TextBox();
            this.lastname_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.add_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button.Location = new System.Drawing.Point(38, 178);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(115, 49);
            this.add_button.TabIndex = 26;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.InfoText;
            this.edit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edit_button.Location = new System.Drawing.Point(38, 123);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(114, 49);
            this.edit_button.TabIndex = 25;
            this.edit_button.Text = "Change";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.delete_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button.Location = new System.Drawing.Point(38, 68);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(115, 49);
            this.delete_button.TabIndex = 24;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(194, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Group";
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname_label.Location = new System.Drawing.Point(194, 115);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(55, 20);
            this.firstname_label.TabIndex = 22;
            this.firstname_label.Text = "Name";
            // 
            // lastname_label
            // 
            this.lastname_label.AutoSize = true;
            this.lastname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname_label.Location = new System.Drawing.Point(194, 59);
            this.lastname_label.Name = "lastname_label";
            this.lastname_label.Size = new System.Drawing.Size(81, 20);
            this.lastname_label.TabIndex = 21;
            this.lastname_label.Text = "Surname";
            // 
            // firstname_textBox
            // 
            this.firstname_textBox.Location = new System.Drawing.Point(184, 140);
            this.firstname_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstname_textBox.Name = "firstname_textBox";
            this.firstname_textBox.Size = new System.Drawing.Size(153, 26);
            this.firstname_textBox.TabIndex = 19;
            // 
            // lastname_textBox
            // 
            this.lastname_textBox.Location = new System.Drawing.Point(184, 84);
            this.lastname_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastname_textBox.Name = "lastname_textBox";
            this.lastname_textBox.Size = new System.Drawing.Size(201, 26);
            this.lastname_textBox.TabIndex = 18;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(51, 23);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.ReadOnly = true;
            this.id_textBox.Size = new System.Drawing.Size(114, 26);
            this.id_textBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID:";
            // 
            // group_comboBox
            // 
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Location = new System.Drawing.Point(184, 199);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(153, 28);
            this.group_comboBox.TabIndex = 29;
            // 
            // StudentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 236);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.lastname_label);
            this.Controls.Add(this.firstname_textBox);
            this.Controls.Add(this.lastname_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentEditor";
            this.Text = "StudentEditor";
            this.Load += new System.EventHandler(this.StudentEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label lastname_label;
        private System.Windows.Forms.TextBox firstname_textBox;
        private System.Windows.Forms.TextBox lastname_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox group_comboBox;
    }
}