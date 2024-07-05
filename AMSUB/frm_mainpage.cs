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
    public partial class frm_mainpage : Form
    {
        frm_AddEmployee AddEmployee;
        frm_ViewAll ViewAllEmployees;
        frm_GenerateID GenerateEmployeeID;
        frm_EAttendance EmployeeAttendance;

        public frm_mainpage()
        {
            InitializeComponent();
        }

        bool manageE_expand = false;
        private void timer_ManageTransition_Tick(object sender, EventArgs e)
        {
            if (manageE_expand == false)
            {
                manageEContainer.Height += 10;
                if (manageEContainer.Height >= 233)
                {
                    timer_ManageTransition.Stop();
                    manageE_expand = true;
                }
            }
            else
            {
                manageEContainer.Height -= 10;
                if(manageEContainer.Height <= 58)
                {
                    timer_ManageTransition.Stop();
                    manageE_expand = false;
                }
            }
        }

        private void btn_ManageEmployee_Click(object sender, EventArgs e)
        {
            timer_ManageTransition.Start();
        }

        bool sidebarExpand = true;

        private void timer_Sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flp_SideBar.Width -= 10;
                if (flp_SideBar.Width <= 82)
                {
                    sidebarExpand = false;
                    timer_Sidebar.Stop();
                }
            }
            else
            {
                flp_SideBar.Width += 10;
                if (flp_SideBar.Width >= 297)
                {
                    sidebarExpand = true;
                    timer_Sidebar.Stop();
                }
            }
        }

        private void pb_Menu_Click(object sender, EventArgs e)
        {
            timer_Sidebar.Start();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            labelWelcome.Visible = false;

            if (AddEmployee == null)
            {
                AddEmployee = new frm_AddEmployee();
                AddEmployee.FormClosed += AddEmployee_FormClosed;
                AddEmployee.MdiParent = this;
                AddEmployee.Dock = DockStyle.Fill;
                AddEmployee.Show();
            } else
            {
                AddEmployee.Activate();
            }
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddEmployee = null;
        }
        
        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            labelWelcome.Visible = false;

            if (ViewAllEmployees == null)
            {
                ViewAllEmployees = new frm_ViewAll();
                ViewAllEmployees.FormClosed += ViewAllEmployees_FormClosed;
                ViewAllEmployees.MdiParent = this;
                ViewAllEmployees.Dock = DockStyle.Fill;
                ViewAllEmployees.Show();
            } else
            {
                ViewAllEmployees.Activate();
            }
        }

        private void ViewAllEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            ViewAllEmployees = null;
        }

        private void btn_GenerateID_Click(object sender, EventArgs e)
        {
            labelWelcome.Visible = false;

            if (GenerateEmployeeID == null)
            {
                GenerateEmployeeID = new frm_GenerateID();
                GenerateEmployeeID.FormClosed += GenerateEmployeeID_FormClosed;
                GenerateEmployeeID.MdiParent = this;
                GenerateEmployeeID.Dock = DockStyle.Fill;
                GenerateEmployeeID.Show();
            }
            else
            {
                GenerateEmployeeID.Activate();
            }
        }

        private void GenerateEmployeeID_FormClosed(object sender, FormClosedEventArgs e)
        {
            GenerateEmployeeID = null;
        }

        private void btn_EmpAttendance_Click(object sender, EventArgs e)
        {
            labelWelcome.Visible = false;

            if (EmployeeAttendance == null)
            {
                EmployeeAttendance = new frm_EAttendance();
                EmployeeAttendance.FormClosed += EmployeeAttendance_FormClosed;
                EmployeeAttendance.MdiParent = this;
                EmployeeAttendance.Dock = DockStyle.Fill;
                EmployeeAttendance.Show();
            }
            else
            {
                EmployeeAttendance.Activate();
            }
        }

        private void EmployeeAttendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeAttendance = null;
        }
    }
}
