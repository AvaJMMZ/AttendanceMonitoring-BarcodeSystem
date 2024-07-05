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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();

            // Attach event handlers to label
            label4.MouseEnter += Label_MouseEnter;
            label4.MouseLeave += Label_MouseLeave;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtbx_username.Text;
            string password = txtbx_password.Text;

            // Check credentials (replace with your authentication logic)
            if (IsValidUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtbx_username.Text = "";
                txtbx_password.Text = "";

                this.Hide();

                frm_mainpage mainPageForm = new frm_mainpage();
                mainPageForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password)
        {
            return username == "admin" && password == "admin123";
        }

        private void chbx_showpass_CheckedChanged_1(object sender, EventArgs e)
        {
            txtbx_password.UseSystemPasswordChar = !chbx_showpass.Checked; 
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.Control;
        }
    }
}
