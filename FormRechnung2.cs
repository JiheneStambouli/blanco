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
    public partial class FormRechnung2 : Form
    {
        private bool shouldCloseForm = false;
        public List<Rechnung> RechnungenListToEdit { get; set; }
        private int CurrentRechnungIndex { get; set; }

        private decimal sumGesamtpreis { get; set; }

        public FormRechnung2()
        {
            InitializeComponent();
            SetProperties();

            this.RechnungenListToEdit = new List<Rechnung>();

            //AddNewRechnung();
        }

        public FormRechnung2(List<Rechnung> rechnungenListToEdit)
        {
            InitializeComponent();
            SetProperties();


            this.sumGesamtpreis = 0; 

            RechnungenListToEdit = rechnungenListToEdit;
            if (RechnungenListToEdit.Count > 1)
            {
                this.btnWeiter.Enabled = true;
            }
            CurrentRechnungIndex = 0;
            ShowCurrentRechnung();
        }

        private void SetProperties()
        {
            SetIconStylesToButton(btnHome);
            SetIconStylesToButton(btnAddService);
            SetIconStylesToButton(btnDeleteService);

            this.MinimumSize = new Size(823, 676);

            // Events
            this.FormClosing += FormRechnung_FormClosing;

            this.txtAbsender.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular) ;
            this.txtEmpfaenger.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            this.txtIntro.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            this.txtGruss.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            this.txtContent.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            this.txtEndGruss.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);


            // Initialize textboxes event handlers
            txtRechnungNr.TextChanged += TxtRechnungNr_TextChanged;
            txtKundenNr.TextChanged += TxtKundenNr_TextChanged;
            //txtEmpfaenger.TextChanged += TxtEmpfaenger_TextChanged;
            txtBeginDate.TextChanged += TxtBeginDate_TextChanged;
            txtEndDate.TextChanged += TxtEndDate_TextChanged;
            txtZeichen.TextChanged += TxtZeichen_TextChanged;
            txtDatum.TextChanged += TxtDatum_TextChanged;
            txtGruss.TextChanged += TxtGruss_TextChanged;
            txtIntro.TextChanged += TxtIntro_TextChanged;
            txtContent.TextChanged += TxtContent_TextChanged;
            txtEndGruss.TextChanged += TxtEndGruss_TextChanged;


            this.btnPrevious.Enabled = false;
            this.btnWeiter.Enabled = false;

            this.btnHome.DialogResult = DialogResult.Abort;
            this.btnSaveRechnung.DialogResult = DialogResult.OK;

        }

        private void SetIconStylesToButton(Button btn)
        {
            Image originalImage = btn.Image;
            // Resize the image to fit the button's size
            Image resizedImage = new Bitmap(btn.Width, btn.Height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, btn.Width, btn.Height));
            }

            // Set the resized image as the button's background image
            btn.BackgroundImage = resizedImage;

            // Stretch and fill the image inside the button
            btn.BackgroundImageLayout = ImageLayout.Stretch;

            // Access the image from resources

            this.FormBorderStyle = FormBorderStyle.Sizable;

            btn.Text = string.Empty;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0; // Set the border size to 1 (optional)

        }

        private void UpdateButtonStates()
        {
            btnPrevious.Enabled = CurrentRechnungIndex > 0;
            btnWeiter.Enabled = CurrentRechnungIndex < RechnungenListToEdit.Count - 1;
        }

        //private void AddNewRechnung()
        //{
        //    Rechnung rechnung = new Rechnung();
        //    this.RechnungenListToEdit.Add(rechnung);
        //    CurrentRechnungIndex = RechnungenListToEdit.Count - 1;
        //    ShowCurrentRechnung();
        //    UpdateButtonStates();
        //}

        private void ShowCurrentRechnung()
        {
            this.txtEmpfaenger.Text = RechnungenListToEdit[CurrentRechnungIndex].Empfaenger;
            this.txtRechnungNr.Text = RechnungenListToEdit[CurrentRechnungIndex].RechnungNr.ToString();
            //this.txtZeichen.Text = RechnungenListToEdit[CurrentRechnungIndex].Zeichen;
            //this.txtKundenNr.Text = RechnungenListToEdit[CurrentRechnungIndex].KundenNr;
            this.txtDatum.Text = RechnungenListToEdit[CurrentRechnungIndex].Datum.ToString();
            this.txtBeginDate.Text = RechnungenListToEdit[CurrentRechnungIndex].BeginDate.ToString();
            this.txtEndDate.Text = RechnungenListToEdit[CurrentRechnungIndex].EndDate.ToString();
            this.txtGruss.Text = RechnungenListToEdit[CurrentRechnungIndex].Gruss;
            this.txtIntro.Text = RechnungenListToEdit[CurrentRechnungIndex].Intro;
            this.txtContent.Text = RechnungenListToEdit[CurrentRechnungIndex].Content;
            this.txtEndGruss.Text = RechnungenListToEdit[CurrentRechnungIndex].EndGruss;


            foreach (Service service in RechnungenListToEdit[CurrentRechnungIndex].Services)
            {
                dataGridView.Rows.Add(service.Pos + ".", service.Beschreibung, service.Menge, service.Einzelpreis, service.Gesamtpreis);
            }


            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            this.dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[0].Width = (int)(dataGridView.Width * 0.1);  

            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].Width = (int)(dataGridView.Width * 0.3);  

            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[2].Width = (int)(dataGridView.Width * 0.2);  

            dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[3].Width = (int)(dataGridView.Width * 0.2);  


            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[4].Width = (int)(dataGridView.Width * 0.2);

            Add3FixatedRows();

            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dataGridView.CellPainting += DataGridView_CellPainting;
            dataGridView.CellValueChanged += DataGridView_CellValueChanged;
            dataGridView.SelectionChanged += DataGridView_SelectionChanged;

        }


        private void Add3FixatedRows()
        {
            //// Calculate the sum of Gesamtpreis for all rows
            //for (int i = 0; i < dataGridView.Rows.Count - 1; i++) // Exclude the last row (which is the new row)
            //{
            //    DataGridViewRow row = dataGridView.Rows[i];
            //    if (row.Cells["Gesamtpreis"].Value != null && decimal.TryParse(row.Cells["Gesamtpreis"].Value.ToString(), out decimal gesamtpreis))
            //    {
            //        sumGesamtpreis += gesamtpreis;
            //    }
            //}

            // Check if the grid is empty
            if (dataGridView.RowCount == 0)
            {
                
            }

            //// Add the row for Summe Netto
            //dataGridView.Rows.Add("", "", "", "Summe Netto:", sumGesamtpreis.ToString("C"));

            //// Add the row for § 38 UStG
            //dataGridView.Rows.Add("", "", "", "§ 38 UStG:", "€");

            //// Add the row for GesamtPreis
            //dataGridView.Rows.Add("", "", "", "Gesamtpreis:", (sumGesamtpreis + 10).ToString("C")); // Adding 10 for UStG

            // Assuming you have already defined and configured the DataGridView named dataGridView

            // Add the row for Summe Netto
            var rowSummeNetto = new DataGridViewRow();
            rowSummeNetto.CreateCells(dataGridView);

            rowSummeNetto.Cells[0].ReadOnly = true;
            rowSummeNetto.Cells[1].ReadOnly = true;
            rowSummeNetto.Cells[2].ReadOnly = true;

            rowSummeNetto.Cells[3].Value = "Summe Netto:";
            rowSummeNetto.Cells[4].Value = sumGesamtpreis.ToString("C");
            dataGridView.Rows.Add(rowSummeNetto);

            // Add the row for § 38 UStG
            var rowUStG = new DataGridViewRow();
            rowUStG.CreateCells(dataGridView);

            rowUStG.Cells[0].ReadOnly = true;
            rowUStG.Cells[1].ReadOnly = true;
            rowUStG.Cells[2].ReadOnly = true;

            rowUStG.Cells[3].Value = "§ 38 UStG:";
            rowUStG.Cells[4].Value = "€";
            dataGridView.Rows.Add(rowUStG);

            // Add the row for GesamtPreis
            var rowGesamtpreis = new DataGridViewRow();
            rowGesamtpreis.CreateCells(dataGridView);

            rowGesamtpreis.Cells[0].ReadOnly = true;
            rowGesamtpreis.Cells[1].ReadOnly = true;
            rowGesamtpreis.Cells[2].ReadOnly = true;

            rowGesamtpreis.Cells[3].Value = "Gesamtpreis:";
            rowGesamtpreis.Cells[4].Value = (sumGesamtpreis + 10).ToString("C"); // Adding 10 for UStG
            dataGridView.Rows.Add(rowGesamtpreis);

        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                // Get the index of the last three rows
                int rowCount = dataGridView.Rows.Count;
                int lastThreeRowsStartIndex = Math.Max(rowCount - 3, 0);

                // Get the current selected cell
                DataGridViewCell currentCell = dataGridView.SelectedCells[0];

                // Check if the selected cell is in the last three rows and not in the last column of the before last row
                if (currentCell.RowIndex >= lastThreeRowsStartIndex &&
                    !(currentCell.RowIndex == rowCount - 2 && currentCell.ColumnIndex == dataGridView.Columns.Count - 1))
                {
                    // Clear the selection
                    dataGridView.ClearSelection();

                }
            }
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewCellStyle gridcolStyle = new DataGridViewCellStyle();
            gridcolStyle.BackColor = SystemColors.AppWorkspace;


            dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].Style = gridcolStyle;

            dataGridView.Rows[dataGridView.RowCount - 2].Cells[0].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 2].Cells[1].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 2].Cells[2].Style = gridcolStyle;

            dataGridView.Rows[dataGridView.RowCount - 3].Cells[0].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[1].Style = gridcolStyle;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[2].Style = gridcolStyle;

            dataGridView.Rows[dataGridView.RowCount - 1].Cells[0].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[1].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[2].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[3].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 1].Cells[4].ReadOnly = true;

            dataGridView.Rows[dataGridView.RowCount - 2].Cells[0].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 2].Cells[1].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 2].Cells[2].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 2].Cells[3].ReadOnly = true;

            dataGridView.Rows[dataGridView.RowCount - 3].Cells[0].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[1].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[2].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[3].ReadOnly = true;
            dataGridView.Rows[dataGridView.RowCount - 3].Cells[4].ReadOnly = true;
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //todoooooooooooooooooooooooooooooooooooooooooooooooooooooooo
            //// Calculate the sum of Gesamtpreis for all rows
            //decimal sumGesamtpreis = 0;
            //for (int i = 0; i < dataGridView.Rows.Count - 1; i++) // Exclude the last row (which is the new row)
            //{
            //    DataGridViewRow row = dataGridView.Rows[i];
            //    if (row.Cells["Gesamtpreis"].Value != null && decimal.TryParse(row.Cells["Gesamtpreis"].Value.ToString(), out decimal gesamtpreis))
            //    {
            //        sumGesamtpreis += gesamtpreis;
            //    }
            //}

            //// Update the GesamtPreis row with the new sum
            //dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[3].Value = "GesamtPreis: " + (sumGesamtpreis + 10).ToString("C");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AreYouSureToAbort();
        }

        private void AreYouSureToAbort()
        {
            DialogResult result = MessageBox.Show("Are you sure to exit the Edit Mode without saving your data first?", "Are you sure?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                shouldCloseForm = true;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentRechnungIndex > 0)
            {
                CurrentRechnungIndex--;
                ShowCurrentRechnung();
                UpdateButtonStates();
            }
        }

        private void btnWeiter_Click(object sender, EventArgs e)
        {
            if (CurrentRechnungIndex < RechnungenListToEdit.Count - 1)
            {
                CurrentRechnungIndex++;
                ShowCurrentRechnung();
                UpdateButtonStates();
            }
        }

        private void FormRechnung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldCloseForm)
            {
                // Close the form if the flag is set
                return; // Exit the event handler
            }
            else
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    AreYouSureToAbort();
                }
            }
            // Check if the close reason is because the user clicked the close button

        }

        private void TxtRechnungNr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtKundenNr_TextChanged(object sender, EventArgs e)
        {
            RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.KundenNummer = txtKundenNr.Text;
        }

        //private void TxtEmpfaenger_TextChanged(object sender, EventArgs e)
        //{
        //    RechnungenListToEdit[CurrentRechnungIndex].Empfaenger = txtEmpfaenger.Text;
        //}

        private void TxtBeginDate_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtBeginDate.Text, out DateTime beginDate))
            {
                RechnungenListToEdit[CurrentRechnungIndex].BeginDate = beginDate;
            }
        }

        private void TxtEndDate_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtEndDate.Text, out DateTime endDate))
            {
                RechnungenListToEdit[CurrentRechnungIndex].EndDate = endDate;
            }
        }

        private void TxtZeichen_TextChanged(object sender, EventArgs e)
        {
            //RechnungenListToEdit[CurrentRechnungIndex].Zeichen = txtZeichen.Text;
        }

        private void TxtDatum_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(txtDatum.Text, out DateTime datum))
            {
                RechnungenListToEdit[CurrentRechnungIndex].Datum = datum;
            }
        }

        private void TxtGruss_TextChanged(object sender, EventArgs e)
        {
            RechnungenListToEdit[CurrentRechnungIndex].Gruss = txtGruss.Text;
        }

        private void TxtContent_TextChanged(object sender, EventArgs e)
        {
            RechnungenListToEdit[CurrentRechnungIndex].Content = txtContent.Text;
        }

        private void TxtIntro_TextChanged(object sender, EventArgs e)
        {
            RechnungenListToEdit[CurrentRechnungIndex].Content = txtIntro.Text;
        }

        private void TxtEndGruss_TextChanged(object sender, EventArgs e)
        {
            RechnungenListToEdit[CurrentRechnungIndex].Content = txtEndGruss.Text;
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            //AddNewRechnung();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {

        }
    }
}
