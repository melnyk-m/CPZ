using SPZ5.Model;
namespace SPZ5
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
            Serialization.Serialize(StoragePath, Storage.Students);
            Serialization.Serialize(GroupListPath, Storage.Groups);
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.one_button = new System.Windows.Forms.Button();
            this.all_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 64);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(485, 443);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // one_button
            // 
            this.one_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.one_button.Location = new System.Drawing.Point(21, 10);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(288, 48);
            this.one_button.TabIndex = 10;
            this.one_button.Text = "Выбрать группу для показа";
            this.one_button.UseVisualStyleBackColor = false;
            this.one_button.Click += new System.EventHandler(this.one_button_Click);
            // 
            // all_button
            // 
            this.all_button.BackColor = System.Drawing.SystemColors.Info;
            this.all_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.all_button.Location = new System.Drawing.Point(315, 10);
            this.all_button.Name = "all_button";
            this.all_button.Size = new System.Drawing.Size(191, 48);
            this.all_button.TabIndex = 11;
            this.all_button.Text = "Показать все";
            this.all_button.UseVisualStyleBackColor = false;
            this.all_button.Click += new System.EventHandler(this.all_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 591);
            this.Controls.Add(this.all_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button one_button;
        private System.Windows.Forms.Button all_button;
    }
}

