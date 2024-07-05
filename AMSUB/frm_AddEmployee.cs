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
using System.Drawing.Imaging;

namespace AMSUB
{
    public partial class frm_AddEmployee : Form
    {
        public event EventHandler EmployeeAdded;

        private DataClasses1DataContext dbcon = new DataClasses1DataContext();

        public frm_AddEmployee()
        {
            InitializeComponent();
        }

        public class BarcodeGenerator
        {
            private static readonly Random random = new Random();
            private const string Characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            public static string GenerateBarcode()
            {
                string barcode = new string(Enumerable.Repeat(Characters, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

                return barcode;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Retrieve values from TextBoxes
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string birthdate = dateBirthdate.Text.Trim();
            string gender = cbGender.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string email = txtEmail.Text.Trim();
            string department = cbDepartment.Text.Trim();
            string jobPosition = txtJobPos.Text.Trim();
            string address = txtAddress.Text.Trim();
            string barcode = BarcodeGenerator.GenerateBarcode();

            // Check if all fields are filled
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(surname) ||
                string.IsNullOrEmpty(birthdate) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(mobile) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(department) || string.IsNullOrEmpty(jobPosition) ||
                string.IsNullOrEmpty(address) || pbEmployeeImg.Image == null)
            {
                MessageBox.Show("Please fill in all fields and select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new tbl_employee object
            tbl_employee newEmployee = new tbl_employee
            {
                firstname = firstName,
                middlename = middleName,
                surname = surname,
                birthdate = birthdate,
                gender = gender,
                mobile = mobile,
                email = email,
                department = department,
                jobposition = jobPosition,
                address = address,
                barcode = barcode
            };

            dbcon.tbl_employees.InsertOnSubmit(newEmployee);
            dbcon.SubmitChanges();

            using (MemoryStream ms = new MemoryStream())
            {
                pbEmployeeImg.Image.Save(ms, ImageFormat.Png);
                newEmployee.image = ms.ToArray();
            }

            dbcon.SubmitChanges();

            MessageBox.Show("Employee added successfully!");
            OnEmployeeAdded(EventArgs.Empty);
            ClearControls(this);
        }

        protected virtual void OnEmployeeAdded(EventArgs e)
        {
            EmployeeAdded?.Invoke(this, e);
        }

        private void ClearControls(Control container)
        {
            foreach (var textBox in container.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (var comboBox in container.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1; 
            }

            foreach (var dateTimePicker in container.Controls.OfType<DateTimePicker>())
            {
                dateTimePicker.Value = DateTime.Now;
            }

            pbEmployeeImg.Image = null;
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
