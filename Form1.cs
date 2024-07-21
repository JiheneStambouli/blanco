using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlancoAssist
{
        public partial class Form1 : Form
        {
            RechnungenDAO rechnungenDAO = new RechnungenDAO();

            BindingSource RechnungenBindingSource = new BindingSource();

            public FormRechnung2 formRechnung;

            private bool editMode = false;

            public List<Rechnung> rechnungenListToEdit;

            public Form1()
            {
                InitializeComponent();


                this.btnEditRechnugen.Enabled = false;
                InitializeGridProperties();
                this.RechnungenBindingSource.DataSource = rechnungenDAO.Rechnungen;
                this.dataGridViewHome.DataSource = RechnungenBindingSource;
                this.dataGridViewHome.CellClick += dataGridViewHome_CellClick;
            }

            private void InitializeGridProperties()
            {
                dataGridViewHome.SelectionChanged += dataGridViewHome_SelectionChanged;


                this.dataGridViewHome.AutoGenerateColumns = false;
                dataGridViewHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridViewHome.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[0].Width = (int)(dataGridViewHome.Width * 0.15); // 10%

                dataGridViewHome.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[1].Width = (int)(dataGridViewHome.Width * 0.2); // 30%

                dataGridViewHome.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[2].Width = (int)(dataGridViewHome.Width * 0.15); // 20%

                dataGridViewHome.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[3].Width = (int)(dataGridViewHome.Width * 0.2); // 40%


                dataGridViewHome.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[4].Width = (int)(dataGridViewHome.Width * 0.2); // 40%

                dataGridViewHome.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewHome.Columns[5].Width = (int)(dataGridViewHome.Width * 0.22); // 40%
            }



            //List<Rechnung> selectedRechnugenToEdit = new List<Rechnung>();

            private void dataGridViewHome_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // Check if the clicked cell is in the last row and last column
                if (e.RowIndex == dataGridViewHome.RowCount - 1 && e.ColumnIndex == 0)
                {
                    // Switch to the second tab page when the last row and last column is clicked
                    EnableEditMode();
                    CreateRechnung();
                }

                else
                {
                    dataGridViewHome.Rows[e.RowIndex].Selected = true;
                }
            }

            private void CreateRechnung()
            {
                this.formRechnung = new FormRechnung2();
                ShowFormRechnungDialog(formRechnung);
            }

            private void EnableEditMode()
            {
                this.editMode = true;
                this.Hide();
            }

            private void DisableEditMode()
            {
                this.editMode = false;
                this.formRechnung = null;
                rechnungenListToEdit = null;
                this.dataGridViewHome.DataSource = rechnungenDAO.UpdateRechnungenFromDatabase();
                this.Show();

            }

            private void EditRechnungen()
            {
                rechnungenListToEdit = new List<Rechnung>();

                //List<DataGridViewRow> selectedRows = dataGridViewHome.SelectedRows.Cast<DataGridViewRow>().ToList();
                List<DataGridViewRow> selectedRows = dataGridViewHome.SelectedRows.Cast<DataGridViewRow>()
                                    .OrderBy(row => row.Index).ToList();


                // Get the Rechnung list from the data source
                foreach (DataGridViewRow row in selectedRows)
                {
                    Rechnung rechnung = (Rechnung)row.DataBoundItem;
                    rechnungenListToEdit.Add(rechnung);
                }

                formRechnung = new FormRechnung2(rechnungenListToEdit);
                ShowFormRechnungDialog(formRechnung);
            }

            private void RemoveRechnungen()
            {
                List<string> selectedRechnungIds = new List<string>();
                foreach (DataGridViewRow row in dataGridViewHome.SelectedRows)
                {
                    Rechnung rechnung = (Rechnung)row.DataBoundItem;
                    selectedRechnungIds.Add(rechnung.ID);
                }

                rechnungenDAO.DeleteRechnungen(selectedRechnungIds);
            }

            private void ShowFormRechnungDialog(FormRechnung2 formRechnung)
            {

                DialogResult result = formRechnung.ShowDialog() == DialogResult.OK ? DialogResult.OK : DialogResult.Cancel;


                if (result == DialogResult.OK)
                {
                    List<Rechnung> updateRechnungenList = formRechnung.RechnungenListToEdit;

                    rechnungenDAO.SaveOrUpdateRechnungenToDatabase(updateRechnungenList);

                    this.DisableEditMode();
                }
                if (result == DialogResult.Cancel)
                {
                    this.DisableEditMode();
                }
                if (result == DialogResult.None)
                {

                }
            }

            private void dataGridViewHome_SelectionChanged(object sender, EventArgs e)
            {
                btnEditRechnugen.Enabled = dataGridViewHome.SelectedRows.Count > 0;
                btnRemoveRechnungen.Enabled = dataGridViewHome.SelectedRows.Count > 0;
                foreach (DataGridViewCell cell in dataGridViewHome.SelectedCells)
                {
                    // Select the entire row of the current cell
                    dataGridViewHome.Rows[cell.RowIndex].Selected = true;
                }
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                EnableEditMode();
                CreateRechnung();
            }

            private void btnEditRechnugen_Click(object sender, EventArgs e)
            {
                this.EnableEditMode();
                EditRechnungen();
            }

            private void btnRemoveRechnungen_Click(object sender, EventArgs e)
            {
                RemoveRechnungen();
                this.dataGridViewHome.DataSource = rechnungenDAO.UpdateRechnungenFromDatabase();
            }

            private void dataGridViewHome_DataSourceChanged(object sender, EventArgs e)
            {
                dataGridViewHome.Refresh();
            }

        }
}
