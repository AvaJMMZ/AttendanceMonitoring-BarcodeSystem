using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AMSUB
{
    public partial class frm_ViewAll : Form
    {
        private Form additionalDetailsPopup;

        public frm_ViewAll()
        {
            InitializeComponent();
        }

        private void frm_ViewAll_Load(object sender, EventArgs e)
        {
            this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet_tblEmployeeList.tbl_employee);
            this.ControlBox = false;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.SelectionChanged += dgvEmployee_SelectionChanged;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployee.Columns["btnMoreDetails"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmployee.Rows[e.RowIndex];

                string birthdate = selectedRow.Cells["birthdateDataGridViewTextBoxColumn"].Value.ToString();
                string gender = selectedRow.Cells["genderDataGridViewTextBoxColumn"].Value.ToString();
                string mobile = selectedRow.Cells["mobileDataGridViewTextBoxColumn"].Value.ToString();
                string email = selectedRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                string barcode = selectedRow.Cells["barcodeDataGridViewTextBoxColumn"].Value.ToString();

                byte[] imageData = (byte[])selectedRow.Cells["imageDataGridViewImageColumn"].Value;
                Image image = null;
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                ShowAdditionalDetailsPopup(birthdate, gender, mobile, email, barcode, image);
            }
        }

        private void ShowAdditionalDetailsPopup(string birthdate, string gender, string mobile, string email, string barcode, Image image)
        {
            if (additionalDetailsPopup == null || additionalDetailsPopup.IsDisposed)
            {
                additionalDetailsPopup = new Form();
                additionalDetailsPopup.Text = "Additional Details";
                additionalDetailsPopup.Size = new Size(400, 300);
                additionalDetailsPopup.StartPosition = FormStartPosition.CenterParent;
                additionalDetailsPopup.FormBorderStyle = FormBorderStyle.FixedDialog;
                additionalDetailsPopup.MaximizeBox = false;
                additionalDetailsPopup.MinimizeBox = false;
                additionalDetailsPopup.FormClosed += AdditionalDetailsPopup_FormClosed; // Add FormClosed event handler

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.Padding = new Padding(10);

                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Labels
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // Values

                tableLayoutPanel.Controls.Add(CreateLabel("Birthdate:"), 0, 0);
                tableLayoutPanel.Controls.Add(CreateLabel(birthdate, FontStyle.Bold), 1, 0);
                tableLayoutPanel.Controls.Add(CreateLabel("Gender:"), 0, 1);
                tableLayoutPanel.Controls.Add(CreateLabel(gender, FontStyle.Bold), 1, 1);
                tableLayoutPanel.Controls.Add(CreateLabel("Mobile:"), 0, 2);
                tableLayoutPanel.Controls.Add(CreateLabel(mobile, FontStyle.Bold), 1, 2);
                tableLayoutPanel.Controls.Add(CreateLabel("Email:"), 0, 3);
                tableLayoutPanel.Controls.Add(CreateLabel(email, FontStyle.Bold), 1, 3);
                tableLayoutPanel.Controls.Add(CreateLabel("Barcode:"), 0, 4);
                tableLayoutPanel.Controls.Add(CreateLabel(barcode, FontStyle.Bold), 1, 4);

                additionalDetailsPopup.Controls.Add(tableLayoutPanel);

                if (image != null)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    tableLayoutPanel.Controls.Add(pictureBox, 0, 5);
                    tableLayoutPanel.SetColumnSpan(pictureBox, 2);
                }

                additionalDetailsPopup.Controls.Add(tableLayoutPanel);
                additionalDetailsPopup.ShowDialog();
            }
            else
            {
                additionalDetailsPopup.BringToFront();
            }
        }

        private Label CreateLabel(string text, FontStyle fontStyle = FontStyle.Regular)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font(label.Font, fontStyle);
            label.AutoSize = true;
            return label;
        }

        private void AdditionalDetailsPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            additionalDetailsPopup.Dispose();
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
                    // Escape single quote by doubling it
                    string departmentFilter = $"Department = '{selectedDepartment.Replace("'", "''")}'";
                    tblemployeeBindingSource.Filter = departmentFilter;
                    MessageBox.Show($"Employees in the {selectedDepartment} department are now visible.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            bool isRowSelected = dgvEmployee.SelectedRows.Count > 0;

            btnEdit.Enabled = isRowSelected;
            btnDelete.Enabled = isRowSelected;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int selectedEmployeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["employeeidDataGridViewTextBoxColumn"].Value);

                frmEditEmp editForm = new frmEditEmp(selectedEmployeeID);
                editForm.ChangesSaved += EditForm_ChangesSaved;
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditForm_ChangesSaved(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            try
            {
                this.tbl_employeeTableAdapter.Fill(this.aMSUBDataSet_tblEmployeeList.tbl_employee);
                dgvEmployee.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                // Retrieve the employee ID from the selected row
                int selectedEmployeeID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["employeeidDataGridViewTextBoxColumn"].Value);

                // Prompt the user for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the employee from the database
                        using (DataClasses1DataContext db = new DataClasses1DataContext())
                        {
                            tbl_employee employeeToDelete = db.tbl_employees.SingleOrDefault(emp => emp.employee_id == selectedEmployeeID);
                            if (employeeToDelete != null)
                            {
                                db.tbl_employees.DeleteOnSubmit(employeeToDelete);
                                db.SubmitChanges();
                                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshDataGridView(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Selected employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
