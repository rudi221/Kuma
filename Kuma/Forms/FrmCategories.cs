using Kuma.Repositories;
using Kuma.Services;
using System.Data;

namespace Kuma.Forms
{
    public partial class FrmCategories : Form
    {
        #region Deklarationen  
        private readonly DatabaseHelper dbHelper;
        private readonly Validator _validator;
        #endregion

        #region Konstruktor
        public FrmCategories()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            _validator = new Validator(errorProvider1);
            LoadData();
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            string query = "SELECT * FROM Category";
            DataTable dataTable = dbHelper.GetDataTable(query);
            dgvCategories.DataSource = dataTable;

            if (dgvCategories.Columns["CategoryId"] != null)
            {
                dgvCategories.Columns["CategoryId"].Visible = false;
                dgvCategories.Columns["CategoryName"].HeaderText = "Kategorie";
            }
        }
        #endregion

        #region Event Handlers for Buttons
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (_validator.ValidateTextBox(txbCategory, "Dieses Feld darf nicht leer sein."))
            {
                string table = "Category";
                string[] columns = { "CategoryName" };
                object[] values = { txbCategory.Text };

                try
                {
                    dbHelper.InsertData(table, columns, values);
                    MessageBox.Show("Kategorie erfolgreich hinzugefügt!");
                    LoadData();  // Daten nach dem Einfügen aktualisieren
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}");
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Möchtest du die ausgewählte Zeile wirklich löschen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCategories.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["CategoryId"].Value.ToString();
                            string condition = $"CategoryId = {id}";

                            try
                            {
                                dbHelper.DeleteData("Category", condition);
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
