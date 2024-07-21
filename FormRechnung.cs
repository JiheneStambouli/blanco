using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlancoAssist
{
    public partial class FormRechnung : BaseBlancoForm
    {
        private Helper helper { get; set; }

        private bool shouldCloseForm = false;
        public List<Rechnung> RechnungenListToEdit { get; set; }
        private int CurrentRechnungIndex { get; set; }

        private decimal sumGesamtpreis { get; set; }

        public FormRechnung(Helper helper)
        {
            InitializeComponent();

            this.helper = helper;


            SetProperties();

            this.RechnungenListToEdit = new List<Rechnung>();

        }

        public FormRechnung(Helper helper, List<Rechnung> rechnungenListToEdit)
        {
            InitializeComponent();

            this.helper = helper;


            SetProperties();

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
            this.MinimumSize = new Size(823, 676);
            this.DrawerTabControl = this.tabControlEditMode;
            FormsHelper.SetCommonTabControlProperties(this.tabControlEditMode);

            radioButtonHHH.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonGebaude.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonEntlastung.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonPrivat.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonRenovierung.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonVerhinderung.CheckedChanged += RadioButton_CheckedChanged;


            //FormsHelper.SetCommonTextBoxProperties(this.txtKundenNr);
            //FormsHelper.SetCommonTextBoxProperties(this.txtKundenFirstName);
            //FormsHelper.SetCommonTextBoxProperties(this.txtKundenLastName);
            //FormsHelper.SetCommonTextBoxProperties(this.txtAddress);
            //FormsHelper.SetCommonTextBoxProperties(this.txtRechnungNr);
            //FormsHelper.SetCommonTextBoxProperties(this.txtZeichen);
            //FormsHelper.SetCommonTextBoxProperties(this.txtEmpaenger);
            //FormsHelper.SetCommonTextBoxProperties(this.txtStunden);
            //FormsHelper.SetCommonTextBoxProperties(this.txtBeginDate);
            //FormsHelper.SetCommonTextBoxProperties(this.txtEndDate);
            //FormsHelper.SetCommonTextBoxProperties(this.txtBezahlt);
            //FormsHelper.SetCommonTextBoxProperties(this.txtDatumBezahlt);
            //FormsHelper.SetCommonTextBoxProperties(this.txtFaelligAm);
            //FormsHelper.SetCommonTextBoxProperties(this.txtStatus);


            //this.FormsHelper.SetCommonDateTextBoxProperties(this.txtBeginDate);
            //this.FormsHelper.SetCommonDateTextBoxProperties(this.txtEndDate);
            //this.FormsHelper.SetCommonDateTextBoxProperties(this.txtDatumBezahlt);
            //this.FormsHelper.SetCommonDateTextBoxProperties(this.txtFaelligAm);

            //this.FormsHelper.SetCommonToolbarButtonsProperties(this.btnHome);
            //this.FormsHelper.SetCommonToolbarButtonsProperties(this.btnSaveRechnung);
            //this.FormsHelper.SetCommonToolbarButtonsProperties(this.btnDownload);

            foreach (TextBox textBox in new TextBox[]
            {
                this.txtKundenNr,
                this.txtKundenFirstName,
                this.txtKundenLastName,
                this.txtAddress,
                this.txtRechnungNr,
                this.txtZeichen,
                this.txtEmpaenger,
                this.txtStunden,
                this.txtBezahlt,
                this.txtStatus,
               
            })
            {
                FormsHelper.SetCommonTextBoxProperties(textBox);

                // Assign Leave event handler using lambda expression
                textBox.Leave += (sender, e) =>
                {
                    validateRechnung();
                };
            }

            foreach (DateTimePicker dtpicker in new DateTimePicker[]
           {
                
                this.txtDatumBezahlt,
                this.txtBeginDate,
                this.txtEndDate,
                this.txtFaelligAm

           })
            {

                // Assign Leave event handler using lambda expression
                dtpicker.Leave += (sender, e) =>
                {
                    validateRechnung();
                };
            }

            // Set common properties for date textboxes
            //foreach (TextBox dateTextBox in new TextBox[]
            //{
            //    this.txtBeginDate,
            //    this.txtEndDate,
            //    this.txt,
            //    this.txtFaelligAm
            //})
            //{
            //    FormsHelper.SetCommonDateTextBoxProperties(dateTextBox);
            //}

            // Set common properties for toolbar buttons
            FormsHelper.SetCommonToolbarButtonsProperties(this.btnHome);
            FormsHelper.SetCommonToolbarButtonsProperties(this.btnSaveRechnung);
            FormsHelper.SetCommonToolbarButtonsProperties(this.btnDownload);


            //SetIconStylesToButton(btnHome);
            SetIconStylesToButton(btnAddService);
            //SetIconStylesToButton(btnDeleteService);


            // Events

            this.FormClosing += FormRechnung_FormClosing;

            this.txtBezahlt.TextChanged += TxtBezahlt_TextChanged;

            this.txtKundenFirstName.Leave += update_empfänger; 
            this.txtKundenLastName.Leave += update_empfänger; 
            this.txtVersicherer.Leave += update_empfänger; 
            this.txtAddress.Leave += update_empfänger; 


            //this.txtAbsender.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular) ;
            //this.txtEmpfaenger.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            //this.txtIntro.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            //this.txtGruss.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            //this.txtContent.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);
            //this.txtEndGruss.Font = new Font(Font.SystemFontName, 9, FontStyle.Regular);


            FormsHelper.SetCommonTextBoxProperties(this.txtKundenNr);
            FormsHelper.SetCommonTextBoxProperties(this.txtKundenFirstName);
            FormsHelper.SetCommonTextBoxProperties(this.txtKundenLastName);
            FormsHelper.SetCommonTextBoxProperties(this.txtAddress);
            FormsHelper.SetCommonTextBoxProperties(this.txtRechnungNr);
            FormsHelper.SetCommonTextBoxProperties(this.txtZeichen);
            FormsHelper.SetCommonTextBoxProperties(this.txtEmpaenger);
            FormsHelper.SetCommonTextBoxProperties(this.txtStunden);
            FormsHelper.SetCommonTextBoxProperties(this.txtBeginDate);
            FormsHelper.SetCommonTextBoxProperties(this.txtEndDate);
            FormsHelper.SetCommonTextBoxProperties(this.txtBezahlt);
            FormsHelper.SetCommonTextBoxProperties(this.txtDatumBezahlt);
            FormsHelper.SetCommonTextBoxProperties(this.txtFaelligAm);
            FormsHelper.SetCommonTextBoxProperties(this.txtStatus);



            this.btnPrevious.Enabled = false;
            this.btnWeiter.Enabled = false;

            this.btnHome.DialogResult = DialogResult.Abort;
            this.btnSaveRechnung.DialogResult = DialogResult.OK;


            DisableTextBoxes();

            CurrentRechnungIndex = -1;

        }

        private void update_empfänger(object sender, EventArgs e)
        {
            updateEmpfaenger();
        }

        private void updateEmpfaenger()
        {
            var kunde = this.RechnungenListToEdit[CurrentRechnungIndex].ParentKunde;
            var versicherer = this.RechnungenListToEdit[CurrentRechnungIndex].ParentKunde?.Versicherer;

            string firstName = kunde?.FirstName ?? string.Empty;
            string lastName = kunde?.LastName ?? string.Empty;
            string address = kunde?.Address ?? (versicherer?.Address ?? string.Empty);

            if (this.RechnungenListToEdit[CurrentRechnungIndex].Type == KundenType.P)
            {
                if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(address))
                {
                    this.txtEmpaenger.Text = string.Empty;
                }
                else if (!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName))
                {
                    this.txtEmpaenger.Text = $"{lastName} {firstName}".Trim();
                }
                else if (!string.IsNullOrEmpty(address))
                {
                    this.txtEmpaenger.Text = address;
                }
            }
            else
            {
                if (versicherer != null)
                {
                    string versichererName = versicherer.Name ?? string.Empty;
                    address = versicherer.Address ?? string.Empty;

                    if (string.IsNullOrEmpty(versichererName) && string.IsNullOrEmpty(address))
                    {
                        this.txtEmpaenger.Text = string.Empty;
                    }
                    else if (!string.IsNullOrEmpty(versichererName) && !string.IsNullOrEmpty(address))
                    {
                        this.txtEmpaenger.Text = $"{versichererName}, \n{address}";
                    }
                    else if (!string.IsNullOrEmpty(versichererName))
                    {
                        this.txtEmpaenger.Text = versichererName;
                    }
                    else if (!string.IsNullOrEmpty(address))
                    {
                        this.txtEmpaenger.Text = address;
                    }
                }
                else
                {
                    this.txtEmpaenger.Text = string.Empty;
                }
            }
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

        bool changeType = false;
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton currentRadioButton = sender as RadioButton;
            KundenType selectedEnum = GetSelectedKundenType(currentRadioButton);


            RadioButton[] radioButtons =
            {
                this.radioButtonHHH,
                this.radioButtonPrivat,
                this.radioButtonEntlastung,
                this.radioButtonGebaude,
                this.radioButtonVerhinderung,
                this.radioButtonRenovierung
            };


            if (!changeType)
            {

                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton != currentRadioButton)
                    {
                        radioButton.Checked = false;
                    }
                }

                if (currentRadioButton != null && currentRadioButton.Checked)
                {
                    // Enable textboxes
                    EnableTextBoxes();

                    // Call helper.getNextKundenNumber() with the appropriate enum
                    //this.txtKundenNr.Text = helper.getNextKundenNumber(selectedEnum);

                    Rechnung cRechnung = helper.CreateNewRechnung(selectedEnum);

                    this.RechnungenListToEdit.Add(cRechnung);
                    CurrentRechnungIndex = RechnungenListToEdit.Count - 1;
                    ShowCurrentRechnung();
                }
            }
            else
            {

                switch (selectedEnum)
                {
                    case KundenType.P:
                        this.txtZeichen.Text = null;
                        this.txtVersicherer.DataSource = null;
                        this.txtVersicherer.Enabled = false;

                        break;
                    default:
                        this.txtVersicherer.Enabled = true;
                        InitializeVersichererComboBox();
                        break;
                }

            }
        }

        private void EnableTextBoxes()
        {
            this.txtZeichen.Enabled = true;
            this.txtBeginDate.Enabled = true;
            this.txtEndDate.Enabled = true;
            this.txtEmpaenger.Enabled = true;
            this.txtStunden.Enabled = true;
            this.txtBezahlt.Enabled = true;
            this.txtFaelligAm.Enabled = true;
            this.dataGridViewServices.Enabled = true;
            this.txtGruss.Enabled = true;
            this.txtIntro.Enabled = true;
            this.txtContent.Enabled = true;
            this.txtEndGruss.Enabled = true;
            txtKundenFirstName.Enabled = true;
            txtKundenLastName.Enabled = true;
            txtAddress.Enabled = true;
        }

        private void DisableTextBoxes()
        {
            this.txtZeichen.Enabled = false;
            this.txtBeginDate.Enabled = false;
            this.txtEndDate.Enabled = false;
            this.txtEmpaenger.Enabled = false;
            this.txtStunden.Enabled = false;
            this.txtBezahlt.Enabled = false;
            this.txtFaelligAm.Enabled = false;
            this.dataGridViewServices.Enabled = false;
            this.txtGruss.Enabled = false;
            this.txtIntro.Enabled = false;
            this.txtContent.Enabled = false;
            this.txtEndGruss.Enabled = false;
            txtKundenFirstName.Enabled = false;
            txtKundenLastName.Enabled = false;
            txtAddress.Enabled = false;
        }

        private KundenType GetSelectedKundenType(RadioButton radioButton)
        {
            if (radioButton == this.radioButtonHHH) return KundenType.H;
            if (radioButton == this.radioButtonPrivat) return KundenType.P;
            if (radioButton == this.radioButtonEntlastung) return KundenType.E;
            if (radioButton == this.radioButtonGebaude) return KundenType.G;
            if (radioButton == this.radioButtonVerhinderung) return KundenType.V;
            if (radioButton == this.radioButtonRenovierung) return KundenType.R;
            throw new InvalidOperationException("Unknown radio button");
        }

        private void UpdateButtonStates()
        {
            btnPrevious.Enabled = CurrentRechnungIndex > 0;
            btnWeiter.Enabled = CurrentRechnungIndex < RechnungenListToEdit.Count - 1;
        }

        //checked
        private void TxtBezahlt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string input = textBox.Text.Replace("€", "").Trim();
                if (!float.TryParse(input, out float bezahlt))
                {
                    errorMsg = "Please enter a valid floating-point number for Bezahlt.";
                    textBox.Text = "0.00";
                }
                else if(bezahlt > 0)
                {
                    textBox.Text = bezahlt.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
                    this.RechnungenListToEdit[CurrentRechnungIndex].Bezahlt = bezahlt;


                    this.RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt = DateTime.Now;
                    this.txtDatumBezahlt.Value = this.RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt;



                    DateTime faelligAm = this.RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt.AddDays(30);
                    this.RechnungenListToEdit[CurrentRechnungIndex].FaelligAm = faelligAm;
                    this.txtFaelligAm.Text = faelligAm.ToString();

                    //this.ShowCurrentRechnung();
                }
                else if (bezahlt == 0)
                {
                    this.RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt = DateTime.MinValue;
                }
            }
        }


        //private void AddNewRechnung()
        //{
        //    this.RechnungenListToEdit.Add(helper.CreateNewRechnung());
        //    CurrentRechnungIndex = RechnungenListToEdit.Count - 1;
        //    ShowCurrentRechnung();
        //    UpdateButtonStates();
        //}

        private void ShowCurrentRechnung()
        {
            this.txtRechnungNr.Text = RechnungenListToEdit[CurrentRechnungIndex].RechnungNr.ToString();


            this.txtZeichen.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Zeichen) ? RechnungenListToEdit[CurrentRechnungIndex].Zeichen.ToString() : "";


            this.txtKundenNr.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].KundenNr) ? RechnungenListToEdit[CurrentRechnungIndex].KundenNr.ToString() : "";


            this.lblDatum.Text = RechnungenListToEdit[CurrentRechnungIndex].Datum.ToString();


            // Set txtBeginDate text
            if (RechnungenListToEdit[CurrentRechnungIndex].BeginDate != null && RechnungenListToEdit[CurrentRechnungIndex].BeginDate >= 
                DateTimePicker.MinimumDateTime && RechnungenListToEdit[CurrentRechnungIndex].BeginDate <= DateTimePicker.MaximumDateTime)
            {
                this.txtBeginDate.Value = RechnungenListToEdit[CurrentRechnungIndex].BeginDate;
            }
            //this.txtBeginDate.Text = RechnungenListToEdit[CurrentRechnungIndex]?.BeginDate.ToString() ?? DateTime.Now.ToString();

            //// Set txtEndDate text
            //this.txtEndDate.Text = RechnungenListToEdit[CurrentRechnungIndex]?.EndDate.ToString() ?? DateTime.Now.ToString();

            if (RechnungenListToEdit[CurrentRechnungIndex].EndDate != null && RechnungenListToEdit[CurrentRechnungIndex].EndDate >= 
                DateTimePicker.MinimumDateTime && RechnungenListToEdit[CurrentRechnungIndex].EndDate <= DateTimePicker.MaximumDateTime)
            {
                this.txtEndDate.Value = RechnungenListToEdit[CurrentRechnungIndex].EndDate;
            }

            this.txtGruss.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Gruss) ? RechnungenListToEdit[CurrentRechnungIndex].Gruss.ToString() : "";


            this.txtIntro.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Intro) ? RechnungenListToEdit[CurrentRechnungIndex].Intro.ToString() : "";


            this.txtContent.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Content) ? RechnungenListToEdit[CurrentRechnungIndex].Content.ToString() : "";


            this.txtEndGruss.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].EndGruss) ? RechnungenListToEdit[CurrentRechnungIndex].EndGruss.ToString() : "";


            //this.txtEmpaenger.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Empfaenger) ? RechnungenListToEdit[CurrentRechnungIndex].Empfaenger.ToString() : "";

            this.txtKundenFirstName.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.FirstName) ? RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.FirstName : "";
            this.txtKundenLastName.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.LastName) ? RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.LastName : "";
            this.txtAddress.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Address) ? RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Address : "";


            this.txtBezahlt.Text = RechnungenListToEdit[CurrentRechnungIndex].Bezahlt.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
            //this.txtDatumBezahlt.Text = RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt.ToString("dd.MM.yyyy");
            //this.txtFaelligAm.Text = RechnungenListToEdit[CurrentRechnungIndex].FaelligAm.ToString("dd.MM.yyyy");

            this.txtDatumBezahlt.Text = RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt != DateTime.MinValue ? RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt.ToString("dd.MM.yyyy") : "";
            
            this.txtFaelligAm.Text = RechnungenListToEdit[CurrentRechnungIndex].FaelligAm != DateTime.MinValue ? RechnungenListToEdit[CurrentRechnungIndex].FaelligAm.ToString("dd.MM.yyyy") : "";

            this.txtStatus.Text = !string.IsNullOrEmpty(RechnungenListToEdit[CurrentRechnungIndex].Status.ToString()) ? RechnungenListToEdit[CurrentRechnungIndex].Status.ToString() : "";
            this.txtStunden.Text = RechnungenListToEdit[CurrentRechnungIndex].Stunden.ToString("0.00");

            if (this.RechnungenListToEdit[CurrentRechnungIndex].Type == KundenType.P)
            {
                this.txtVersicherer.Enabled = false;
            }

            foreach (Service service in RechnungenListToEdit[CurrentRechnungIndex].Services)
            {
                dataGridViewServices.Rows.Add(service.Pos + ".", service.Beschreibung, service.Menge, service.Einzelpreis, service.Gesamtpreis);
            }

            updateEmpfaenger();

            InitializeVersichererComboBox();
            InitializeDataGridView();
            Add3FixatedRows();
            UpdateButtonStates();
            this.changeType = true;
        }

        private void InitializeVersichererComboBox()
        {
            this.txtVersicherer.DataSource = helper.Versicherer;
            this.txtVersicherer.ValueMember = "ID";
            this.txtVersicherer.DisplayMember = "Name";

            this.txtVersicherer.SelectedItem = null;

        }

        private void InitializeDataGridView()
        {
            this.dataGridViewServices.Rows.Clear();
            this.dataGridViewServices.AutoGenerateColumns = false;
            dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewServices.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewServices.Columns[0].Width = (int)(dataGridViewServices.Width * 0.1);

            dataGridViewServices.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewServices.Columns[1].Width = (int)(dataGridViewServices.Width * 0.3);

            dataGridViewServices.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewServices.Columns[2].Width = (int)(dataGridViewServices.Width * 0.2);

            dataGridViewServices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewServices.Columns[3].Width = (int)(dataGridViewServices.Width * 0.2);


            dataGridViewServices.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewServices.Columns[4].Width = (int)(dataGridViewServices.Width * 0.2);



            dataGridViewServices.AllowUserToAddRows = false;
            dataGridViewServices.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dataGridViewServices.CellPainting += DataGridView_CellPainting;
            dataGridViewServices.CellValueChanged += DataGridView_CellValueChanged;
            dataGridViewServices.SelectionChanged += DataGridView_SelectionChanged;

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
            if (dataGridViewServices.RowCount == 0)
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
            rowSummeNetto.CreateCells(dataGridViewServices);

            rowSummeNetto.Cells[0].ReadOnly = true;
            rowSummeNetto.Cells[1].ReadOnly = true;
            rowSummeNetto.Cells[2].ReadOnly = true;

            rowSummeNetto.Cells[3].Value = "Summe Netto:";
            rowSummeNetto.Cells[4].Value = sumGesamtpreis.ToString("C");
            dataGridViewServices.Rows.Add(rowSummeNetto);

            // Add the row for § 38 UStG
            var rowUStG = new DataGridViewRow();
            rowUStG.CreateCells(dataGridViewServices);

            rowUStG.Cells[0].ReadOnly = true;
            rowUStG.Cells[1].ReadOnly = true;
            rowUStG.Cells[2].ReadOnly = true;

            switch (this.RechnungenListToEdit[CurrentRechnungIndex].Type)
            {
                case KundenType.H:
                    rowUStG.Cells[3].Value = "§ 38 UStG:";
                    break;
                case KundenType.R:
                    rowUStG.Cells[3].Value = "§ 38 UStG:";
                    break;
                case KundenType.G:
                    rowUStG.Cells[3].Value = "§ 38 UStG:";
                    break;
                case KundenType.P:
                    rowUStG.Cells[3].Value = "§ zzgl. UST. 19%";
                    break;
                case KundenType.E:
                    rowUStG.Cells[3].Value = "§ 45 UStG:";
                    break;
                case KundenType.V:
                    rowUStG.Cells[3].Value = "§ 39 UStG:";
                    break;
                default:
                    // Handle any other cases or provide a default value
                    break;
            }

            rowUStG.Cells[4].Value = "0 €";


            dataGridViewServices.Rows.Add(rowUStG);

            // Add the row for GesamtPreis
            var rowGesamtpreis = new DataGridViewRow();
            rowGesamtpreis.CreateCells(dataGridViewServices);

            rowGesamtpreis.Cells[0].ReadOnly = true;
            rowGesamtpreis.Cells[1].ReadOnly = true;
            rowGesamtpreis.Cells[2].ReadOnly = true;

            rowGesamtpreis.Cells[3].Value = "Gesamtpreis:";

            decimal ustAmount = 0;
            switch (this.RechnungenListToEdit[CurrentRechnungIndex].Type)
            {
                case KundenType.H:
                    ustAmount = 38 / 100m * sumGesamtpreis;
                    break;
                case KundenType.R:
                    ustAmount = 38 / 100m * sumGesamtpreis;
                    break;
                case KundenType.G:
                    ustAmount = 38 / 100m * sumGesamtpreis;
                    break;
                case KundenType.P:
                    ustAmount = 19 / 100m * sumGesamtpreis;
                    break;
                case KundenType.E:
                    ustAmount = 45 / 100m * sumGesamtpreis;
                    break;
                case KundenType.V:
                    ustAmount = 39 / 100m * sumGesamtpreis;
                    break;
                default:
                    // Handle any other cases or provide a default value
                    break;
            }

            //rowGesamtpreis.Cells[4].Value = (sumGesamtpreis + 10).ToString("C"); // Adding 10 for UStG
            rowGesamtpreis.Cells[4].Value = ustAmount; // Adding 10 for UStG



            dataGridViewServices.Rows.Add(rowGesamtpreis);

        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedCells.Count > 0)
            {
                // Get the index of the last three rows
                int rowCount = dataGridViewServices.Rows.Count;
                int lastThreeRowsStartIndex = Math.Max(rowCount - 3, 0);

                // Get the current selected cell
                DataGridViewCell currentCell = dataGridViewServices.SelectedCells[0];

                // Check if the selected cell is in the last three rows and not in the last column of the before last row
                if (currentCell.RowIndex >= lastThreeRowsStartIndex &&
                    !(currentCell.RowIndex == rowCount - 2 && currentCell.ColumnIndex == dataGridViewServices.Columns.Count - 1))
                {
                    // Clear the selection
                    dataGridViewServices.ClearSelection();

                }
            }
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridViewCellStyle gridcolStyle = new DataGridViewCellStyle();
            gridcolStyle.BackColor = SystemColors.Window;


            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[0].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[1].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[2].Style = gridcolStyle;

            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[0].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[1].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[2].Style = gridcolStyle;

            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[0].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[1].Style = gridcolStyle;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[2].Style = gridcolStyle;

            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[0].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[1].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[2].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[3].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 1].Cells[4].ReadOnly = true;

            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[0].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[1].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[2].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 2].Cells[3].ReadOnly = true;

            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[0].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[1].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[2].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[3].ReadOnly = true;
            dataGridViewServices.Rows[dataGridViewServices.RowCount - 3].Cells[4].ReadOnly = true;
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            float gesamt = 0;

            for (int i = 3; i < dataGridViewServices.Rows.Count; i++)
            {
                float cellValue = float.Parse(dataGridViewServices.Rows[i].Cells[4].Value.ToString());
                gesamt += cellValue;
            }


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

        private void txtContent_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtFaelligAm_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRechnung_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteRechnung_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveRechnung_Click(object sender, EventArgs e)
        {
            validateRechnung();
        }

        //internal void SetTextBoxBorderColor(TextBox txtTextBox, Color borderColor)
        //{
        //    // Check if a panel already exists for this TextBox
        //    if (textBoxPanels.ContainsKey(txtTextBox))
        //    {
        //        // Update the panel's border color
        //        textBoxPanels[txtTextBox].BackColor = borderColor;
        //    }
        //    else
        //    {
        //        // Create a new Panel
        //        Panel panel = new Panel();
        //        panel.Location = txtTextBox.Location;
        //        panel.Size = txtTextBox.Size;
        //        panel.BorderStyle = BorderStyle.FixedSingle; // or Fixed3D
        //        panel.BackColor = Color.Transparent;
        //        this.Controls.Add(panel);

        //        // Add the TextBox to the Panel
        //        panel.Controls.Add(txtTextBox);

        //        // Set the border color
        //        panel.BackColor = borderColor;

        //        // Store the TextBox and its corresponding panel in the dictionary
        //        textBoxPanels.Add(txtTextBox, panel);
        //    }
        //}

        // Dictionary to store TextBoxes and their corresponding panels
        //private Dictionary<TextBox, Panel> textBoxPanels = new Dictionary<TextBox, Panel>();

        //internal void SetTextBoxBorderColor(TextBox txtTextBox, Color borderColor)
        //{
        //    // Check if a panel already exists for this TextBox
        //    if (textBoxPanels.ContainsKey(txtTextBox))
        //    {
        //        // Update the panel's border color
        //        textBoxPanels[txtTextBox].BackColor = borderColor;
        //    }
        //    else
        //    {
        //        // Create a new Panel
        //        Panel panel = new Panel();
        //        panel.Location = txtTextBox.Location;
        //        panel.Size = txtTextBox.Size;
        //        panel.BorderStyle = BorderStyle.FixedSingle; // or Fixed3D
        //        panel.BackColor = Color.Transparent;

        //        // Add the TextBox to the Panel
        //        panel.Controls.Add(txtTextBox);

        //        // Adjust the TextBox position and size within the panel
        //        txtTextBox.Location = new Point(0, 0);
        //        txtTextBox.Size = panel.Size;

        //        // Set the border color
        //        panel.BackColor = borderColor;

        //        // Add the panel to the form's controls
        //        this.Controls.Add(panel);
        //        panel.BringToFront(); // Ensure the panel is in front

        //        // Store the TextBox and its corresponding panel in the dictionary
        //        textBoxPanels.Add(txtTextBox, panel);
        //    }
        //}

        string errorMsg;
        private void validateRechnung()
        {
            
            errorMsg = "";
            //Check Dates 
            //Begin End
            //if (!DateTime.TryParse(this.txtBeginDate.Text, out DateTime beginDate))
            //{
            //    errorMsg += "Begin Date. ";
            //    txtBeginDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            //}
            //else
            //{
            //    RechnungenListToEdit[CurrentRechnungIndex].BeginDate = beginDate;
            //}

            //// Validate end date
            //if (!DateTime.TryParse(this.txtEndDate.Text, out DateTime endDate))
            //{
            //    errorMsg += "End Date. ";
            //    txtEndDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            //}
            //else
            //{
            //    // Check if end date is after begin date
                if (txtEndDate.Value < txtBeginDate.Value)
                {
                    errorMsg += "End Date < Begin Date. ";
                }
                else
                {
                    RechnungenListToEdit[CurrentRechnungIndex].EndDate = txtEndDate.Value;
                    RechnungenListToEdit[CurrentRechnungIndex].BeginDate = txtBeginDate.Value;

                }
            //}

            ////fällgi am 
            //if (!DateTime.TryParse(this.txtFaelligAm.Text, out DateTime fälligAm) && !string.IsNullOrWhiteSpace(this.txtFaelligAm.Text))
            //{
            //    errorMsg += "fälligAm. ";
            //    txtFaelligAm.Text = null;

            //}
            //else
            //{
            //    RechnungenListToEdit[CurrentRechnungIndex].FaelligAm = fälligAm;
            //}


            ////datum Bezahlt
            //if (!DateTime.TryParse(this.txtDatumBezahlt.Text, out DateTime dtumBezahlt) && ValidateMoney(this.txtBezahlt) != 0 && ValidateMoney(this.txtBezahlt) != null)
            //{
            //    errorMsg += "Datum der Bezahlung. ";
            //    txtDatumBezahlt.Text = null;
            //}
            //else
            //{
            //    RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt = dtumBezahlt;
            //}

            //firstName

            if (string.IsNullOrWhiteSpace(this.txtKundenFirstName.Text))
            {
                errorMsg += "Vorname. ";
                txtKundenFirstName.Text = null;
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.FirstName = this.txtKundenFirstName.Text.Trim();
            }

            // Validate last name
            if (string.IsNullOrWhiteSpace(this.txtKundenLastName.Text))
            {
                errorMsg += "Nachname. ";
                txtKundenLastName.Text = null;
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.LastName = this.txtKundenLastName.Text.Trim();
            }


            // Validate address
            if (string.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                errorMsg += "Address. ";
                txtAddress.Text = null;
            }
            else
            {
                string address = this.txtAddress.Text.Trim();

                // Define a regular expression pattern for German address format
                string pattern = @"^[A-Za-zäöüÄÖÜß\s\-]+ \d+[a-zA-Z]?, \d{5} [A-Za-zäöüÄÖÜß\s\-]+$";

                // Check if the address matches the pattern
                if (Regex.IsMatch(address, pattern))
                {
                    // Address is valid, store it
                    RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Address = address;
                }
                else
                {
                    // Address is not valid
                    errorMsg += "German address. ";
                    txtAddress.Text = null;
                }
            }


            // Rechnung Nr
            string rechnungNrPattern = @"^\d{5} R$";

            if (!Regex.IsMatch(this.txtRechnungNr.Text, rechnungNrPattern))
            {
                errorMsg += "RechnungNr. ";
                txtRechnungNr.Text = null;
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].RechnungNr = this.txtRechnungNr.Text;
            }

            //stunden
            if (ValidateHours(this.txtStunden) == null)
            {
                errorMsg += "Stunden. ";
                txtStunden.Text = null;
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].Stunden = ValidateHours(txtStunden) ?? 0;
            }

            // Validate Bezahlt 
            if (ValidateMoney(txtBezahlt) == null )
            {
                errorMsg += "Bezahlt. ";
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].Bezahlt = ValidateMoney(txtBezahlt) ?? 0.0f;
            }

            //Zeichen
            if (String.IsNullOrEmpty(txtZeichen.Text))
            {
                errorMsg += "Zeichen.  ";
            }
            else
            {
                RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Zeichen = txtZeichen.Text.ToString();
            }

            this.txtError.Text = errorMsg;

            //if (!string.IsNullOrEmpty(errorMsg))
            //{
            //    MessageBox.Show(errorMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private float? ValidateMoney(TextBox textBox)
        {
            string input = textBox.Text.Replace("€", "").Trim();

            if (!float.TryParse(input, out float bezahlt) || bezahlt < 0)
            {
                this.txtError.Text += "Please enter a valid floating-point number for Bezahlt.";
                return null;
            }
            else
            {
                this.txtError.Text += bezahlt.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
                return bezahlt;
            }
        }

        private float? ValidateHours(TextBox textBox)
        {
            if (!float.TryParse(textBox.Text, out float stunden))
            {
                errorMsg = "Please enter a valid floating-point number for Stunden.";
                textBox.Text = "0.0";
                return null;
            }
            else
            {
                return stunden;
            }
        }

        private void txtVersicherer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentRechnungIndex >= 0)
            {
                if (this.RechnungenListToEdit[CurrentRechnungIndex].Type != KundenType.P)
                {
                    ComboBox comboBox = sender as ComboBox;

                    if (comboBox != null && comboBox.SelectedItem != null)
                    {
                        // Assuming txtVersicherer.SelectedItem contains the selected Versicherer object
                        Versicherer selectedVersicherer = comboBox.SelectedItem as Versicherer;

                        if (selectedVersicherer != null)
                        {
                            this.RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Versicherer = selectedVersicherer;


                        }
                    }
                    else
                    {
                        this.RechnungenListToEdit[CurrentRechnungIndex].ParentKunde.Versicherer = null;
                        updateEmpfaenger();
                    }

                }
            }
        }

        //private bool bezahlt(string text)
        //{

        //    //TextBox textBox = sender as TextBox;
        //    //if (textBox != null)
        //    //{
        //    //    string input = textBox.Text.Replace("€", "").Trim();
        //    //    if (!float.TryParse(input, out float bezahlt))
        //    //    {
        //    //        MessageBox.Show("Please enter a valid floating-point number for Bezahlt.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    //        textBox.Text = "0.00";
        //    //    }
        //    //    else
        //    //    {
        //    //        textBox.Text = bezahlt.ToString("C", CultureInfo.GetCultureInfo("de-DE"));
        //    //        this.RechnungenListToEdit[CurrentRechnungIndex].Bezahlt = bezahlt;
        //    //        this.RechnungenListToEdit[CurrentRechnungIndex].DatumBezahlt = DateTime.Now;
        //    //        this.ShowCurrentRechnung();
        //    //    }
        //    //}

        //}
    }
}




//type
//KundenNr
//KundenFirstName
//KundenLastName
//RechnungNr
//Zeichen
//Versicherer
//Datum
//Empfänger
//Stunden
//Bezahlt
//DatumBezahlt 
//FaelligAm
//Status
//beginDate 
//endDate 
//content
//gruss
//endGruss
//intro 
//Services 
//txtaddress