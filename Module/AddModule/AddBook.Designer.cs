namespace ElectronicLibrary
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.publish = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add_book = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(100, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(100, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Publish Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(100, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Author Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(100, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Book Name";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.add_btn.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Transparent;
            this.add_btn.Location = new System.Drawing.Point(104, 479);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(260, 53);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Add Book";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // publish
            // 
            this.publish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publish.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.publish.Location = new System.Drawing.Point(104, 318);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(260, 32);
            this.publish.TabIndex = 3;
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.author.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.author.Location = new System.Drawing.Point(104, 230);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(260, 32);
            this.author.TabIndex = 2;
            // 
            // bname
            // 
            this.bname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bname.Location = new System.Drawing.Point(104, 143);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(260, 32);
            this.bname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(98, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 35);
            this.label6.TabIndex = 48;
            this.label6.Text = "Add New Book";
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.Transparent;
            this.add_book.FlatAppearance.BorderSize = 0;
            this.add_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_book.Image = ((System.Drawing.Image)(resources.GetObject("add_book.Image")));
            this.add_book.Location = new System.Drawing.Point(297, 46);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(66, 53);
            this.add_book.TabIndex = 58;
            this.add_book.UseVisualStyleBackColor = false;
            // 
            // category
            // 
            this.category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(105, 404);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(258, 32);
            this.category.TabIndex = 4;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 593);
            this.Controls.Add(this.category);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.publish);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox publish;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.ComboBox category;
    }
}