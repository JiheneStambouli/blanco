using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlancoAssist
{
    public partial class FormMain : BaseBlancoForm
    {
        //RechnungenDAO rechnungenDAO = new RechnungenDAO();

        BindingSource RechnungenBindingSource = new BindingSource();

        public FormRechnung formRechnung;

        private bool editMode = false;

        public List<Rechnung> rechnungenListToEdit;

        private Helper helper;

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FormMain()
        {
            InitializeComponent();

            helper = new Helper();
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;

            //initializeMaterialSkinManager();

            InitializeButtonsProperties();
            InitializeRechnungGridProperties();
            InitializeKundenGridProperties();
            InitializeVersichererGridProperties();

            FormsHelper.SetCommonGridProperties(this.dataGridViewKunden);
            FormsHelper.SetCommonGridProperties(this.dataGridViewRechnungen);
            FormsHelper.SetCommonGridProperties(this.dataGridViewVersicherer);


            FormsHelper.SetCommonAddButtonsProperties(this.btnAddKunde);
            FormsHelper.SetCommonAddButtonsProperties(this.btnAddRechnung);
            FormsHelper.SetCommonAddButtonsProperties(this.btnAddVersicherer);
            FormsHelper.SetCommonEditButtonsProperties(this.btnEditKunde);
            FormsHelper.SetCommonEditButtonsProperties(this.btnEditRechnungen);
            FormsHelper.SetCommonEditButtonsProperties(this.btnEditVersicherer);
            FormsHelper.SetCommonRemoveButtonsProperties(this.btnDeleteKunde);
            FormsHelper.SetCommonRemoveButtonsProperties(this.btnDeleteRechnungen);
            FormsHelper.SetCommonRemoveButtonsProperties(this.btnDeleteVersicherer);

            FormsHelper.SetCommonTabControlProperties(this.tabControlMain);
            this.DrawerTabControl = this.tabControlMain;

            //CommonTabControlProperties(this.tabControlMain);
            //CommonTabControlProperties(this.tabControlEditMode);
            //this.RechnungenBindingSource.DataSource = rechnungenDAO.Rechnungen;
            //this.dataGridViewHome.DataSource = RechnungenBindingSource;
            this.dataGridViewRechnungen.DataSource = helper.Rechnungen;
            this.dataGridViewKunden.DataSource = helper.Kunden;
            this.dataGridViewVersicherer.DataSource = helper.Versicherer;
        }

        /*
    (\(\
    ( – -)   
    ((‘) (’)
   */

        //Buttons Edit/Add/Delete Events 
        private void InitializeButtonsProperties()
        {
            this.btnEditRechnungen.Enabled = false;
            this.btnDeleteRechnungen.Enabled = false;
        }
        private void btnAddRechnung_Click(object sender, EventArgs e)
        {
            EnableEditMode();
            
            CreateRechnung();
        }

        private void btnAddKunden_Click(object sender, EventArgs e)
        {
            EnableEditMode();
            CreateKunde();
        }

        private void btnAddVersicherer_Click(object sender, EventArgs e)
        {
            EnableEditMode();
            CreateVersicherer();
        }

        private void btnEditRechnugen_Click(object sender, EventArgs e)
        {
            this.EnableEditMode();
            EditRechnungen();
        }

        private void btnEditKunden_Click(object sender, EventArgs e)
        {
            this.EnableEditMode();
            EditKunden();
        }

        private void btnEditVersicherer_Click(object sender, EventArgs e)
        {
            this.EnableEditMode();
            EditVersicherer();
        }

        private void btnRemoveRechnungen_Click(object sender, EventArgs e)
        {
            RemoveRechnungen();
            this.dataGridViewRechnungen.DataSource = this.helper.UpdateRechnungenFromDatabase();
        }

        private void btnRemoveKunden_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnRemoveVersicherer_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void CreateRechnung()
        {
            this.formRechnung = new FormRechnung(this.helper);
            ShowFormRechnungDialog(formRechnung);
        }

        private void CreateKunde()
        {
            //todo
        }

        private void CreateVersicherer()
        {
            //todo
        }

        private void EditRechnungen()
        {
            rechnungenListToEdit = new List<Rechnung>();

            //List<DataGridViewRow> selectedRows = dataGridViewHome.SelectedRows.Cast<DataGridViewRow>().ToList();
            List<DataGridViewRow> selectedRows = dataGridViewRechnungen.SelectedRows.Cast<DataGridViewRow>()
                                .OrderBy(row => row.Index).ToList();


            // Get the Rechnung list from the data source
            foreach (DataGridViewRow row in selectedRows)
            {
                Rechnung rechnung = (Rechnung)row.DataBoundItem;
                rechnungenListToEdit.Add(rechnung);
            }

            formRechnung = new FormRechnung(this.helper, rechnungenListToEdit);
            ShowFormRechnungDialog(formRechnung);
        }

        private void EditKunden()
        {
            //todo
        }

        private void EditVersicherer()
        {
            //todo
        }

        private void RemoveRechnungen()
        {
            List<string> selectedRechnungIds = new List<string>();
            foreach (DataGridViewRow row in dataGridViewRechnungen.SelectedRows)
            {
                Rechnung rechnung = (Rechnung)row.DataBoundItem;
                selectedRechnungIds.Add(rechnung.ID);
            }

            helper.DeleteRechnungen(selectedRechnungIds);
        }

        private void RemoveKunden()
        {
            //todo
        }

        private void RemoveVersicherer()
        {
            //todo
        }

                /*
          (\(\
          ( – -)   
          ((‘) (’)
         */

        //SkinManager
        private void initializeMaterialSkinManager()
        {
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

            /*
         (\(\
         ( – -)
         ((‘) (’)
        */
        //Grids
        private void InitializeRechnungGridProperties()
        {
            //dataGridViewRechnungen Events
            this.dataGridViewRechnungen.SelectionChanged += dataGridViewRechnungen_SelectionChanged;
            this.dataGridViewRechnungen.CellClick += dataGridViewRechnungen_CellClick;


            this.dataGridViewRechnungen.AutoGenerateColumns = false;
            this.dataGridViewRechnungen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewRechnungen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[0].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[1].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[2].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[3].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 


            this.dataGridViewRechnungen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[4].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[5].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[6].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 


            this.dataGridViewRechnungen.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[7].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[8].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 

            this.dataGridViewRechnungen.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[9].Width = (int)(this.dataGridViewRechnungen.Width * 0.05);

            this.dataGridViewRechnungen.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[10].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 


            this.dataGridViewRechnungen.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewRechnungen.Columns[11].Width = (int)(this.dataGridViewRechnungen.Width * 0.05); 
        }

        private void InitializeKundenGridProperties()
        {
            //dataGridViewRechnungen Events
            this.dataGridViewKunden.SelectionChanged += DataGridViewKunden_SelectionChanged;
            this.dataGridViewKunden.CellClick += DataGridViewKunden_CellClick;


            this.dataGridViewKunden.AutoGenerateColumns = false;
            this.dataGridViewKunden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewKunden.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewKunden.Columns[0].Width = (int)(this.dataGridViewKunden.Width * 0.1); // 10%

            this.dataGridViewKunden.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewKunden.Columns[1].Width = (int)(this.dataGridViewKunden.Width * 0.15); // 30%

            this.dataGridViewKunden.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewKunden.Columns[2].Width = (int)(this.dataGridViewKunden.Width * 0.20); // 20%

            this.dataGridViewKunden.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewKunden.Columns[3].Width = (int)(this.dataGridViewKunden.Width * 0.4); // 40%


            this.dataGridViewKunden.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewKunden.Columns[4].Width = (int)(this.dataGridViewKunden.Width * 0.15); // 40%

        }

        private void InitializeVersichererGridProperties()
        {
            //dataGridViewRechnungen Events
            this.dataGridViewVersicherer.SelectionChanged += DataGridViewVersicherer_SelectionChanged;
            this.dataGridViewVersicherer.CellClick += DataGridViewVersicherer_CellClick;

            this.dataGridViewVersicherer.AutoGenerateColumns = false;
            this.dataGridViewVersicherer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridViewVersicherer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewVersicherer.Columns[0].Width = (int)(this.dataGridViewVersicherer.Width * 0.3); // 10%

            this.dataGridViewVersicherer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewVersicherer.Columns[1].Width = (int)(this.dataGridViewVersicherer.Width * 0.7);
        }

        //-----------------

        private void dataGridViewRechnungen_SelectionChanged(object sender, EventArgs e)
        {
            btnEditRechnungen.Enabled = dataGridViewRechnungen.SelectedRows.Count > 0;
            btnDeleteRechnungen.Enabled = dataGridViewRechnungen.SelectedRows.Count > 0;
            foreach (DataGridViewCell cell in dataGridViewRechnungen.SelectedCells)
            {
                // Select the entire row of the current cell
                dataGridViewRechnungen.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void DataGridViewKunden_SelectionChanged(object sender, EventArgs e)
        {
            //todo
            //btnEditRechnungen.Enabled = dataGridViewRechnungen.SelectedRows.Count > 0;
            //btnDeleteRechnungen.Enabled = dataGridViewRechnungen.SelectedRows.Count > 0;
            //foreach (DataGridViewCell cell in dataGridViewRechnungen.SelectedCells)
            //{
            //    // Select the entire row of the current cell
            //    dataGridViewRechnungen.Rows[cell.RowIndex].Selected = true;
            //} 
        }

        private void DataGridViewVersicherer_SelectionChanged(object sender, EventArgs e)
        {
            //todo
        }

        //-------------

        private void dataGridViewRechnungen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the last row and last column
            if (e.RowIndex == dataGridViewRechnungen.RowCount - 1 && e.ColumnIndex == 0)
            {
                // Switch to the second tab page when the last row and last column is clicked
                EnableEditMode();
                CreateRechnung();
            }

            else
            {
                dataGridViewRechnungen.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DataGridViewKunden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the last row and last column
            if (e.RowIndex == this.dataGridViewKunden.RowCount - 1 && e.ColumnIndex == 0)
            {
                // Switch to the second tab page when the last row and last column is clicked
                EnableEditMode();
                CreateKunde();
            }

            else
            {
                this.dataGridViewKunden.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DataGridViewVersicherer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewKunden.RowCount - 1 && e.ColumnIndex == 0)
            {
                // Switch to the second tab page when the last row and last column is clicked
                EnableEditMode();
                CreateVersicherer();
            }

            else
            {
                this.dataGridViewKunden.Rows[e.RowIndex].Selected = true;
            }
        }

        //---------

        private void dataGridViewRechnungen_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridViewRechnungen.Refresh();
        }
        private void dataGridViewVersicherer_DataSourceChanged(object sender, EventArgs e)
        {
            //todo
        }

        private void dataGridViewKunden_DataSourceChanged(object sender, EventArgs e)
        {
            //todo
        }


            /*
         (\(\
         ( – -)
         ((‘) (’)
        */

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
            this.dataGridViewRechnungen.DataSource = helper.UpdateRechnungenFromDatabase();
            this.Show();
        }


        /*
         (\(\
         ( – -)
         ((‘) (’)
        */

        private void ShowFormRechnungDialog(FormRechnung formRechnung)
        {

            DialogResult result = formRechnung.ShowDialog() == DialogResult.OK ? DialogResult.OK : DialogResult.Cancel;


            if (result == DialogResult.OK)
            {
                List<Rechnung> updateRechnungenList = formRechnung.RechnungenListToEdit;

                helper.SaveOrUpdateRechnungenToDatabase(updateRechnungenList);

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
