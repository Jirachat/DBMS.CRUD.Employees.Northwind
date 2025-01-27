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
        DateTime birthDate;
        DateTime hireDate;
        string address = string.Empty;
        string city = string.Empty;
        string region = string.Empty;
        string postalCode = string.Empty;
        string country = string.Empty;
        string homePhone = string.Empty;
        string extension = string.Empty;
        string photoPath = string.Empty; // เปลี่ยนเป็นเส้นทางรูปภาพ
        string notes = string.Empty;
        string reportsTo = string.Empty;
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
            if (e.RowIndex >= 0) // ตรวจสอบว่าแถวที่คลิกมีข้อมูล
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                employeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                firstName = row.Cells["FirstName"].Value?.ToString() ?? string.Empty;
                lastName = row.Cells["LastName"].Value?.ToString() ?? string.Empty;
                title = row.Cells["Title"].Value?.ToString() ?? string.Empty;
                titleOfCourtesy = row.Cells["TitleOfCourtesy"].Value?.ToString() ?? string.Empty;

                // ตรวจสอบว่า BirthDate เป็น DBNull หรือไม่
                if (row.Cells["BirthDate"].Value != DBNull.Value)
                {
                    birthDate = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                }
                else
                {
                    birthDate = DateTime.MinValue; // หรือกำหนดค่าเริ่มต้นอื่น ๆ
                }

                // ตรวจสอบว่า HireDate เป็น DBNull หรือไม่
                if (row.Cells["HireDate"].Value != DBNull.Value)
                {
                    hireDate = Convert.ToDateTime(row.Cells["HireDate"].Value);
                }
                else
                {
                    hireDate = DateTime.MinValue; // หรือกำหนดค่าเริ่มต้นอื่น ๆ
                }

                address = row.Cells["Address"].Value?.ToString() ?? string.Empty;
                city = row.Cells["City"].Value?.ToString() ?? string.Empty;
                region = row.Cells["Region"].Value?.ToString() ?? string.Empty;
                postalCode = row.Cells["PostalCode"].Value?.ToString() ?? string.Empty;
                country = row.Cells["Country"].Value?.ToString() ?? string.Empty;
                homePhone = row.Cells["HomePhone"].Value?.ToString() ?? string.Empty;
                extension = row.Cells["Extension"].Value?.ToString() ?? string.Empty;
                photoPath = row.Cells["PhotoPath"].Value?.ToString() ?? string.Empty; // ดึงเส้นทางรูปภาพ
                notes = row.Cells["Notes"].Value?.ToString() ?? string.Empty;

                // ตรวจสอบว่า ReportsTo เป็น DBNull หรือไม่
                if (row.Cells["ReportsTo"].Value != DBNull.Value)
                {
                    reportsTo = row.Cells["ReportsTo"].Value?.ToString() ?? string.Empty;
                }
                else
                {
                    reportsTo = string.Empty; // หรือกำหนดค่าเริ่มต้นอื่น ๆ
                }
            }
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
            f.BirthDate = birthDate;
            f.HireDate = hireDate;
            f.Address = address;
            f.City = city;
            f.Region = region;
            f.PostalCode = postalCode;
            f.Country = country;
            f.HomePhone = homePhone;
            f.Extension = extension;
            f.PhotoPath = photoPath; // ส่งค่าเส้นทางรูปภาพ
            f.Notes = notes;
            f.ReportsTo = reportsTo;
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
