using Kuma.Models;

namespace Kuma.Services
{

    public static class HtmlGenerator
    {
        public static string GenerateHtml(List<ArtistFileList>? currentFileList, TourData tourData)
        {
            string htmlHeader = $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta http-equiv='X-UA-Compatible' content='IE=edge'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <link href='https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC' crossorigin='anonymous'>
                <style> body background - color: #f5f5f5; </style>
                <title>Document</title>
            </head>
            <body>
                <div style='background: #fff; width: 100%;'>
                    <div class='container'>
                        <div class='row'>
                            <div class='col-2 p-3'>
                                <img src='../../Images/logo.jpg' alt=''>
                            </div>
                            <div class='col-10'></div>
                        </div>
                    </div>
                </div>
                <div class='container'>
                    <div class='row'>
                        <div class='col-12'>
                            <div class='col-12 mt-5'>
                                <h3>Ihre Informationen zu {tourData.ArtistName}</h3>
                            </div>
                        </div>
                    </div>
                </div>
                <div class='container'>
                    <div class='row'>
                        <div class='col-12'>
                            <table class='table mt-5 table-striped'>
                                <thead>
                                    <tr class='table-primary'>
                                        <th>Name</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody>";

            string htmlBody = "";
            foreach (var currentFile in currentFileList)
            {
                htmlBody += $@"
                <tr>
                    <td style='width: 90%;'>{currentFile.Category}</td>
                    <td style='width: 10%;'>
                        <a href='{currentFile.FileName}' download>
                            <button type='button' class='btn btn-sm btn-success'>Download</button>
                        </a>
                    </td>
                </tr>";
            }

            string htmlFooter = @"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </body>
            </html>";

            return htmlHeader + htmlBody + htmlFooter;
        }


    }
}




