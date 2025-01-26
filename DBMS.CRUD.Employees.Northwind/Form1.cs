using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS.CRUD.Employees.Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        int employeeID = 0;
        string firstName = string.Empty;
        string lastName = string.Empty;
        string title = string.Empty;
        string titleOfCourtesy = string.Empty;
        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectNorthwind();
            showdata();
        }
        private void showdata()
        {
            string sql = "SELECT * FROM Employees";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvEmployees.DataSource = ds.Tables[0];
        }

        private void dgvEmployees_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeID = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            firstName = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            lastName = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            title = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            titleOfCourtesy = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (employeeID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            frmEmployees f = new frmEmployees();
            f.Status = "update";
            f.EmployeeID = employeeID;
            f.FirstName = firstName;
            f.LastName = lastName;
            f.Title = title;
            f.TitleOfCourtesy = titleOfCourtesy;
            f.ShowDialog();
            showdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (employeeID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "เกิดข้อผิดพลาด");
                return;
            }

            string msg = employeeID.ToString() + Environment.NewLine;
            msg += "คำนำหน้า :" + titleOfCourtesy + Environment.NewLine;
            msg += "ชื่อ :" + firstName + Environment.NewLine;
            msg += "นามสกุล :" + lastName;

            if (MessageBox.Show(msg, "ต้องการลบข้อมูลชุดนี้หรือไม่", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            string sql = "DELETE FROM Employees WHERE EmployeeID = @employeeID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@employeeID", employeeID);

            try
            {
                conn.Open();
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ", "สำเร็จ");
                    showdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด" + Environment.NewLine + ex.Message, "Error!!!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdate.PerformClick();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmEmployees f = new frmEmployees();
            f.Status = "insert";
            f.ShowDialog();
            showdata();
        }
    }
}
