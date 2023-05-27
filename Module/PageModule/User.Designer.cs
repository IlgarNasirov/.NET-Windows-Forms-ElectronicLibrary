namespace ElectronicLibrary
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.books_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.ucard_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.logout_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.brw_btn = new System.Windows.Forms.Button();
            this.choose_ctg = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_chb = new System.Windows.Forms.CheckBox();
            this.books_dgv = new System.Windows.Forms.DataGridView();
            this.ucard_dgv = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucard_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.books_btn,
            this.ucard_btn});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MaximumSize = new System.Drawing.Size(1180, 50);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1180, 45);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // books_btn
            // 
            this.books_btn.ForeColor = System.Drawing.Color.White;
            this.books_btn.Name = "books_btn";
            this.books_btn.Size = new System.Drawing.Size(94, 41);
            this.books_btn.Text = " Books ";
            this.books_btn.Click += new System.EventHandler(this.books_btn_Click);
            // 
            // ucard_btn
            // 
            this.ucard_btn.ForeColor = System.Drawing.Color.White;
            this.ucard_btn.Name = "ucard_btn";
            this.ucard_btn.Padding = new System.Windows.Forms.Padding(5);
            this.ucard_btn.Size = new System.Drawing.Size(115, 41);
            this.ucard_btn.Text = "User Card";
            this.ucard_btn.Click += new System.EventHandler(this.ucard_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(1174, 0);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(92, 46);
            this.logout_btn.TabIndex = 22;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1273, 726);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.books_dgv);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.brw_btn);
            this.tabPage1.Controls.Add(this.choose_ctg);
            this.tabPage1.Controls.Add(this.search_btn);
            this.tabPage1.Controls.Add(this.search_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1265, 697);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(29, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "you can rent it for two weeks.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(11, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "• For this, select the book and press the \"Borrow\".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(11, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(397, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "• If the book you\'re looking for is on the shelf,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(11, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "• Here you can see the books available in the library.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(425, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Welcome to the Electronic Library";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // brw_btn
            // 
            this.brw_btn.BackColor = System.Drawing.Color.LightGreen;
            this.brw_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brw_btn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brw_btn.ForeColor = System.Drawing.Color.DimGray;
            this.brw_btn.Location = new System.Drawing.Point(1153, 184);
            this.brw_btn.Name = "brw_btn";
            this.brw_btn.Size = new System.Drawing.Size(100, 40);
            this.brw_btn.TabIndex = 14;
            this.brw_btn.Text = "Borrow";
            this.brw_btn.UseVisualStyleBackColor = false;
            this.brw_btn.Click += new System.EventHandler(this.brw_btn_Click);
            // 
            // choose_ctg
            // 
            this.choose_ctg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.choose_ctg.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_ctg.ForeColor = System.Drawing.Color.DimGray;
            this.choose_ctg.Location = new System.Drawing.Point(906, 188);
            this.choose_ctg.Name = "choose_ctg";
            this.choose_ctg.Size = new System.Drawing.Size(226, 32);
            this.choose_ctg.TabIndex = 13;
            this.choose_ctg.Text = "Choose category";
            this.choose_ctg.SelectedIndexChanged += new System.EventHandler(this.choose_ctg_SelectedIndexChanged);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(837, 187);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(50, 37);
            this.search_btn.TabIndex = 12;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search_box.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.DimGray;
            this.search_box.Location = new System.Drawing.Point(519, 187);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(324, 32);
            this.search_box.TabIndex = 11;
            this.search_box.Text = "Search by author or book";
            this.search_box.Enter += new System.EventHandler(this.search_box_Enter);
            this.search_box.Leave += new System.EventHandler(this.search_box_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucard_dgv);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.return_btn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.show_chb);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1265, 697);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(990, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "the selected borrowed book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(114, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "usage history information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.Transparent;
            this.return_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.ForeColor = System.Drawing.Color.LightCoral;
            this.return_btn.Location = new System.Drawing.Point(888, 219);
            this.return_btn.Margin = new System.Windows.Forms.Padding(0);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(100, 30);
            this.return_btn.TabIndex = 17;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(607, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = " User Card ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // show_chb
            // 
            this.show_chb.AutoSize = true;
            this.show_chb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_chb.Font = new System.Drawing.Font("Candara", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_chb.ForeColor = System.Drawing.SystemColors.Highlight;
            this.show_chb.Location = new System.Drawing.Point(15, 223);
            this.show_chb.Name = "show_chb";
            this.show_chb.Size = new System.Drawing.Size(97, 25);
            this.show_chb.TabIndex = 12;
            this.show_chb.Text = " Show all";
            this.show_chb.UseVisualStyleBackColor = true;
            this.show_chb.CheckedChanged += new System.EventHandler(this.show_chb_CheckedChanged);
            // 
            // books_dgv
            // 
            this.books_dgv.AllowUserToAddRows = false;
            this.books_dgv.AllowUserToDeleteRows = false;
            this.books_dgv.AllowUserToResizeColumns = false;
            this.books_dgv.AllowUserToResizeRows = false;
            this.books_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.books_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.books_dgv.ColumnHeadersHeight = 30;
            this.books_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.books_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.books_dgv.Location = new System.Drawing.Point(15, 241);
            this.books_dgv.Name = "books_dgv";
            this.books_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.books_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.books_dgv.RowHeadersVisible = false;
            this.books_dgv.RowHeadersWidth = 50;
            this.books_dgv.RowTemplate.Height = 24;
            this.books_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books_dgv.Size = new System.Drawing.Size(1238, 443);
            this.books_dgv.TabIndex = 22;
            // 
            // ucard_dgv
            // 
            this.ucard_dgv.AllowUserToAddRows = false;
            this.ucard_dgv.AllowUserToDeleteRows = false;
            this.ucard_dgv.AllowUserToResizeColumns = false;
            this.ucard_dgv.AllowUserToResizeRows = false;
            this.ucard_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucard_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ucard_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ucard_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucard_dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.ucard_dgv.Location = new System.Drawing.Point(15, 254);
            this.ucard_dgv.Name = "ucard_dgv";
            this.ucard_dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ucard_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ucard_dgv.RowHeadersVisible = false;
            this.ucard_dgv.RowHeadersWidth = 50;
            this.ucard_dgv.RowTemplate.Height = 24;
            this.ucard_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ucard_dgv.Size = new System.Drawing.Size(1238, 430);
            this.ucard_dgv.TabIndex = 21;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucard_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem books_btn;
        private System.Windows.Forms.ToolStripMenuItem ucard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox choose_ctg;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button brw_btn;
        private System.Windows.Forms.CheckBox show_chb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView books_dgv;
        private System.Windows.Forms.DataGridView ucard_dgv;
    }
}