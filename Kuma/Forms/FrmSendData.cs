using Kuma.Models;
using Kuma.Services;

namespace Kuma.Forms
{
    public partial class FrmSendData : Form
    {
        private List<ArtistFileList> currentFileList;
        private TourData currentTourData;
        private CustomerTour currentTour;

        public FrmSendData(CustomerTour customerTour, List<ArtistFileList> currentFileList)
        {
            InitializeComponent();

            this.currentFileList = currentFileList;
            this.currentTourData = customerTour.TourData;
            this.currentTour = customerTour;

            lblArtistName.Text = customerTour.TourData.ArtistName;
            lblArtisttour.Text = customerTour.TourData.TourName;

            lblCustomerName.Text = customerTour.Customer.Firstname + " " + customerTour.Customer.Lastname;
        }

        private async void btnSendData_Click(object sender, EventArgs e)
        {

            // html Vorlage erstellen und mit uuid speichern
            // template speichern in temp 

            string uniqueId = Guid.NewGuid().ToString();
            string filename = $"{uniqueId}.html";
            string downloadLink = Path.Combine("https://www.udpromo.de/kuma/", GetWebLink.GetLink($"{currentTourData.ArtistName}/{currentTourData.TourName})/"));
            string htmlContent = HtmlGenerator.GenerateHtml(currentFileList, currentTourData, downloadLink);
            string filePath = Path.Combine(PathManager.GetArtistTourPath(currentTourData.ArtistName, currentTourData.TourName), filename);

            File.WriteAllText(filePath, htmlContent);
            currentFileList.Add(new ArtistFileList("", filePath));
            lblStatus.Text = "Daten werden gesendet...";

            FtpUploader uploader = new FtpUploader();
            List<string> fileNames = currentFileList.Select(file => file.FileName).ToList();
            await uploader.UploadFilesAsync(fileNames, currentTourData, progressBar1);

            File.Delete(filePath);
            lblStatus.Text = "Daten wurden erfolgreich gesendet.";
            lblStatus.Text = "E-Mail wird gesendet...";
            string customerName = currentTour.Customer.Firstname + " " + currentTour.Customer.Lastname;

            EmailManager emailManager = new EmailManager();

            emailManager.SendEmail(currentTour.Customer.Email, currentTour.TourData.ArtistName, currentTour.TourData.TourName, customerName, txbMessageContent.Text, txbCc.Text, filename);
            lblStatus.Text = "E-Mail wurde erfolgreich gesendet.";
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
