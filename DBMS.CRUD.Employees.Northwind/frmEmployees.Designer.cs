namespace DBMS.CRUD.Employees.Northwind
{
    partial class frmEmployees
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmployeeID = new TextBox();
            txtTitle = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtTitleOfCourtesy = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Magenta;
            btnSave.Location = new Point(237, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 57);
            btnSave.TabIndex = 0;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DodgerBlue;
            btnCancel.Location = new Point(420, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 57);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(237, 86);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 126);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 171);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 4;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 214);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 262);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "ตำแหน่ง";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(335, 78);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(191, 23);
            txtEmployeeID.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(335, 254);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(191, 23);
            txtTitle.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(335, 206);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(335, 163);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(335, 118);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(191, 23);
            txtTitleOfCourtesy.TabIndex = 11;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTitleOfCourtesy);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtTitle);
            Controls.Add(txtEmployeeID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmEmployees";
            Text = "frmEmployees";
            Load += frmEmployees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmployeeID;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtTitleOfCourtesy;
    }
}