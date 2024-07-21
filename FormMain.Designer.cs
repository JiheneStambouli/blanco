using System.Windows.Forms;

namespace BlancoAssist
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain = new BlancoAssist.BaseBlancoTabControl();
            this.tabPageRechnungen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRechnung = new MaterialSkin.Controls.MaterialButton();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewRechnungen = new System.Windows.Forms.DataGridView();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKundenNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KundenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpfaenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZeitraum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GesamtRechnungPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bezahlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumBezahlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaelligAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditRechnungen = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteRechnungen = new MaterialSkin.Controls.MaterialButton();
            this.tabPageKunden = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddKunde = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewKunden = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditKunde = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteKunde = new MaterialSkin.Controls.MaterialButton();
            this.tabPageVersicherer = new System.Windows.Forms.TabPage();
            this.btnDeleteVersicherer = new MaterialSkin.Controls.MaterialButton();
            this.btnEditVersicherer = new MaterialSkin.Controls.MaterialButton();
            this.btnAddVersicherer = new MaterialSkin.Controls.MaterialButton();
            this.dataGridViewVersicherer = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.btnTestOldHome = new MaterialSkin.Controls.MaterialButton();
            this.tabControlMain.SuspendLayout();
            this.tabPageRechnungen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechnungen)).BeginInit();
            this.tabPageKunden.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).BeginInit();
            this.tabPageVersicherer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVersicherer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Menge";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Einzelpreis";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Gesamtpreis";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRechnungen);
            this.tabControlMain.Controls.Add(this.tabPageKunden);
            this.tabControlMain.Controls.Add(this.tabPageVersicherer);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabControlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControlMain.ImageList = this.imageListMain;
            this.tabControlMain.Location = new System.Drawing.Point(2, 64);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1201, 624);
            this.tabControlMain.TabIndex = 29;
            // 
            // tabPageRechnungen
            // 
            this.tabPageRechnungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageRechnungen.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRechnungen.ImageKey = "icons8-rechnung-26.png";
            this.tabPageRechnungen.Location = new System.Drawing.Point(4, 33);
            this.tabPageRechnungen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRechnungen.Name = "tabPageRechnungen";
            this.tabPageRechnungen.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRechnungen.Size = new System.Drawing.Size(1193, 587);
            this.tabPageRechnungen.TabIndex = 0;
            this.tabPageRechnungen.Text = "Rechnugen";
            this.tabPageRechnungen.Click += new System.EventHandler(this.btnEditRechnugen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddRechnung, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRechnungen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEditRechnungen, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteRechnungen, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 581);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // btnAddRechnung
            // 
            this.btnAddRechnung.AutoSize = false;
            this.btnAddRechnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRechnung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddRechnung.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddRechnung.Depth = 0;
            this.btnAddRechnung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRechnung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddRechnung.HighEmphasis = true;
            this.btnAddRechnung.Icon = global::BlancoAssist.Properties.Resources.icons8_add_rechnung_31;
            this.btnAddRechnung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRechnung.ImageKey = "(none)";
            this.btnAddRechnung.ImageList = this.imageListMain;
            this.btnAddRechnung.Location = new System.Drawing.Point(1033, 4);
            this.btnAddRechnung.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRechnung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRechnung.Name = "btnAddRechnung";
            this.btnAddRechnung.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRechnung.Padding = new System.Windows.Forms.Padding(4);
            this.btnAddRechnung.Size = new System.Drawing.Size(132, 32);
            this.btnAddRechnung.TabIndex = 26;
            this.btnAddRechnung.Text = "Anlegen";
            this.btnAddRechnung.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddRechnung.UseAccentColor = false;
            this.btnAddRechnung.UseVisualStyleBackColor = false;
            this.btnAddRechnung.Click += new System.EventHandler(this.btnAddRechnung_Click);
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "icons8-invoice-26.png");
            this.imageListMain.Images.SetKeyName(1, "icons8-users-26.png");
            this.imageListMain.Images.SetKeyName(2, "icon-edit-31.png");
            this.imageListMain.Images.SetKeyName(3, "icons8-kunden-26.png");
            this.imageListMain.Images.SetKeyName(4, "icons8-rechnung-26.png");
            this.imageListMain.Images.SetKeyName(5, "icons8-company-26.png");
            // 
            // dataGridViewRechnungen
            // 
            this.dataGridViewRechnungen.AllowUserToAddRows = false;
            this.dataGridViewRechnungen.AllowUserToDeleteRows = false;
            this.dataGridViewRechnungen.AllowUserToOrderColumns = true;
            this.dataGridViewRechnungen.AllowUserToResizeRows = false;
            this.dataGridViewRechnungen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRechnungen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewRechnungen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewRechnungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechnungen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDatum,
            this.RechnungNr,
            this.Status,
            this.colKundenNr,
            this.colZeichen,
            this.KundenName,
            this.colEmpfaenger,
            this.colZeitraum,
            this.GesamtRechnungPreis,
            this.Bezahlt,
            this.DatumBezahlt,
            this.FaelligAm});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewRechnungen, 3);
            this.dataGridViewRechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRechnungen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewRechnungen.Location = new System.Drawing.Point(20, 44);
            this.dataGridViewRechnungen.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewRechnungen.Name = "dataGridViewRechnungen";
            this.dataGridViewRechnungen.RowHeadersWidth = 51;
            this.dataGridViewRechnungen.Size = new System.Drawing.Size(1149, 453);
            this.dataGridViewRechnungen.TabIndex = 24;
            this.dataGridViewRechnungen.DataSourceChanged += new System.EventHandler(this.dataGridViewRechnungen_DataSourceChanged);
            // 
            // colDatum
            // 
            this.colDatum.DataPropertyName = "Datum";
            this.colDatum.HeaderText = "Datum";
            this.colDatum.MinimumWidth = 6;
            this.colDatum.Name = "colDatum";
            this.colDatum.Width = 125;
            // 
            // RechnungNr
            // 
            this.RechnungNr.DataPropertyName = "RechnungNr";
            this.RechnungNr.HeaderText = "RechnungNr";
            this.RechnungNr.MinimumWidth = 6;
            this.RechnungNr.Name = "RechnungNr";
            this.RechnungNr.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // colKundenNr
            // 
            this.colKundenNr.DataPropertyName = "KundenNr";
            this.colKundenNr.HeaderText = "KundenNr";
            this.colKundenNr.MinimumWidth = 6;
            this.colKundenNr.Name = "colKundenNr";
            this.colKundenNr.Width = 125;
            // 
            // colZeichen
            // 
            this.colZeichen.DataPropertyName = "Zeichen";
            this.colZeichen.HeaderText = "Zeichen";
            this.colZeichen.MinimumWidth = 6;
            this.colZeichen.Name = "colZeichen";
            this.colZeichen.Width = 125;
            // 
            // KundenName
            // 
            this.KundenName.DataPropertyName = "KundenName";
            this.KundenName.HeaderText = "kundenName";
            this.KundenName.MinimumWidth = 6;
            this.KundenName.Name = "KundenName";
            this.KundenName.Width = 125;
            // 
            // colEmpfaenger
            // 
            this.colEmpfaenger.DataPropertyName = "Empfaenger";
            this.colEmpfaenger.HeaderText = "Empfaenger";
            this.colEmpfaenger.MinimumWidth = 6;
            this.colEmpfaenger.Name = "colEmpfaenger";
            this.colEmpfaenger.Width = 125;
            // 
            // colZeitraum
            // 
            this.colZeitraum.DataPropertyName = "Zeitraum";
            this.colZeitraum.HeaderText = "Zeitraum";
            this.colZeitraum.MinimumWidth = 6;
            this.colZeitraum.Name = "colZeitraum";
            this.colZeitraum.Width = 125;
            // 
            // GesamtRechnungPreis
            // 
            this.GesamtRechnungPreis.DataPropertyName = "GesamtRechnungPreis";
            this.GesamtRechnungPreis.HeaderText = "GesamtRechnungPreis";
            this.GesamtRechnungPreis.MinimumWidth = 6;
            this.GesamtRechnungPreis.Name = "GesamtRechnungPreis";
            this.GesamtRechnungPreis.Width = 125;
            // 
            // Bezahlt
            // 
            this.Bezahlt.DataPropertyName = "Bezahlt";
            this.Bezahlt.HeaderText = "Bezahlt";
            this.Bezahlt.MinimumWidth = 6;
            this.Bezahlt.Name = "Bezahlt";
            this.Bezahlt.Width = 125;
            // 
            // DatumBezahlt
            // 
            this.DatumBezahlt.DataPropertyName = "DatumBezahlt";
            this.DatumBezahlt.HeaderText = "DatumBezahlt";
            this.DatumBezahlt.MinimumWidth = 6;
            this.DatumBezahlt.Name = "DatumBezahlt";
            this.DatumBezahlt.Width = 125;
            // 
            // FaelligAm
            // 
            this.FaelligAm.DataPropertyName = "FaelligAm";
            this.FaelligAm.HeaderText = "FaelligAm";
            this.FaelligAm.MinimumWidth = 6;
            this.FaelligAm.Name = "FaelligAm";
            this.FaelligAm.Width = 125;
            // 
            // btnEditRechnungen
            // 
            this.btnEditRechnungen.AutoSize = false;
            this.btnEditRechnungen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditRechnungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditRechnungen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditRechnungen.Depth = 0;
            this.btnEditRechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditRechnungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditRechnungen.HighEmphasis = true;
            this.btnEditRechnungen.Icon = global::BlancoAssist.Properties.Resources.icon_edit_313;
            this.btnEditRechnungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRechnungen.ImageKey = "(none)";
            this.btnEditRechnungen.ImageList = this.imageListMain;
            this.btnEditRechnungen.Location = new System.Drawing.Point(1033, 525);
            this.btnEditRechnungen.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRechnungen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditRechnungen.Name = "btnEditRechnungen";
            this.btnEditRechnungen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditRechnungen.Padding = new System.Windows.Forms.Padding(4);
            this.btnEditRechnungen.Size = new System.Drawing.Size(132, 32);
            this.btnEditRechnungen.TabIndex = 25;
            this.btnEditRechnungen.Text = "Bearbeiten";
            this.btnEditRechnungen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditRechnungen.UseAccentColor = false;
            this.btnEditRechnungen.UseVisualStyleBackColor = false;
            this.btnEditRechnungen.Click += new System.EventHandler(this.btnEditRechnugen_Click);
            // 
            // btnDeleteRechnungen
            // 
            this.btnDeleteRechnungen.AutoSize = false;
            this.btnDeleteRechnungen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRechnungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteRechnungen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteRechnungen.Depth = 0;
            this.btnDeleteRechnungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRechnungen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRechnungen.HighEmphasis = true;
            this.btnDeleteRechnungen.Icon = global::BlancoAssist.Properties.Resources.icons8_remove_31;
            this.btnDeleteRechnungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRechnungen.ImageKey = "(none)";
            this.btnDeleteRechnungen.ImageList = this.imageListMain;
            this.btnDeleteRechnungen.Location = new System.Drawing.Point(893, 525);
            this.btnDeleteRechnungen.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRechnungen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteRechnungen.Name = "btnDeleteRechnungen";
            this.btnDeleteRechnungen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteRechnungen.Padding = new System.Windows.Forms.Padding(4);
            this.btnDeleteRechnungen.Size = new System.Drawing.Size(132, 32);
            this.btnDeleteRechnungen.TabIndex = 27;
            this.btnDeleteRechnungen.Text = "Entfernen";
            this.btnDeleteRechnungen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteRechnungen.UseAccentColor = false;
            this.btnDeleteRechnungen.UseVisualStyleBackColor = false;
            this.btnDeleteRechnungen.Click += new System.EventHandler(this.btnRemoveRechnungen_Click);
            // 
            // tabPageKunden
            // 
            this.tabPageKunden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageKunden.Controls.Add(this.tableLayoutPanel2);
            this.tabPageKunden.ImageKey = "icons8-kunden-26.png";
            this.tabPageKunden.Location = new System.Drawing.Point(4, 33);
            this.tabPageKunden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageKunden.Name = "tabPageKunden";
            this.tabPageKunden.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageKunden.Size = new System.Drawing.Size(1193, 587);
            this.tabPageKunden.TabIndex = 1;
            this.tabPageKunden.Text = "Kunden";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddKunde, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewKunden, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEditKunde, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteKunde, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1189, 581);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // btnAddKunde
            // 

            this.btnAddKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKunde.AutoSize = false;
            this.btnAddKunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddKunde.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddKunde.Depth = 0;
            this.btnAddKunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddKunde.HighEmphasis = true;
            this.btnAddKunde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddKunde.ImageKey = "(none)";
            this.btnAddKunde.ImageList = this.imageListMain;
            this.btnAddKunde.Location = new System.Drawing.Point(1038, 4);
            this.btnAddKunde.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddKunde.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddKunde.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddKunde.Padding = new System.Windows.Forms.Padding(4);
            this.btnAddKunde.Size = new System.Drawing.Size(131, 32);
            this.btnAddKunde.TabIndex = 28;
            this.btnAddKunde.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddKunde.UseAccentColor = false;
            this.btnAddKunde.UseVisualStyleBackColor = false;
            this.btnAddKunde.Icon = global::BlancoAssist.Properties.Resources.icons8_add_kunde_31;
            this.btnAddKunde.Name = "btnAddKunde";
            this.btnAddKunde.Text = "Anlegen";
            this.btnAddKunde.Click += new System.EventHandler(this.btnAddKunden_Click);
            // 
            // dataGridViewKunden
            // 
            this.dataGridViewKunden.AllowUserToAddRows = false;
            this.dataGridViewKunden.AllowUserToDeleteRows = false;
            this.dataGridViewKunden.AllowUserToOrderColumns = true;
            this.dataGridViewKunden.AllowUserToResizeRows = false;
            this.dataGridViewKunden.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewKunden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewKunden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewKunden, 3);
            this.dataGridViewKunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKunden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewKunden.Location = new System.Drawing.Point(20, 44);
            this.dataGridViewKunden.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewKunden.Name = "dataGridViewKunden";
            this.dataGridViewKunden.RowHeadersWidth = 51;
            this.dataGridViewKunden.Size = new System.Drawing.Size(1149, 453);
            this.dataGridViewKunden.TabIndex = 24;
            this.dataGridViewKunden.DataSourceChanged += new System.EventHandler(this.dataGridViewKunden_DataSourceChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KundenNummer";
            this.dataGridViewTextBoxColumn6.HeaderText = "KundenNummer";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Anschrift";
            this.dataGridViewTextBoxColumn9.HeaderText = "Anschrift";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CreationDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "CreationDate";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // btnEditKunde
            // 
            this.btnEditKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditKunde.AutoSize = false;
            this.btnEditKunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditKunde.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditKunde.Depth = 0;
            this.btnEditKunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditKunde.HighEmphasis = true;
            this.btnEditKunde.Icon = global::BlancoAssist.Properties.Resources.icon_edit_313;
            this.btnEditKunde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditKunde.ImageKey = "(none)";
            this.btnEditKunde.ImageList = this.imageListMain;
            this.btnEditKunde.Location = new System.Drawing.Point(1035, 525);
            this.btnEditKunde.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditKunde.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditKunde.Name = "btnEditKunde";
            this.btnEditKunde.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditKunde.Padding = new System.Windows.Forms.Padding(4);
            this.btnEditKunde.Size = new System.Drawing.Size(130, 32);
            this.btnEditKunde.TabIndex = 28;
            this.btnEditKunde.Text = "Bearbeiten";
            this.btnEditKunde.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditKunde.UseAccentColor = false;
            this.btnEditKunde.UseVisualStyleBackColor = false;
            this.btnEditKunde.Click += new System.EventHandler(this.btnEditKunden_Click);
            // 
            // btnDeleteKunde
            // 
            this.btnDeleteKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteKunde.AutoSize = false;
            this.btnDeleteKunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteKunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteKunde.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteKunde.Depth = 0;
            this.btnDeleteKunde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteKunde.HighEmphasis = true;
            this.btnDeleteKunde.Icon = global::BlancoAssist.Properties.Resources.icons8_remove_31;
            this.btnDeleteKunde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteKunde.ImageKey = "(none)";
            this.btnDeleteKunde.ImageList = this.imageListMain;
            this.btnDeleteKunde.Location = new System.Drawing.Point(895, 525);
            this.btnDeleteKunde.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteKunde.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteKunde.Name = "btnDeleteKunde";
            this.btnDeleteKunde.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteKunde.Padding = new System.Windows.Forms.Padding(4);
            this.btnDeleteKunde.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteKunde.TabIndex = 29;
            this.btnDeleteKunde.Text = "Entfernen";
            this.btnDeleteKunde.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteKunde.UseAccentColor = false;
            this.btnDeleteKunde.UseVisualStyleBackColor = false;
            this.btnDeleteKunde.Click += new System.EventHandler(this.btnRemoveKunden_Click);
            // 
            // tabPageVersicherer
            // 
            this.tabPageVersicherer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageVersicherer.Controls.Add(this.tableLayoutPanel3);
            this.tabPageVersicherer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageVersicherer.ImageKey = "icons8-company-26.png";
            this.tabPageVersicherer.Location = new System.Drawing.Point(4, 33);
            this.tabPageVersicherer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageVersicherer.Name = "tabPageVersicherer";
            this.tabPageVersicherer.Size = new System.Drawing.Size(1193, 587);
            this.tabPageVersicherer.TabIndex = 2;
            this.tabPageVersicherer.Text = "Versicherer";
            // 
            // btnDeleteVersicherer
            // 
            this.btnDeleteVersicherer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVersicherer.AutoSize = false;
            this.btnDeleteVersicherer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteVersicherer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteVersicherer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteVersicherer.Depth = 0;
            this.btnDeleteVersicherer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteVersicherer.HighEmphasis = true;
            this.btnDeleteVersicherer.Icon = global::BlancoAssist.Properties.Resources.icons8_remove_31;
            this.btnDeleteVersicherer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteVersicherer.ImageKey = "(none)";
            this.btnDeleteVersicherer.ImageList = this.imageListMain;
            this.btnDeleteVersicherer.Location = new System.Drawing.Point(899, 531);
            this.btnDeleteVersicherer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteVersicherer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteVersicherer.Name = "btnDeleteVersicherer";
            this.btnDeleteVersicherer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteVersicherer.Padding = new System.Windows.Forms.Padding(4);
            this.btnDeleteVersicherer.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteVersicherer.TabIndex = 31;
            this.btnDeleteVersicherer.Text = "Entfernen";
            this.btnDeleteVersicherer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteVersicherer.UseAccentColor = false;
            this.btnDeleteVersicherer.UseVisualStyleBackColor = false;
            this.btnDeleteVersicherer.Click += new System.EventHandler(this.btnRemoveVersicherer_Click);
            // 
            // btnEditVersicherer
            // 
            this.btnEditVersicherer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVersicherer.AutoSize = false;
            this.btnEditVersicherer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditVersicherer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditVersicherer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditVersicherer.Depth = 0;
            this.btnEditVersicherer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditVersicherer.HighEmphasis = true;
            this.btnEditVersicherer.Icon = global::BlancoAssist.Properties.Resources.icon_edit_313;
            this.btnEditVersicherer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditVersicherer.ImageKey = "(none)";
            this.btnEditVersicherer.ImageList = this.imageListMain;
            this.btnEditVersicherer.Location = new System.Drawing.Point(1039, 531);
            this.btnEditVersicherer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditVersicherer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditVersicherer.Name = "btnEditVersicherer";
            this.btnEditVersicherer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditVersicherer.Padding = new System.Windows.Forms.Padding(4);
            this.btnEditVersicherer.Size = new System.Drawing.Size(130, 32);
            this.btnEditVersicherer.TabIndex = 30;
            this.btnEditVersicherer.Text = "Bearbeiten";
            this.btnEditVersicherer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditVersicherer.UseAccentColor = false;
            this.btnEditVersicherer.UseVisualStyleBackColor = false;
            this.btnEditVersicherer.Click += new System.EventHandler(this.btnEditVersicherer_Click);
            // 
            // btnAddVersicherer
            // 
            this.btnAddVersicherer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVersicherer.AutoSize = false;
            this.btnAddVersicherer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddVersicherer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddVersicherer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddVersicherer.Depth = 0;
            this.btnAddVersicherer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddVersicherer.HighEmphasis = true;
            this.btnAddVersicherer.Icon = global::BlancoAssist.Properties.Resources.icons8_add_versicherer_31;
            this.btnAddVersicherer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVersicherer.ImageKey = "(none)";
            this.btnAddVersicherer.ImageList = this.imageListMain;
            this.btnAddVersicherer.Location = new System.Drawing.Point(1038, 4);
            this.btnAddVersicherer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVersicherer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddVersicherer.Name = "btnAddVersicherer";
            this.btnAddVersicherer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddVersicherer.Padding = new System.Windows.Forms.Padding(4);
            this.btnAddVersicherer.Size = new System.Drawing.Size(131, 32);
            this.btnAddVersicherer.TabIndex = 28;
            this.btnAddVersicherer.Text = "Anlegen";
            this.btnAddVersicherer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddVersicherer.UseAccentColor = false;
            this.btnAddVersicherer.UseVisualStyleBackColor = false;
            this.btnAddVersicherer.Click += new System.EventHandler(this.btnAddVersicherer_Click);
            // 
            // dataGridViewVersicherer
            // 
            this.dataGridViewVersicherer.AllowUserToAddRows = false;
            this.dataGridViewVersicherer.AllowUserToDeleteRows = false;
            this.dataGridViewVersicherer.AllowUserToOrderColumns = true;
            this.dataGridViewVersicherer.AllowUserToResizeRows = false;
            this.dataGridViewVersicherer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewVersicherer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewVersicherer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewVersicherer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVersicherer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tableLayoutPanel3.SetColumnSpan(this.dataGridViewVersicherer, 3);
            this.dataGridViewVersicherer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVersicherer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewVersicherer.Location = new System.Drawing.Point(20, 44);
            this.dataGridViewVersicherer.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dataGridViewVersicherer.Name = "dataGridViewVersicherer";
            this.dataGridViewVersicherer.RowHeadersWidth = 51;
            this.dataGridViewVersicherer.Size = new System.Drawing.Size(1153, 459);
            this.dataGridViewVersicherer.TabIndex = 24;
            this.dataGridViewVersicherer.DataSourceChanged += new System.EventHandler(this.dataGridViewVersicherer_DataSourceChanged);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Anschrift ";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddVersicherer, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewVersicherer, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEditVersicherer, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnDeleteVersicherer, 2, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1193, 587);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::BlancoAssist.Properties.Resources.icon_edit_313;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton2.ImageKey = "(none)";
            this.materialButton2.ImageList = this.imageListMain;
            this.materialButton2.Location = new System.Drawing.Point(1033, 525);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Padding = new System.Windows.Forms.Padding(4);
            this.materialButton2.Size = new System.Drawing.Size(132, 32);
            this.materialButton2.TabIndex = 25;
            this.materialButton2.Text = "Bearbeiten";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::BlancoAssist.Properties.Resources.icons8_remove_31;
            this.materialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton3.ImageKey = "(none)";
            this.materialButton3.ImageList = this.imageListMain;
            this.materialButton3.Location = new System.Drawing.Point(893, 525);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Padding = new System.Windows.Forms.Padding(4);
            this.materialButton3.Size = new System.Drawing.Size(132, 32);
            this.materialButton3.TabIndex = 27;
            this.materialButton3.Text = "Entfernen";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = false;
            // 
            // btnTestOldHome
            // 
            this.btnTestOldHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestOldHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTestOldHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTestOldHome.Depth = 0;
            this.btnTestOldHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTestOldHome.HighEmphasis = true;
            this.btnTestOldHome.Icon = null;
            this.btnTestOldHome.Location = new System.Drawing.Point(494, 22);
            this.btnTestOldHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestOldHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestOldHome.Name = "btnTestOldHome";
            this.btnTestOldHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTestOldHome.Size = new System.Drawing.Size(64, 36);
            this.btnTestOldHome.TabIndex = 30;
            this.btnTestOldHome.Text = "home";
            this.btnTestOldHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTestOldHome.UseAccentColor = false;
            this.btnTestOldHome.UseVisualStyleBackColor = false;
            this.btnTestOldHome.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 691);
            this.Controls.Add(this.btnTestOldHome);
            this.Controls.Add(this.tabControlMain);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControlMain;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 64, 2, 3);
            this.Text = "BlancoAssist";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRechnungen.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechnungen)).EndInit();
            this.tabPageKunden.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).EndInit();
            this.tabPageVersicherer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVersicherer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BaseBlancoTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageKunden;
        private MaterialSkin.Controls.MaterialButton btnTestOldHome;
        private System.Windows.Forms.ImageList imageListMain;
        private System.Windows.Forms.TabPage tabPageVersicherer;
        private System.Windows.Forms.TabPage tabPageRechnungen;
        private MaterialSkin.Controls.MaterialButton btnDeleteRechnungen;
        private MaterialSkin.Controls.MaterialButton btnAddRechnung;
        private MaterialSkin.Controls.MaterialButton btnEditRechnungen;
        private DataGridView dataGridViewRechnungen;
        private DataGridView dataGridViewKunden;
        private DataGridView dataGridViewVersicherer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private MaterialSkin.Controls.MaterialButton btnAddKunde;
        private MaterialSkin.Controls.MaterialButton btnDeleteKunde;
        private MaterialSkin.Controls.MaterialButton btnEditKunde;
        private MaterialSkin.Controls.MaterialButton btnAddVersicherer;
        private MaterialSkin.Controls.MaterialButton btnDeleteVersicherer;
        private MaterialSkin.Controls.MaterialButton btnEditVersicherer;
        private DataGridViewTextBoxColumn colDatum;
        private DataGridViewTextBoxColumn RechnungNr;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn colKundenNr;
        private DataGridViewTextBoxColumn colZeichen;
        private DataGridViewTextBoxColumn KundenName;
        private DataGridViewTextBoxColumn colEmpfaenger;
        private DataGridViewTextBoxColumn colZeitraum;
        private DataGridViewTextBoxColumn GesamtRechnungPreis;
        private DataGridViewTextBoxColumn Bezahlt;
        private DataGridViewTextBoxColumn DatumBezahlt;
        private DataGridViewTextBoxColumn FaelligAm;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private TableLayoutPanel tableLayoutPanel3;
    }
}

