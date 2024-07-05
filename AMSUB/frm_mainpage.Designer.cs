namespace AMSUB
{
    partial class frm_mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mainpage));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.pb_Menu = new System.Windows.Forms.PictureBox();
            this.flp_SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.manageEContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_ManageEmployee = new System.Windows.Forms.Panel();
            this.btn_ManageEmployee = new System.Windows.Forms.Button();
            this.panel_AddEmployee = new System.Windows.Forms.Panel();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.panel_GenerateID = new System.Windows.Forms.Panel();
            this.btn_GenerateID = new System.Windows.Forms.Button();
            this.panel_ViewAll = new System.Windows.Forms.Panel();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.panel_EmpAttendance = new System.Windows.Forms.Panel();
            this.btn_EmpAttendance = new System.Windows.Forms.Button();
            this.panel_Logout = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.timer_ManageTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_Sidebar = new System.Windows.Forms.Timer(this.components);
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).BeginInit();
            this.flp_SideBar.SuspendLayout();
            this.manageEContainer.SuspendLayout();
            this.panel_ManageEmployee.SuspendLayout();
            this.panel_AddEmployee.SuspendLayout();
            this.panel_GenerateID.SuspendLayout();
            this.panel_ViewAll.SuspendLayout();
            this.panel_EmpAttendance.SuspendLayout();
            this.panel_Logout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_header.Controls.Add(this.label_header);
            this.pnl_header.Controls.Add(this.pb_Menu);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1370, 42);
            this.pnl_header.TabIndex = 0;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(62, 6);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(653, 29);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "ATTENDANCE MONITORING SYSTEM USING BARCODE";
            // 
            // pb_Menu
            // 
            this.pb_Menu.Image = ((System.Drawing.Image)(resources.GetObject("pb_Menu.Image")));
            this.pb_Menu.Location = new System.Drawing.Point(13, 1);
            this.pb_Menu.Name = "pb_Menu";
            this.pb_Menu.Size = new System.Drawing.Size(43, 40);
            this.pb_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Menu.TabIndex = 1;
            this.pb_Menu.TabStop = false;
            this.pb_Menu.Click += new System.EventHandler(this.pb_Menu_Click);
            // 
            // flp_SideBar
            // 
            this.flp_SideBar.BackColor = System.Drawing.SystemColors.ControlText;
            this.flp_SideBar.Controls.Add(this.manageEContainer);
            this.flp_SideBar.Controls.Add(this.panel_EmpAttendance);
            this.flp_SideBar.Controls.Add(this.panel_Logout);
            this.flp_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flp_SideBar.Location = new System.Drawing.Point(0, 42);
            this.flp_SideBar.Name = "flp_SideBar";
            this.flp_SideBar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flp_SideBar.Size = new System.Drawing.Size(297, 707);
            this.flp_SideBar.TabIndex = 1;
            // 
            // manageEContainer
            // 
            this.manageEContainer.BackColor = System.Drawing.Color.Black;
            this.manageEContainer.Controls.Add(this.panel_ManageEmployee);
            this.manageEContainer.Controls.Add(this.panel_AddEmployee);
            this.manageEContainer.Controls.Add(this.panel_GenerateID);
            this.manageEContainer.Controls.Add(this.panel_ViewAll);
            this.manageEContainer.ForeColor = System.Drawing.Color.White;
            this.manageEContainer.Location = new System.Drawing.Point(3, 20);
            this.manageEContainer.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.manageEContainer.Name = "manageEContainer";
            this.manageEContainer.Size = new System.Drawing.Size(291, 58);
            this.manageEContainer.TabIndex = 6;
            // 
            // panel_ManageEmployee
            // 
            this.panel_ManageEmployee.Controls.Add(this.btn_ManageEmployee);
            this.panel_ManageEmployee.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ManageEmployee.Name = "panel_ManageEmployee";
            this.panel_ManageEmployee.Size = new System.Drawing.Size(290, 58);
            this.panel_ManageEmployee.TabIndex = 3;
            // 
            // btn_ManageEmployee
            // 
            this.btn_ManageEmployee.BackColor = System.Drawing.Color.Black;
            this.btn_ManageEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_ManageEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManageEmployee.Image")));
            this.btn_ManageEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageEmployee.Location = new System.Drawing.Point(-17, -23);
            this.btn_ManageEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ManageEmployee.Name = "btn_ManageEmployee";
            this.btn_ManageEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_ManageEmployee.Size = new System.Drawing.Size(330, 105);
            this.btn_ManageEmployee.TabIndex = 2;
            this.btn_ManageEmployee.Text = "                     Manage Employee";
            this.btn_ManageEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageEmployee.UseVisualStyleBackColor = false;
            this.btn_ManageEmployee.Click += new System.EventHandler(this.btn_ManageEmployee_Click);
            // 
            // panel_AddEmployee
            // 
            this.panel_AddEmployee.BackColor = System.Drawing.Color.Black;
            this.panel_AddEmployee.Controls.Add(this.btn_AddEmployee);
            this.panel_AddEmployee.Location = new System.Drawing.Point(0, 58);
            this.panel_AddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.panel_AddEmployee.Name = "panel_AddEmployee";
            this.panel_AddEmployee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_AddEmployee.Size = new System.Drawing.Size(290, 58);
            this.panel_AddEmployee.TabIndex = 4;
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_AddEmployee.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEmployee.Image")));
            this.btn_AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEmployee.Location = new System.Drawing.Point(-17, -23);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btn_AddEmployee.Size = new System.Drawing.Size(330, 105);
            this.btn_AddEmployee.TabIndex = 2;
            this.btn_AddEmployee.Text = "                     Add Employee";
            this.btn_AddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEmployee.UseVisualStyleBackColor = false;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // panel_GenerateID
            // 
            this.panel_GenerateID.BackColor = System.Drawing.Color.Black;
            this.panel_GenerateID.Controls.Add(this.btn_GenerateID);
            this.panel_GenerateID.Location = new System.Drawing.Point(0, 116);
            this.panel_GenerateID.Margin = new System.Windows.Forms.Padding(0);
            this.panel_GenerateID.Name = "panel_GenerateID";
            this.panel_GenerateID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_GenerateID.Size = new System.Drawing.Size(290, 58);
            this.panel_GenerateID.TabIndex = 5;
            // 
            // btn_GenerateID
            // 
            this.btn_GenerateID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_GenerateID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateID.ForeColor = System.Drawing.Color.White;
            this.btn_GenerateID.Image = ((System.Drawing.Image)(resources.GetObject("btn_GenerateID.Image")));
            this.btn_GenerateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerateID.Location = new System.Drawing.Point(-17, -23);
            this.btn_GenerateID.Name = "btn_GenerateID";
            this.btn_GenerateID.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btn_GenerateID.Size = new System.Drawing.Size(330, 105);
            this.btn_GenerateID.TabIndex = 2;
            this.btn_GenerateID.Text = "                     Generate ID";
            this.btn_GenerateID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerateID.UseVisualStyleBackColor = false;
            this.btn_GenerateID.Click += new System.EventHandler(this.btn_GenerateID_Click);
            // 
            // panel_ViewAll
            // 
            this.panel_ViewAll.BackColor = System.Drawing.Color.Black;
            this.panel_ViewAll.Controls.Add(this.btn_ViewAll);
            this.panel_ViewAll.Location = new System.Drawing.Point(0, 174);
            this.panel_ViewAll.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ViewAll.Name = "panel_ViewAll";
            this.panel_ViewAll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_ViewAll.Size = new System.Drawing.Size(290, 58);
            this.panel_ViewAll.TabIndex = 4;
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_ViewAll.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAll.ForeColor = System.Drawing.Color.White;
            this.btn_ViewAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_ViewAll.Image")));
            this.btn_ViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewAll.Location = new System.Drawing.Point(-17, -23);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btn_ViewAll.Size = new System.Drawing.Size(330, 105);
            this.btn_ViewAll.TabIndex = 2;
            this.btn_ViewAll.Text = "                     View All Employee";
            this.btn_ViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewAll.UseVisualStyleBackColor = false;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            // 
            // panel_EmpAttendance
            // 
            this.panel_EmpAttendance.Controls.Add(this.btn_EmpAttendance);
            this.panel_EmpAttendance.Location = new System.Drawing.Point(3, 81);
            this.panel_EmpAttendance.Name = "panel_EmpAttendance";
            this.panel_EmpAttendance.Size = new System.Drawing.Size(290, 58);
            this.panel_EmpAttendance.TabIndex = 4;
            // 
            // btn_EmpAttendance
            // 
            this.btn_EmpAttendance.BackColor = System.Drawing.Color.Black;
            this.btn_EmpAttendance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmpAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_EmpAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btn_EmpAttendance.Image")));
            this.btn_EmpAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EmpAttendance.Location = new System.Drawing.Point(-17, -23);
            this.btn_EmpAttendance.Name = "btn_EmpAttendance";
            this.btn_EmpAttendance.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_EmpAttendance.Size = new System.Drawing.Size(330, 105);
            this.btn_EmpAttendance.TabIndex = 2;
            this.btn_EmpAttendance.Text = "                     Employee\'s Attendance";
            this.btn_EmpAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EmpAttendance.UseVisualStyleBackColor = false;
            this.btn_EmpAttendance.Click += new System.EventHandler(this.btn_EmpAttendance_Click);
            // 
            // panel_Logout
            // 
            this.panel_Logout.Controls.Add(this.btn_Logout);
            this.panel_Logout.Location = new System.Drawing.Point(3, 142);
            this.panel_Logout.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel_Logout.Name = "panel_Logout";
            this.panel_Logout.Size = new System.Drawing.Size(290, 58);
            this.panel_Logout.TabIndex = 5;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Black;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(-17, -23);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(330, 105);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "                     Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // timer_ManageTransition
            // 
            this.timer_ManageTransition.Interval = 10;
            this.timer_ManageTransition.Tick += new System.EventHandler(this.timer_ManageTransition_Tick);
            // 
            // timer_Sidebar
            // 
            this.timer_Sidebar.Interval = 10;
            this.timer_Sidebar.Tick += new System.EventHandler(this.timer_Sidebar_Tick);
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.DarkGray;
            this.labelWelcome.Font = new System.Drawing.Font("Century", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(550, 300);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(587, 116);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "WELCOME";
            // 
            // frm_mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.flp_SideBar);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frm_mainpage";
            this.Text = "Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Menu)).EndInit();
            this.flp_SideBar.ResumeLayout(false);
            this.manageEContainer.ResumeLayout(false);
            this.panel_ManageEmployee.ResumeLayout(false);
            this.panel_AddEmployee.ResumeLayout(false);
            this.panel_GenerateID.ResumeLayout(false);
            this.panel_ViewAll.ResumeLayout(false);
            this.panel_EmpAttendance.ResumeLayout(false);
            this.panel_Logout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox pb_Menu;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.FlowLayoutPanel flp_SideBar;
        private System.Windows.Forms.Panel panel_ManageEmployee;
        private System.Windows.Forms.Button btn_ManageEmployee;
        private System.Windows.Forms.Panel panel_AddEmployee;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Panel panel_ViewAll;
        private System.Windows.Forms.Button btn_ViewAll;
        private System.Windows.Forms.Panel panel_GenerateID;
        private System.Windows.Forms.Button btn_GenerateID;
        private System.Windows.Forms.Panel panel_EmpAttendance;
        private System.Windows.Forms.Button btn_EmpAttendance;
        private System.Windows.Forms.FlowLayoutPanel manageEContainer;
        private System.Windows.Forms.Panel panel_Logout;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Timer timer_ManageTransition;
        private System.Windows.Forms.Timer timer_Sidebar;
        private System.Windows.Forms.Label labelWelcome;
    }
}