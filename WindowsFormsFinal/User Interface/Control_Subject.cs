using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsFinal
{
    public partial class Control_Subject : UserControl
    {
        /* thành phần này tượng trưng cho một môn học của sinh viên
         * nó chứa các thông tin cần thiết của một môn học*/
        internal string SubjectCode;
        internal string SubjectName;
        internal string Lecturer;
        internal string StartDate;
        internal string EndDate;
        internal string Credits;
        internal string Information;

        // khởi tạo đối tượng môn học và set các thuộc tính cần thiết cho nó
        public Control_Subject(DataRow data)
        {
            InitializeComponent();

            Name = data["Subject Code"].ToString();
            Dock = DockStyle.Top;

            SubjectCode = data["Subject Code"].ToString();
            SubjectName = data["Subject Name"].ToString();
            Information = data["Information"].ToString();
            Lecturer = data["Lecturer"].ToString();
            Credits = data["Credits"].ToString();

            DateTime TMP;
            TMP = DateTime.Parse(data["Start Date"].ToString());
            StartDate = TMP.ToString("d");
            TMP = DateTime.Parse(data["End Date"].ToString());
            EndDate = TMP.ToString("d");

            label1.Text = data["Subject Name"].ToString();
            label2.Text = data["Lecturer"].ToString();
        }

        // tạo các sự kiện theo dõi khi click đối tượng
        internal delegate void MyClickEvent(object sender, Control_Subject c);
        internal event MyClickEvent UserClick;

        internal void ClickEvent(object sender, Control_Subject c)
        {
            UserClick?.Invoke(sender, c); // execute event
        }

        internal void Subject_OBJ_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(220, 240, 240);
        }

        internal void Subject_OBJ_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        internal void Subject_OBJ_MouseDown(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.LightBlue;
            label2.BackColor = Color.LightBlue;
            label3.BackColor = Color.LightBlue;
            ClickEvent(sender, this);
        }

        internal void Subject_OBJ_MouseUp(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

    }
}