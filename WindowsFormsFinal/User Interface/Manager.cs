using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsFinal
{
    public partial class Main_Manager : Form
    {
        /* _id và _key lần lượt là tên đăng nhập và mật khẩu để có thể mở 1 form quản lí,
         * nếu _id là admin thì form sẽ khởi động theo quyền của người quản trị
         * nếu _id khác thì form sẽ khởi động theo quyền của người dùng */
        private readonly string _admin = "admin";
        private readonly string _id;
        private string _key;

        public Main_Manager(string id, string key)
        {
            InitializeComponent();

            _id = id;
            _key = key;
            account_tbxUser.Text = id;
            account_tbxPass.Text = key;

            menu_btnMySubject.Tag = controlMySubjects;
            menu_btnSubjectUsers.Tag = controlAdmin;
            menu_btnSubjectList.Tag = controlAdmin;
            menu_btnUserList.Tag = controlAdmin;

            if (id != _admin)
                MakeUItoUserMode();
            else MakeUItoAdminMode();
        }

        #region XỬ LÝ TỔNG QUAN GIAO DIỆN

        // hiệu ứng mờ dần khi hiện cửa sổ Manager
        private void Effect_Show_Manager(object sender, EventArgs e)
        {
            Opacity = 0;
            _timer1.Start();
        }
        private void Effect(object sender, EventArgs e)
        {
            Opacity += 0.08;
            if (Opacity <= 0) _timer1.Stop();
        }

        // ẩn toàn bộ toolbar
        private void HideAllToolbar()
        {
            topbar_btnDel.Hide();
            topbar_btnEdit.Hide();
            topbar_btnAdd.Hide();
            topbar_btnExport.Hide();
        }

        // hiện toàn bộ toolbar
        private void ShowAllToolbar()
        {
            topbar_btnDel.Show();
            topbar_btnEdit.Show();
            topbar_btnAdd.Show();
            topbar_btnExport.Show();
        }

        // vào giao diện quản trị (admin)
        private void MakeUItoAdminMode()
        {
            menu_btnSubjectList.Show();
            menu_btnUserList.Show();
            menu_btnSubjectUsers.Show();

            topbar_btnFinish.Hide();
            topbar_btnBack.Hide();
            account_editDel.Hide();

            controlMySubjects.FillAllSubjects(_id);
        }

        // vào giao diện người dùng (admin)
        private void MakeUItoUserMode()
        {
            topbar_btnBack.Hide();
            topbar_btnFinish.Hide();

            controlMySubjects.FillAllSubjects(_id);
        }

        string[] backupText;
        // vào chế độ thêm/sửa học phần
        private void MakeUItoTypingMode()
        {
            backupText = controlMySubjects.GetTextBoxes();

            HideAllToolbar();
            topbar_btnFinish.Show();
            topbar_btnBack.Show();

            controlMySubjects.Panel1Collapse();
            controlMySubjects.CanEditTextBoxes();
        }

        // vào chế độ xem danh sách học phần
        private void MakeUItoViewMode()
        {
            ShowAllToolbar();
            topbar_btnFinish.Hide();
            topbar_btnBack.Hide();

            controlMySubjects.NonEditTextBoxes();
            controlMySubjects.Panel1Expand();
        }

        // làm mới danh sách học phần
        private void RefreshMySubject()
        {
            controlMySubjects.splitContainer.Panel1.Controls.Clear();
            controlMySubjects.ClearTextBoxes();
            controlMySubjects.FillAllSubjects(_id);
            MakeUItoViewMode();
        }
        #endregion


        #region NHẬN VÀ XỬ LÝ CÁC SỰ KIỆN

        // sự kiện khi click vào nhãn tiêu đề
        private void Topbar_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        // sự kiện khi thoát cửa sổ Manager (đăng xuất)
        private void Topbar_close_Click(object sender, EventArgs e)
        {
            Dispose(true);
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
                Location = new Point(Cursor.Position.X - xOffset,
                                     Cursor.Position.Y - yOffset);
        }
        private void Topbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // thêm học phần sinh viên
        private void Topbar_btnAdd_Click(object sender, EventArgs e)
        {
            topbar_btnFinish.Tag = sender as Button;

            MakeUItoTypingMode();
            controlMySubjects.ClearTextBoxes();
            controlMySubjects.textBox1.Focus();
        }
        // xác nhận thêm
        private void FinishAdd(string[] sevenField)
        {
            bool logic;
            var AAD = AccessData.GetInstance();

            logic = !AAD.CheckSubject(sevenField[0]) &&
                AAD.AddSubject(sevenField) &&
                AAD.AddUserSubject(_id, sevenField);
            if (logic)
            {
                RefreshMySubject();
                MessageBox.Show("Completion!");
                return;
            }

            logic = AAD.AddUserSubject(_id, sevenField);
            if (logic)
            {
                RefreshMySubject();
                MessageBox.Show("Completion!");
                return;
            }
            MessageBox.Show("Error.");
        }

        // sửa học phần sinh viên
        private void Topbar_btnEdit_Click(object sender, EventArgs e)
        {
            if (controlMySubjects.NonSubjectClicked)
                MessageBox.Show("No subject selected yet!");
            else
            {
                topbar_btnFinish.Tag = sender as Button;
                MakeUItoTypingMode();
                controlMySubjects.textBox1.ReadOnly = true;
                controlMySubjects.textBox2.Focus();
            }
        }
        // xác nhận sửa
        private void FinishEdit(string[] sevenField)
        {
            var AAD = AccessData.GetInstance();
            bool logic = AAD.UpdateUserSubject(_id, sevenField) &&
                         AAD.UpdateSubject(sevenField);

            if (logic)
                RefreshMySubject();
            else { MessageBox.Show("Error."); return; }
        }

        // thoát khỏi chế độ thêm/sửa học phần sinh viên
        private void Topbar_btnBack_Click(object sender, EventArgs e)
        {
            controlMySubjects.SetTextBoxes(backupText);
            MakeUItoViewMode();
        }

        // xác nhận sự kiện thêm/sửa học phần sinh viên
        private void Topbar_btnFinish_Click(object sender, EventArgs e)
        {
            string[] sevenField = controlMySubjects.GetTextBoxes();

            if ((sender as Button).Tag.Equals(topbar_btnAdd))
                FinishAdd(sevenField);
            else if ((sender as Button).Tag.Equals(topbar_btnEdit))
                FinishEdit(sevenField);
        }

        // xóa học phần sinh viên
        private void Topbar_btnDel_Click(object sender, EventArgs e)
        {
            if (controlMySubjects.NonSubjectClicked)
                MessageBox.Show("No subject selected yet!");
            else
            {
                DialogResult result = MessageBox.
                    Show("Cannot recover deleted data.", "Warning!",
                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (AccessData.GetInstance()
                    .DeleteUserSubject(_id, controlMySubjects.textBox1.Text))
                    {
                        RefreshMySubject();
                    }
                    else MessageBox.Show("Error.");
                }
            }
        }

        // sự kiện ẩn menu điều hướng
        private bool navColapse = false;
        private void Topbar_Nav_Click(object sender, EventArgs e)
        {
            navColapse = !navColapse;
            if (navColapse)
                menu.Hide();
            else
                menu.Show();
        }

        // các sự kiện trên menu điều hướng
        private void Menu_Control_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;

            topbar_lbHeader.Text = obj.Text.Trim().ToUpper();
            string temp = topbar_lbHeader.Text;
            switch (temp)
            {
                case "MY SUBJECTS":
                    ShowAllToolbar();
                    MakeUItoViewMode();
                    topbar_btnSearch.Hide();
                    topbar_Search.Hide();
                    break;

                default:
                    HideAllToolbar();
                    topbar_btnSearch.Show();
                    topbar_Search.Show();
                    topbar_btnBack.Hide();
                    topbar_btnFinish.Hide();
                    if (temp == "SUBJECT OF USERS")
                        (obj.Tag as Control_Admin).ID = "Student_Subject";
                    else if (temp == "SUBJECT LIST")
                        (obj.Tag as Control_Admin).ID = "Subject_List";
                    else
                        (obj.Tag as Control_Admin).ID = "Student_List";

                    (obj.Tag as Control_Admin).Control_Admin_Load();
                    break;
            }
            (obj.Tag as UserControl).BringToFront();
        }

        // chọn vào menu Account
        private bool customClick = true;
        private void Menu_Account_Click(object sender, EventArgs e)
        {
            customClick = !customClick;
            if (customClick)
                account.Show();
            else
                account.Hide();
        }

        // xóa tài khoản
        private void Cus_delAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Cannot recover deleted data.", "Warning!",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (AccessData.GetInstance().DeleteAccount(_id))
                    MessageBox.Show("Done!");
                else MessageBox.Show("Error.");

                Dispose(true);
            }
        }

        // đổi mật khẩu
        private void Cus_edit_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            account_tbxPass.Enabled = true;
            account_tbxPass.Focus();
        }
        private void PassChanging(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                // nhấn Enter
                account_tbxPass.Enabled = false;
        }
        private void PassChanged(object sender, EventArgs e)
        {
            if (AccessData.GetInstance().
                ChangePassword(_id, account_tbxPass.Text, _key))
            {
                _key = account_tbxPass.Text;
                MessageBox.Show("Done!");
            }
            else MessageBox.Show("Error.");

            account_tbxPass.Enabled = false;
        }

        // xuất dữ liệu môn học ra file PDF
        private void Topbar_btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = AccessData.GetInstance().GetUserSubjectList(_id);
            try
            {
                WindowState = FormWindowState.Minimized;
                ExportToPDF.ExportDataTableToPdf(dt, "Export_Data.pdf", "My Subjects");
                System.Diagnostics.Process.Start("Export_Data.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        // tìm kiếm dữ liệu (chỉ admin)
        private void Topbar_btnSearch_Click(object sender, EventArgs e)
        {
            controlAdmin.FindString(topbar_txtSearch.Text);
        }
        #endregion
    }
}
