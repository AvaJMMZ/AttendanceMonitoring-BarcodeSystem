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
    public partial class frmEditEmp : Form
    {
        private int selectedEmployeeID;
        public event EventHandler ChangesSaved;

        public frmEditEmp(int employeeID)
        {
            InitializeComponent();
            selectedEmployeeID = employeeID;
            LoadEmployeeDetails();
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    tbl_employee selectedEmployee = db.tbl_employees.SingleOrDefault(emp => emp.employee_id == selectedEmployeeID);

                    if (selectedEmployee != null)
                    {
                        txtFirstName.Text = selectedEmployee.firstname;
                        txtMiddleName.Text = selectedEmployee.middlename;
                        txtSurname.Text = selectedEmployee.surname;
                        dateBirthdate.Value = DateTime.Parse(selectedEmployee.birthdate);
                        cbGender.Text = selectedEmployee.gender;
                        txtAddress.Text = selectedEmployee.address;
                        txtMobile.Text = selectedEmployee.mobile;
                        txtEmail.Text = selectedEmployee.email;
                        cbDepartment.Text = selectedEmployee.department;
                        txtJobPos.Text = selectedEmployee.jobposition;

                        byte[] imageData = selectedEmployee.image.ToArray();

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pbEmployeeImg.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employee details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    tbl_employee selectedEmployee = db.tbl_employees.SingleOrDefault(emp => emp.employee_id == selectedEmployeeID);

                    if (selectedEmployee != null)
                    {
                        // Update employee details based on form controls
                        selectedEmployee.firstname = txtFirstName.Text;
                        selectedEmployee.middlename = txtMiddleName.Text;
                        selectedEmployee.surname = txtSurname.Text;
                        selectedEmployee.birthdate = dateBirthdate.Value.ToString("yyyy-MM-dd");
                        selectedEmployee.gender = cbGender.Text;
                        selectedEmployee.address = txtAddress.Text;
                        selectedEmployee.mobile = txtMobile.Text;
                        selectedEmployee.email = txtEmail.Text;
                        selectedEmployee.department = cbDepartment.Text;
                        selectedEmployee.jobposition = txtJobPos.Text;

                        // Update employee image if PictureBox is not null
                        if (pbEmployeeImg.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pbEmployeeImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                selectedEmployee.image = ms.ToArray();
                            }
                        }

                        db.SubmitChanges();
                        MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangesSaved?.Invoke(this, EventArgs.Empty); // Notify changes saved
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selected employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating employee details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbEmployeeImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DisplayImage(filePath);
            }
        }

        private void DisplayImage(string filePath)
        {
            try
            {
                Image selectedImage = Image.FromFile(filePath);
                pbEmployeeImg.Image = selectedImage;
                pbEmployeeImg.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
