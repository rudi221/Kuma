using Kuma.Forms;

namespace Kuma.Controls
{

    #region Deklaration

    #endregion

    #region Konstruktor
    public partial class UcAAddressData : UserControl
    {
        public UcAAddressData()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers for Buttons
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.ShowDialog();
        }

        #endregion

        #region Methoden

        #endregion

    }
}
