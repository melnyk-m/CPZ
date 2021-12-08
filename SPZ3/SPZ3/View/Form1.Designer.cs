namespace SPZ3
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
            this.users_listBox = new System.Windows.Forms.ListBox();
            this.programs_listBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.compare_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.installation_button = new System.Windows.Forms.Button();
            this.uninstallation_button = new System.Windows.Forms.Button();
            this.smaller_button = new System.Windows.Forms.Button();
            this.larger_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // users_listBox
            // 
            this.users_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users_listBox.FormattingEnabled = true;
            this.users_listBox.ItemHeight = 20;
            this.users_listBox.Location = new System.Drawing.Point(384, 57);
            this.users_listBox.Name = "users_listBox";
            this.users_listBox.Size = new System.Drawing.Size(148, 304);
            this.users_listBox.TabIndex = 27;
            // 
            // programs_listBox
            // 
            this.programs_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programs_listBox.FormattingEnabled = true;
            this.programs_listBox.ItemHeight = 20;
            this.programs_listBox.Location = new System.Drawing.Point(8, 57);
            this.programs_listBox.Name = "programs_listBox";
            this.programs_listBox.Size = new System.Drawing.Size(300, 304);
            this.programs_listBox.TabIndex = 26;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DoubleClickEnabled = true;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // compare_button
            // 
            this.compare_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compare_button.Location = new System.Drawing.Point(384, 444);
            this.compare_button.Name = "compare_button";
            this.compare_button.Size = new System.Drawing.Size(146, 33);
            this.compare_button.TabIndex = 24;
            this.compare_button.Text = "СРАВНИТЬ";
            this.compare_button.UseVisualStyleBackColor = true;
            this.compare_button.Click += new System.EventHandler(this.compare_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(386, 406);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(146, 33);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "УДАЛИТЬ";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_button.Location = new System.Drawing.Point(384, 367);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(148, 33);
            this.add_button.TabIndex = 22;
            this.add_button.Text = "ДОБАВИТЬ";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(8, 406);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(148, 33);
            this.update_button.TabIndex = 21;
            this.update_button.Text = "ОБНОВИТЬ";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // installation_button
            // 
            this.installation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.installation_button.Location = new System.Drawing.Point(8, 367);
            this.installation_button.Name = "installation_button";
            this.installation_button.Size = new System.Drawing.Size(148, 33);
            this.installation_button.TabIndex = 20;
            this.installation_button.Text = "ИНСТАЛЯЦИЯ";
            this.installation_button.UseVisualStyleBackColor = true;
            this.installation_button.Click += new System.EventHandler(this.installation_button_Click);
            // 
            // uninstallation_button
            // 
            this.uninstallation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uninstallation_button.Location = new System.Drawing.Point(162, 367);
            this.uninstallation_button.Name = "uninstallation_button";
            this.uninstallation_button.Size = new System.Drawing.Size(146, 33);
            this.uninstallation_button.TabIndex = 19;
            this.uninstallation_button.Text = "ДЕИНСТАЛЯЦИЯ";
            this.uninstallation_button.UseVisualStyleBackColor = true;
            this.uninstallation_button.Click += new System.EventHandler(this.uninstallation_button_Click);
            // 
            // smaller_button
            // 
            this.smaller_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smaller_button.Location = new System.Drawing.Point(314, 207);
            this.smaller_button.Name = "smaller_button";
            this.smaller_button.Size = new System.Drawing.Size(64, 37);
            this.smaller_button.TabIndex = 18;
            this.smaller_button.Text = "<";
            this.smaller_button.UseVisualStyleBackColor = true;
            this.smaller_button.Click += new System.EventHandler(this.smaller_button_Click);
            // 
            // larger_button
            // 
            this.larger_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.larger_button.Location = new System.Drawing.Point(314, 166);
            this.larger_button.Name = "larger_button";
            this.larger_button.Size = new System.Drawing.Size(64, 35);
            this.larger_button.TabIndex = 17;
            this.larger_button.Text = ">";
            this.larger_button.UseVisualStyleBackColor = true;
            this.larger_button.Click += new System.EventHandler(this.larger_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(382, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "ПОЛЬЗОВАТЕЛИ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "ПРОГРАММЫ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 502);
            this.Controls.Add(this.users_listBox);
            this.Controls.Add(this.programs_listBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.compare_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.installation_button);
            this.Controls.Add(this.uninstallation_button);
            this.Controls.Add(this.smaller_button);
            this.Controls.Add(this.larger_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox users_listBox;
        public System.Windows.Forms.ListBox programs_listBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button compare_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button installation_button;
        private System.Windows.Forms.Button uninstallation_button;
        private System.Windows.Forms.Button smaller_button;
        private System.Windows.Forms.Button larger_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

