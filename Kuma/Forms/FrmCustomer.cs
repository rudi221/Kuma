using Kuma.Controls;
using Kuma.Models;
using Kuma.Repositories;
using Kuma.Services;
using System.Data;

namespace Kuma.Forms
{
    public partial class FrmCustomer : Form
    {
        #region Deklarationen

        private DatabaseHelper dbHelper;
        private Validator _validator;

        private UcAddressData ucAdressData;

        public event EventHandler<AddressSelectedEventArgs> AddressSelected;

        #endregion

        #region Konstruktor
        public FrmCustomer()
        {
            InitializeComponent();

            btnAddCustomer.Visible = false;

            dbHelper = new DatabaseHelper();
            _validator = new Validator(errorProvider1);
            ucAdressData = new UcAddressData();
            Controls.Add(ucAdressData);

            LoadData();
        }
        #endregion

        #region Event Handlers for Buttons
        #endregion

        #region Methoden


        private void LoadData()
        {
            string query = "SELECT CustomerId, FormOfAdress,Company,FirstName,Lastname,CustomerEmail FROM Customer";
            DataTable dataTable = dbHelper.GetDataTable(query);
            dgvCustomer.DataSource = dataTable;

            GridSettings();


        }

        private void GridSettings()

        {
            if (dgvCustomer.Columns["CustomerId"] != null)
            {
                dgvCustomer.Columns["CustomerId"].Visible = false;
                dgvCustomer.Columns["Company"].HeaderText = "Firma";
                dgvCustomer.Columns["FormOfAdress"].HeaderText = "Anrede";
                dgvCustomer.Columns["FirstName"].HeaderText = "Vorname";
                dgvCustomer.Columns["LastName"].HeaderText = "Name";
                dgvCustomer.Columns["CustomerEmail"].HeaderText = "E-Mail";
            }


        }



        #endregion

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCustomer.SelectedRows[0];
                cbTitel.Text = selectedRow.Cells["FormOfAdress"].Value.ToString();
                tbCompany.Text = selectedRow.Cells["Company"].Value.ToString();
                tbFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                tbLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                tbMail.Text = selectedRow.Cells["CustomerEmail"].Value.ToString();






            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            cbTitel.Text = "";
            tbCompany.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbMail.Text = "";

            btnUpdateCustomer.Visible = false;
            btnAddCustomer.Visible = true;
            btnAddCustomer.Location = new Point(129, 138);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            AddressData adresse = new AddressData(
                cbTitel.Text,
                tbCompany.Text,
                tbFirstName.Text,
                tbLastName.Text,
                tbMail.Text
            );
        }



        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string table = "Customer";
            string[] columns = { "FormOfAdress", "Company", "FirstName", "LastName", "CustomerEmail" };
            object[] values = { cbTitel.Text, tbCompany.Text, tbFirstName.Text, tbLastName.Text, tbMail.Text };


            if (ValidateForm())
            {
                try
                {
                    dbHelper.InsertData(table, columns, values);
                    MessageBox.Show("Kunde erflogreich hinzugefügt!");
                    btnAddCustomer.Visible = false;
                    btnUpdateCustomer.Visible = true;
                    LoadData();  // Daten nach dem Einfügen aktualisieren
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }




        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();

                e.SuppressKeyPress = true;
            }
        }




        private void PerformSearch()
        {
            string searchWord = tbSearch.Text;

            if (searchWord.Length > 0)
            {
                string query = $"SELECT CustomerId, FormOfAdress, Company, FirstName, LastName, CustomerEmail FROM Customer WHERE Company LIKE '%{searchWord}%' or LastName LIKE '%{searchWord}%'";

                GridSettings();

                DataTable dataTable = dbHelper.GetDataTable(query);
                dgvCustomer.DataSource = dataTable;
            }
            else
            {
                LoadData();
            }

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

            if (dgvCustomer.SelectedRows.Count > 0)
            {

                DialogResult result = MessageBox.Show("Möchtest du die ausgewählte Zeile wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    foreach (DataGridViewRow row in dgvCustomer.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["CustomerId"].Value.ToString();
                            string condition = $"CustomerId = {id}";

                            try
                            {
                                dbHelper.DeleteData("Customer", condition);
                                dgvCustomer.Rows.Remove(row);

                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                            }
                        }
                    }



                }




            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            isValid &= _validator.ValidateTextBox(tbCompany, "Dieses Feld darf nicht leer sein.");
            isValid &= _validator.ValidateTextBox(tbFirstName, "Dieses Feld darf nicht leer sein.");
            isValid &= _validator.ValidateTextBox(tbLastName, "Dieses Feld darf nicht leer sein.");
            isValid &= _validator.ValidateEmailTextBox(tbMail, "Die Emailadresse ist im falschen Format.");

            return isValid;



        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            AddressData adresse = new AddressData(
                cbTitel.Text,
                tbCompany.Text,
                tbFirstName.Text,
                tbLastName.Text,
                tbMail.Text
            );

            OnAddressSelected(new AddressSelectedEventArgs(adresse));
            this.DialogResult = DialogResult.OK;
        }


        protected virtual void OnAddressSelected(AddressSelectedEventArgs e)
        {
            AddressSelected?.Invoke(this, e);
        }
    }


}
