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
            txtAddress = new TextBox();
            txtPostalCode = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtHireDate = new TextBox();
            txtBirthDate = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtPhotoPath = new TextBox();
            txtReportsTo = new TextBox();
            txtNotes = new TextBox();
            txtExtension = new TextBox();
            txtHomePhone = new TextBox();
            txtCountry = new TextBox();
            imgPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgPhoto).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Magenta;
            btnSave.Location = new Point(248, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 55);
            btnSave.TabIndex = 0;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DodgerBlue;
            btnCancel.Location = new Point(417, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 55);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "ยกเลิก";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "รหัสพนักงาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 31);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "คำนำหน้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 31);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 4;
            label3.Text = "ชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 87);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "ตำแหน่ง";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(48, 49);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(191, 23);
            txtEmployeeID.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(288, 105);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(191, 23);
            txtTitle.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(48, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(191, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(532, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(288, 49);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(191, 23);
            txtTitleOfCourtesy.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(288, 162);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(191, 23);
            txtAddress.TabIndex = 12;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(288, 222);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(191, 23);
            txtPostalCode.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(532, 162);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(191, 23);
            txtCity.TabIndex = 14;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(49, 222);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(191, 23);
            txtRegion.TabIndex = 15;
            // 
            // txtHireDate
            // 
            txtHireDate.Location = new Point(47, 162);
            txtHireDate.Name = "txtHireDate";
            txtHireDate.Size = new Size(191, 23);
            txtHireDate.TabIndex = 16;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(532, 105);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(191, 23);
            txtBirthDate.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 87);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 18;
            label6.Text = "วันที่เกิด";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 267);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 19;
            label7.Text = "เส้นทาง ไปยังไฟล์รูปภาพ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 204);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 20;
            label8.Text = "ภูมิภาค";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(532, 144);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 21;
            label9.Text = "เมือง";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(288, 144);
            label10.Name = "label10";
            label10.Size = new Size(26, 15);
            label10.TabIndex = 22;
            label10.Text = "ที่อยู่";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 144);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 23;
            label11.Text = "วันที่เริ่มทำงาน";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(288, 204);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 24;
            label12.Text = "รหัสไปรษณีย์";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(288, 336);
            label13.Name = "label13";
            label13.Size = new Size(226, 15);
            label13.TabIndex = 25;
            label13.Text = "รหัสพนักงานของผู้จัดการหรือผู้บังคับบัญชา(ถ้ามี)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 336);
            label14.Name = "label14";
            label14.Size = new Size(49, 15);
            label14.TabIndex = 26;
            label14.Text = "หมายเหตุ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(532, 336);
            label15.Name = "label15";
            label15.Size = new Size(96, 15);
            label15.TabIndex = 27;
            label15.Text = "รูปภาพของพนักงาน";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(288, 267);
            label16.Name = "label16";
            label16.Size = new Size(119, 15);
            label16.TabIndex = 28;
            label16.Text = " หมายเลขต่อภายใน(ถ้ามี)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(49, 267);
            label17.Name = "label17";
            label17.Size = new Size(45, 15);
            label17.TabIndex = 29;
            label17.Text = "เบอร์โทร";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(532, 204);
            label18.Name = "label18";
            label18.Size = new Size(40, 15);
            label18.TabIndex = 30;
            label18.Text = "ประเทศ";
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(532, 285);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(191, 23);
            txtPhotoPath.TabIndex = 32;
            // 
            // txtReportsTo
            // 
            txtReportsTo.Location = new Point(288, 354);
            txtReportsTo.Name = "txtReportsTo";
            txtReportsTo.Size = new Size(191, 23);
            txtReportsTo.TabIndex = 33;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(49, 354);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(191, 23);
            txtNotes.TabIndex = 34;
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(288, 285);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(191, 23);
            txtExtension.TabIndex = 35;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(49, 285);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(191, 23);
            txtHomePhone.TabIndex = 36;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(532, 222);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(191, 23);
            txtCountry.TabIndex = 37;
            // 
            // imgPhoto
            // 
            imgPhoto.Location = new Point(532, 354);
            imgPhoto.Name = "imgPhoto";
            imgPhoto.Size = new Size(101, 86);
            imgPhoto.TabIndex = 38;
            imgPhoto.TabStop = false;
            imgPhoto.Click += imgPhoto_Click;
            // 
            // frmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgPhoto);
            Controls.Add(txtCountry);
            Controls.Add(txtHomePhone);
            Controls.Add(txtExtension);
            Controls.Add(txtNotes);
            Controls.Add(txtReportsTo);
            Controls.Add(txtPhotoPath);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtBirthDate);
            Controls.Add(txtHireDate);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtPostalCode);
            Controls.Add(txtAddress);
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
            ((System.ComponentModel.ISupportInitialize)imgPhoto).EndInit();
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
        private TextBox txtAddress;
        private TextBox txtPostalCode;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtHireDate;
        private TextBox txtBirthDate;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtPhotoPath;
        private TextBox txtReportsTo;
        private TextBox txtNotes;
        private TextBox txtExtension;
        private TextBox txtHomePhone;
        private TextBox txtCountry;
        private PictureBox imgPhoto;
    }
}