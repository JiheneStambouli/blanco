namespace BlancoAssist
{
    partial class FormRechnung2
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
            this.lblSeparator = new System.Windows.Forms.Label();
            this.txtBeginDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblEmpfaenger = new System.Windows.Forms.Label();
            this.lblAbsender = new System.Windows.Forms.Label();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.btnSaveRechnung = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEinzelpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIntro = new System.Windows.Forms.RichTextBox();
            this.txtGruss = new System.Windows.Forms.RichTextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKundenNr = new System.Windows.Forms.Label();
            this.lblZeichen = new System.Windows.Forms.Label();
            this.lblZeitraum = new System.Windows.Forms.Label();
            this.lblRechnungNr = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtKundenNr = new System.Windows.Forms.TextBox();
            this.txtZeichen = new System.Windows.Forms.TextBox();
            this.txtRechnungNr = new System.Windows.Forms.TextBox();
            this.txtEmpfaenger = new System.Windows.Forms.RichTextBox();
            this.txtAbsender = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.txtEndGruss = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Location = new System.Drawing.Point(675, 100);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(12, 13);
            this.lblSeparator.TabIndex = 74;
            this.lblSeparator.Text = "-";
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBeginDate.Location = new System.Drawing.Point(566, 97);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Size = new System.Drawing.Size(103, 21);
            this.txtBeginDate.TabIndex = 73;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndDate.Location = new System.Drawing.Point(691, 97);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(103, 21);
            this.txtEndDate.TabIndex = 72;
            // 
            // lblEmpfaenger
            // 
            this.lblEmpfaenger.AutoSize = true;
            this.lblEmpfaenger.Location = new System.Drawing.Point(15, 126);
            this.lblEmpfaenger.Name = "lblEmpfaenger";
            this.lblEmpfaenger.Size = new System.Drawing.Size(62, 13);
            this.lblEmpfaenger.TabIndex = 71;
            this.lblEmpfaenger.Text = "Empfänger:";
            this.lblEmpfaenger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAbsender
            // 
            this.lblAbsender.AutoSize = true;
            this.lblAbsender.Location = new System.Drawing.Point(21, 100);
            this.lblAbsender.Name = "lblAbsender";
            this.lblAbsender.Size = new System.Drawing.Size(56, 13);
            this.lblAbsender.TabIndex = 70;
            this.lblAbsender.Text = "Absender:";
            this.lblAbsender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNeu
            // 
            this.btnNeu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeu.Location = new System.Drawing.Point(654, 15);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(67, 24);
            this.btnNeu.TabIndex = 68;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(608, 603);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(90, 23);
            this.btnPrevious.TabIndex = 67;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnWeiter
            // 
            this.btnWeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeiter.Location = new System.Drawing.Point(704, 603);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(90, 23);
            this.btnWeiter.TabIndex = 66;
            this.btnWeiter.Text = ">>";
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.btnWeiter_Click);
            // 
            // btnSaveRechnung
            // 
            this.btnSaveRechnung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRechnung.Location = new System.Drawing.Point(726, 15);
            this.btnSaveRechnung.Name = "btnSaveRechnung";
            this.btnSaveRechnung.Size = new System.Drawing.Size(67, 24);
            this.btnSaveRechnung.TabIndex = 65;
            this.btnSaveRechnung.Text = "Speichern";
            this.btnSaveRechnung.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPos,
            this.colBeschreibung,
            this.colMenge,
            this.colEinzelpreis,
            this.colGesamtpreis});
            this.dataGridView.Location = new System.Drawing.Point(13, 327);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(782, 167);
            this.dataGridView.TabIndex = 64;
            // 
            // colPos
            // 
            this.colPos.DataPropertyName = "Pos";
            this.colPos.HeaderText = "Pos";
            this.colPos.Name = "colPos";
            this.colPos.ReadOnly = true;
            // 
            // colBeschreibung
            // 
            this.colBeschreibung.DataPropertyName = "Beschreibung";
            this.colBeschreibung.HeaderText = "Beschreibung";
            this.colBeschreibung.Name = "colBeschreibung";
            // 
            // colMenge
            // 
            this.colMenge.DataPropertyName = "Menge";
            this.colMenge.HeaderText = "Menge";
            this.colMenge.Name = "colMenge";
            // 
            // colEinzelpreis
            // 
            this.colEinzelpreis.DataPropertyName = "Einzelpreis";
            this.colEinzelpreis.HeaderText = "Einzelpreis";
            this.colEinzelpreis.Name = "colEinzelpreis";
            // 
            // colGesamtpreis
            // 
            this.colGesamtpreis.DataPropertyName = "Gesamtpreis";
            this.colGesamtpreis.HeaderText = "Gesamtpreis";
            this.colGesamtpreis.Name = "colGesamtpreis";
            // 
            // txtIntro
            // 
            this.txtIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIntro.Location = new System.Drawing.Point(12, 256);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(782, 28);
            this.txtIntro.TabIndex = 63;
            this.txtIntro.Text = "";
            // 
            // txtGruss
            // 
            this.txtGruss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGruss.Location = new System.Drawing.Point(12, 223);
            this.txtGruss.Name = "txtGruss";
            this.txtGruss.Size = new System.Drawing.Size(782, 27);
            this.txtGruss.TabIndex = 62;
            this.txtGruss.Text = "";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(519, 178);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 61;
            this.lblDatum.Text = "Datum:";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKundenNr
            // 
            this.lblKundenNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKundenNr.AutoSize = true;
            this.lblKundenNr.Location = new System.Drawing.Point(496, 152);
            this.lblKundenNr.Name = "lblKundenNr";
            this.lblKundenNr.Size = new System.Drawing.Size(63, 13);
            this.lblKundenNr.TabIndex = 60;
            this.lblKundenNr.Text = "Kunden Nr.:";
            this.lblKundenNr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZeichen
            // 
            this.lblZeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZeichen.AutoSize = true;
            this.lblZeichen.Location = new System.Drawing.Point(511, 126);
            this.lblZeichen.Name = "lblZeichen";
            this.lblZeichen.Size = new System.Drawing.Size(47, 13);
            this.lblZeichen.TabIndex = 59;
            this.lblZeichen.Text = "Zeichen:";
            this.lblZeichen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZeitraum
            // 
            this.lblZeitraum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZeitraum.AutoSize = true;
            this.lblZeitraum.Location = new System.Drawing.Point(509, 100);
            this.lblZeitraum.Name = "lblZeitraum";
            this.lblZeitraum.Size = new System.Drawing.Size(54, 13);
            this.lblZeitraum.TabIndex = 58;
            this.lblZeitraum.Text = "Zeitraum:";
            this.lblZeitraum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRechnungNr
            // 
            this.lblRechnungNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRechnungNr.AutoSize = true;
            this.lblRechnungNr.Location = new System.Drawing.Point(480, 74);
            this.lblRechnungNr.Name = "lblRechnungNr";
            this.lblRechnungNr.Size = new System.Drawing.Size(77, 13);
            this.lblRechnungNr.TabIndex = 57;
            this.lblRechnungNr.Text = "Rechnung Nr. :";
            this.lblRechnungNr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatum.Location = new System.Drawing.Point(566, 175);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(227, 21);
            this.txtDatum.TabIndex = 56;
            // 
            // txtKundenNr
            // 
            this.txtKundenNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKundenNr.Location = new System.Drawing.Point(566, 149);
            this.txtKundenNr.Name = "txtKundenNr";
            this.txtKundenNr.Size = new System.Drawing.Size(227, 21);
            this.txtKundenNr.TabIndex = 55;
            // 
            // txtZeichen
            // 
            this.txtZeichen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZeichen.Location = new System.Drawing.Point(566, 123);
            this.txtZeichen.Name = "txtZeichen";
            this.txtZeichen.Size = new System.Drawing.Size(227, 21);
            this.txtZeichen.TabIndex = 54;
            // 
            // txtRechnungNr
            // 
            this.txtRechnungNr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRechnungNr.Location = new System.Drawing.Point(566, 71);
            this.txtRechnungNr.Name = "txtRechnungNr";
            this.txtRechnungNr.Size = new System.Drawing.Size(227, 21);
            this.txtRechnungNr.TabIndex = 52;
            // 
            // txtEmpfaenger
            // 
            this.txtEmpfaenger.Location = new System.Drawing.Point(88, 126);
            this.txtEmpfaenger.Name = "txtEmpfaenger";
            this.txtEmpfaenger.Size = new System.Drawing.Size(319, 69);
            this.txtEmpfaenger.TabIndex = 51;
            this.txtEmpfaenger.Text = "";
            // 
            // txtAbsender
            // 
            this.txtAbsender.Location = new System.Drawing.Point(88, 97);
            this.txtAbsender.Name = "txtAbsender";
            this.txtAbsender.Size = new System.Drawing.Size(319, 21);
            this.txtAbsender.TabIndex = 50;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(62, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 31);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "Rechnung";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(13, 498);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(782, 65);
            this.txtContent.TabIndex = 75;
            this.txtContent.Text = "";
            // 
            // txtEndGruss
            // 
            this.txtEndGruss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndGruss.Location = new System.Drawing.Point(11, 569);
            this.txtEndGruss.Name = "txtEndGruss";
            this.txtEndGruss.Size = new System.Drawing.Size(782, 28);
            this.txtEndGruss.TabIndex = 76;
            this.txtEndGruss.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Absender:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Image = global::BlancoAssist.Properties.Resources.icoarrowleft;
            this.btnHome.Location = new System.Drawing.Point(31, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 28);
            this.btnHome.TabIndex = 69;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.Image = global::BlancoAssist.Properties.Resources.icons8_delete_31;
            this.btnDeleteService.Location = new System.Drawing.Point(726, 290);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(31, 31);
            this.btnDeleteService.TabIndex = 78;
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.Image = global::BlancoAssist.Properties.Resources.icons_plus_31;
            this.btnAddService.Location = new System.Drawing.Point(763, 290);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(30, 31);
            this.btnAddService.TabIndex = 77;
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // FormRechnung
            // 
            this.AcceptButton = this.btnSaveRechnung;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(807, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtEndGruss);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblSeparator);
            this.Controls.Add(this.txtBeginDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEmpfaenger);
            this.Controls.Add(this.lblAbsender);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnWeiter);
            this.Controls.Add(this.btnSaveRechnung);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.txtGruss);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKundenNr);
            this.Controls.Add(this.lblZeichen);
            this.Controls.Add(this.lblZeitraum);
            this.Controls.Add(this.lblRechnungNr);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtKundenNr);
            this.Controls.Add(this.txtZeichen);
            this.Controls.Add(this.txtRechnungNr);
            this.Controls.Add(this.txtEmpfaenger);
            this.Controls.Add(this.txtAbsender);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormRechnung";
            this.Text = "FormRechnung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.TextBox txtBeginDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblEmpfaenger;
        private System.Windows.Forms.Label lblAbsender;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnWeiter;
        private System.Windows.Forms.Button btnSaveRechnung;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RichTextBox txtIntro;
        private System.Windows.Forms.RichTextBox txtGruss;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblKundenNr;
        private System.Windows.Forms.Label lblZeichen;
        private System.Windows.Forms.Label lblZeitraum;
        private System.Windows.Forms.Label lblRechnungNr;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtKundenNr;
        private System.Windows.Forms.TextBox txtZeichen;
        private System.Windows.Forms.TextBox txtRechnungNr;
        private System.Windows.Forms.RichTextBox txtEmpfaenger;
        private System.Windows.Forms.TextBox txtAbsender;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.RichTextBox txtEndGruss;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEinzelpreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGesamtpreis;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label1;
    }
}