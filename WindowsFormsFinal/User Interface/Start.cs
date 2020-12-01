using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsFinal
{
    public partial class Main_Start : Form
    {
        public Main_Start()
        {
            InitializeComponent();

            login_tbxUser.Select();
        }

        // hiệu ứng mờ dần khi mở cửa sổ Start
        private void Effect_Start(object sender, EventArgs e)
        {
            /* tận dụng tính chất của thành phần Timer để tạo
             * hiệu ứng mờ dần khi đóng mở cửa sổ */
            if (!Visible)
            {
                Opacity = 1;
                _timer1.Start();
            }
            else
            {
                Opacity = 0;
                _timer2.Start();
            }
        }
        private void Effect_1(object sender, EventArgs e)
        {
            Opacity -= 0.08;
            if (Opacity <= 0) _timer1.Stop();
        }
        private void Effect_2(object sender, EventArgs e)
        {
            Opacity += 0.08;
            if (Opacity >= 1) _timer2.Stop();
        }

        // sự kiện đóng cửa sổ Start (thoát chương trình)
        private void Topbar_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // điều khiển việc kéo thả (di chuyển) cửa sổ
        private bool dragging = false;
        int xOffset = 0;
        int yOffset = 0;
        private void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            xOffset = Cursor.Position.X - Location.X;
            yOffset = Cursor.Position.Y - Location.Y;
        }
        private void Topbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Location = new Point(Cursor.Position.X - xOffset, Cursor.Position.Y - yOffset);
            }
        }
        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // điều hướng panel đăng nhập
        private void Topbar_LoginTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginTab_LinkClicked();
        }
        private void LoginTab_LinkClicked()
        {
            preface.BackColor = Color.DodgerBlue;
            AcceptButton = login_btn;

            topbar_loginTab.LinkColor = Color.DodgerBlue;
            topbar_signTab.LinkColor = Color.Gray;

            sign_tbxUser.Clear();
            sign_tbxPass.Clear();
            sign_tbxRepass.Clear();

            login.BringToFront();

            login_tbxUser.Select();
        }

        // điều hướng panel đăng kí
        private void Topbar_SignTab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignTab_LinkClicked();
        }
        private void SignTab_LinkClicked()
        {
            preface.BackColor = Color.Coral;
            AcceptButton = sign_btn;

            topbar_loginTab.LinkColor = Color.Gray;
            topbar_signTab.LinkColor = Color.Coral;

            login_tbxUser.Clear();
            login_tbxPass.Clear();

            sign.BringToFront();

            sign_tbxUser.Select();
        }

        //***** sự kiện đăng nhập
        private void Log_Button_Click(object sender, EventArgs e)
        {
            if (AccessData.GetInstance().Login(login_tbxUser.Text, login_tbxPass.Text))
            {
                Hide();
                Form manager = new Main_Manager(login_tbxUser.Text, login_tbxPass.Text);
                manager.ShowDialog();
                Show();
            }
            else
                MessageBox.Show("Error.");
        }

        //***** sự kiện đăng kí
        private void Sign_Button_Click(object sender, EventArgs e)
        {
            string username = sign_tbxUser.Text;
            string password = sign_tbxPass.Text;
            string repassword = sign_tbxRepass.Text;

            /* kiểm tra tính hợp lệ của thông tin */
            bool OK = CheckUsername(username) &&
                      !password.Any(c => c > 255) &&
                      password.Equals(repassword);

            if (OK)
            {
                if (AccessData.GetInstance().Signup(username, password))
                {
                    MessageBox.Show("* Tên tài khoản: " + username + "\n\n" + "** Mật khẩu: " + password,
                    "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginTab_LinkClicked();
                }
                else
                    MessageBox.Show("Error.");
            }
            else MessageBox.Show("* Bạn cần nhập đủ và đúng thông tin\n\n** Không dùng Tiếng Việt có dấu!",
                 "Tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // kiểm tra tên người dùng hợp lệ
        private bool CheckUsername(string name)
        {
            /* dùng Regular Expression để kiểm soát cách người dùng nhập dữ liệu*/
            Regex r = new Regex("^[a-zA-Z][a-zA-Z 0-9]{0,20}$");
            bool result = r.IsMatch(name);

            return result;
        }
    }
}