namespace PresentationLayer
{
    partial class AddProduct
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtPDesc = new MetroFramework.Controls.MetroTextBox();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbPCategory = new MetroFramework.Controls.MetroComboBox();
            this.txtPPRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtPPurchaseU = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPReorder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPSRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pbP = new System.Windows.Forms.PictureBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pnlCategory = new MetroFramework.Controls.MetroPanel();
            this.btnCatRemove = new MetroFramework.Controls.MetroButton();
            this.btnCatInsert = new MetroFramework.Controls.MetroButton();
            this.txtInsertCategory = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).BeginInit();
            this.pnlCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnClose);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.btnNew);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(857, 103);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(179, 249);
            this.metroPanel2.TabIndex = 8;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 183);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 46);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 129);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 46);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 74);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 47);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(22, 20);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 46);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(0, 9);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1067, 91);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Product Entry";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.metroLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.metroLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(688, 272);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 28);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(589, 272);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 28);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // txtPDesc
            // 
            // 
            // 
            // 
            this.txtPDesc.CustomButton.Image = null;
            this.txtPDesc.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.txtPDesc.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDesc.CustomButton.Name = "";
            this.txtPDesc.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txtPDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPDesc.CustomButton.TabIndex = 1;
            this.txtPDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPDesc.CustomButton.UseSelectable = true;
            this.txtPDesc.CustomButton.Visible = false;
            this.txtPDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Description", true));
            this.txtPDesc.Lines = new string[0];
            this.txtPDesc.Location = new System.Drawing.Point(185, 118);
            this.txtPDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDesc.MaxLength = 32767;
            this.txtPDesc.Multiline = true;
            this.txtPDesc.Name = "txtPDesc";
            this.txtPDesc.PasswordChar = '\0';
            this.txtPDesc.PromptText = "Description";
            this.txtPDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPDesc.SelectedText = "";
            this.txtPDesc.SelectionLength = 0;
            this.txtPDesc.SelectionStart = 0;
            this.txtPDesc.ShortcutsEnabled = true;
            this.txtPDesc.Size = new System.Drawing.Size(353, 95);
            this.txtPDesc.TabIndex = 2;
            this.txtPDesc.UseSelectable = true;
            this.txtPDesc.WaterMark = "Description";
            this.txtPDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataSource = typeof(CMS.Data.Product_Details);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(69, 118);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(86, 20);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Description :";
            // 
            // cmbPCategory
            // 
            this.cmbPCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "P_Category", true));
            this.cmbPCategory.FormattingEnabled = true;
            this.cmbPCategory.ItemHeight = 24;
            this.cmbPCategory.Items.AddRange(new object[] {
            "--------------",
            "Software",
            "Motherboard",
            "Accessories",
            "Ram",
            "Processor",
            "Graphics"});
            this.cmbPCategory.Location = new System.Drawing.Point(185, 75);
            this.cmbPCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPCategory.Name = "cmbPCategory";
            this.cmbPCategory.Size = new System.Drawing.Size(183, 30);
            this.cmbPCategory.TabIndex = 1;
            this.cmbPCategory.UseSelectable = true;
            // 
            // txtPPRate
            // 
            // 
            // 
            // 
            this.txtPPRate.CustomButton.Image = null;
            this.txtPPRate.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtPPRate.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPRate.CustomButton.Name = "";
            this.txtPPRate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPPRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPPRate.CustomButton.TabIndex = 1;
            this.txtPPRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPPRate.CustomButton.UseSelectable = true;
            this.txtPPRate.CustomButton.Visible = false;
            this.txtPPRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Purchase_Rate", true));
            this.txtPPRate.Lines = new string[0];
            this.txtPPRate.Location = new System.Drawing.Point(185, 236);
            this.txtPPRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPRate.MaxLength = 32767;
            this.txtPPRate.Name = "txtPPRate";
            this.txtPPRate.PasswordChar = '\0';
            this.txtPPRate.PromptText = "Purchase Rate";
            this.txtPPRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPPRate.SelectedText = "";
            this.txtPPRate.SelectionLength = 0;
            this.txtPPRate.SelectionStart = 0;
            this.txtPPRate.ShortcutsEnabled = true;
            this.txtPPRate.Size = new System.Drawing.Size(167, 28);
            this.txtPPRate.TabIndex = 3;
            this.txtPPRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPPRate.UseSelectable = true;
            this.txtPPRate.WaterMark = "Purchase Rate";
            this.txtPPRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPPRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(40, 236);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 20);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Purchase Rate :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtPPurchaseU);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.txtPStock);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtPReorder);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtPSRate);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.btnRemove);
            this.metroPanel1.Controls.Add(this.btnBrowse);
            this.metroPanel1.Controls.Add(this.pbP);
            this.metroPanel1.Controls.Add(this.txtPDesc);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.cmbPCategory);
            this.metroPanel1.Controls.Add(this.txtPPRate);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtPName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtPID);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(16, 103);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(833, 442);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // txtPPurchaseU
            // 
            // 
            // 
            // 
            this.txtPPurchaseU.CustomButton.Image = null;
            this.txtPPurchaseU.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtPPurchaseU.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPurchaseU.CustomButton.Name = "";
            this.txtPPurchaseU.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPPurchaseU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPPurchaseU.CustomButton.TabIndex = 1;
            this.txtPPurchaseU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPPurchaseU.CustomButton.UseSelectable = true;
            this.txtPPurchaseU.CustomButton.Visible = false;
            this.txtPPurchaseU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Purchase_Unit", true));
            this.txtPPurchaseU.Lines = new string[0];
            this.txtPPurchaseU.Location = new System.Drawing.Point(185, 343);
            this.txtPPurchaseU.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPurchaseU.MaxLength = 32767;
            this.txtPPurchaseU.Name = "txtPPurchaseU";
            this.txtPPurchaseU.PasswordChar = '\0';
            this.txtPPurchaseU.PromptText = "Purchase Unit";
            this.txtPPurchaseU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPPurchaseU.SelectedText = "";
            this.txtPPurchaseU.SelectionLength = 0;
            this.txtPPurchaseU.SelectionStart = 0;
            this.txtPPurchaseU.ShortcutsEnabled = true;
            this.txtPPurchaseU.Size = new System.Drawing.Size(167, 28);
            this.txtPPurchaseU.TabIndex = 6;
            this.txtPPurchaseU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPPurchaseU.UseSelectable = true;
            this.txtPPurchaseU.WaterMark = "Purchase Unit";
            this.txtPPurchaseU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPPurchaseU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(40, 343);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 20);
            this.metroLabel8.TabIndex = 31;
            this.metroLabel8.Text = "Purchase Unit :";
            // 
            // txtPStock
            // 
            // 
            // 
            // 
            this.txtPStock.CustomButton.Image = null;
            this.txtPStock.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtPStock.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPStock.CustomButton.Name = "";
            this.txtPStock.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPStock.CustomButton.TabIndex = 1;
            this.txtPStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPStock.CustomButton.UseSelectable = true;
            this.txtPStock.CustomButton.Visible = false;
            this.txtPStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Stock", true));
            this.txtPStock.Lines = new string[0];
            this.txtPStock.Location = new System.Drawing.Point(185, 379);
            this.txtPStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtPStock.MaxLength = 32767;
            this.txtPStock.Name = "txtPStock";
            this.txtPStock.PasswordChar = '\0';
            this.txtPStock.PromptText = "Stock";
            this.txtPStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPStock.SelectedText = "";
            this.txtPStock.SelectionLength = 0;
            this.txtPStock.SelectionStart = 0;
            this.txtPStock.ShortcutsEnabled = true;
            this.txtPStock.Size = new System.Drawing.Size(167, 28);
            this.txtPStock.TabIndex = 7;
            this.txtPStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPStock.UseSelectable = true;
            this.txtPStock.WaterMark = "Stock";
            this.txtPStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(104, 379);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 20);
            this.metroLabel7.TabIndex = 29;
            this.metroLabel7.Text = "Stock :";
            // 
            // txtPReorder
            // 
            // 
            // 
            // 
            this.txtPReorder.CustomButton.Image = null;
            this.txtPReorder.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtPReorder.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPReorder.CustomButton.Name = "";
            this.txtPReorder.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPReorder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPReorder.CustomButton.TabIndex = 1;
            this.txtPReorder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPReorder.CustomButton.UseSelectable = true;
            this.txtPReorder.CustomButton.Visible = false;
            this.txtPReorder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Reorder_Point", true));
            this.txtPReorder.Lines = new string[0];
            this.txtPReorder.Location = new System.Drawing.Point(185, 308);
            this.txtPReorder.Margin = new System.Windows.Forms.Padding(4);
            this.txtPReorder.MaxLength = 32767;
            this.txtPReorder.Name = "txtPReorder";
            this.txtPReorder.PasswordChar = '\0';
            this.txtPReorder.PromptText = "Reorder Point";
            this.txtPReorder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPReorder.SelectedText = "";
            this.txtPReorder.SelectionLength = 0;
            this.txtPReorder.SelectionStart = 0;
            this.txtPReorder.ShortcutsEnabled = true;
            this.txtPReorder.Size = new System.Drawing.Size(167, 28);
            this.txtPReorder.TabIndex = 5;
            this.txtPReorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPReorder.UseSelectable = true;
            this.txtPReorder.WaterMark = "Reorder Point";
            this.txtPReorder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPReorder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(40, 308);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 20);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Reorder Point :";
            // 
            // txtPSRate
            // 
            // 
            // 
            // 
            this.txtPSRate.CustomButton.Image = null;
            this.txtPSRate.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtPSRate.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPSRate.CustomButton.Name = "";
            this.txtPSRate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPSRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPSRate.CustomButton.TabIndex = 1;
            this.txtPSRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPSRate.CustomButton.UseSelectable = true;
            this.txtPSRate.CustomButton.Visible = false;
            this.txtPSRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "Sales_Rate", true));
            this.txtPSRate.Lines = new string[0];
            this.txtPSRate.Location = new System.Drawing.Point(185, 272);
            this.txtPSRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPSRate.MaxLength = 32767;
            this.txtPSRate.Name = "txtPSRate";
            this.txtPSRate.PasswordChar = '\0';
            this.txtPSRate.PromptText = "Sales Rate";
            this.txtPSRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPSRate.SelectedText = "";
            this.txtPSRate.SelectionLength = 0;
            this.txtPSRate.SelectionStart = 0;
            this.txtPSRate.ShortcutsEnabled = true;
            this.txtPSRate.Size = new System.Drawing.Size(167, 28);
            this.txtPSRate.TabIndex = 4;
            this.txtPSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPSRate.UseSelectable = true;
            this.txtPSRate.WaterMark = "Sales Rate";
            this.txtPSRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPSRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(67, 272);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Sales Rate :";
            // 
            // pbP
            // 
            this.pbP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbP.Location = new System.Drawing.Point(589, 75);
            this.pbP.Margin = new System.Windows.Forms.Padding(4);
            this.pbP.Name = "pbP";
            this.pbP.Size = new System.Drawing.Size(193, 190);
            this.pbP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbP.TabIndex = 22;
            this.pbP.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(83, 75);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Category :";
            // 
            // txtPName
            // 
            // 
            // 
            // 
            this.txtPName.CustomButton.Image = null;
            this.txtPName.CustomButton.Location = new System.Drawing.Point(295, 2);
            this.txtPName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.CustomButton.Name = "";
            this.txtPName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPName.CustomButton.TabIndex = 1;
            this.txtPName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPName.CustomButton.UseSelectable = true;
            this.txtPName.CustomButton.Visible = false;
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "P_Name", true));
            this.txtPName.Lines = new string[0];
            this.txtPName.Location = new System.Drawing.Point(185, 39);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.MaxLength = 32767;
            this.txtPName.Name = "txtPName";
            this.txtPName.PasswordChar = '\0';
            this.txtPName.PromptText = "Product Name";
            this.txtPName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPName.SelectedText = "";
            this.txtPName.SelectionLength = 0;
            this.txtPName.SelectionStart = 0;
            this.txtPName.ShortcutsEnabled = true;
            this.txtPName.Size = new System.Drawing.Size(321, 28);
            this.txtPName.TabIndex = 0;
            this.txtPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPName.UseSelectable = true;
            this.txtPName.WaterMark = "Product Name";
            this.txtPName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(29, 39);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(148, 23);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Product Name :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPID
            // 
            // 
            // 
            // 
            this.txtPID.CustomButton.Image = null;
            this.txtPID.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.txtPID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPID.CustomButton.Name = "";
            this.txtPID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPID.CustomButton.TabIndex = 1;
            this.txtPID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPID.CustomButton.UseSelectable = true;
            this.txtPID.CustomButton.Visible = false;
            this.txtPID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productDetailsBindingSource, "P_ID", true));
            this.txtPID.Lines = new string[0];
            this.txtPID.Location = new System.Drawing.Point(185, 4);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPID.MaxLength = 32767;
            this.txtPID.Name = "txtPID";
            this.txtPID.PasswordChar = '\0';
            this.txtPID.PromptText = "Auto Generated";
            this.txtPID.ReadOnly = true;
            this.txtPID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPID.SelectedText = "";
            this.txtPID.SelectionLength = 0;
            this.txtPID.SelectionStart = 0;
            this.txtPID.ShortcutsEnabled = true;
            this.txtPID.Size = new System.Drawing.Size(184, 28);
            this.txtPID.TabIndex = 30;
            this.txtPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPID.UseSelectable = true;
            this.txtPID.WaterMark = "Auto Generated";
            this.txtPID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(29, 4);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 28);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Product ID :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnCatRemove);
            this.pnlCategory.Controls.Add(this.btnCatInsert);
            this.pnlCategory.Controls.Add(this.txtInsertCategory);
            this.pnlCategory.HorizontalScrollbarBarColor = true;
            this.pnlCategory.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCategory.HorizontalScrollbarSize = 10;
            this.pnlCategory.Location = new System.Drawing.Point(857, 360);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(180, 185);
            this.pnlCategory.TabIndex = 10;
            this.pnlCategory.VerticalScrollbarBarColor = true;
            this.pnlCategory.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCategory.VerticalScrollbarSize = 10;
            // 
            // btnCatRemove
            // 
            this.btnCatRemove.Location = new System.Drawing.Point(22, 122);
            this.btnCatRemove.Name = "btnCatRemove";
            this.btnCatRemove.Size = new System.Drawing.Size(140, 34);
            this.btnCatRemove.TabIndex = 4;
            this.btnCatRemove.Text = "Remove";
            this.btnCatRemove.UseSelectable = true;
            this.btnCatRemove.Click += new System.EventHandler(this.btnCatRemove_Click);
            // 
            // btnCatInsert
            // 
            this.btnCatInsert.Location = new System.Drawing.Point(21, 86);
            this.btnCatInsert.Name = "btnCatInsert";
            this.btnCatInsert.Size = new System.Drawing.Size(140, 28);
            this.btnCatInsert.TabIndex = 3;
            this.btnCatInsert.Text = "Add";
            this.btnCatInsert.UseSelectable = true;
            this.btnCatInsert.Click += new System.EventHandler(this.btnCatInsert_Click);
            // 
            // txtInsertCategory
            // 
            // 
            // 
            // 
            this.txtInsertCategory.CustomButton.Image = null;
            this.txtInsertCategory.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtInsertCategory.CustomButton.Name = "";
            this.txtInsertCategory.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtInsertCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInsertCategory.CustomButton.TabIndex = 1;
            this.txtInsertCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInsertCategory.CustomButton.UseSelectable = true;
            this.txtInsertCategory.CustomButton.Visible = false;
            this.txtInsertCategory.Lines = new string[0];
            this.txtInsertCategory.Location = new System.Drawing.Point(22, 36);
            this.txtInsertCategory.MaxLength = 32767;
            this.txtInsertCategory.Multiline = true;
            this.txtInsertCategory.Name = "txtInsertCategory";
            this.txtInsertCategory.PasswordChar = '\0';
            this.txtInsertCategory.PromptText = "Insert new Category";
            this.txtInsertCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInsertCategory.SelectedText = "";
            this.txtInsertCategory.SelectionLength = 0;
            this.txtInsertCategory.SelectionStart = 0;
            this.txtInsertCategory.ShortcutsEnabled = true;
            this.txtInsertCategory.Size = new System.Drawing.Size(140, 31);
            this.txtInsertCategory.TabIndex = 2;
            this.txtInsertCategory.UseSelectable = true;
            this.txtInsertCategory.WaterMark = "Insert new Category";
            this.txtInsertCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInsertCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbP)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbP;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtPDesc;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbPCategory;
        private MetroFramework.Controls.MetroTextBox txtPPRate;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtPPurchaseU;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPStock;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtPReorder;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPSRate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel pnlCategory;
        private MetroFramework.Controls.MetroTextBox txtInsertCategory;
        private MetroFramework.Controls.MetroButton btnCatInsert;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private MetroFramework.Controls.MetroButton btnCatRemove;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}