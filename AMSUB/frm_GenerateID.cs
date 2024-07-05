using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMSUB
{
    public partial class frm_GenerateID : Form
    {
        public frm_GenerateID()
        {
            InitializeComponent();
            this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet.tbl_employee);
            frm_AddEmployee addEmployeeForm = new frm_AddEmployee();
            addEmployeeForm.EmployeeAdded += AddEmployeeForm_EmployeeAdded;
        }

        private void AddEmployeeForm_EmployeeAdded(object sender, EventArgs e)
        {
            // Refresh the DataGridView when an employee is added
            this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet.tbl_employee);
        }

        private void frm_GenerateID_Load(object sender, EventArgs e)
        {
            this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet.tbl_employee);
            this.ControlBox = false;


            btnMHSO.Click += (s, ev) => SetDepartmentAndBindData("btnMHSO");
            btnMMO.Click += (s, ev) => SetDepartmentAndBindData("btnMMO");
            btnMVMO.Click += (s, ev) => SetDepartmentAndBindData("btnMVMO");
            btnMPDO.Click += (s, ev) => SetDepartmentAndBindData("btnMPDO");
            btnLCRO.Click += (s, ev) => SetDepartmentAndBindData("btnLCRO");
            btnMBO.Click += (s, ev) => SetDepartmentAndBindData("btnMBO");
            btnMAcO.Click += (s, ev) => SetDepartmentAndBindData("btnMAcO");
            btnMTO.Click += (s, ev) => SetDepartmentAndBindData("btnMTO");
            btnMAsO.Click += (s, ev) => SetDepartmentAndBindData("btnMAsO");
            btnMSWDO.Click += (s, ev) => SetDepartmentAndBindData("btnMSWDO");
            btnMAgO.Click += (s, ev) => SetDepartmentAndBindData("btnMAgO");
            btnMENRO.Click += (s, ev) => SetDepartmentAndBindData("btnMENRO");
            btnMEO.Click += (s, ev) => SetDepartmentAndBindData("btnMEO");
            btnMotor.Click += (s, ev) => SetDepartmentAndBindData("btnMotor");
            btnMDRRMO.Click += (s, ev) => SetDepartmentAndBindData("btnMDRRMO");
        }

        private void SetDepartmentAndBindData(string buttonName)
        {
            string desiredDepartment = "";

            switch (buttonName)
            {
                case "btnMMO":
                    desiredDepartment = "Office of the Municipal Mayor";
                    break;
                case "btnMVMO":
                    desiredDepartment = "Office of the Municipal Vice Mayor";
                    break;
                case "btnMPDO":
                    desiredDepartment = "Municipal Planning and Devt. Office";
                    break;
                case "btnLCRO":
                    desiredDepartment = "Office of the Local Civil Registrar";
                    break;
                case "btnMBO":
                    desiredDepartment = "Office of the Municipal Budget";
                    break;
                case "btnMAcO":
                    desiredDepartment = "Office of the Municipal Accountant";
                    break;
                case "btnMTO":
                    desiredDepartment = "Municipal Treasurer's Office";
                    break;
                case "btnMAsO":
                    desiredDepartment = "Office of the Municipal Assessor";
                    break;
                case "btnMHSO":
                    desiredDepartment = "Municipal Health Services Office";
                    break;
                case "btnMSWDO":
                    desiredDepartment = "Municipal Social Welfare and Dev't Office";
                    break;
                case "btnMAgO":
                    desiredDepartment = "Office of the Municipal Agriculturist";
                    break;
                case "btnMENRO":
                    desiredDepartment = "Office of the Mun. Enviro. & Natural Resources";
                    break;
                case "btnMEO":
                    desiredDepartment = "Office of the Municipal Engineer";
                    break;
                case "btnMotor":
                    desiredDepartment = "MMO - MOTORPOOL";
                    break;
                case "btnMDRRMO":
                    desiredDepartment = "Mun. Disaster Risk Reduction and Mgt. Officer";
                    break;
                default:
                    break;
            }

            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var employees = from emp in context.tbl_employees
                                where emp.department == desiredDepartment
                                select emp;

                dgvEmployee.DataSource = employees.ToList();
            }

            MessageBox.Show("Data loaded for " + desiredDepartment, "Data Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvEmployee.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgvEmployee.Columns[e.ColumnIndex].Name == "btnGenerateID")
                {
                    // Retrieve the data from the clicked row
                    string fullname = $"{dgvEmployee.Rows[e.RowIndex].Cells["firstnameDataGridViewTextBoxColumn"].Value} {dgvEmployee.Rows[e.RowIndex].Cells["middlenameDataGridViewTextBoxColumn"].Value} {dgvEmployee.Rows[e.RowIndex].Cells["surnameDataGridViewTextBoxColumn"].Value}";
                    string barcode = $"{dgvEmployee.Rows[e.RowIndex].Cells["barcodeDataGridViewTextBoxColumn"].Value}";
                    object imageDataObj = dgvEmployee.Rows[e.RowIndex].Cells["imageDataGridViewImageColumn"].Value;
                    string birthdate = dgvEmployee.Rows[e.RowIndex].Cells["birthdateDataGridViewTextBoxColumn"].Value?.ToString();
                    string gender = dgvEmployee.Rows[e.RowIndex].Cells["genderDataGridViewTextBoxColumn"].Value?.ToString();
                    string mobile = dgvEmployee.Rows[e.RowIndex].Cells["mobileDataGridViewTextBoxColumn"].Value?.ToString();
                    string email = dgvEmployee.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].Value?.ToString();
                    string address = dgvEmployee.Rows[e.RowIndex].Cells["addressDataGridViewTextBoxColumn"].Value?.ToString();
                    string department = dgvEmployee.Rows[e.RowIndex].Cells["departmentDataGridViewTextBoxColumn"].Value?.ToString();
                    string jobposition = dgvEmployee.Rows[e.RowIndex].Cells["jobpositionDataGridViewTextBoxColumn"].Value?.ToString();

                    byte[] imageData = null;

                    if (imageDataObj is byte[])
                    {
                        imageData = (byte[])imageDataObj;
                    }
                    else if (imageDataObj is System.Data.Linq.Binary)
                    {
                        imageData = ((System.Data.Linq.Binary)imageDataObj).ToArray();
                    }

                    EmployeeID EmployeeID = new EmployeeID(barcode, fullname, imageData, birthdate, gender, mobile, email, address, department, jobposition);

                    EmployeeID.Show();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = null;
                this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet.tbl_employee);
                dgvEmployee.DataSource = this.aMSUBDataSet.tbl_employee;
                MessageBox.Show("All data refreshed successfully.", "Data Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
