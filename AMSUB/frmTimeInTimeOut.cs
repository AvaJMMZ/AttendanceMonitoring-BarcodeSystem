using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace AMSUB
{
    public partial class frmTimeInTimeOut : Form
    {
        private DataClasses1DataContext dbcon = new DataClasses1DataContext();

        public frmTimeInTimeOut()
        {
            InitializeComponent();

            UpdateDateTime();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            txtBarcode.KeyPress += TxtBarcode_KeyPress;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = $"{now.ToString("MMMM dd, yyyy")} | {now.ToString("hh:mm:ss tt")}";
            lblDateTime.Text = formattedDateTime;
        }

        private void TxtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string scannedBarcode = txtBarcode.Text;
                var employee = dbcon.tbl_employees.FirstOrDefault(emp => emp.barcode == scannedBarcode);

                if (employee != null)
                {
                    DateTime currentDate = DateTime.Today;
                    DateTime currentTime = DateTime.Now;
                    string amtimeIn = "";
                    string amtimeOut = "";
                    string pmtimeIn = "";
                    string pmtimeOut = "";

                    if (currentTime.Hour < 9 || (currentTime.Hour == 9 && currentTime.Minute < 59))
                        {
                            // Before 9:59 AM, mark as time in
                            string dateString = currentDate.ToString("MMMM dd, yyyy");
                            var existingAttendance = dbcon.tblAttendances.FirstOrDefault(a => a.empID == employee.employee_id && a.date == dateString);

                            if (existingAttendance == null)
                            {
                                amtimeIn = currentTime.ToString("hh:mm:ss tt");
                            }
                            else
                            {
                                MessageBox.Show($"Time in has already been recorded for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBarcode.Clear();
                                return;
                            }
                        }
                        else if ((currentTime.Hour == 10 && currentTime.Minute >= 0) || (currentTime.Hour == 12 && currentTime.Minute <= 30))
                        {
                            // Between 10:00 AM and 12:30 PM, mark as time out
                            amtimeOut = currentTime.ToString("hh:mm:ss tt");
                        }
                    
                        if (currentTime.Hour == 12 && currentTime.Minute >= 31 || (currentTime.Hour > 14 && currentTime.Minute >= 59))
                        {
                            // 12:31 PM to 2:59 PM, mark as time in
                            string dateString = currentDate.ToString("MMMM dd, yyyy");
                            var existingAttendance = dbcon.tblAttendances.FirstOrDefault(a => a.empID == employee.employee_id && a.date == dateString);

                            if (existingAttendance == null)
                            {
                                pmtimeIn = currentTime.ToString("hh:mm:ss tt");
                            }
                            else
                            {
                                MessageBox.Show($"Time in has already been recorded for today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBarcode.Clear();
                                return;
                            }
                        }
                        else if (currentTime.Hour >= 15)
                        {
                            // After 3:00 PM, mark as time out
                            pmtimeOut = currentTime.ToString("hh:mm:ss tt");
                        }

                    string OdateString = currentDate.ToString("MMMM dd, yyyy");

                    var OexistingAttendance = dbcon.tblAttendances.FirstOrDefault(a => a.empID == employee.employee_id && a.date == OdateString);

                    if (OexistingAttendance != null)
                    {
                        // Existing attendance record found
                        if (!string.IsNullOrEmpty(OexistingAttendance.amtimeOut) || !string.IsNullOrEmpty(OexistingAttendance.pmtimeOut))
                        {
                            MessageBox.Show($"Time out has already been recorded for today.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBarcode.Clear();
                            return;
                        }

                        OexistingAttendance.amtimeOut = amtimeOut;
                        OexistingAttendance.pmtimeOut = pmtimeOut;

                        dbcon.SubmitChanges();

                        MessageBox.Show($"Thank you, {employee.firstname}. Time Out done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // No existing attendance record found, create a new one
                        tblAttendance newAttendance = new tblAttendance
                        {
                            empID = employee.employee_id,
                            date = OdateString,
                            amtimeIn = amtimeIn,
                            amtimeOut = amtimeOut,
                            pmtimeIn = pmtimeIn,
                            pmtimeOut = pmtimeOut
                        };

                        dbcon.tblAttendances.InsertOnSubmit(newAttendance);
                        dbcon.SubmitChanges();

                        MessageBox.Show($"Thank you, {employee.firstname}. Time In done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Not an employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtBarcode.Clear();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_login loginForm = new frm_login();
            loginForm.Show();
        }
    }
}
