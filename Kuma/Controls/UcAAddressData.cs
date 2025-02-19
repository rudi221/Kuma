using Kuma.Forms;

namespace Kuma.Controls
{
    public partial class UcAAddressData : UserControl
    {
        public UcAAddressData()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
        }
    }
}
