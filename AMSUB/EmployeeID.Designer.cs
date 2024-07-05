namespace AMSUB
{
    partial class EmployeeID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeID));
            this.Fullname = new System.Windows.Forms.Label();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.pbEmployeeImg = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conIDCard = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.jobpositionLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.genderLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.conIDCard.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fullname
            // 
            this.Fullname.AutoSize = true;
            this.Fullname.BackColor = System.Drawing.Color.Black;
            this.Fullname.Font = new System.Drawing.Font("Arial Black", 17F, System.Drawing.FontStyle.Bold);
            this.Fullname.ForeColor = System.Drawing.Color.White;
            this.Fullname.Location = new System.Drawing.Point(5, 9);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(128, 32);
            this.Fullname.TabIndex = 0;
            this.Fullname.Text = "Fullname";
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(343, 253);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Padding = new System.Windows.Forms.Padding(0, 0, 10, 5);
            this.pbBarcode.Size = new System.Drawing.Size(179, 58);
            this.pbBarcode.TabIndex = 1;
            this.pbBarcode.TabStop = false;
            // 
            // pbEmployeeImg
            // 
            this.pbEmployeeImg.BackColor = System.Drawing.Color.Black;
            this.pbEmployeeImg.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeImg.Image")));
            this.pbEmployeeImg.Location = new System.Drawing.Point(24, 64);
            this.pbEmployeeImg.Name = "pbEmployeeImg";
            this.pbEmployeeImg.Padding = new System.Windows.Forms.Padding(3);
            this.pbEmployeeImg.Size = new System.Drawing.Size(150, 150);
            this.pbEmployeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeImg.TabIndex = 3;
            this.pbEmployeeImg.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(426, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "L G U   K A L AMANSIG";
            // 
            // conIDCard
            // 
            this.conIDCard.BackColor = System.Drawing.Color.White;
            this.conIDCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conIDCard.Controls.Add(this.panel2);
            this.conIDCard.Controls.Add(this.pbEmployeeImg);
            this.conIDCard.Controls.Add(this.flowLayoutPanel1);
            this.conIDCard.Controls.Add(this.label2);
            this.conIDCard.Controls.Add(this.pbBarcode);
            this.conIDCard.Controls.Add(this.pbLogo);
            this.conIDCard.Controls.Add(this.label1);
            this.conIDCard.Controls.Add(this.departmentLabel);
            this.conIDCard.Controls.Add(this.panel1);
            this.conIDCard.Location = new System.Drawing.Point(11, 12);
            this.conIDCard.Name = "conIDCard";
            this.conIDCard.Size = new System.Drawing.Size(534, 318);
            this.conIDCard.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.jobpositionLabel);
            this.panel1.Controls.Add(this.Fullname);
            this.panel1.Location = new System.Drawing.Point(173, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 78);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(127, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "SULTAN KUDARAT";
            // 
            // jobpositionLabel
            // 
            this.jobpositionLabel.AutoSize = true;
            this.jobpositionLabel.BackColor = System.Drawing.Color.Black;
            this.jobpositionLabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.jobpositionLabel.ForeColor = System.Drawing.Color.White;
            this.jobpositionLabel.Location = new System.Drawing.Point(7, 41);
            this.jobpositionLabel.Name = "jobpositionLabel";
            this.jobpositionLabel.Size = new System.Drawing.Size(108, 23);
            this.jobpositionLabel.TabIndex = 1;
            this.jobpositionLabel.Text = "jobposition";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.BackColor = System.Drawing.Color.White;
            this.departmentLabel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.departmentLabel.ForeColor = System.Drawing.Color.Black;
            this.departmentLabel.Location = new System.Drawing.Point(180, 170);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(96, 19);
            this.departmentLabel.TabIndex = 8;
            this.departmentLabel.Text = "department";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.BackColor = System.Drawing.Color.White;
            this.birthdateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.birthdateLabel.ForeColor = System.Drawing.Color.Black;
            this.birthdateLabel.Location = new System.Drawing.Point(5, 5);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(58, 15);
            this.birthdateLabel.TabIndex = 9;
            this.birthdateLabel.Text = "birthdate";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.birthdateLabel);
            this.flowLayoutPanel1.Controls.Add(this.genderLabel);
            this.flowLayoutPanel1.Controls.Add(this.mobileLabel);
            this.flowLayoutPanel1.Controls.Add(this.emailLabel);
            this.flowLayoutPanel1.Controls.Add(this.addressLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 211);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(313, 105);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.White;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.genderLabel.ForeColor = System.Drawing.Color.Black;
            this.genderLabel.Location = new System.Drawing.Point(5, 25);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(47, 15);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "gender";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.BackColor = System.Drawing.Color.White;
            this.mobileLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.mobileLabel.ForeColor = System.Drawing.Color.Black;
            this.mobileLabel.Location = new System.Drawing.Point(5, 45);
            this.mobileLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(45, 15);
            this.mobileLabel.TabIndex = 11;
            this.mobileLabel.Text = "mobile";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.White;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(5, 65);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 15);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.White;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.addressLabel.ForeColor = System.Drawing.Color.Black;
            this.addressLabel.Location = new System.Drawing.Point(5, 85);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(54, 15);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "address";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(438, 336);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(107, 30);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "DOWNLOAD";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(332, 336);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-1, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 78);
            this.panel2.TabIndex = 7;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 336);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 30);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // EmployeeID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(557, 378);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.conIDCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeID";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.conIDCard.ResumeLayout(false);
            this.conIDCard.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Fullname;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.PictureBox pbEmployeeImg;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conIDCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label jobpositionLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnDone;
    }
}