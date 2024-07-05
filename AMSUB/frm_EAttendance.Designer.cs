namespace AMSUB
{
    partial class frm_EAttendance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EAttendance));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobpositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateDTR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMSUBDataSet_tblEmp = new AMSUB.AMSUBDataSet_tblEmp();
            this.tbl_employeeTableAdapter = new AMSUB.AMSUBDataSet_tblEmpTableAdapters.tbl_employeeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.btnStartAtt = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.tblAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialogDTR = new System.Windows.Forms.PrintPreviewDialog();
            this.rvDTR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aMSUBDataSet_tblEmployeeList = new AMSUB.AMSUBDataSet_tblEmployeeList();
            this.tbl_employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeeTableAdapter1 = new AMSUB.AMSUBDataSet_tblEmployeeListTableAdapters.tbl_employeeTableAdapter();
            this.tableAdapterManager = new AMSUB.AMSUBDataSet_tblEmployeeListTableAdapters.TableAdapterManager();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSUBDataSet_tblEmp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSUBDataSet_tblEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Controls.Add(this.labelAddEmployee);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1112, 68);
            this.panelTitle.TabIndex = 4;
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAddEmployee.Location = new System.Drawing.Point(399, 9);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(344, 52);
            this.labelAddEmployee.TabIndex = 1;
            this.labelAddEmployee.Text = "GENERATE DTR";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeight = 40;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.jobpositionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.btnGenerateDTR,
            this.birthdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.barcodeDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvEmployee.DataSource = this.tblemployeeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 154);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "NULL";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 70;
            dataGridViewCellStyle5.NullValue = "NULL";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.RowTemplate.Height = 40;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(476, 634);
            this.dgvEmployee.TabIndex = 6;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobpositionDataGridViewTextBoxColumn
            // 
            this.jobpositionDataGridViewTextBoxColumn.DataPropertyName = "jobposition";
            this.jobpositionDataGridViewTextBoxColumn.HeaderText = "Job Position";
            this.jobpositionDataGridViewTextBoxColumn.Name = "jobpositionDataGridViewTextBoxColumn";
            this.jobpositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobpositionDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnGenerateDTR
            // 
            this.btnGenerateDTR.HeaderText = "DTR";
            this.btnGenerateDTR.Name = "btnGenerateDTR";
            this.btnGenerateDTR.ReadOnly = true;
            this.btnGenerateDTR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnGenerateDTR.Text = "GENERATE";
            this.btnGenerateDTR.UseColumnTextForButtonValue = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "barcode";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Visible = false;
            // 
            // tblemployeeBindingSource
            // 
            this.tblemployeeBindingSource.DataMember = "tbl_employee";
            this.tblemployeeBindingSource.DataSource = this.aMSUBDataSet_tblEmp;
            // 
            // aMSUBDataSet_tblEmp
            // 
            this.aMSUBDataSet_tblEmp.DataSetName = "AMSUBDataSet_tblEmp";
            this.aMSUBDataSet_tblEmp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_employeeTableAdapter
            // 
            this.tbl_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbMonth);
            this.panel1.Controls.Add(this.btnStartAtt);
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 86);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Year:";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(392, 48);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(147, 26);
            this.cbYear.TabIndex = 33;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Month:";
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbMonth.Location = new System.Drawing.Point(152, 48);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(174, 26);
            this.cbMonth.TabIndex = 31;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // btnStartAtt
            // 
            this.btnStartAtt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAtt.Location = new System.Drawing.Point(845, 23);
            this.btnStartAtt.Name = "btnStartAtt";
            this.btnStartAtt.Size = new System.Drawing.Size(214, 38);
            this.btnStartAtt.TabIndex = 29;
            this.btnStartAtt.Text = "START ATTENDANCE";
            this.btnStartAtt.UseVisualStyleBackColor = true;
            this.btnStartAtt.Click += new System.EventHandler(this.btnStartAtt_Click);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.White;
            this.Department.Location = new System.Drawing.Point(21, 13);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(125, 22);
            this.Department.TabIndex = 28;
            this.Department.Text = "Department:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "ALL",
            "Office of the Municipal Mayor",
            "Office of the Municipal Vice Mayor",
            "Municipal Planning and Devt. Office",
            "Office of the Local Civil Registrar",
            "Office of the Municipal Budget",
            "Office of the Municipal Accountant",
            "Municipal Treasurer\'s Office",
            "Office of the Municipal Assessor",
            "Municipal Health Services Office",
            "Municipal Social Welfare and Dev\'t Office",
            "Office of the Municipal Agriculturist",
            "Office of the Mun. Enviro. and Natural Resources",
            "Office of the Municipal Engineer",
            "MMO - MOTORPOOL",
            "Mun. Disaster Risk Reduction and Mgt. Officer"});
            this.cbDepartment.Location = new System.Drawing.Point(152, 12);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(387, 26);
            this.cbDepartment.TabIndex = 27;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // tblAttendanceBindingSource
            // 
            this.tblAttendanceBindingSource.DataMember = "tblAttendance";
            // 
            // printPreviewDialogDTR
            // 
            this.printPreviewDialogDTR.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDTR.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogDTR.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogDTR.Enabled = true;
            this.printPreviewDialogDTR.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogDTR.Icon")));
            this.printPreviewDialogDTR.Name = "printPreviewDialogDTR";
            this.printPreviewDialogDTR.Visible = false;
            // 
            // rvDTR
            // 
            this.rvDTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvDTR.LocalReport.ReportEmbeddedResource = "AMSUB.DTRReport.rdlc";
            this.rvDTR.Location = new System.Drawing.Point(476, 154);
            this.rvDTR.Name = "rvDTR";
            this.rvDTR.ServerReport.BearerToken = null;
            this.rvDTR.Size = new System.Drawing.Size(636, 634);
            this.rvDTR.TabIndex = 10;
            // 
            // aMSUBDataSet_tblEmployeeList
            // 
            this.aMSUBDataSet_tblEmployeeList.DataSetName = "AMSUBDataSet_tblEmployeeList";
            this.aMSUBDataSet_tblEmployeeList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_employeeBindingSource
            // 
            this.tbl_employeeBindingSource.DataMember = "tbl_employee";
            this.tbl_employeeBindingSource.DataSource = this.aMSUBDataSet_tblEmployeeList;
            // 
            // tbl_employeeTableAdapter1
            // 
            this.tbl_employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_employeeTableAdapter = this.tbl_employeeTableAdapter1;
            this.tableAdapterManager.UpdateOrder = AMSUB.AMSUBDataSet_tblEmployeeListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frm_EAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1112, 788);
            this.Controls.Add(this.rvDTR);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EAttendance";
            this.Text = "frm_EAttendance";
            this.Load += new System.EventHandler(this.frm_EAttendance_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSUBDataSet_tblEmp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblAttendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMSUBDataSet_tblEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private AMSUBDataSet_tblEmp aMSUBDataSet_tblEmp;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource;
        private AMSUBDataSet_tblEmpTableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.BindingSource tblAttendanceBindingSource;
        private System.Windows.Forms.Button btnStartAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobpositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnGenerateDTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogDTR;
        private Microsoft.Reporting.WinForms.ReportViewer rvDTR;
        private AMSUBDataSet_tblEmployeeList aMSUBDataSet_tblEmployeeList;
        private System.Windows.Forms.BindingSource tbl_employeeBindingSource;
        private AMSUBDataSet_tblEmployeeListTableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter1;
        private AMSUBDataSet_tblEmployeeListTableAdapters.TableAdapterManager tableAdapterManager;
    }
}