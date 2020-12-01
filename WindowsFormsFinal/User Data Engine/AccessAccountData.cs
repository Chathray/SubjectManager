using System;
using System.Data;

namespace WindowsFormsFinal
{
    public class AccessData
    {
        // lớp này chứa các lệnh truy vấn cơ sở dữ liệu SQL cần thiết
        private static AccessData instance;

        private AccessData() { }
        public static AccessData GetInstance()
        {
            if (instance == null)
            {
                instance = new AccessData();
            }
            return instance;
        }

        #region QUERY USER
        //--
        internal bool Login(string Username, string Password)
        {
            string query = "SELECT * FROM Student_List " +
                "WHERE Username='" + Username + "'and Password='" + Password + "'";

            DataTable result = DataProvider.ExecuteReader(query);

            return result.Rows.Count > 0;
        }

        //--
        internal bool Signup(string Username, string Password)
        {
            string nonquery = "INSERT into Student_List " +
                "VALUES('" + Username + "','" + Password + "')";

            return DataProvider.ExecuteNonQuery(nonquery);
        }

        //--
        internal bool DeleteAccount(string Username)
        {
            string nonquery1 = "DELETE FROM Student_Subject " +
                "WHERE Username='" + Username + "'";

            string nonquery2 = "DELETE FROM Student_List " +
                "WHERE Username='" + Username + "'";

            bool result = DataProvider.ExecuteNonQuery(nonquery1) &&
                          DataProvider.ExecuteNonQuery(nonquery2);
            return result;
        }

        //--
        internal bool ChangePassword(string Username, string newPass, string oldPass)
        {
            string nonquery = "UPDATE Student_List " +
                "SET Password='" + newPass + "' " +
                "WHERE Username='" + Username + "'and Password='" + oldPass + "'";

            return DataProvider.ExecuteNonQuery(nonquery);
        }

        //--
        internal DataTable GetUserSubjectList(string Username, string sortBy)
        {
            string query = "SELECT * " +
                "FROM Subject_List LEFT OUTER JOIN Student_Subject " +
                "ON Student_Subject.[Subject Code] = Subject_List.[Subject Code] " +
                "WHERE Username = '" + Username + "'";

            DataTable result = DataProvider.ExecuteReader(query);
            result.DefaultView.Sort = sortBy;
            result = result.DefaultView.ToTable();

            return result;
        }

        //--
        internal DataTable GetUserSubjectList(string Username)
        {
            string query = "SELECT Subject_List.* " +
                "FROM Subject_List JOIN Student_Subject " +
                "ON Student_Subject.[Subject Code] = Subject_List.[Subject Code] " +
                "WHERE Username = '" + Username + "'";

            DataTable result = DataProvider.ExecuteReader(query);
            return result;
        }

        //--
        internal bool AddUserSubject(string Username, string[] s)
        {
            string nonquery = "INSERT into Student_Subject VALUES('" + Username + "','" +
                s[0] + "',N'" + s[2] + "','" + s[3] + "','" + s[4] + "',N'" + s[6] + "')";

            return DataProvider.ExecuteNonQuery(nonquery);
        }

        //--
        internal bool UpdateUserSubject(string Username, string[] s)
        {
            string nonquery = "UPDATE Student_Subject SET " +
                "Lecturer=N'" + s[2] + "'," +
                "[Start Date]='" + s[3] + "'," +
                "[End Date]='" + s[4] + "'," +
                "Information=N'" + s[6] + "' " +
                "WHERE Username='" + Username + "'and [Subject Code]='" + s[0] + "'";

            return DataProvider.ExecuteNonQuery(nonquery);
        }

        //--
        internal bool DeleteUserSubject(string Username, string SubjectCode)
        {
            string nonquery = "DELETE FROM Student_Subject " +
                "WHERE [Subject Code]='" + SubjectCode + "'and Username='" + Username + "'";

            return DataProvider.ExecuteNonQuery(nonquery);
        }
        #endregion



        #region QUERY ADMIN
        //--
        internal DataTable GetUserList()
        {
            string query = "SELECT * FROM Student_List";

            DataTable result = DataProvider.ExecuteReader(query);
            return result;
        }

        //--
        internal DataTable GetSubjectList()
        {
            string query = "SELECT * FROM Subject_List";

            DataTable result = DataProvider.ExecuteReader(query);
            return result;
        }

        //--
        internal DataTable GetStudentSubjectList()
        {
            string query = "SELECT * FROM Student_List";

            DataTable result = DataProvider.ExecuteReader(query);
            return result;
        }

        //--
        internal bool CheckSubject(string SubjectCode)
        {
            string query = "SELECT * FROM Subject_List " +
                "WHERE [Subject Code]='" + SubjectCode + "'";

            DataTable result = DataProvider.ExecuteReader(query);

            return result.Rows.Count > 0;
        }

        //--
        internal bool AddSubject(string[] s)
        {
            string nonquery = "INSERT into Subject_List VALUES('" +
                s[0] + "',N'" + s[1] + "','" + s[5] + "')";

            return DataProvider.ExecuteNonQuery(nonquery);
        }

        //--
        internal bool UpdateSubject(string[] s)
        {
            string nonquery = "UPDATE Subject_List SET " +
                "[Subject Name]=N'" + s[1] + "'," +
                "Credits='" + s[5] + "' " +
                "WHERE [Subject Code]='" + s[0] + "'";

            return DataProvider.ExecuteNonQuery(nonquery);
        }
        #endregion
    }
}