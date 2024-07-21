namespace BlancoAssist
{
    partial class FormRechnung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechnung));
            this.tabControlEditMode = new BlancoAssist.BaseBlancoTabControl();
            this.tabPageRechnung = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtGruss = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.radioButtonHHH = new System.Windows.Forms.RadioButton();
            this.radioButtonVerhinderung = new System.Windows.Forms.RadioButton();
            this.radioButtonPrivat = new System.Windows.Forms.RadioButton();
            this.radioButtonEntlastung = new System.Windows.Forms.RadioButton();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.lblKundenNr = new MaterialSkin.Controls.MaterialLabel();
            this.lblKundenName = new MaterialSkin.Controls.MaterialLabel();
            this.lblRechnungNr = new MaterialSkin.Controls.MaterialLabel();
            this.lblZeichen = new MaterialSkin.Controls.MaterialLabel();
            this.lblZeitraum = new MaterialSkin.Controls.MaterialLabel();
            this.txtIntro = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContent = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtEndGruss = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.radioButtonGebaude = new System.Windows.Forms.RadioButton();
            this.radioButtonRenovierung = new System.Windows.Forms.RadioButton();
            this.txtKundenNr = new System.Windows.Forms.TextBox();
            this.txtKundenLastName = new System.Windows.Forms.TextBox();
            this.txtRechnungNr = new System.Windows.Forms.TextBox();
            this.txtZeichen = new System.Windows.Forms.TextBox();
            this.lblStunden = new MaterialSkin.Controls.MaterialLabel();
            this.lblBezahlt = new MaterialSkin.Controls.MaterialLabel();
            this.lblDatumBezahlt = new MaterialSkin.Controls.MaterialLabel();
            this.lblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblFaelligAm = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpfaenger = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmpaenger = new System.Windows.Forms.TextBox();
            this.txtStunden = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnWeiter = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevious = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteRechnung = new MaterialSkin.Controls.MaterialButton();
            this.btnAddRechnung = new MaterialSkin.Controls.MaterialButton();
            this.txtKundenFirstName = new System.Windows.Forms.TextBox();
            this.txtVersicherer = new System.Windows.Forms.ComboBox();
            this.lblVerischerer = new MaterialSkin.Controls.MaterialLabel();
            this.lblDatum = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.Label();
            this.txtDatumBezahlt = new System.Windows.Forms.DateTimePicker();
            this.txtBezahlt = new System.Windows.Forms.TextBox();
            this.txtFaelligAm = new System.Windows.Forms.DateTimePicker();
            this.txtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.imageListEditMode = new System.Windows.Forms.ImageList(this.components);
            this.btnDownload = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveRechnung = new MaterialSkin.Controls.MaterialButton();
            this.btnHome = new MaterialSkin.Controls.MaterialButton();
            this.btnAddService = new System.Windows.Forms.Button();
            this.tabControlEditMode.SuspendLayout();
            this.tabPageRechnung.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEditMode
            // 
            this.tabControlEditMode.Controls.Add(this.tabPageRechnung);
            this.tabControlEditMode.Depth = 0;
            this.tabControlEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditMode.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabControlEditMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControlEditMode.ImageList = this.imageListEditMode;
            this.tabControlEditMode.Location = new System.Drawing.Point(3, 64);
            this.tabControlEditMode.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlEditMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlEditMode.Multiline = true;
            this.tabControlEditMode.Name = "tabControlEditMode";
            this.tabControlEditMode.SelectedIndex = 0;
            this.tabControlEditMode.Size = new System.Drawing.Size(1199, 833);
            this.tabControlEditMode.TabIndex = 84;
            // 
            // tabPageRechnung
            // 
            this.tabPageRechnung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPageRechnung.Controls.Add(this.tableLayoutPanel);
            this.tabPageRechnung.ImageKey = "icons8-rechnung-26.png";
            this.tabPageRechnung.Location = new System.Drawing.Point(4, 33);
            this.tabPageRechnung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRechnung.Name = "tabPageRechnung";
            this.tabPageRechnung.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageRechnung.Size = new System.Drawing.Size(1191, 796);
            this.tabPageRechnung.TabIndex = 0;
            this.tabPageRechnung.Text = "Rechnug0";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.ColumnCount = 20;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.txtGruss, 1, 11);
            this.tableLayoutPanel.Controls.Add(this.radioButtonHHH, 7, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonVerhinderung, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonPrivat, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonEntlastung, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.lblType, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblKundenNr, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.lblKundenName, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.lblRechnungNr, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.lblZeichen, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.lblZeitraum, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.txtIntro, 1, 12);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewServices, 1, 14);
            this.tableLayoutPanel.Controls.Add(this.txtContent, 1, 15);
            this.tableLayoutPanel.Controls.Add(this.txtEndGruss, 1, 16);
            this.tableLayoutPanel.Controls.Add(this.radioButtonGebaude, 5, 2);
            this.tableLayoutPanel.Controls.Add(this.radioButtonRenovierung, 6, 2);
            this.tableLayoutPanel.Controls.Add(this.txtKundenNr, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.txtKundenLastName, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.txtRechnungNr, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.txtZeichen, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.lblStunden, 9, 4);
            this.tableLayoutPanel.Controls.Add(this.lblBezahlt, 9, 5);
            this.tableLayoutPanel.Controls.Add(this.lblDatumBezahlt, 9, 6);
            this.tableLayoutPanel.Controls.Add(this.lblStatus, 9, 8);
            this.tableLayoutPanel.Controls.Add(this.lblFaelligAm, 9, 7);
            this.tableLayoutPanel.Controls.Add(this.lblEmpfaenger, 9, 2);
            this.tableLayoutPanel.Controls.Add(this.txtEmpaenger, 10, 2);
            this.tableLayoutPanel.Controls.Add(this.txtStunden, 10, 4);
            this.tableLayoutPanel.Controls.Add(this.txtStatus, 10, 8);
            this.tableLayoutPanel.Controls.Add(this.btnWeiter, 18, 18);
            this.tableLayoutPanel.Controls.Add(this.btnPrevious, 17, 18);
            this.tableLayoutPanel.Controls.Add(this.btnDeleteRechnung, 17, 0);
            this.tableLayoutPanel.Controls.Add(this.btnAddRechnung, 18, 0);
            this.tableLayoutPanel.Controls.Add(this.txtKundenFirstName, 5, 4);
            this.tableLayoutPanel.Controls.Add(this.txtVersicherer, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.lblVerischerer, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.lblDatum, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.lblAddress, 9, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAddress, 10, 3);
            this.tableLayoutPanel.Controls.Add(this.txtError, 0, 19);
            this.tableLayoutPanel.Controls.Add(this.txtDatumBezahlt, 10, 6);
            this.tableLayoutPanel.Controls.Add(this.txtBezahlt, 10, 5);
            this.tableLayoutPanel.Controls.Add(this.txtFaelligAm, 10, 7);
            this.tableLayoutPanel.Controls.Add(this.txtBeginDate, 2, 7);
            this.tableLayoutPanel.Controls.Add(this.txtEndDate, 5, 7);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 20;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1187, 790);
            this.tableLayoutPanel.TabIndex = 95;
            // 
            // txtGruss
            // 
            this.txtGruss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtGruss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtGruss, 18);
            this.txtGruss.Depth = 0;
            this.txtGruss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGruss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtGruss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtGruss.Location = new System.Drawing.Point(23, 332);
            this.txtGruss.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGruss.Name = "txtGruss";
            this.txtGruss.Size = new System.Drawing.Size(1141, 28);
            this.txtGruss.TabIndex = 22;
            this.txtGruss.Text = "";
            // 
            // radioButtonHHH
            // 
            this.radioButtonHHH.AutoSize = true;
            this.radioButtonHHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonHHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonHHH.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonHHH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonHHH.Location = new System.Drawing.Point(423, 63);
            this.radioButtonHHH.Name = "radioButtonHHH";
            this.radioButtonHHH.Size = new System.Drawing.Size(44, 54);
            this.radioButtonHHH.TabIndex = 6;
            this.radioButtonHHH.TabStop = true;
            this.radioButtonHHH.Text = "H";
            this.radioButtonHHH.UseVisualStyleBackColor = false;
            // 
            // radioButtonVerhinderung
            // 
            this.radioButtonVerhinderung.AutoSize = true;
            this.radioButtonVerhinderung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonVerhinderung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonVerhinderung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonVerhinderung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonVerhinderung.Location = new System.Drawing.Point(273, 63);
            this.radioButtonVerhinderung.Name = "radioButtonVerhinderung";
            this.radioButtonVerhinderung.Size = new System.Drawing.Size(44, 54);
            this.radioButtonVerhinderung.TabIndex = 3;
            this.radioButtonVerhinderung.TabStop = true;
            this.radioButtonVerhinderung.Text = "V";
            this.radioButtonVerhinderung.UseVisualStyleBackColor = false;
            // 
            // radioButtonPrivat
            // 
            this.radioButtonPrivat.AutoSize = true;
            this.radioButtonPrivat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonPrivat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPrivat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonPrivat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonPrivat.Location = new System.Drawing.Point(223, 63);
            this.radioButtonPrivat.Name = "radioButtonPrivat";
            this.radioButtonPrivat.Size = new System.Drawing.Size(44, 54);
            this.radioButtonPrivat.TabIndex = 2;
            this.radioButtonPrivat.TabStop = true;
            this.radioButtonPrivat.Text = "P";
            this.radioButtonPrivat.UseVisualStyleBackColor = false;
            // 
            // radioButtonEntlastung
            // 
            this.radioButtonEntlastung.AutoSize = true;
            this.radioButtonEntlastung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonEntlastung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonEntlastung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonEntlastung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonEntlastung.Location = new System.Drawing.Point(173, 63);
            this.radioButtonEntlastung.Name = "radioButtonEntlastung";
            this.radioButtonEntlastung.Size = new System.Drawing.Size(44, 54);
            this.radioButtonEntlastung.TabIndex = 1;
            this.radioButtonEntlastung.TabStop = true;
            this.radioButtonEntlastung.Text = "E";
            this.radioButtonEntlastung.UseVisualStyleBackColor = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblType.Depth = 0;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(23, 60);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(144, 60);
            this.lblType.TabIndex = 88;
            this.lblType.Text = "Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKundenNr
            // 
            this.lblKundenNr.AutoSize = true;
            this.lblKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblKundenNr.Depth = 0;
            this.lblKundenNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKundenNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKundenNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKundenNr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKundenNr.Location = new System.Drawing.Point(23, 120);
            this.lblKundenNr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKundenNr.Name = "lblKundenNr";
            this.lblKundenNr.Size = new System.Drawing.Size(144, 27);
            this.lblKundenNr.TabIndex = 89;
            this.lblKundenNr.Text = "KundenNr:";
            this.lblKundenNr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKundenName
            // 
            this.lblKundenName.AutoSize = true;
            this.lblKundenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblKundenName.Depth = 0;
            this.lblKundenName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKundenName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblKundenName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKundenName.Location = new System.Drawing.Point(23, 147);
            this.lblKundenName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKundenName.Name = "lblKundenName";
            this.lblKundenName.Size = new System.Drawing.Size(144, 27);
            this.lblKundenName.TabIndex = 94;
            this.lblKundenName.Text = "KundenName:";
            this.lblKundenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRechnungNr
            // 
            this.lblRechnungNr.AutoSize = true;
            this.lblRechnungNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblRechnungNr.Depth = 0;
            this.lblRechnungNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRechnungNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRechnungNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRechnungNr.Location = new System.Drawing.Point(23, 174);
            this.lblRechnungNr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRechnungNr.Name = "lblRechnungNr";
            this.lblRechnungNr.Size = new System.Drawing.Size(144, 27);
            this.lblRechnungNr.TabIndex = 92;
            this.lblRechnungNr.Text = "RechnungNr:";
            this.lblRechnungNr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZeichen
            // 
            this.lblZeichen.AutoSize = true;
            this.lblZeichen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblZeichen.Depth = 0;
            this.lblZeichen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZeichen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblZeichen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblZeichen.Location = new System.Drawing.Point(23, 201);
            this.lblZeichen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblZeichen.Name = "lblZeichen";
            this.lblZeichen.Size = new System.Drawing.Size(144, 27);
            this.lblZeichen.TabIndex = 91;
            this.lblZeichen.Text = "Zeichen:";
            this.lblZeichen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZeitraum
            // 
            this.lblZeitraum.AutoSize = true;
            this.lblZeitraum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblZeitraum.Depth = 0;
            this.lblZeitraum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZeitraum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblZeitraum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblZeitraum.Location = new System.Drawing.Point(23, 228);
            this.lblZeitraum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblZeitraum.Name = "lblZeitraum";
            this.lblZeitraum.Size = new System.Drawing.Size(144, 27);
            this.lblZeitraum.TabIndex = 90;
            this.lblZeitraum.Text = "Zeitraum:";
            this.lblZeitraum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIntro
            // 
            this.txtIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtIntro, 18);
            this.txtIntro.Depth = 0;
            this.txtIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtIntro.Location = new System.Drawing.Point(23, 366);
            this.txtIntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(1141, 28);
            this.txtIntro.TabIndex = 23;
            this.txtIntro.Text = "";
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tableLayoutPanel.SetColumnSpan(this.dataGridViewServices, 18);
            this.dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServices.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridViewServices.Location = new System.Drawing.Point(23, 420);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 51;
            this.dataGridViewServices.Size = new System.Drawing.Size(1141, 193);
            this.dataGridViewServices.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pos";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Beschreibung";
            this.dataGridViewTextBoxColumn2.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Menge";
            this.dataGridViewTextBoxColumn3.HeaderText = "Menge";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Einzelpreis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Einzelpreis";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gesamtpreis";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gesamtpreis";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtContent, 18);
            this.txtContent.Depth = 0;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtContent.Location = new System.Drawing.Point(23, 619);
            this.txtContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(1141, 54);
            this.txtContent.TabIndex = 24;
            this.txtContent.Text = "";
            // 
            // txtEndGruss
            // 
            this.txtEndGruss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEndGruss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtEndGruss, 18);
            this.txtEndGruss.Depth = 0;
            this.txtEndGruss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndGruss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtEndGruss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEndGruss.Location = new System.Drawing.Point(23, 679);
            this.txtEndGruss.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndGruss.Name = "txtEndGruss";
            this.txtEndGruss.Size = new System.Drawing.Size(1141, 28);
            this.txtEndGruss.TabIndex = 25;
            this.txtEndGruss.Text = "";
            // 
            // radioButtonGebaude
            // 
            this.radioButtonGebaude.AutoSize = true;
            this.radioButtonGebaude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonGebaude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonGebaude.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonGebaude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonGebaude.Location = new System.Drawing.Point(323, 63);
            this.radioButtonGebaude.Name = "radioButtonGebaude";
            this.radioButtonGebaude.Size = new System.Drawing.Size(44, 54);
            this.radioButtonGebaude.TabIndex = 4;
            this.radioButtonGebaude.TabStop = true;
            this.radioButtonGebaude.Text = "G";
            this.radioButtonGebaude.UseVisualStyleBackColor = false;
            // 
            // radioButtonRenovierung
            // 
            this.radioButtonRenovierung.AutoSize = true;
            this.radioButtonRenovierung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radioButtonRenovierung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonRenovierung.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radioButtonRenovierung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioButtonRenovierung.Location = new System.Drawing.Point(373, 63);
            this.radioButtonRenovierung.Name = "radioButtonRenovierung";
            this.radioButtonRenovierung.Size = new System.Drawing.Size(44, 54);
            this.radioButtonRenovierung.TabIndex = 5;
            this.radioButtonRenovierung.TabStop = true;
            this.radioButtonRenovierung.Text = "R";
            this.radioButtonRenovierung.UseVisualStyleBackColor = false;
            // 
            // txtKundenNr
            // 
            this.txtKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtKundenNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtKundenNr, 6);
            this.txtKundenNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKundenNr.Enabled = false;
            this.txtKundenNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKundenNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKundenNr.Location = new System.Drawing.Point(173, 123);
            this.txtKundenNr.Name = "txtKundenNr";
            this.txtKundenNr.ReadOnly = true;
            this.txtKundenNr.Size = new System.Drawing.Size(294, 17);
            this.txtKundenNr.TabIndex = 7;
            this.txtKundenNr.Text = "testtest";
            // 
            // txtKundenLastName
            // 
            this.txtKundenLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtKundenLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtKundenLastName, 3);
            this.txtKundenLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKundenLastName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKundenLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKundenLastName.Location = new System.Drawing.Point(173, 150);
            this.txtKundenLastName.Name = "txtKundenLastName";
            this.txtKundenLastName.Size = new System.Drawing.Size(144, 17);
            this.txtKundenLastName.TabIndex = 8;
            // 
            // txtRechnungNr
            // 
            this.txtRechnungNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRechnungNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtRechnungNr, 6);
            this.txtRechnungNr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRechnungNr.Enabled = false;
            this.txtRechnungNr.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRechnungNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRechnungNr.Location = new System.Drawing.Point(173, 177);
            this.txtRechnungNr.Name = "txtRechnungNr";
            this.txtRechnungNr.ReadOnly = true;
            this.txtRechnungNr.Size = new System.Drawing.Size(294, 17);
            this.txtRechnungNr.TabIndex = 10;
            // 
            // txtZeichen
            // 
            this.txtZeichen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtZeichen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtZeichen, 6);
            this.txtZeichen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtZeichen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtZeichen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtZeichen.Location = new System.Drawing.Point(173, 204);
            this.txtZeichen.Name = "txtZeichen";
            this.txtZeichen.Size = new System.Drawing.Size(294, 17);
            this.txtZeichen.TabIndex = 11;
            // 
            // lblStunden
            // 
            this.lblStunden.AutoSize = true;
            this.lblStunden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblStunden.Depth = 0;
            this.lblStunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStunden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStunden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStunden.Location = new System.Drawing.Point(523, 147);
            this.lblStunden.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStunden.Name = "lblStunden";
            this.lblStunden.Size = new System.Drawing.Size(144, 27);
            this.lblStunden.TabIndex = 120;
            this.lblStunden.Text = "Stunden:";
            this.lblStunden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBezahlt
            // 
            this.lblBezahlt.AutoSize = true;
            this.lblBezahlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblBezahlt.Depth = 0;
            this.lblBezahlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBezahlt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBezahlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBezahlt.Location = new System.Drawing.Point(523, 174);
            this.lblBezahlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBezahlt.Name = "lblBezahlt";
            this.lblBezahlt.Size = new System.Drawing.Size(144, 27);
            this.lblBezahlt.TabIndex = 121;
            this.lblBezahlt.Text = "Bezahlt:";
            this.lblBezahlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatumBezahlt
            // 
            this.lblDatumBezahlt.AutoSize = true;
            this.lblDatumBezahlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDatumBezahlt.Depth = 0;
            this.lblDatumBezahlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatumBezahlt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDatumBezahlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatumBezahlt.Location = new System.Drawing.Point(523, 201);
            this.lblDatumBezahlt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatumBezahlt.Name = "lblDatumBezahlt";
            this.lblDatumBezahlt.Size = new System.Drawing.Size(144, 27);
            this.lblDatumBezahlt.TabIndex = 122;
            this.lblDatumBezahlt.Text = "DatumBezahlt:";
            this.lblDatumBezahlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblStatus.Depth = 0;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(523, 255);
            this.lblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 27);
            this.lblStatus.TabIndex = 123;
            this.lblStatus.Text = "Status:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaelligAm
            // 
            this.lblFaelligAm.AutoSize = true;
            this.lblFaelligAm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblFaelligAm.Depth = 0;
            this.lblFaelligAm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaelligAm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFaelligAm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFaelligAm.Location = new System.Drawing.Point(523, 228);
            this.lblFaelligAm.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFaelligAm.Name = "lblFaelligAm";
            this.lblFaelligAm.Size = new System.Drawing.Size(144, 27);
            this.lblFaelligAm.TabIndex = 124;
            this.lblFaelligAm.Text = "Fällig am:";
            this.lblFaelligAm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFaelligAm.Click += new System.EventHandler(this.txtFaelligAm_Click);
            // 
            // lblEmpfaenger
            // 
            this.lblEmpfaenger.AutoSize = true;
            this.lblEmpfaenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEmpfaenger.Depth = 0;
            this.lblEmpfaenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpfaenger.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpfaenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpfaenger.Location = new System.Drawing.Point(523, 60);
            this.lblEmpfaenger.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpfaenger.Name = "lblEmpfaenger";
            this.lblEmpfaenger.Size = new System.Drawing.Size(144, 60);
            this.lblEmpfaenger.TabIndex = 130;
            this.lblEmpfaenger.Text = "Empfänger:";
            this.lblEmpfaenger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmpaenger
            // 
            this.txtEmpaenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtEmpaenger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtEmpaenger, 6);
            this.txtEmpaenger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpaenger.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmpaenger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEmpaenger.Location = new System.Drawing.Point(673, 63);
            this.txtEmpaenger.Multiline = true;
            this.txtEmpaenger.Name = "txtEmpaenger";
            this.txtEmpaenger.ReadOnly = true;
            this.txtEmpaenger.Size = new System.Drawing.Size(294, 54);
            this.txtEmpaenger.TabIndex = 15;
            // 
            // txtStunden
            // 
            this.txtStunden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtStunden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtStunden, 6);
            this.txtStunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStunden.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStunden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStunden.Location = new System.Drawing.Point(673, 150);
            this.txtStunden.Name = "txtStunden";
            this.txtStunden.Size = new System.Drawing.Size(294, 17);
            this.txtStunden.TabIndex = 17;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtStatus, 6);
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStatus.Location = new System.Drawing.Point(673, 258);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(294, 17);
            this.txtStatus.TabIndex = 21;
            // 
            // btnWeiter
            // 
            this.btnWeiter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWeiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnWeiter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWeiter.Depth = 0;
            this.btnWeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWeiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnWeiter.HighEmphasis = true;
            this.btnWeiter.Icon = null;
            this.btnWeiter.Location = new System.Drawing.Point(1031, 736);
            this.btnWeiter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWeiter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWeiter.Size = new System.Drawing.Size(132, 28);
            this.btnWeiter.TabIndex = 28;
            this.btnWeiter.Text = ">>";
            this.btnWeiter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWeiter.UseAccentColor = false;
            this.btnWeiter.UseVisualStyleBackColor = false;
            this.btnWeiter.Click += new System.EventHandler(this.btnWeiter_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrevious.Depth = 0;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrevious.HighEmphasis = true;
            this.btnPrevious.Icon = null;
            this.btnPrevious.Location = new System.Drawing.Point(891, 736);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrevious.Size = new System.Drawing.Size(132, 28);
            this.btnPrevious.TabIndex = 27;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrevious.UseAccentColor = false;
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRechnung
            // 
            this.btnDeleteRechnung.AutoSize = false;
            this.btnDeleteRechnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRechnung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteRechnung.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteRechnung.Depth = 0;
            this.btnDeleteRechnung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteRechnung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteRechnung.HighEmphasis = true;
            this.btnDeleteRechnung.Icon = global::BlancoAssist.Properties.Resources.icons8_remove_31;
            this.btnDeleteRechnung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteRechnung.ImageKey = "(none)";
            this.btnDeleteRechnung.Location = new System.Drawing.Point(891, 4);
            this.btnDeleteRechnung.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRechnung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteRechnung.Name = "btnDeleteRechnung";
            this.btnDeleteRechnung.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteRechnung.Padding = new System.Windows.Forms.Padding(4);
            this.btnDeleteRechnung.Size = new System.Drawing.Size(132, 32);
            this.btnDeleteRechnung.TabIndex = 27;
            this.btnDeleteRechnung.Text = "Entfernen";
            this.btnDeleteRechnung.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteRechnung.UseAccentColor = false;
            this.btnDeleteRechnung.UseVisualStyleBackColor = false;
            this.btnDeleteRechnung.Click += new System.EventHandler(this.btnDeleteRechnung_Click);
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
            this.btnAddRechnung.Location = new System.Drawing.Point(1031, 4);
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
            // txtKundenFirstName
            // 
            this.txtKundenFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtKundenFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtKundenFirstName, 3);
            this.txtKundenFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKundenFirstName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKundenFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtKundenFirstName.Location = new System.Drawing.Point(323, 150);
            this.txtKundenFirstName.Name = "txtKundenFirstName";
            this.txtKundenFirstName.Size = new System.Drawing.Size(144, 17);
            this.txtKundenFirstName.TabIndex = 9;
            // 
            // txtVersicherer
            // 
            this.txtVersicherer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtVersicherer, 6);
            this.txtVersicherer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersicherer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVersicherer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtVersicherer.FormattingEnabled = true;
            this.txtVersicherer.Location = new System.Drawing.Point(173, 258);
            this.txtVersicherer.Name = "txtVersicherer";
            this.txtVersicherer.Size = new System.Drawing.Size(294, 25);
            this.txtVersicherer.TabIndex = 14;
            this.txtVersicherer.SelectedIndexChanged += new System.EventHandler(this.txtVersicherer_SelectedIndexChanged);
            // 
            // lblVerischerer
            // 
            this.lblVerischerer.AutoSize = true;
            this.lblVerischerer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblVerischerer.Depth = 0;
            this.lblVerischerer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerischerer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVerischerer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVerischerer.Location = new System.Drawing.Point(23, 255);
            this.lblVerischerer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVerischerer.Name = "lblVerischerer";
            this.lblVerischerer.Size = new System.Drawing.Size(144, 27);
            this.lblVerischerer.TabIndex = 132;
            this.lblVerischerer.Text = "Versicherer:";
            this.lblVerischerer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.lblDatum, 7);
            this.lblDatum.Depth = 0;
            this.lblDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatum.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDatum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatum.Location = new System.Drawing.Point(23, 282);
            this.lblDatum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(444, 27);
            this.lblDatum.TabIndex = 135;
            this.lblDatum.Text = "Datum+++";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAddress.Depth = 0;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(523, 120);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(144, 27);
            this.lblAddress.TabIndex = 136;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtAddress, 6);
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAddress.Location = new System.Drawing.Point(673, 123);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(294, 17);
            this.txtAddress.TabIndex = 16;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtError, 20);
            this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtError.Location = new System.Drawing.Point(3, 770);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(1181, 20);
            this.txtError.TabIndex = 137;
            // 
            // txtDatumBezahlt
            // 
            this.txtDatumBezahlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtDatumBezahlt, 6);
            this.txtDatumBezahlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDatumBezahlt.Enabled = false;
            this.txtDatumBezahlt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDatumBezahlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDatumBezahlt.Location = new System.Drawing.Point(673, 204);
            this.txtDatumBezahlt.Name = "txtDatumBezahlt";
            this.txtDatumBezahlt.Size = new System.Drawing.Size(294, 24);
            this.txtDatumBezahlt.TabIndex = 138;
            // 
            // txtBezahlt
            // 
            this.txtBezahlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBezahlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel.SetColumnSpan(this.txtBezahlt, 6);
            this.txtBezahlt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBezahlt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBezahlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBezahlt.Location = new System.Drawing.Point(673, 177);
            this.txtBezahlt.Name = "txtBezahlt";
            this.txtBezahlt.Size = new System.Drawing.Size(294, 17);
            this.txtBezahlt.TabIndex = 18;
            // 
            // txtFaelligAm
            // 
            this.txtFaelligAm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtFaelligAm, 6);
            this.txtFaelligAm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaelligAm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFaelligAm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFaelligAm.Location = new System.Drawing.Point(673, 231);
            this.txtFaelligAm.Name = "txtFaelligAm";
            this.txtFaelligAm.Size = new System.Drawing.Size(294, 24);
            this.txtFaelligAm.TabIndex = 139;
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtBeginDate, 3);
            this.txtBeginDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBeginDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBeginDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBeginDate.Location = new System.Drawing.Point(173, 231);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Size = new System.Drawing.Size(144, 24);
            this.txtBeginDate.TabIndex = 140;
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel.SetColumnSpan(this.txtEndDate, 3);
            this.txtEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEndDate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEndDate.Location = new System.Drawing.Point(323, 231);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(144, 24);
            this.txtEndDate.TabIndex = 141;
            // 
            // imageListEditMode
            // 
            this.imageListEditMode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListEditMode.ImageStream")));
            this.imageListEditMode.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListEditMode.Images.SetKeyName(0, "icons8-company-26.png");
            this.imageListEditMode.Images.SetKeyName(1, "icons8-kunden-26.png");
            this.imageListEditMode.Images.SetKeyName(2, "icons8-rechnung-26.png");
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.AutoSize = false;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDownload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDownload.Depth = 0;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDownload.HighEmphasis = true;
            this.btnDownload.Icon = global::BlancoAssist.Properties.Resources.icons8_download_26;
            this.btnDownload.Location = new System.Drawing.Point(1048, 30);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDownload.Size = new System.Drawing.Size(42, 27);
            this.btnDownload.TabIndex = 112;
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDownload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDownload.UseAccentColor = false;
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // btnSaveRechnung
            // 
            this.btnSaveRechnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRechnung.AutoSize = false;
            this.btnSaveRechnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveRechnung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSaveRechnung.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveRechnung.Depth = 0;
            this.btnSaveRechnung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveRechnung.HighEmphasis = true;
            this.btnSaveRechnung.Icon = global::BlancoAssist.Properties.Resources.icons8_save_261;
            this.btnSaveRechnung.Location = new System.Drawing.Point(1098, 30);
            this.btnSaveRechnung.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveRechnung.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveRechnung.Name = "btnSaveRechnung";
            this.btnSaveRechnung.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveRechnung.Size = new System.Drawing.Size(42, 27);
            this.btnSaveRechnung.TabIndex = 111;
            this.btnSaveRechnung.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveRechnung.UseAccentColor = false;
            this.btnSaveRechnung.UseVisualStyleBackColor = false;
            this.btnSaveRechnung.Click += new System.EventHandler(this.btnSaveRechnung_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.AutoSize = false;
            this.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHome.Depth = 0;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.HighEmphasis = true;
            this.btnHome.Icon = global::BlancoAssist.Properties.Resources.icons8_home_page_26;
            this.btnHome.Location = new System.Drawing.Point(1148, 30);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHome.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHome.Name = "btnHome";
            this.btnHome.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHome.Size = new System.Drawing.Size(50, 26);
            this.btnHome.TabIndex = 110;
            this.btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHome.UseAccentColor = false;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddService.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddService.Image = global::BlancoAssist.Properties.Resources.icons_plus_31;
            this.btnAddService.Location = new System.Drawing.Point(1161, 553);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(30, 31);
            this.btnAddService.TabIndex = 77;
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // FormRechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 900);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSaveRechnung);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.tabControlEditMode);
            this.Controls.Add(this.btnAddService);
            this.DrawerShowIconsWhenHidden = true;
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRechnung";
            this.Text = "FormRechnung";
            this.tabControlEditMode.ResumeLayout(false);
            this.tabPageRechnung.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddService;
        private BaseBlancoTabControl tabControlEditMode;
        private System.Windows.Forms.TabPage tabPageRechnung;
        private MaterialSkin.Controls.MaterialButton btnDeleteRechnung;
        private MaterialSkin.Controls.MaterialButton btnAddRechnung;
        private System.Windows.Forms.ImageList imageListEditMode;
        private System.Windows.Forms.RadioButton radioButtonPrivat;
        private System.Windows.Forms.RadioButton radioButtonHHH;
        private System.Windows.Forms.RadioButton radioButtonEntlastung;
        private System.Windows.Forms.RadioButton radioButtonVerhinderung;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private MaterialSkin.Controls.MaterialLabel lblRechnungNr;
        private MaterialSkin.Controls.MaterialLabel lblZeichen;
        private MaterialSkin.Controls.MaterialLabel lblZeitraum;
        private MaterialSkin.Controls.MaterialLabel lblKundenNr;
        private MaterialSkin.Controls.MaterialLabel lblKundenName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtGruss;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtIntro;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtContent;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtEndGruss;
        private MaterialSkin.Controls.MaterialButton btnWeiter;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnHome;
        private MaterialSkin.Controls.MaterialButton btnSaveRechnung;
        private MaterialSkin.Controls.MaterialButton btnDownload;
        private System.Windows.Forms.RadioButton radioButtonGebaude;
        private System.Windows.Forms.RadioButton radioButtonRenovierung;
        private System.Windows.Forms.TextBox txtKundenNr;
        private System.Windows.Forms.TextBox txtKundenLastName;
        private System.Windows.Forms.TextBox txtRechnungNr;
        private System.Windows.Forms.TextBox txtZeichen;
        private MaterialSkin.Controls.MaterialLabel lblStunden;
        private MaterialSkin.Controls.MaterialLabel lblBezahlt;
        private MaterialSkin.Controls.MaterialLabel lblDatumBezahlt;
        private MaterialSkin.Controls.MaterialLabel lblStatus;
        private MaterialSkin.Controls.MaterialLabel lblFaelligAm;
        private System.Windows.Forms.TextBox txtStunden;
        private System.Windows.Forms.TextBox txtBezahlt;
        private System.Windows.Forms.TextBox txtStatus;
        private MaterialSkin.Controls.MaterialLabel lblEmpfaenger;
        private System.Windows.Forms.TextBox txtEmpaenger;
        private MaterialSkin.Controls.MaterialLabel lblVerischerer;
        private System.Windows.Forms.ComboBox txtVersicherer;
        private System.Windows.Forms.TextBox txtKundenFirstName;
        private MaterialSkin.Controls.MaterialLabel lblDatum;
        private System.Windows.Forms.TextBox txtAddress;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private System.Windows.Forms.Label txtError;
        private System.Windows.Forms.DateTimePicker txtDatumBezahlt;
        private System.Windows.Forms.DateTimePicker txtFaelligAm;
        private System.Windows.Forms.DateTimePicker txtBeginDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
    }
}