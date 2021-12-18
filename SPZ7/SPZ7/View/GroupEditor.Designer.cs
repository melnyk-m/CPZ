namespace SPZ7.View
{
    partial class GroupEditor
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
            this.group_textBox = new System.Windows.Forms.TextBox();
            this.addGroup_button = new System.Windows.Forms.Button();
            this.rename_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteGroup_button = new System.Windows.Forms.Button();
            this.newGroup_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // group_textBox
            // 
            this.group_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_textBox.Location = new System.Drawing.Point(99, 28);
            this.group_textBox.Name = "group_textBox";
            this.group_textBox.ReadOnly = true;
            this.group_textBox.Size = new System.Drawing.Size(149, 26);
            this.group_textBox.TabIndex = 20;
            // 
            // addGroup_button
            // 
            this.addGroup_button.BackColor = System.Drawing.SystemColors.InfoText;
            this.addGroup_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addGroup_button.Location = new System.Drawing.Point(249, 75);
            this.addGroup_button.Name = "addGroup_button";
            this.addGroup_button.Size = new System.Drawing.Size(82, 39);
            this.addGroup_button.TabIndex = 19;
            this.addGroup_button.Text = "Add";
            this.addGroup_button.UseVisualStyleBackColor = false;
            this.addGroup_button.Click += new System.EventHandler(this.addGroup_button_Click);
            // 
            // rename_button
            // 
            this.rename_button.BackColor = System.Drawing.SystemColors.InfoText;
            this.rename_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rename_button.Location = new System.Drawing.Point(124, 75);
            this.rename_button.Name = "rename_button";
            this.rename_button.Size = new System.Drawing.Size(90, 39);
            this.rename_button.TabIndex = 18;
            this.rename_button.Text = "Rename";
            this.rename_button.UseVisualStyleBackColor = false;
            this.rename_button.Click += new System.EventHandler(this.rename_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "New name:";
            // 
            // deleteGroup_button
            // 
            this.deleteGroup_button.BackColor = System.Drawing.SystemColors.InfoText;
            this.deleteGroup_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteGroup_button.Location = new System.Drawing.Point(9, 75);
            this.deleteGroup_button.Name = "deleteGroup_button";
            this.deleteGroup_button.Size = new System.Drawing.Size(91, 39);
            this.deleteGroup_button.TabIndex = 16;
            this.deleteGroup_button.Text = "Delete";
            this.deleteGroup_button.UseVisualStyleBackColor = false;
            this.deleteGroup_button.Click += new System.EventHandler(this.deleteGroup_button_Click);
            // 
            // newGroup_textBox
            // 
            this.newGroup_textBox.Location = new System.Drawing.Point(182, 134);
            this.newGroup_textBox.Name = "newGroup_textBox";
            this.newGroup_textBox.Size = new System.Drawing.Size(149, 26);
            this.newGroup_textBox.TabIndex = 15;
            // 
            // GroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.group_textBox);
            this.Controls.Add(this.addGroup_button);
            this.Controls.Add(this.rename_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteGroup_button);
            this.Controls.Add(this.newGroup_textBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GroupEditor";
            this.Text = "GroupEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox group_textBox;
        private System.Windows.Forms.Button addGroup_button;
        private System.Windows.Forms.Button rename_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteGroup_button;
        private System.Windows.Forms.TextBox newGroup_textBox;
    }
}