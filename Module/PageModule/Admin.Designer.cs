namespace ElectronicLibrary
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctg_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.users_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.books_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_ctg = new System.Windows.Forms.Button();
            this.del_ctg = new System.Windows.Forms.Button();
            this.add_ctg = new System.Windows.Forms.Button();
            this.ctg_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_book = new System.Windows.Forms.Button();
            this.del_book = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.logout3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add_book = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.search_btn = new System.Windows.Forms.Button();
            this.logout2 = new System.Windows.Forms.Button();
            this.choose_ctg = new System.Windows.Forms.ComboBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.books_dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucard_dgv = new System.Windows.Forms.DataGridView();
            this.users_dgv = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logout1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_user = new System.Windows.Forms.Button();
            this.del_user = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctg_dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucard_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ctg_btn
            // 
            this.ctg_btn.ForeColor = System.Drawing.Color.White;
            this.ctg_btn.Name = "ctg_btn";
            this.ctg_btn.Padding = new System.Windows.Forms.Padding(5);
            this.ctg_btn.Size = new System.Drawing.Size(132, 41);
            this.ctg_btn.Text = " Categories ";
            this.ctg_btn.Click += new System.EventHandler(this.ctg_btn_Click);
            // 
            // users_btn
            // 
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(87, 41);
            this.users_btn.Text = " Users ";
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.users_btn,
            this.books_btn,
            this.ctg_btn});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MaximumSize = new System.Drawing.Size(1180, 50);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1180, 45);
            this.menu.TabIndex = 3;
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
            // edit_ctg
            // 
            this.edit_ctg.FlatAppearance.BorderSize = 0;
            this.edit_ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_ctg.Image = ((System.Drawing.Image)(resources.GetObject("edit_ctg.Image")));
            this.edit_ctg.Location = new System.Drawing.Point(654, 456);
            this.edit_ctg.Name = "edit_ctg";
            this.edit_ctg.Size = new System.Drawing.Size(80, 80);
            this.edit_ctg.TabIndex = 7;
            this.edit_ctg.UseVisualStyleBackColor = true;
            this.edit_ctg.Click += new System.EventHandler(this.edit_ctg_Click);
            // 
            // del_ctg
            // 
            this.del_ctg.FlatAppearance.BorderSize = 0;
            this.del_ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_ctg.Image = ((System.Drawing.Image)(resources.GetObject("del_ctg.Image")));
            this.del_ctg.Location = new System.Drawing.Point(654, 370);
            this.del_ctg.Name = "del_ctg";
            this.del_ctg.Size = new System.Drawing.Size(80, 80);
            this.del_ctg.TabIndex = 6;
            this.del_ctg.UseVisualStyleBackColor = true;
            this.del_ctg.Click += new System.EventHandler(this.del_ctg_Click);
            // 
            // add_ctg
            // 
            this.add_ctg.FlatAppearance.BorderSize = 0;
            this.add_ctg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_ctg.Image = ((System.Drawing.Image)(resources.GetObject("add_ctg.Image")));
            this.add_ctg.Location = new System.Drawing.Point(654, 284);
            this.add_ctg.Name = "add_ctg";
            this.add_ctg.Size = new System.Drawing.Size(80, 80);
            this.add_ctg.TabIndex = 5;
            this.add_ctg.UseVisualStyleBackColor = true;
            this.add_ctg.Click += new System.EventHandler(this.add_ctg_Click);
            // 
            // ctg_dgv
            // 
            this.ctg_dgv.AllowUserToAddRows = false;
            this.ctg_dgv.AllowUserToDeleteRows = false;
            this.ctg_dgv.AllowUserToResizeColumns = false;
            this.ctg_dgv.AllowUserToResizeRows = false;
            this.ctg_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctg_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctg_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.ctg_dgv.ColumnHeadersHeight = 30;
            this.ctg_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctg_dgv.DefaultCellStyle = dataGridViewCellStyle24;
            this.ctg_dgv.Location = new System.Drawing.Point(14, 172);
            this.ctg_dgv.Name = "ctg_dgv";
            this.ctg_dgv.ReadOnly = true;
            this.ctg_dgv.RowHeadersVisible = false;
            this.ctg_dgv.RowHeadersWidth = 51;
            this.ctg_dgv.RowTemplate.Height = 24;
            this.ctg_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctg_dgv.Size = new System.Drawing.Size(490, 540);
            this.ctg_dgv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "BOOKS";
            // 
            // edit_book
            // 
            this.edit_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_book.BackColor = System.Drawing.Color.Azure;
            this.edit_book.FlatAppearance.BorderSize = 0;
            this.edit_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_book.Image = ((System.Drawing.Image)(resources.GetObject("edit_book.Image")));
            this.edit_book.Location = new System.Drawing.Point(1194, 154);
            this.edit_book.Name = "edit_book";
            this.edit_book.Size = new System.Drawing.Size(66, 53);
            this.edit_book.TabIndex = 4;
            this.edit_book.UseVisualStyleBackColor = false;
            this.edit_book.Click += new System.EventHandler(this.edit_book_Click);
            // 
            // del_book
            // 
            this.del_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.del_book.BackColor = System.Drawing.Color.Azure;
            this.del_book.FlatAppearance.BorderSize = 0;
            this.del_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_book.Image = ((System.Drawing.Image)(resources.GetObject("del_book.Image")));
            this.del_book.Location = new System.Drawing.Point(1132, 154);
            this.del_book.Name = "del_book";
            this.del_book.Size = new System.Drawing.Size(66, 53);
            this.del_book.TabIndex = 3;
            this.del_book.UseVisualStyleBackColor = false;
            this.del_book.Click += new System.EventHandler(this.del_book_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(81, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "CATEGORİES";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Azure;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.logout3);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.edit_ctg);
            this.tabPage3.Controls.Add(this.del_ctg);
            this.tabPage3.Controls.Add(this.add_ctg);
            this.tabPage3.Controls.Add(this.ctg_dgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1266, 723);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "page3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(740, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Edit Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(740, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Remove Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(740, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Add New Category";
            // 
            // logout3
            // 
            this.logout3.BackColor = System.Drawing.Color.DodgerBlue;
            this.logout3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout3.FlatAppearance.BorderSize = 0;
            this.logout3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout3.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout3.ForeColor = System.Drawing.Color.White;
            this.logout3.Location = new System.Drawing.Point(1174, 0);
            this.logout3.Name = "logout3";
            this.logout3.Size = new System.Drawing.Size(92, 47);
            this.logout3.TabIndex = 21;
            this.logout3.Text = "Log out";
            this.logout3.UseVisualStyleBackColor = false;
            this.logout3.Click += new System.EventHandler(this.logout3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // add_book
            // 
            this.add_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_book.BackColor = System.Drawing.Color.Azure;
            this.add_book.FlatAppearance.BorderSize = 0;
            this.add_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_book.Image = ((System.Drawing.Image)(resources.GetObject("add_book.Image")));
            this.add_book.Location = new System.Drawing.Point(1070, 154);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(66, 53);
            this.add_book.TabIndex = 2;
            this.add_book.UseVisualStyleBackColor = false;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.search_btn);
            this.tabPage2.Controls.Add(this.logout2);
            this.tabPage2.Controls.Add(this.choose_ctg);
            this.tabPage2.Controls.Add(this.search_box);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.edit_book);
            this.tabPage2.Controls.Add(this.del_book);
            this.tabPage2.Controls.Add(this.add_book);
            this.tabPage2.Controls.Add(this.books_dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "page2";
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
            this.search_btn.Location = new System.Drawing.Point(325, 164);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(50, 37);
            this.search_btn.TabIndex = 22;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // logout2
            // 
            this.logout2.BackColor = System.Drawing.Color.DodgerBlue;
            this.logout2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout2.FlatAppearance.BorderSize = 0;
            this.logout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout2.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout2.ForeColor = System.Drawing.Color.White;
            this.logout2.Location = new System.Drawing.Point(1174, 0);
            this.logout2.Name = "logout2";
            this.logout2.Size = new System.Drawing.Size(92, 47);
            this.logout2.TabIndex = 21;
            this.logout2.Text = "Log out";
            this.logout2.UseVisualStyleBackColor = false;
            this.logout2.Click += new System.EventHandler(this.logout2_Click);
            // 
            // choose_ctg
            // 
            this.choose_ctg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.choose_ctg.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_ctg.ForeColor = System.Drawing.Color.DimGray;
            this.choose_ctg.Location = new System.Drawing.Point(401, 165);
            this.choose_ctg.Name = "choose_ctg";
            this.choose_ctg.Size = new System.Drawing.Size(226, 32);
            this.choose_ctg.TabIndex = 9;
            this.choose_ctg.Text = "Category";
            this.choose_ctg.SelectedIndexChanged += new System.EventHandler(this.choose_ctg_SelectedIndexChanged);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.search_box.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.ForeColor = System.Drawing.Color.DimGray;
            this.search_box.Location = new System.Drawing.Point(14, 164);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(324, 32);
            this.search_box.TabIndex = 7;
            this.search_box.Text = "Search by author or book";
            this.search_box.Enter += new System.EventHandler(this.search_box_Enter);
            this.search_box.Leave += new System.EventHandler(this.search_box_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.books_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.books_dgv.ColumnHeadersHeight = 30;
            this.books_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.books_dgv.DefaultCellStyle = dataGridViewCellStyle26;
            this.books_dgv.Location = new System.Drawing.Point(14, 213);
            this.books_dgv.Name = "books_dgv";
            this.books_dgv.ReadOnly = true;
            this.books_dgv.RowHeadersVisible = false;
            this.books_dgv.RowHeadersWidth = 51;
            this.books_dgv.RowTemplate.Height = 24;
            this.books_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books_dgv.Size = new System.Drawing.Size(1238, 499);
            this.books_dgv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(14, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "User card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(68, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "USERS";
            // 
            // ucard_dgv
            // 
            this.ucard_dgv.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.ucard_dgv.AllowUserToAddRows = false;
            this.ucard_dgv.AllowUserToDeleteRows = false;
            this.ucard_dgv.AllowUserToResizeColumns = false;
            this.ucard_dgv.AllowUserToResizeRows = false;
            this.ucard_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucard_dgv.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle27.NullValue = null;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ucard_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.ucard_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucard_dgv.DefaultCellStyle = dataGridViewCellStyle28;
            this.ucard_dgv.Location = new System.Drawing.Point(14, 509);
            this.ucard_dgv.Name = "ucard_dgv";
            this.ucard_dgv.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ucard_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.ucard_dgv.RowHeadersVisible = false;
            this.ucard_dgv.RowHeadersWidth = 51;
            this.ucard_dgv.RowTemplate.Height = 24;
            this.ucard_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ucard_dgv.Size = new System.Drawing.Size(1238, 203);
            this.ucard_dgv.TabIndex = 1;
            // 
            // users_dgv
            // 
            this.users_dgv.AllowUserToAddRows = false;
            this.users_dgv.AllowUserToDeleteRows = false;
            this.users_dgv.AllowUserToResizeColumns = false;
            this.users_dgv.AllowUserToResizeRows = false;
            this.users_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.users_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.users_dgv.DefaultCellStyle = dataGridViewCellStyle31;
            this.users_dgv.Location = new System.Drawing.Point(14, 143);
            this.users_dgv.Name = "users_dgv";
            this.users_dgv.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.users_dgv.RowHeadersVisible = false;
            this.users_dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.users_dgv.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.users_dgv.RowTemplate.Height = 24;
            this.users_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.users_dgv.Size = new System.Drawing.Size(940, 340);
            this.users_dgv.TabIndex = 0;
            this.users_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dgv_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-6, -28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1274, 752);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.logout1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.edit_user);
            this.tabPage1.Controls.Add(this.del_user);
            this.tabPage1.Controls.Add(this.add_user);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ucard_dgv);
            this.tabPage1.Controls.Add(this.users_dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "page1";
            // 
            // logout1
            // 
            this.logout1.BackColor = System.Drawing.Color.DodgerBlue;
            this.logout1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout1.FlatAppearance.BorderSize = 0;
            this.logout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout1.ForeColor = System.Drawing.Color.White;
            this.logout1.Location = new System.Drawing.Point(1174, 0);
            this.logout1.Name = "logout1";
            this.logout1.Size = new System.Drawing.Size(92, 47);
            this.logout1.TabIndex = 21;
            this.logout1.Text = "Log out";
            this.logout1.UseVisualStyleBackColor = false;
            this.logout1.Click += new System.EventHandler(this.logout1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(1040, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Change User Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(1040, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remove User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(1040, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add New User";
            // 
            // edit_user
            // 
            this.edit_user.FlatAppearance.BorderSize = 0;
            this.edit_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_user.Image = ((System.Drawing.Image)(resources.GetObject("edit_user.Image")));
            this.edit_user.Location = new System.Drawing.Point(965, 343);
            this.edit_user.Name = "edit_user";
            this.edit_user.Size = new System.Drawing.Size(75, 64);
            this.edit_user.TabIndex = 12;
            this.edit_user.UseVisualStyleBackColor = true;
            this.edit_user.Click += new System.EventHandler(this.edit_user_Click);
            // 
            // del_user
            // 
            this.del_user.FlatAppearance.BorderSize = 0;
            this.del_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_user.Image = ((System.Drawing.Image)(resources.GetObject("del_user.Image")));
            this.del_user.Location = new System.Drawing.Point(965, 273);
            this.del_user.Name = "del_user";
            this.del_user.Size = new System.Drawing.Size(75, 64);
            this.del_user.TabIndex = 11;
            this.del_user.UseVisualStyleBackColor = true;
            this.del_user.Click += new System.EventHandler(this.del_user_Click);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.Transparent;
            this.add_user.FlatAppearance.BorderSize = 0;
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Image = ((System.Drawing.Image)(resources.GetObject("add_user.Image")));
            this.add_user.Location = new System.Drawing.Point(965, 203);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(75, 64);
            this.add_user.TabIndex = 10;
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctg_dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucard_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_dgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ctg_btn;
        private System.Windows.Forms.ToolStripMenuItem users_btn;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem books_btn;
        private System.Windows.Forms.Button edit_ctg;
        private System.Windows.Forms.Button del_ctg;
        private System.Windows.Forms.Button add_ctg;
        private System.Windows.Forms.DataGridView ctg_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_book;
        private System.Windows.Forms.Button del_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView books_dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ucard_dgv;
        private System.Windows.Forms.DataGridView users_dgv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ComboBox choose_ctg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_user;
        private System.Windows.Forms.Button del_user;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button logout3;
        private System.Windows.Forms.Button logout2;
        private System.Windows.Forms.Button logout1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button search_btn;
    }
}