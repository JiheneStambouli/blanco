using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlancoAssist
{
    
    public class BaseBlancoForm : MaterialForm
    {
        protected readonly MaterialSkinManager materialSkinManager;
        private System.ComponentModel.IContainer components;
        public FormsHelper FormsHelper ;

        public BaseBlancoForm()
        {
            materialSkinManager = MaterialSkinManager.Instance;

            FormsHelper = new FormsHelper();


            initializeMaterialSkinManager();

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(500, 350);    
            this.Size = new System.Drawing.Size(900, 700);

        }

        private void initializeMaterialSkinManager()
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseBlancoForm));
            this.SuspendLayout();
            // 
            // BaseBlancoForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "BaseBlancoForm";
            this.ResumeLayout(false);

        }
    }

    public class BaseBlancoTabControl : MaterialTabControl
    {
        protected readonly MaterialSkinManager materialSkinManager;

        public BaseBlancoTabControl()
        {
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Multiline = true;
        }

    }

    //public class BaseBlancoDataGridView: DataGridView
    //{
    //    protected readonly MaterialSkinManager materialSkinManager;

    //    public BaseBlancoDataGridView()
    //    {
    //        this.AllowUserToAddRows = false;
    //        this.AllowUserToDeleteRows = false;
    //        this.AllowUserToResizeColumns = true;   
    //        this.AllowUserToResizeRows = false;
    //        this.AllowUserToOrderColumns = true;
    //        this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
    //        | System.Windows.Forms.AnchorStyles.Left)
    //        | System.Windows.Forms.AnchorStyles.Right)));
    //        this.BackgroundColor = System.Drawing.SystemColors.Window;
    //        this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    //        this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
    //        this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    //        this.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
    //        this.Location = new System.Drawing.Point(0, 50);
    //        this.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
    //        this.Size = new System.Drawing.Size(884, 590);
    //        this.Location = new System.Drawing.Point(0, 50);

    //    }

    //}

    public class FormsHelper
    {


        public FormsHelper() { InitializeImageListMain(); }

        private void InitializeImageListMain()
        {
            //ImageListBlanco = new ImageList();
            //ImageListBlanco.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBlanco.ImageStream")));
            //ImageListBlanco.TransparentColor = System.Drawing.Color.Transparent;
            //ImageListBlanco.Images.SetKeyName(0, "icons8-invoice-26.png");
            //ImageListBlanco.Images.SetKeyName(1, "icons8-users-26.png");
            //ImageListBlanco.Images.SetKeyName(2, "icon-edit-31.png");
            //ImageListBlanco.Images.SetKeyName(3, "icons8-kunden-26.png");
            //ImageListBlanco.Images.SetKeyName(4, "icons8-rechnung-26.png");
            //ImageListBlanco.Images.SetKeyName(5, "icons8-company-26.png");
        }

        public void SetCommonGridProperties(DataGridView datagrid)
        {
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AllowUserToResizeColumns = true;
            datagrid.AllowUserToResizeRows = false;
            datagrid.AllowUserToOrderColumns = true;
            datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            datagrid.BackgroundColor = System.Drawing.SystemColors.Window;
            datagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            datagrid.Location = new System.Drawing.Point(0, 50);
            datagrid.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            datagrid.Size = new System.Drawing.Size(896, 496);
            datagrid.Location = new System.Drawing.Point(0, 50);
        }

        //todo
        public void SetCommonTabControlProperties(BaseBlancoTabControl tabControl)
        {
            tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            tabControl.Location = new System.Drawing.Point(2, 64);
            tabControl.Margin = new System.Windows.Forms.Padding(2);
            tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Size = new System.Drawing.Size(896, 633);
        }

        public void SetCommonAddButtonsProperties(MaterialButton btn)
        {
            btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            btn.AutoSize = false;
            btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            btn.Depth = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(752, 7);
            btn.Margin = new System.Windows.Forms.Padding(4);
            btn.MouseState = MaterialSkin.MouseState.HOVER;
            btn.NoAccentTextColor = System.Drawing.Color.Empty;
            btn.Padding = new System.Windows.Forms.Padding(4);
            btn.Size = new System.Drawing.Size(131, 36);
            btn.Text = "Anlegen";
            btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn.UseAccentColor = false;
            btn.UseVisualStyleBackColor = false;
        }

        public void SetCommonTabPageProperties(TabPage tab)
        {
            tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            tab.Location = new System.Drawing.Point(4, 33);
            tab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tab.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tab.Size = new System.Drawing.Size(888, 596);
        }


        public void SetCommonEditButtonsProperties(MaterialButton btn)
        {
            btn.Padding = new System.Windows.Forms.Padding(4);
            btn.Size = new System.Drawing.Size(130, 36);
            btn.Location = new System.Drawing.Point(752, 553);
            btn.Margin = new System.Windows.Forms.Padding(4);
        }

        public void SetCommonRemoveButtonsProperties(MaterialButton btn)
        {
            btn.Location = new System.Drawing.Point(614, 553);
            btn.Margin = new System.Windows.Forms.Padding(4);
            btn.Padding = new System.Windows.Forms.Padding(4);
            btn.Size = new System.Drawing.Size(130, 36);
        }

        internal void SetCommonTextBoxProperties(Control txt)
        {
            if (txt is TextBox)
            {
                TextBox textBox = (TextBox)txt;
                textBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (txt is DateTimePicker)
            {
                DateTimePicker dateTimePicker = (DateTimePicker)txt;
            }

        }

        //internal void SetCommonDateTextBoxProperties(DateTimePicker txtDatum)
        //{
        //    txtDatum.Click += TxtDatum_Click;
        //}

        //private void TxtDatum_Click(object sender, EventArgs e)
        //{
        //    TextBox textBox = sender as TextBox;
        //    if (textBox != null)
        //    {
        //        // Create a DateTimePicker control
        //        DateTimePicker dateTimePicker = new DateTimePicker();

        //        // Set its format and position
        //        dateTimePicker.Format = DateTimePickerFormat.Short;
        //        dateTimePicker.Location = textBox.PointToScreen(new System.Drawing.Point(0, textBox.Height));

        //        // Add event handler for value changed
        //        dateTimePicker.ValueChanged += (s, ev) =>
        //        {
        //            textBox.Text = dateTimePicker.Value.ToShortDateString();
        //            dateTimePicker.Dispose(); // Dispose the DateTimePicker after use
        //        };

        //        // Show the DateTimePicker control
        //        dateTimePicker.Show();
        //    }
        //}

        internal void SetCommonToolbarButtonsProperties(MaterialButton btn)
        {
            btn.AutoSize = false;
            btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn.Depth = 0;
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            btn.HighEmphasis = true;
            btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn.MouseState = MaterialSkin.MouseState.HOVER;
            btn.NoAccentTextColor = System.Drawing.Color.Empty;
            btn.Size = new System.Drawing.Size(40, 26);
            btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn.UseAccentColor = false;
            btn.UseVisualStyleBackColor = false;
            btn.Text = string.Empty; 
            
        }

        
    }
}
