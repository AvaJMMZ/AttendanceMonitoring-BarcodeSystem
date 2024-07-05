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
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace AMSUB
{
    public partial class EmployeeID : Form
    {
        public EmployeeID(string barcode, string fullname, byte[] employeeImage, string birthdate, string gender, string mobile, string email, string address, string department, string jobposition)
        {
            InitializeComponent();
            Fullname.Text = fullname.ToUpper();
            genderLabel.Text = "Gender: " + gender;
            mobileLabel.Text = "Mobile: " + mobile; 
            emailLabel.Text = "Email: " + email; 
            addressLabel.Text = "Address: " + address; 
            departmentLabel.Text = department.ToUpper();
            jobpositionLabel.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(jobposition.ToLower());

            DateTime parsedDate;
            if (DateTime.TryParse(birthdate, out parsedDate))
            {
                birthdateLabel.Text = "Birthdate: " + parsedDate.ToString("MMMM dd, yyyy");
            }

            Bitmap barcodeImage = GenerateBarcode(barcode);

            pbBarcode.Image = barcodeImage;

            if (employeeImage != null && employeeImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(employeeImage))
                {
                    pbEmployeeImg.Image = Image.FromStream(ms);
                }
            }
        }

        private Bitmap GenerateBarcode(string content)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;
            barcodeWriter.Options = new ZXing.Common.EncodingOptions
            {
                Width = 90,
                Height = 50,
            };

            Bitmap barcodeBitmap = barcodeWriter.Write(content);

            return barcodeBitmap;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Bitmap panelBitmap = new Bitmap(conIDCard.Width, conIDCard.Height);
            conIDCard.DrawToBitmap(panelBitmap, new Rectangle(0, 0, conIDCard.Width, conIDCard.Height));

            string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
            string fileName = $"{Fullname.Text}ID.png";
            string filePath = Path.Combine(downloadsFolder, fileName);

            try
            {
                panelBitmap.Save(filePath, ImageFormat.Png);
                panelBitmap.Dispose();

                MessageBox.Show("Image saved to Downloads folder.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPanel);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void PrintPanel(object sender, PrintPageEventArgs e)
        {
            int cardWidth = 340;
            int cardHeight = 210;

            int marginLeft = 20; 
            int marginTop = 20; 

            Rectangle cardRect = new Rectangle(marginLeft, marginTop, cardWidth, cardHeight);

            using (Pen pen = new Pen(Color.Black))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, cardRect);
            }

            Bitmap panelBitmap = new Bitmap(conIDCard.Width, conIDCard.Height);
            conIDCard.DrawToBitmap(panelBitmap, new Rectangle(0, 0, conIDCard.Width, conIDCard.Height));

            e.Graphics.DrawImage(panelBitmap, cardRect);
            panelBitmap.Dispose();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
