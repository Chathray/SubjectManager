namespace WindowsFormsFinal
{
    partial class Main_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Manager));
            this.topbar = new System.Windows.Forms.Panel();
            this.topbar_btnExport = new System.Windows.Forms.Button();
            this.topbar_btnSearch = new System.Windows.Forms.Button();
            this.topbar_Search = new System.Windows.Forms.Panel();
            this.topbar_txtSearch = new System.Windows.Forms.TextBox();
            this.topbar_btnFinish = new System.Windows.Forms.Button();
            this.topbar_btnBack = new System.Windows.Forms.Button();
            this.topbar_btnDel = new System.Windows.Forms.Button();
            this.topbar_btnEdit = new System.Windows.Forms.Button();
            this.topbar_btnOut = new System.Windows.Forms.Button();
            this.topbar_btnAdd = new System.Windows.Forms.Button();
            this.topbar_lbHeader = new System.Windows.Forms.Label();
            this.topbar_btnMenu = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.menu_btnUserList = new System.Windows.Forms.Button();
            this.menu_btnSubjectList = new System.Windows.Forms.Button();
            this.menu_btnSubjectUsers = new System.Windows.Forms.Button();
            this.menu_btnMySubject = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Panel();
            this.account_separator_2 = new System.Windows.Forms.Label();
            this.account_separator_1 = new System.Windows.Forms.Label();
            this.account_lbPass = new System.Windows.Forms.Label();
            this.account_lbUser = new System.Windows.Forms.Label();
            this.account_tbxPass = new System.Windows.Forms.TextBox();
            this.account_tbxUser = new System.Windows.Forms.TextBox();
            this.account_editDel = new System.Windows.Forms.LinkLabel();
            this.account_editPass = new System.Windows.Forms.LinkLabel();
            this.menu_btnAccount = new System.Windows.Forms.Button();
            this._timer1 = new System.Windows.Forms.Timer(this.components);
            this.controlMySubjects = new WindowsFormsFinal.Control_MySubjects();
            this.controlAdmin = new WindowsFormsFinal.Control_Admin();
            this.topbar.SuspendLayout();
            this.topbar_Search.SuspendLayout();
            this.menu.SuspendLayout();
            this.account.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.topbar.Controls.Add(this.topbar_btnExport);
            this.topbar.Controls.Add(this.topbar_btnSearch);
            this.topbar.Controls.Add(this.topbar_Search);
            this.topbar.Controls.Add(this.topbar_btnFinish);
            this.topbar.Controls.Add(this.topbar_btnBack);
            this.topbar.Controls.Add(this.topbar_btnDel);
            this.topbar.Controls.Add(this.topbar_btnEdit);
            this.topbar.Controls.Add(this.topbar_btnOut);
            this.topbar.Controls.Add(this.topbar_btnAdd);
            this.topbar.Controls.Add(this.topbar_lbHeader);
            this.topbar.Controls.Add(this.topbar_btnMenu);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(850, 40);
            this.topbar.TabIndex = 0;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // topbar_btnExport
            // 
            this.topbar_btnExport.AccessibleName = "";
            this.topbar_btnExport.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.topbar_btnExport.FlatAppearance.BorderSize = 0;
            this.topbar_btnExport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnExport.ForeColor = System.Drawing.Color.White;
            this.topbar_btnExport.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnExport.Image")));
            this.topbar_btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnExport.Location = new System.Drawing.Point(724, 0);
            this.topbar_btnExport.Name = "topbar_btnExport";
            this.topbar_btnExport.Size = new System.Drawing.Size(86, 40);
            this.topbar_btnExport.TabIndex = 16;
            this.topbar_btnExport.Text = "Export";
            this.topbar_btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnExport.UseVisualStyleBackColor = true;
            this.topbar_btnExport.Click += new System.EventHandler(this.Topbar_btnExport_Click);
            // 
            // topbar_btnSearch
            // 
            this.topbar_btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbar_btnSearch.BackgroundImage")));
            this.topbar_btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnSearch.FlatAppearance.BorderSize = 0;
            this.topbar_btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnSearch.ForeColor = System.Drawing.Color.Transparent;
            this.topbar_btnSearch.Location = new System.Drawing.Point(597, 8);
            this.topbar_btnSearch.Name = "topbar_btnSearch";
            this.topbar_btnSearch.Size = new System.Drawing.Size(25, 25);
            this.topbar_btnSearch.TabIndex = 14;
            this.topbar_btnSearch.UseVisualStyleBackColor = false;
            this.topbar_btnSearch.Visible = false;
            this.topbar_btnSearch.Click += new System.EventHandler(this.Topbar_btnSearch_Click);
            // 
            // topbar_Search
            // 
            this.topbar_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar_Search.BackColor = System.Drawing.Color.Transparent;
            this.topbar_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbar_Search.BackgroundImage")));
            this.topbar_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topbar_Search.Controls.Add(this.topbar_txtSearch);
            this.topbar_Search.Location = new System.Drawing.Point(625, 9);
            this.topbar_Search.Name = "topbar_Search";
            this.topbar_Search.Size = new System.Drawing.Size(180, 22);
            this.topbar_Search.TabIndex = 13;
            this.topbar_Search.Visible = false;
            // 
            // topbar_txtSearch
            // 
            this.topbar_txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.topbar_txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topbar_txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_txtSearch.Location = new System.Drawing.Point(9, 2);
            this.topbar_txtSearch.Name = "topbar_txtSearch";
            this.topbar_txtSearch.Size = new System.Drawing.Size(163, 18);
            this.topbar_txtSearch.TabIndex = 11;
            // 
            // topbar_btnFinish
            // 
            this.topbar_btnFinish.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnFinish.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnFinish.FlatAppearance.BorderSize = 0;
            this.topbar_btnFinish.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnFinish.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnFinish.ForeColor = System.Drawing.Color.White;
            this.topbar_btnFinish.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnFinish.Image")));
            this.topbar_btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnFinish.Location = new System.Drawing.Point(491, 0);
            this.topbar_btnFinish.Name = "topbar_btnFinish";
            this.topbar_btnFinish.Size = new System.Drawing.Size(75, 40);
            this.topbar_btnFinish.TabIndex = 6;
            this.topbar_btnFinish.Text = "Finish";
            this.topbar_btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnFinish.UseVisualStyleBackColor = true;
            this.topbar_btnFinish.Visible = false;
            this.topbar_btnFinish.Click += new System.EventHandler(this.Topbar_btnFinish_Click);
            // 
            // topbar_btnBack
            // 
            this.topbar_btnBack.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnBack.FlatAppearance.BorderSize = 0;
            this.topbar_btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnBack.ForeColor = System.Drawing.Color.White;
            this.topbar_btnBack.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnBack.Image")));
            this.topbar_btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnBack.Location = new System.Drawing.Point(416, 0);
            this.topbar_btnBack.Name = "topbar_btnBack";
            this.topbar_btnBack.Size = new System.Drawing.Size(75, 40);
            this.topbar_btnBack.TabIndex = 6;
            this.topbar_btnBack.Text = "Back";
            this.topbar_btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnBack.UseVisualStyleBackColor = true;
            this.topbar_btnBack.Visible = false;
            this.topbar_btnBack.Click += new System.EventHandler(this.Topbar_btnBack_Click);
            // 
            // topbar_btnDel
            // 
            this.topbar_btnDel.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnDel.FlatAppearance.BorderSize = 0;
            this.topbar_btnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnDel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnDel.ForeColor = System.Drawing.Color.White;
            this.topbar_btnDel.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnDel.Image")));
            this.topbar_btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnDel.Location = new System.Drawing.Point(341, 0);
            this.topbar_btnDel.Name = "topbar_btnDel";
            this.topbar_btnDel.Size = new System.Drawing.Size(75, 40);
            this.topbar_btnDel.TabIndex = 5;
            this.topbar_btnDel.Text = "Delete";
            this.topbar_btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnDel.UseVisualStyleBackColor = true;
            this.topbar_btnDel.Click += new System.EventHandler(this.Topbar_btnDel_Click);
            // 
            // topbar_btnEdit
            // 
            this.topbar_btnEdit.AccessibleName = "";
            this.topbar_btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnEdit.FlatAppearance.BorderSize = 0;
            this.topbar_btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnEdit.ForeColor = System.Drawing.Color.White;
            this.topbar_btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnEdit.Image")));
            this.topbar_btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnEdit.Location = new System.Drawing.Point(266, 0);
            this.topbar_btnEdit.Name = "topbar_btnEdit";
            this.topbar_btnEdit.Size = new System.Drawing.Size(75, 40);
            this.topbar_btnEdit.TabIndex = 4;
            this.topbar_btnEdit.Tag = "";
            this.topbar_btnEdit.Text = "Edit";
            this.topbar_btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnEdit.UseVisualStyleBackColor = true;
            this.topbar_btnEdit.Click += new System.EventHandler(this.Topbar_btnEdit_Click);
            // 
            // topbar_btnOut
            // 
            this.topbar_btnOut.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbar_btnOut.BackgroundImage")));
            this.topbar_btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.topbar_btnOut.FlatAppearance.BorderSize = 0;
            this.topbar_btnOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnOut.ForeColor = System.Drawing.Color.White;
            this.topbar_btnOut.Location = new System.Drawing.Point(810, 0);
            this.topbar_btnOut.Name = "topbar_btnOut";
            this.topbar_btnOut.Size = new System.Drawing.Size(40, 40);
            this.topbar_btnOut.TabIndex = 10;
            this.topbar_btnOut.UseVisualStyleBackColor = false;
            this.topbar_btnOut.Click += new System.EventHandler(this.Topbar_close_Click);
            // 
            // topbar_btnAdd
            // 
            this.topbar_btnAdd.AccessibleName = "";
            this.topbar_btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnAdd.FlatAppearance.BorderSize = 0;
            this.topbar_btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_btnAdd.ForeColor = System.Drawing.Color.White;
            this.topbar_btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("topbar_btnAdd.Image")));
            this.topbar_btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnAdd.Location = new System.Drawing.Point(191, 0);
            this.topbar_btnAdd.Name = "topbar_btnAdd";
            this.topbar_btnAdd.Size = new System.Drawing.Size(75, 40);
            this.topbar_btnAdd.TabIndex = 3;
            this.topbar_btnAdd.Text = "Add";
            this.topbar_btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbar_btnAdd.UseVisualStyleBackColor = false;
            this.topbar_btnAdd.Click += new System.EventHandler(this.Topbar_btnAdd_Click);
            // 
            // topbar_lbHeader
            // 
            this.topbar_lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.topbar_lbHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_lbHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_lbHeader.ForeColor = System.Drawing.Color.White;
            this.topbar_lbHeader.Location = new System.Drawing.Point(40, 0);
            this.topbar_lbHeader.Name = "topbar_lbHeader";
            this.topbar_lbHeader.Size = new System.Drawing.Size(151, 40);
            this.topbar_lbHeader.TabIndex = 2;
            this.topbar_lbHeader.Text = "MY SUBJECTS";
            this.topbar_lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_lbHeader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Topbar_Click);
            // 
            // topbar_btnMenu
            // 
            this.topbar_btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.topbar_btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbar_btnMenu.BackgroundImage")));
            this.topbar_btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_btnMenu.FlatAppearance.BorderSize = 0;
            this.topbar_btnMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.topbar_btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.topbar_btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_btnMenu.ForeColor = System.Drawing.Color.White;
            this.topbar_btnMenu.Location = new System.Drawing.Point(0, 0);
            this.topbar_btnMenu.Name = "topbar_btnMenu";
            this.topbar_btnMenu.Size = new System.Drawing.Size(40, 40);
            this.topbar_btnMenu.TabIndex = 1;
            this.topbar_btnMenu.UseVisualStyleBackColor = true;
            this.topbar_btnMenu.Click += new System.EventHandler(this.Topbar_Nav_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu.Controls.Add(this.menu_btnUserList);
            this.menu.Controls.Add(this.menu_btnSubjectList);
            this.menu.Controls.Add(this.menu_btnSubjectUsers);
            this.menu.Controls.Add(this.menu_btnMySubject);
            this.menu.Controls.Add(this.account);
            this.menu.Controls.Add(this.menu_btnAccount);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 40);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.menu.Size = new System.Drawing.Size(190, 480);
            this.menu.TabIndex = 1;
            // 
            // menu_btnUserList
            // 
            this.menu_btnUserList.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btnUserList.FlatAppearance.BorderSize = 0;
            this.menu_btnUserList.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btnUserList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btnUserList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.menu_btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnUserList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnUserList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnUserList.Image = ((System.Drawing.Image)(resources.GetObject("menu_btnUserList.Image")));
            this.menu_btnUserList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnUserList.Location = new System.Drawing.Point(0, 130);
            this.menu_btnUserList.Name = "menu_btnUserList";
            this.menu_btnUserList.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.menu_btnUserList.Size = new System.Drawing.Size(190, 40);
            this.menu_btnUserList.TabIndex = 14;
            this.menu_btnUserList.Text = "   User List";
            this.menu_btnUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_btnUserList.UseVisualStyleBackColor = false;
            this.menu_btnUserList.Visible = false;
            this.menu_btnUserList.Click += new System.EventHandler(this.Menu_Control_Click);
            // 
            // menu_btnSubjectList
            // 
            this.menu_btnSubjectList.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btnSubjectList.FlatAppearance.BorderSize = 0;
            this.menu_btnSubjectList.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.menu_btnSubjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnSubjectList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnSubjectList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnSubjectList.Image = ((System.Drawing.Image)(resources.GetObject("menu_btnSubjectList.Image")));
            this.menu_btnSubjectList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnSubjectList.Location = new System.Drawing.Point(0, 90);
            this.menu_btnSubjectList.Name = "menu_btnSubjectList";
            this.menu_btnSubjectList.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.menu_btnSubjectList.Size = new System.Drawing.Size(190, 40);
            this.menu_btnSubjectList.TabIndex = 13;
            this.menu_btnSubjectList.Text = "   Subject List";
            this.menu_btnSubjectList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnSubjectList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_btnSubjectList.UseVisualStyleBackColor = false;
            this.menu_btnSubjectList.Visible = false;
            this.menu_btnSubjectList.Click += new System.EventHandler(this.Menu_Control_Click);
            // 
            // menu_btnSubjectUsers
            // 
            this.menu_btnSubjectUsers.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btnSubjectUsers.FlatAppearance.BorderSize = 0;
            this.menu_btnSubjectUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btnSubjectUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.menu_btnSubjectUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnSubjectUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnSubjectUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menu_btnSubjectUsers.Image = ((System.Drawing.Image)(resources.GetObject("menu_btnSubjectUsers.Image")));
            this.menu_btnSubjectUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnSubjectUsers.Location = new System.Drawing.Point(0, 50);
            this.menu_btnSubjectUsers.Name = "menu_btnSubjectUsers";
            this.menu_btnSubjectUsers.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.menu_btnSubjectUsers.Size = new System.Drawing.Size(190, 40);
            this.menu_btnSubjectUsers.TabIndex = 12;
            this.menu_btnSubjectUsers.Text = "   Subject Of Users";
            this.menu_btnSubjectUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnSubjectUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_btnSubjectUsers.UseVisualStyleBackColor = false;
            this.menu_btnSubjectUsers.Visible = false;
            this.menu_btnSubjectUsers.Click += new System.EventHandler(this.Menu_Control_Click);
            // 
            // menu_btnMySubject
            // 
            this.menu_btnMySubject.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnMySubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btnMySubject.FlatAppearance.BorderSize = 0;
            this.menu_btnMySubject.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btnMySubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btnMySubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.menu_btnMySubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnMySubject.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnMySubject.ForeColor = System.Drawing.Color.White;
            this.menu_btnMySubject.Image = ((System.Drawing.Image)(resources.GetObject("menu_btnMySubject.Image")));
            this.menu_btnMySubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnMySubject.Location = new System.Drawing.Point(0, 10);
            this.menu_btnMySubject.Name = "menu_btnMySubject";
            this.menu_btnMySubject.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.menu_btnMySubject.Size = new System.Drawing.Size(190, 40);
            this.menu_btnMySubject.TabIndex = 11;
            this.menu_btnMySubject.Text = "   My Subjects";
            this.menu_btnMySubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnMySubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_btnMySubject.UseVisualStyleBackColor = false;
            this.menu_btnMySubject.Click += new System.EventHandler(this.Menu_Control_Click);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Controls.Add(this.account_separator_2);
            this.account.Controls.Add(this.account_separator_1);
            this.account.Controls.Add(this.account_lbPass);
            this.account.Controls.Add(this.account_lbUser);
            this.account.Controls.Add(this.account_tbxPass);
            this.account.Controls.Add(this.account_tbxUser);
            this.account.Controls.Add(this.account_editDel);
            this.account.Controls.Add(this.account_editPass);
            this.account.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.account.Location = new System.Drawing.Point(0, 247);
            this.account.Name = "account";
            this.account.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.account.Size = new System.Drawing.Size(190, 183);
            this.account.TabIndex = 10;
            // 
            // account_separator_2
            // 
            this.account_separator_2.BackColor = System.Drawing.Color.White;
            this.account_separator_2.Location = new System.Drawing.Point(22, 106);
            this.account_separator_2.Name = "account_separator_2";
            this.account_separator_2.Size = new System.Drawing.Size(150, 1);
            this.account_separator_2.TabIndex = 10;
            // 
            // account_separator_1
            // 
            this.account_separator_1.BackColor = System.Drawing.Color.White;
            this.account_separator_1.Location = new System.Drawing.Point(22, 50);
            this.account_separator_1.Name = "account_separator_1";
            this.account_separator_1.Size = new System.Drawing.Size(150, 1);
            this.account_separator_1.TabIndex = 9;
            // 
            // account_lbPass
            // 
            this.account_lbPass.AutoSize = true;
            this.account_lbPass.BackColor = System.Drawing.Color.Transparent;
            this.account_lbPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_lbPass.ForeColor = System.Drawing.Color.Snow;
            this.account_lbPass.Location = new System.Drawing.Point(19, 65);
            this.account_lbPass.Name = "account_lbPass";
            this.account_lbPass.Size = new System.Drawing.Size(67, 17);
            this.account_lbPass.TabIndex = 8;
            this.account_lbPass.Text = "Password:";
            this.account_lbPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account_lbUser
            // 
            this.account_lbUser.AutoSize = true;
            this.account_lbUser.BackColor = System.Drawing.Color.Transparent;
            this.account_lbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_lbUser.ForeColor = System.Drawing.Color.Snow;
            this.account_lbUser.Location = new System.Drawing.Point(19, 10);
            this.account_lbUser.Name = "account_lbUser";
            this.account_lbUser.Size = new System.Drawing.Size(70, 17);
            this.account_lbUser.TabIndex = 7;
            this.account_lbUser.Text = "Username:";
            // 
            // account_tbxPass
            // 
            this.account_tbxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.account_tbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_tbxPass.Enabled = false;
            this.account_tbxPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_tbxPass.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.account_tbxPass.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.account_tbxPass.Location = new System.Drawing.Point(22, 88);
            this.account_tbxPass.Name = "account_tbxPass";
            this.account_tbxPass.Size = new System.Drawing.Size(150, 18);
            this.account_tbxPass.TabIndex = 6;
            this.account_tbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassChanging);
            this.account_tbxPass.Leave += new System.EventHandler(this.PassChanged);
            // 
            // account_tbxUser
            // 
            this.account_tbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.account_tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_tbxUser.CausesValidation = false;
            this.account_tbxUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.account_tbxUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_tbxUser.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.account_tbxUser.Location = new System.Drawing.Point(22, 32);
            this.account_tbxUser.Margin = new System.Windows.Forms.Padding(0);
            this.account_tbxUser.Name = "account_tbxUser";
            this.account_tbxUser.ReadOnly = true;
            this.account_tbxUser.Size = new System.Drawing.Size(150, 18);
            this.account_tbxUser.TabIndex = 5;
            // 
            // account_editDel
            // 
            this.account_editDel.ActiveLinkColor = System.Drawing.Color.LightSalmon;
            this.account_editDel.AutoSize = true;
            this.account_editDel.BackColor = System.Drawing.Color.Transparent;
            this.account_editDel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_editDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_editDel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.account_editDel.LinkColor = System.Drawing.Color.LightSalmon;
            this.account_editDel.Location = new System.Drawing.Point(19, 154);
            this.account_editDel.Name = "account_editDel";
            this.account_editDel.Size = new System.Drawing.Size(105, 19);
            this.account_editDel.TabIndex = 17;
            this.account_editDel.TabStop = true;
            this.account_editDel.Text = "Delete Account";
            this.account_editDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.account_editDel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cus_delAccount_LinkClicked);
            // 
            // account_editPass
            // 
            this.account_editPass.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.account_editPass.AutoSize = true;
            this.account_editPass.BackColor = System.Drawing.Color.Transparent;
            this.account_editPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_editPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_editPass.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.account_editPass.LinkColor = System.Drawing.Color.SkyBlue;
            this.account_editPass.Location = new System.Drawing.Point(19, 124);
            this.account_editPass.Name = "account_editPass";
            this.account_editPass.Size = new System.Drawing.Size(119, 19);
            this.account_editPass.TabIndex = 16;
            this.account_editPass.TabStop = true;
            this.account_editPass.Text = "Change Password";
            this.account_editPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.account_editPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cus_edit_pass_LinkClicked);
            // 
            // menu_btnAccount
            // 
            this.menu_btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.menu_btnAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu_btnAccount.FlatAppearance.BorderSize = 0;
            this.menu_btnAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.menu_btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu_btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.menu_btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btnAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_btnAccount.ForeColor = System.Drawing.Color.White;
            this.menu_btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("menu_btnAccount.Image")));
            this.menu_btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnAccount.Location = new System.Drawing.Point(0, 430);
            this.menu_btnAccount.Name = "menu_btnAccount";
            this.menu_btnAccount.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.menu_btnAccount.Size = new System.Drawing.Size(190, 40);
            this.menu_btnAccount.TabIndex = 15;
            this.menu_btnAccount.Text = "   Account";
            this.menu_btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.menu_btnAccount.UseVisualStyleBackColor = false;
            this.menu_btnAccount.Click += new System.EventHandler(this.Menu_Account_Click);
            // 
            // _timer1
            // 
            this._timer1.Interval = 1;
            this._timer1.Tick += new System.EventHandler(this.Effect);
            // 
            // controlMySubjects
            // 
            this.controlMySubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMySubjects.Location = new System.Drawing.Point(190, 40);
            this.controlMySubjects.Name = "controlMySubjects";
            this.controlMySubjects.Size = new System.Drawing.Size(660, 480);
            this.controlMySubjects.TabIndex = 2;
            // 
            // controlAdmin
            // 
            this.controlAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.controlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlAdmin.Location = new System.Drawing.Point(190, 40);
            this.controlAdmin.Name = "controlAdmin";
            this.controlAdmin.Size = new System.Drawing.Size(660, 480);
            this.controlAdmin.TabIndex = 4;
            // 
            // Main_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 520);
            this.Controls.Add(this.controlMySubjects);
            this.Controls.Add(this.controlAdmin);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.topbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.VisibleChanged += new System.EventHandler(this.Effect_Show_Manager);
            this.topbar.ResumeLayout(false);
            this.topbar_Search.ResumeLayout(false);
            this.topbar_Search.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.account.ResumeLayout(false);
            this.account.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Control_MySubjects controlMySubjects;
        private System.Windows.Forms.Button topbar_btnAdd;
        private System.Windows.Forms.Button topbar_btnBack;
        private System.Windows.Forms.Button topbar_btnDel;
        private System.Windows.Forms.Button topbar_btnEdit;
        private System.Windows.Forms.Button topbar_btnFinish;
        private System.Windows.Forms.Button topbar_btnMenu;
        private System.Windows.Forms.Button topbar_btnOut;
        private System.Windows.Forms.Label topbar_lbHeader;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Timer _timer1;
        private System.Windows.Forms.Button menu_btnMySubject;
        private System.Windows.Forms.Panel account;
        private System.Windows.Forms.Label account_separator_2;
        private System.Windows.Forms.Label account_separator_1;
        private System.Windows.Forms.Label account_lbPass;
        private System.Windows.Forms.Label account_lbUser;
        private System.Windows.Forms.TextBox account_tbxPass;
        private System.Windows.Forms.TextBox account_tbxUser;
        private System.Windows.Forms.LinkLabel account_editDel;
        private System.Windows.Forms.LinkLabel account_editPass;
        private System.Windows.Forms.Button menu_btnAccount;
        private System.Windows.Forms.Button menu_btnUserList;
        private System.Windows.Forms.Button menu_btnSubjectList;
        private Control_Admin controlAdmin;
        private System.Windows.Forms.Button menu_btnSubjectUsers;
        private System.Windows.Forms.TextBox topbar_txtSearch;
        private System.Windows.Forms.Panel topbar_Search;
        private System.Windows.Forms.Button topbar_btnSearch;
        private System.Windows.Forms.Button topbar_btnExport;
    }
}