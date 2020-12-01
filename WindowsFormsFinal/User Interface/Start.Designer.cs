namespace WindowsFormsFinal
{
    partial class Main_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Start));
            this._timer1 = new System.Windows.Forms.Timer(this.components);
            this._timer2 = new System.Windows.Forms.Timer(this.components);
            this.login = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_lbPass = new System.Windows.Forms.Label();
            this.login_lbUser = new System.Windows.Forms.Label();
            this.login_tbxPass = new System.Windows.Forms.TextBox();
            this.login_tbxUser = new System.Windows.Forms.TextBox();
            this.preface = new System.Windows.Forms.Panel();
            this.preface_3 = new System.Windows.Forms.Label();
            this.preface_1 = new System.Windows.Forms.Label();
            this.preface_2 = new System.Windows.Forms.Label();
            this.preface_0 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Panel();
            this.sign_lbRepass = new System.Windows.Forms.Label();
            this.sign_tbxRepass = new System.Windows.Forms.TextBox();
            this.sign_btn = new System.Windows.Forms.Button();
            this.sign_lbPass = new System.Windows.Forms.Label();
            this.sign_lbUser = new System.Windows.Forms.Label();
            this.sign_tbxPass = new System.Windows.Forms.TextBox();
            this.sign_tbxUser = new System.Windows.Forms.TextBox();
            this.topbar = new System.Windows.Forms.Panel();
            this.topbar_signTab = new System.Windows.Forms.LinkLabel();
            this.topbar_close = new System.Windows.Forms.Button();
            this.topbar_separator = new System.Windows.Forms.Label();
            this.topbar_loginTab = new System.Windows.Forms.LinkLabel();
            this.login.SuspendLayout();
            this.preface.SuspendLayout();
            this.sign.SuspendLayout();
            this.topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _timer1
            // 
            this._timer1.Interval = 1;
            this._timer1.Tick += new System.EventHandler(this.Effect_1);
            // 
            // _timer2
            // 
            this._timer2.Interval = 1;
            this._timer2.Tick += new System.EventHandler(this.Effect_2);
            // 
            // login
            // 
            this.login.Controls.Add(this.login_btn);
            this.login.Controls.Add(this.login_lbPass);
            this.login.Controls.Add(this.login_lbUser);
            this.login.Controls.Add(this.login_tbxPass);
            this.login.Controls.Add(this.login_tbxUser);
            this.login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login.Location = new System.Drawing.Point(256, 60);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(344, 340);
            this.login.TabIndex = 2;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Transparent;
            this.login_btn.Location = new System.Drawing.Point(62, 223);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(225, 35);
            this.login_btn.TabIndex = 13;
            this.login_btn.Tag = "";
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.Log_Button_Click);
            // 
            // login_lbPass
            // 
            this.login_lbPass.AutoSize = true;
            this.login_lbPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_lbPass.Location = new System.Drawing.Point(58, 132);
            this.login_lbPass.Name = "login_lbPass";
            this.login_lbPass.Size = new System.Drawing.Size(70, 19);
            this.login_lbPass.TabIndex = 12;
            this.login_lbPass.Text = "Password:";
            // 
            // login_lbUser
            // 
            this.login_lbUser.AutoSize = true;
            this.login_lbUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_lbUser.Location = new System.Drawing.Point(58, 52);
            this.login_lbUser.Name = "login_lbUser";
            this.login_lbUser.Size = new System.Drawing.Size(74, 19);
            this.login_lbUser.TabIndex = 11;
            this.login_lbUser.Text = "Username:";
            // 
            // login_tbxPass
            // 
            this.login_tbxPass.BackColor = System.Drawing.Color.Ivory;
            this.login_tbxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tbxPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login_tbxPass.Location = new System.Drawing.Point(62, 161);
            this.login_tbxPass.Name = "login_tbxPass";
            this.login_tbxPass.Size = new System.Drawing.Size(225, 25);
            this.login_tbxPass.TabIndex = 2;
            this.login_tbxPass.UseSystemPasswordChar = true;
            // 
            // login_tbxUser
            // 
            this.login_tbxUser.AccessibleDescription = "";
            this.login_tbxUser.BackColor = System.Drawing.Color.Ivory;
            this.login_tbxUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tbxUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login_tbxUser.Location = new System.Drawing.Point(62, 80);
            this.login_tbxUser.Margin = new System.Windows.Forms.Padding(0);
            this.login_tbxUser.Name = "login_tbxUser";
            this.login_tbxUser.Size = new System.Drawing.Size(225, 25);
            this.login_tbxUser.TabIndex = 1;
            // 
            // preface
            // 
            this.preface.BackColor = System.Drawing.Color.DodgerBlue;
            this.preface.Controls.Add(this.preface_3);
            this.preface.Controls.Add(this.preface_1);
            this.preface.Controls.Add(this.preface_2);
            this.preface.Controls.Add(this.preface_0);
            this.preface.Dock = System.Windows.Forms.DockStyle.Left;
            this.preface.Location = new System.Drawing.Point(0, 0);
            this.preface.Name = "preface";
            this.preface.Size = new System.Drawing.Size(256, 400);
            this.preface.TabIndex = 0;
            // 
            // preface_3
            // 
            this.preface_3.BackColor = System.Drawing.Color.Transparent;
            this.preface_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preface_3.ForeColor = System.Drawing.Color.White;
            this.preface_3.Image = ((System.Drawing.Image)(resources.GetObject("preface_3.Image")));
            this.preface_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preface_3.Location = new System.Drawing.Point(53, 290);
            this.preface_3.Name = "preface_3";
            this.preface_3.Size = new System.Drawing.Size(65, 23);
            this.preface_3.TabIndex = 12;
            this.preface_3.Text = "Joy";
            this.preface_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // preface_1
            // 
            this.preface_1.BackColor = System.Drawing.Color.Transparent;
            this.preface_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preface_1.ForeColor = System.Drawing.Color.White;
            this.preface_1.Image = ((System.Drawing.Image)(resources.GetObject("preface_1.Image")));
            this.preface_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preface_1.Location = new System.Drawing.Point(53, 196);
            this.preface_1.Name = "preface_1";
            this.preface_1.Size = new System.Drawing.Size(148, 23);
            this.preface_1.TabIndex = 11;
            this.preface_1.Text = "Study Schedule";
            this.preface_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // preface_2
            // 
            this.preface_2.BackColor = System.Drawing.Color.Transparent;
            this.preface_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preface_2.ForeColor = System.Drawing.Color.White;
            this.preface_2.Image = ((System.Drawing.Image)(resources.GetObject("preface_2.Image")));
            this.preface_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preface_2.Location = new System.Drawing.Point(53, 243);
            this.preface_2.Name = "preface_2";
            this.preface_2.Size = new System.Drawing.Size(151, 23);
            this.preface_2.TabIndex = 10;
            this.preface_2.Text = "Group Manager";
            this.preface_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // preface_0
            // 
            this.preface_0.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preface_0.ForeColor = System.Drawing.Color.White;
            this.preface_0.Image = ((System.Drawing.Image)(resources.GetObject("preface_0.Image")));
            this.preface_0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.preface_0.Location = new System.Drawing.Point(13, 28);
            this.preface_0.Name = "preface_0";
            this.preface_0.Size = new System.Drawing.Size(230, 94);
            this.preface_0.TabIndex = 4;
            this.preface_0.Text = "Subject Manager";
            this.preface_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // sign
            // 
            this.sign.Controls.Add(this.sign_lbRepass);
            this.sign.Controls.Add(this.sign_tbxRepass);
            this.sign.Controls.Add(this.sign_btn);
            this.sign.Controls.Add(this.sign_lbPass);
            this.sign.Controls.Add(this.sign_lbUser);
            this.sign.Controls.Add(this.sign_tbxPass);
            this.sign.Controls.Add(this.sign_tbxUser);
            this.sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sign.Location = new System.Drawing.Point(256, 60);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(344, 340);
            this.sign.TabIndex = 3;
            // 
            // sign_lbRepass
            // 
            this.sign_lbRepass.AutoSize = true;
            this.sign_lbRepass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_lbRepass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sign_lbRepass.Location = new System.Drawing.Point(58, 173);
            this.sign_lbRepass.Name = "sign_lbRepass";
            this.sign_lbRepass.Size = new System.Drawing.Size(123, 19);
            this.sign_lbRepass.TabIndex = 20;
            this.sign_lbRepass.Text = "Confirm Password:";
            // 
            // sign_tbxRepass
            // 
            this.sign_tbxRepass.BackColor = System.Drawing.Color.Ivory;
            this.sign_tbxRepass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_tbxRepass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sign_tbxRepass.Location = new System.Drawing.Point(62, 200);
            this.sign_tbxRepass.Name = "sign_tbxRepass";
            this.sign_tbxRepass.Size = new System.Drawing.Size(225, 25);
            this.sign_tbxRepass.TabIndex = 19;
            this.sign_tbxRepass.UseSystemPasswordChar = true;
            // 
            // sign_btn
            // 
            this.sign_btn.BackColor = System.Drawing.Color.Coral;
            this.sign_btn.FlatAppearance.BorderSize = 0;
            this.sign_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_btn.ForeColor = System.Drawing.Color.Transparent;
            this.sign_btn.Location = new System.Drawing.Point(62, 252);
            this.sign_btn.Name = "sign_btn";
            this.sign_btn.Size = new System.Drawing.Size(225, 35);
            this.sign_btn.TabIndex = 18;
            this.sign_btn.Tag = "";
            this.sign_btn.Text = "Sign Up";
            this.sign_btn.UseVisualStyleBackColor = false;
            this.sign_btn.Click += new System.EventHandler(this.Sign_Button_Click);
            // 
            // sign_lbPass
            // 
            this.sign_lbPass.AutoSize = true;
            this.sign_lbPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sign_lbPass.Location = new System.Drawing.Point(58, 99);
            this.sign_lbPass.Name = "sign_lbPass";
            this.sign_lbPass.Size = new System.Drawing.Size(70, 19);
            this.sign_lbPass.TabIndex = 17;
            this.sign_lbPass.Text = "Password:";
            // 
            // sign_lbUser
            // 
            this.sign_lbUser.AutoSize = true;
            this.sign_lbUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sign_lbUser.Location = new System.Drawing.Point(58, 23);
            this.sign_lbUser.Name = "sign_lbUser";
            this.sign_lbUser.Size = new System.Drawing.Size(74, 19);
            this.sign_lbUser.TabIndex = 16;
            this.sign_lbUser.Text = "Username:";
            // 
            // sign_tbxPass
            // 
            this.sign_tbxPass.BackColor = System.Drawing.Color.Ivory;
            this.sign_tbxPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_tbxPass.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sign_tbxPass.Location = new System.Drawing.Point(62, 126);
            this.sign_tbxPass.Name = "sign_tbxPass";
            this.sign_tbxPass.Size = new System.Drawing.Size(225, 25);
            this.sign_tbxPass.TabIndex = 15;
            this.sign_tbxPass.UseSystemPasswordChar = true;
            // 
            // sign_tbxUser
            // 
            this.sign_tbxUser.BackColor = System.Drawing.Color.Ivory;
            this.sign_tbxUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_tbxUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sign_tbxUser.Location = new System.Drawing.Point(62, 50);
            this.sign_tbxUser.Margin = new System.Windows.Forms.Padding(0);
            this.sign_tbxUser.Name = "sign_tbxUser";
            this.sign_tbxUser.Size = new System.Drawing.Size(225, 25);
            this.sign_tbxUser.TabIndex = 14;
            // 
            // topbar
            // 
            this.topbar.Controls.Add(this.topbar_signTab);
            this.topbar.Controls.Add(this.topbar_close);
            this.topbar.Controls.Add(this.topbar_separator);
            this.topbar.Controls.Add(this.topbar_loginTab);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(256, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(344, 60);
            this.topbar.TabIndex = 1;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            // 
            // topbar_signTab
            // 
            this.topbar_signTab.ActiveLinkColor = System.Drawing.Color.Coral;
            this.topbar_signTab.BackColor = System.Drawing.Color.Transparent;
            this.topbar_signTab.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.topbar_signTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_signTab.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_signTab.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.topbar_signTab.LinkColor = System.Drawing.Color.Gray;
            this.topbar_signTab.Location = new System.Drawing.Point(103, 0);
            this.topbar_signTab.Name = "topbar_signTab";
            this.topbar_signTab.Size = new System.Drawing.Size(94, 60);
            this.topbar_signTab.TabIndex = 5;
            this.topbar_signTab.TabStop = true;
            this.topbar_signTab.Text = "Sign Up";
            this.topbar_signTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbar_signTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Topbar_SignTab_LinkClicked);
            // 
            // topbar_close
            // 
            this.topbar_close.BackColor = System.Drawing.Color.Transparent;
            this.topbar_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topbar_close.BackgroundImage")));
            this.topbar_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topbar_close.FlatAppearance.BorderSize = 0;
            this.topbar_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbar_close.Location = new System.Drawing.Point(304, 0);
            this.topbar_close.Name = "topbar_close";
            this.topbar_close.Size = new System.Drawing.Size(40, 30);
            this.topbar_close.TabIndex = 0;
            this.topbar_close.UseVisualStyleBackColor = false;
            this.topbar_close.Click += new System.EventHandler(this.Topbar_Close_Click);
            // 
            // topbar_separator
            // 
            this.topbar_separator.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_separator.Image = ((System.Drawing.Image)(resources.GetObject("topbar_separator.Image")));
            this.topbar_separator.Location = new System.Drawing.Point(93, 0);
            this.topbar_separator.Name = "topbar_separator";
            this.topbar_separator.Size = new System.Drawing.Size(10, 60);
            this.topbar_separator.TabIndex = 6;
            // 
            // topbar_loginTab
            // 
            this.topbar_loginTab.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.topbar_loginTab.BackColor = System.Drawing.Color.Transparent;
            this.topbar_loginTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbar_loginTab.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbar_loginTab.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.topbar_loginTab.LinkColor = System.Drawing.Color.DodgerBlue;
            this.topbar_loginTab.Location = new System.Drawing.Point(0, 0);
            this.topbar_loginTab.Name = "topbar_loginTab";
            this.topbar_loginTab.Size = new System.Drawing.Size(93, 60);
            this.topbar_loginTab.TabIndex = 4;
            this.topbar_loginTab.TabStop = true;
            this.topbar_loginTab.Text = "Log In";
            this.topbar_loginTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.topbar_loginTab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Topbar_LoginTab_LinkClicked);
            // 
            // Main_Start
            // 
            this.AcceptButton = this.login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.login);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.preface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Login";
            this.VisibleChanged += new System.EventHandler(this.Effect_Start);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.preface.ResumeLayout(false);
            this.sign.ResumeLayout(false);
            this.sign.PerformLayout();
            this.topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel preface;
        private System.Windows.Forms.Button topbar_close;
        private System.Windows.Forms.Label preface_0;
        private System.Windows.Forms.Label preface_2;
        private System.Windows.Forms.Label preface_3;
        private System.Windows.Forms.Label preface_1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.Panel sign;
        private System.Windows.Forms.LinkLabel topbar_signTab;
        private System.Windows.Forms.LinkLabel topbar_loginTab;
        private System.Windows.Forms.Label topbar_separator;
        private System.Windows.Forms.Label login_lbPass;
        private System.Windows.Forms.Label login_lbUser;
        private System.Windows.Forms.TextBox login_tbxPass;
        private System.Windows.Forms.TextBox login_tbxUser;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label sign_lbRepass;
        private System.Windows.Forms.TextBox sign_tbxRepass;
        private System.Windows.Forms.Button sign_btn;
        private System.Windows.Forms.Label sign_lbPass;
        private System.Windows.Forms.Label sign_lbUser;
        private System.Windows.Forms.TextBox sign_tbxPass;
        private System.Windows.Forms.TextBox sign_tbxUser;
        private System.Windows.Forms.Timer _timer1;
        private System.Windows.Forms.Timer _timer2;
    }
}

