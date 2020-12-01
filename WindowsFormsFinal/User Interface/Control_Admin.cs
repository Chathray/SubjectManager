using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsFinal
{
    public partial class Control_Admin : UserControl
    {
        /* thành phần này tượng trưng cho panel quản lí của một admin */

        internal string ID;
        public Control_Admin()
        {
            InitializeComponent();
        }

        internal void Control_Admin_Load()
        {
            /* ràng buộc DataGridView với BindingSource và lấy về dữ liệu từ database.*/
            dataTable.DataSource = bindingSource;
            GetData("SELECT * FROM " + ID);
        }

        // lấy về dữ liệu từ database
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        private void GetData(string selectCommand)
        {
            try
            {
                string connectionString = DataProvider.connectionStr;

                // tạo Data Adapter mới dựa trên truy vấn được chỉ định.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                /* tạo Command Builder để tạo ra lệnh SQL update, insert, and
                 * delete dựa trên selectCommand. */
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // điền dữ liệu vào bảng và ràng buộc nó vào BindingSource.
                table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error.");
            }
        }

        // đồng bộ dữ liệu từ bảng đến database
        private void Toolbar_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(dataAdapter.Update(table) + " Rows Successfully Updated.");
                Control_Admin_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        // đồng bộ dữ liệu từ database về bảng
        private void Toolbar_Refresh_Click(object sender, EventArgs e)
        {
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        // in bảng dữ liệu ra file PDF
        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToPDF.ExportDataTableToPdf(table, "Export_" + ID + ".pdf", ID);
                System.Diagnostics.Process.Start("Export_" + ID + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        // tìm kiếm nội dung trong bảng
        internal void FindString(string s)
        {
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                    if (item.ToString() == s)
                    {
                        dataTable.ClearSelection();
                        dataTable.Rows[i].Selected = true;
                        dataTable.FirstDisplayedScrollingRowIndex = i;
                        return;
                    }
                i++;
            }
            MessageBox.Show("The string was not found.");
        }
    }
}