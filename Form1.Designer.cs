using System;

namespace BlancoAssist
{
    partial class Form1
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditRechnugen = new System.Windows.Forms.Button();
            this.btnRemoveRechnungen = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.colZeichen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechnungNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKundenNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpfaenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZeitraum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Menge";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Einzelpreis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Gesamtpreis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnEditRechnugen
            // 
            this.btnEditRechnugen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRechnugen.Location = new System.Drawing.Point(697, 586);
            this.btnEditRechnugen.Name = "btnEditRechnugen";
            this.btnEditRechnugen.Size = new System.Drawing.Size(90, 24);
            this.btnEditRechnugen.TabIndex = 26;
            this.btnEditRechnugen.Text = "Bearbeiten";
            this.btnEditRechnugen.UseVisualStyleBackColor = true;
            this.btnEditRechnugen.Click += new System.EventHandler(this.btnEditRechnugen_Click);
            // 
            // btnRemoveRechnungen
            // 
            this.btnRemoveRechnungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveRechnungen.Location = new System.Drawing.Point(601, 586);
            this.btnRemoveRechnungen.Name = "btnRemoveRechnungen";
            this.btnRemoveRechnungen.Size = new System.Drawing.Size(90, 24);
            this.btnRemoveRechnungen.TabIndex = 25;
            this.btnRemoveRechnungen.Text = "Entfernen";
            this.btnRemoveRechnungen.UseVisualStyleBackColor = true;
            this.btnRemoveRechnungen.Click += new System.EventHandler(this.btnRemoveRechnungen_Click);
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.AllowUserToAddRows = false;
            this.dataGridViewHome.AllowUserToOrderColumns = true;
            this.dataGridViewHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colZeichen,
            this.colDatum,
            this.RechnungNr,
            this.colKundenNr,
            this.colEmpfaenger,
            this.colZeitraum});
            this.dataGridViewHome.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.Size = new System.Drawing.Size(775, 504);
            this.dataGridViewHome.TabIndex = 24;
            this.dataGridViewHome.DataSourceChanged += new System.EventHandler(this.dataGridViewHome_DataSourceChanged);
            // 
            // colZeichen
            // 
            this.colZeichen.DataPropertyName = "Zeichen";
            this.colZeichen.HeaderText = "Zeichen";
            this.colZeichen.Name = "colZeichen";
            // 
            // colDatum
            // 
            this.colDatum.DataPropertyName = "Datum";
            this.colDatum.HeaderText = "Datum";
            this.colDatum.Name = "colDatum";
            // 
            // RechnungNr
            // 
            this.RechnungNr.DataPropertyName = "RechnungNr";
            this.RechnungNr.HeaderText = "RechnungNr";
            this.RechnungNr.Name = "RechnungNr";
            // 
            // colKundenNr
            // 
            this.colKundenNr.DataPropertyName = "KundenNr";
            this.colKundenNr.HeaderText = "KundenNr";
            this.colKundenNr.Name = "colKundenNr";
            // 
            // colEmpfaenger
            // 
            this.colEmpfaenger.DataPropertyName = "Empfaenger";
            this.colEmpfaenger.HeaderText = "Empfaenger";
            this.colEmpfaenger.Name = "colEmpfaenger";
            // 
            // colZeitraum
            // 
            this.colZeitraum.DataPropertyName = "Zeitraum";
            this.colZeitraum.HeaderText = "Zeitraum";
            this.colZeitraum.Name = "colZeitraum";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(63, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(79, 31);
            this.lblHome.TabIndex = 27;
            this.lblHome.Text = "Home";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(683, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 24);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Neu Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 621);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEditRechnugen);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnRemoveRechnungen);
            this.Controls.Add(this.dataGridViewHome);
            this.Name = "FormMain";
            this.Text = "Rechnugen bearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnEditRechnugen;
        private System.Windows.Forms.Button btnRemoveRechnungen;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZeichen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechnungNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKundenNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpfaenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZeitraum;
    }
}