using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS.CRUD.Employees.Northwind
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string Status { get; set; }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = EmployeeID.ToString();
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            txtTitle.Text = Title;
            txtTitleOfCourtesy.Text = TitleOfCourtesy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = connectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertEmployees();
            }
            else if (Status == "update")
            {
                UpdateEmployees();
            }
            this.Close();

        }

        private void UpdateEmployees()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string sql = "UPDATE Employees " +
                             "SET FirstName = @FirstName, LastName = @LastName, Title = @Title, TitleOfCourtesy = @TitleOfCourtesy " +
                             "WHERE EmployeeID = @EmployeeID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text.Trim());
                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("ข้อมูลถูกปรับปรุงเรียบร้อยแล้ว", "สำเร็จ");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void InsertEmployees()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string sql = "INSERT INTO Employees (FirstName, LastName, Title, TitleOfCourtesy) " +
                             "VALUES (@FirstName, @LastName, @Title, @TitleOfCourtesy)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text.Trim());

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("ข้อมูลถูกเพิ่มเรียบร้อยแล้ว", "สำเร็จ");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
