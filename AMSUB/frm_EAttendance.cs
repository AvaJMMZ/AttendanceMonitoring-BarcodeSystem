using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Globalization;
using System.Drawing.Printing;

namespace AMSUB
{
    public partial class frm_EAttendance : Form
    {
        private DataClasses1DataContext dbcon = new DataClasses1DataContext();
        private AMSUBDataSet_tblEmployeeList.tbl_employeeDataTable employeeListDataTable;

        public frm_EAttendance()
        {
            InitializeComponent();
        }

        private void frm_EAttendance_Load(object sender, EventArgs e)
        {
            this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet_tblEmp.tbl_employee);
            this.tbl_employeeTableAdapter1.Fill(this.aMSUBDataSet_tblEmployeeList.tbl_employee);

            this.employeeListDataTable = this.aMSUBDataSet_tblEmployeeList.tbl_employee;

            PopulateYearComboBox();

            this.rvDTR.RefreshReport();
        }

        private void PopulateYearComboBox()
        {
            try
            {
                // Query the database to retrieve unique years from your table
                var uniqueYears = (from att in dbcon.tblAttendances
                                   let yearString = att.date.Substring(att.date.Length - 4) // Extract the last 4 characters (the year)
                                   select int.Parse(yearString)) // Convert the extracted string into an integer representing the year
                                  .Distinct()
                                  .ToList();

                // Clear existing items in the ComboBox
                cbYear.Items.Clear();

                // Populate the ComboBox with unique years
                foreach (var year in uniqueYears)
                {
                    cbYear.Items.Add(year);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while populating the year ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cbDepartment.SelectedItem.ToString();

            try
            {
                if (selectedDepartment == "ALL")
                {
                    tblemployeeBindingSource.RemoveFilter();
                    MessageBox.Show("All employees are now visible.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tblemployeeBindingSource.Filter = $"Department = '{selectedDepartment}'";
                    MessageBox.Show($"Employees in the {selectedDepartment} department are now visible.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartAtt_Click(object sender, EventArgs e)
        {
            string enteredPassword = PromptForPassword();
            string correctPassword = "admin123";

            if (enteredPassword == correctPassword)
            {
                frm_mainpage mainpageForm = Application.OpenForms.OfType<frm_mainpage>().FirstOrDefault();
                if (mainpageForm != null)
                {
                    mainpageForm.Close();
                }

                // Open frmTimeInTimeOut
                frmTimeInTimeOut attendanceForm = new frmTimeInTimeOut();
                attendanceForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string PromptForPassword()
        {
            using (var form = new MaterialForm())
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                var passwordTextBox = new MaterialSingleLineTextField();
                var okButton = new MaterialRaisedButton();

                form.Text = "Enter Password";
                form.Size = new Size(300, 250);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;

                passwordTextBox.PasswordChar = '*';
                passwordTextBox.Hint = "Password";
                passwordTextBox.Location = new Point(50, 80);
                passwordTextBox.Width = 200;

                okButton.Text = "OK";
                okButton.Width = 100;
                okButton.Height = 50;
                okButton.Location = new Point(100, 130);
                okButton.Click += (sender, e) => form.DialogResult = DialogResult.OK;

                form.Controls.Add(passwordTextBox);
                form.Controls.Add(okButton);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    return passwordTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvEmployee.Columns["btnGenerateDTR"].Index)
            {
                if (string.IsNullOrEmpty(cbMonth.SelectedItem?.ToString()) || string.IsNullOrEmpty(cbYear.SelectedItem?.ToString()))
                {
                    MessageBox.Show("Please select both month and year first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected employee's ID
                int selectedEmployeeID = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["employeeidDataGridViewTextBoxColumn"].Value);

                // Retrieve employee details
                var EmpData = dbcon.tbl_employees.Where(att => att.employee_id == selectedEmployeeID).ToList();

                // Retrieve attendance data for the selected employee
                var selectedMonth = cbMonth.SelectedItem.ToString();
                var attendanceData = dbcon.tblAttendances
                    .Where(att => att.empID == selectedEmployeeID && att.date.Contains(selectedMonth))
                    .ToList();


                // Clear existing data sources
                this.rvDTR.LocalReport.DataSources.Clear();

                // Add data sources to the report
                this.rvDTR.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_Employee", EmpData));
                this.rvDTR.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet_tblAttendance", attendanceData));

                // Set the path to your RDLC file
                this.rvDTR.LocalReport.ReportPath = @"D:\Documents\Programming\Microsoft Visual Studio 2022\Attendance Monitoring System Using Barcode\AMSUB\AMSUB\DTRReport.rdlc";

                // Set report parameters
                var reportParameters = new List<Microsoft.Reporting.WinForms.ReportParameter>
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("SelectedMonth", cbMonth.SelectedItem.ToString()),
                    new Microsoft.Reporting.WinForms.ReportParameter("SelectedYear", cbYear.SelectedItem.ToString())
                };
                this.rvDTR.LocalReport.SetParameters(reportParameters);

                // Refresh the report viewer
                this.rvDTR.RefreshReport(); 
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private void RefreshReport()
        {
            // Check if both month and year are selected
            if (cbMonth.SelectedItem != null && cbYear.SelectedItem != null)
            {
                // Get the selected employee's ID
                int selectedEmployeeID = GetSelectedEmployeeID();

                if (selectedEmployeeID != -1)
                {
                    // Parse selected month and year
                    string selectedMonth = cbMonth.SelectedItem.ToString();
                    int selectedYear = int.Parse(cbYear.SelectedItem.ToString());

                    // Retrieve all attendance data for the selected employee from the database
                    var allAttendanceData = dbcon.tblAttendances.Where(att => att.empID == selectedEmployeeID).ToList();

                    // Filter the attendance data for the selected month and year using LINQ to Objects
                    var filteredAttendanceData = allAttendanceData
                        .Where(att => {
                            // Parse the date from the database into a DateTime object
                            DateTime date = DateTime.ParseExact(att.date, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
                            // Check if the month and year match the selected values
                            return date.Month == DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.InvariantCulture).Month &&
                                   date.Year == selectedYear;
                        })
                        .ToList();

                    // Clear existing data sources
                    this.rvDTR.LocalReport.DataSources.Clear();

                    // Add data sources to the report
                    // Assuming EmpData is retrieved elsewhere or is already available

                    // Set the path to your RDLC file
                    this.rvDTR.LocalReport.ReportPath = @"D:\Documents\Programming\Microsoft Visual Studio 2022\Attendance Monitoring System Using Barcode\AMSUB\AMSUB\DTRReport.rdlc";

                    // Set report parameters
                    var reportParameters = new List<Microsoft.Reporting.WinForms.ReportParameter>
            {
                new Microsoft.Reporting.WinForms.ReportParameter("SelectedMonth", selectedMonth),
                new Microsoft.Reporting.WinForms.ReportParameter("SelectedYear", selectedYear.ToString())
            };

                    this.rvDTR.LocalReport.SetParameters(reportParameters);

                    // Refresh the report viewer
                    this.rvDTR.RefreshReport();
                }
            }
        }

        private int GetSelectedEmployeeID()
        {
            // Check if a row is selected in the DataGridView
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];

                // Get the value of the employee ID cell
                if (selectedRow.Cells["employeeidDataGridViewTextBoxColumn"].Value != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["employeeidDataGridViewTextBoxColumn"].Value);
                }
            }

            // If no row is selected or if the employee ID cell value is null, return -1 indicating no valid selection
            return -1;
        }
    }
}