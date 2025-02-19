using Kuma.Controls;

namespace Kuma
{
    public partial class FrmMain : Form
    {

        private UcMenu ucMenu;
        private UcArtistData ucArtistData;
        private UcAAddressData ucAddressData;



        public FrmMain()
        {
            InitializeComponent();

            MinimumSize = new Size(1210, 900);
        }
    }
}
