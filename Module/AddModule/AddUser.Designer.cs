namespace ElectronicLibrary
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label6 = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.uname = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(80, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add New User";
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.Transparent;
            this.add_user.FlatAppearance.BorderSize = 0;
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Image = ((System.Drawing.Image)(resources.GetObject("add_user.Image")));
            this.add_user.Location = new System.Drawing.Point(271, 40);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(75, 64);
            this.add_user.TabIndex = 14;
            this.add_user.UseVisualStyleBackColor = false;
            // 
            // uname
            // 
            this.uname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uname.Location = new System.Drawing.Point(103, 143);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(260, 32);
            this.uname.TabIndex = 35;
            // 
            // pass
            // 
            this.pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pass.Location = new System.Drawing.Point(103, 230);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(260, 32);
            this.pass.TabIndex = 36;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name.Location = new System.Drawing.Point(103, 318);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(260, 32);
            this.name.TabIndex = 37;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.add_btn.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Transparent;
            this.add_btn.Location = new System.Drawing.Point(103, 562);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(260, 59);
            this.add_btn.TabIndex = 40;
            this.add_btn.Text = "Add User";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(99, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(99, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(99, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fullname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(99, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(99, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Address";
            // 
            // address
            // 
            this.address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.address.Location = new System.Drawing.Point(103, 493);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(260, 32);
            this.address.TabIndex = 39;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone.Location = new System.Drawing.Point(103, 404);
            this.phone.Mask = "00 000-00-00";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(260, 32);
            this.phone.TabIndex = 38;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 653);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.MaskedTextBox phone;
    }
}