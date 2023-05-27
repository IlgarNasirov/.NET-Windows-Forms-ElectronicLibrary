namespace ElectronicLibrary
{
    partial class AddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.ctgname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(65, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 65;
            this.label1.Text = "Category Name";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.add_btn.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Transparent;
            this.add_btn.Location = new System.Drawing.Point(69, 281);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(233, 53);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add Category";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // ctgname
            // 
            this.ctgname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctgname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctgname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctgname.Location = new System.Drawing.Point(69, 171);
            this.ctgname.Name = "ctgname";
            this.ctgname.Size = new System.Drawing.Size(233, 32);
            this.ctgname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(63, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 35);
            this.label6.TabIndex = 60;
            this.label6.Text = "Add New Category";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.ctgname);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox ctgname;
        private System.Windows.Forms.Label label6;
    }
}