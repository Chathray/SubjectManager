using System.Data;
using System.Windows.Forms;

namespace WindowsFormsFinal
{
    public partial class Control_MySubjects : UserControl
    {
        /* đây là thành phần tượng trương cho panel quản lí môn học của một sinh viên */
        public Control_MySubjects()
        {
            InitializeComponent();
        }

        internal bool NonSubjectClicked
        {
            get
            {
                return 0.Equals
               (textBox1.TextLength +
                textBox2.TextLength +
                textBox3.TextLength +
                textBox4.TextLength +
                textBox5.TextLength +
                textBox6.TextLength +
                textBox7.TextLength);
            }
        }

        // đổ các đối tượng môn học vào panel
        static DataTable dataFields;
        internal void FillAllSubjects(string Username, string sortBy = "[Subject Name] DESC")
        {
            dataFields = AccessData.GetInstance().GetUserSubjectList(Username, sortBy);

            foreach (DataRow row in dataFields.Rows)
            {
                var TMP = new Control_Subject(row);
                TMP.UserClick += SetTextBoxes;
                splitContainer.Panel1.Controls.Add(TMP);
            }
        }

        // thu gọn/ mở rộng panel1 (panel con để chứa các đối tượng môn học)
        internal void Panel1Collapse()
        {
            splitContainer.Panel1Collapsed = true;
        }
        internal void Panel1Expand()
        {
            splitContainer.Panel1Collapsed = false;
        }

        // cho phép sửa các thành phần TextBox
        internal void CanEditTextBoxes()
        {
            textBox2.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox1.ReadOnly = false;
        }

        // không cho phép sửa các thành phần TextBox
        internal void NonEditTextBoxes()
        {
            textBox2.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        // làm sạch các thành phần TextBox
        internal void ClearTextBoxes()
        {
            textBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
        }

        // đổ dữ liệu vào các thành phần TextBox
        internal void SetTextBoxes(object sender, Control_Subject c)
        {
            textBox1.Text = c.SubjectCode;
            textBox2.Text = c.SubjectName;
            textBox3.Text = c.Lecturer;
            textBox4.Text = c.StartDate;
            textBox5.Text = c.EndDate;
            textBox6.Text = c.Credits;
            textBox7.Text = c.Information;
        }
        internal void SetTextBoxes(string[] s)
        {
            textBox1.Text = s[0];
            textBox2.Text = s[1];
            textBox3.Text = s[2];
            textBox4.Text = s[3];
            textBox5.Text = s[4];
            textBox6.Text = s[5];
            textBox7.Text = s[6];
        }
        
        // lấy thông tin từ các thành phần TextBox
        internal string[] GetTextBoxes()
        {
            string[] listRange = new string[7];
            listRange[0] = textBox1.Text;
            listRange[1] = textBox2.Text;
            listRange[2] = textBox3.Text;
            listRange[3] = textBox4.Text;
            listRange[4] = textBox5.Text;
            listRange[5] = textBox6.Text;
            listRange[6] = textBox7.Text;

            return listRange;
        }
    }
}