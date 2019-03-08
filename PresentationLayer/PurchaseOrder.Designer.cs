namespace PresentationLayer
{
    partial class PurchaseOrder
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPoID = new MetroFramework.Controls.MetroTextBox();
            this.productOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.lblFinal = new MetroFramework.Controls.MetroLabel();
            this.lblDiscont = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtPDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtPPriceUnit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtPQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtPName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.txtSupMobile = new MetroFramework.Controls.MetroTextBox();
            this.txtSupAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtSupName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSupId = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.datePo = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(4, 89);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 28);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "PO Date :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPoID
            // 
            // 
            // 
            // 
            this.txtPoID.CustomButton.Image = null;
            this.txtPoID.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.txtPoID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoID.CustomButton.Name = "";
            this.txtPoID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPoID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPoID.CustomButton.TabIndex = 1;
            this.txtPoID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPoID.CustomButton.UseSelectable = true;
            this.txtPoID.CustomButton.Visible = false;
            this.txtPoID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "PONo", true));
            this.txtPoID.Lines = new string[] {
        "Auto Genatrate"};
            this.txtPoID.Location = new System.Drawing.Point(112, 53);
            this.txtPoID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoID.MaxLength = 32767;
            this.txtPoID.Name = "txtPoID";
            this.txtPoID.PasswordChar = '\0';
            this.txtPoID.ReadOnly = true;
            this.txtPoID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPoID.SelectedText = "";
            this.txtPoID.SelectionLength = 0;
            this.txtPoID.SelectionStart = 0;
            this.txtPoID.ShortcutsEnabled = true;
            this.txtPoID.Size = new System.Drawing.Size(184, 28);
            this.txtPoID.TabIndex = 3;
            this.txtPoID.TabStop = false;
            this.txtPoID.Text = "Auto Genatrate";
            this.txtPoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoID.UseSelectable = true;
            this.txtPoID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPoID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productOrderBindingSource
            // 
            this.productOrderBindingSource.DataSource = typeof(CMS.Data.Product_Order);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(17, 53);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 28);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "PO No :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1067, 91);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Purchase Order";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(16, 103);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(833, 443);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.lblFinal);
            this.metroPanel5.Controls.Add(this.lblDiscont);
            this.metroPanel5.Controls.Add(this.lblTotal);
            this.metroPanel5.Controls.Add(this.metroLabel15);
            this.metroPanel5.Controls.Add(this.txtPDiscount);
            this.metroPanel5.Controls.Add(this.metroLabel14);
            this.metroPanel5.Controls.Add(this.txtPPriceUnit);
            this.metroPanel5.Controls.Add(this.metroLabel13);
            this.metroPanel5.Controls.Add(this.txtPQuantity);
            this.metroPanel5.Controls.Add(this.metroLabel12);
            this.metroPanel5.Controls.Add(this.txtPName);
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 12;
            this.metroPanel5.Location = new System.Drawing.Point(5, 202);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(824, 238);
            this.metroPanel5.TabIndex = 36;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 13;
            // 
            // lblFinal
            // 
            this.lblFinal.Location = new System.Drawing.Point(524, 146);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(160, 23);
            this.lblFinal.TabIndex = 49;
            this.lblFinal.Text = "Final :";
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiscont
            // 
            this.lblDiscont.Location = new System.Drawing.Point(524, 111);
            this.lblDiscont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscont.Name = "lblDiscont";
            this.lblDiscont.Size = new System.Drawing.Size(160, 23);
            this.lblDiscont.TabIndex = 48;
            this.lblDiscont.Text = "Discount :";
            this.lblDiscont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(524, 75);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(160, 23);
            this.lblTotal.TabIndex = 47;
            this.lblTotal.Text = "Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Location = new System.Drawing.Point(16, 177);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(160, 23);
            this.metroLabel15.TabIndex = 46;
            this.metroLabel15.Text = "Discount :";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPDiscount
            // 
            // 
            // 
            // 
            this.txtPDiscount.CustomButton.Image = null;
            this.txtPDiscount.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtPDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDiscount.CustomButton.Name = "";
            this.txtPDiscount.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPDiscount.CustomButton.TabIndex = 1;
            this.txtPDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPDiscount.CustomButton.UseSelectable = true;
            this.txtPDiscount.CustomButton.Visible = false;
            this.txtPDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "Discount", true));
            this.txtPDiscount.Lines = new string[0];
            this.txtPDiscount.Location = new System.Drawing.Point(184, 177);
            this.txtPDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDiscount.MaxLength = 32767;
            this.txtPDiscount.Name = "txtPDiscount";
            this.txtPDiscount.PasswordChar = '\0';
            this.txtPDiscount.PromptText = "In %";
            this.txtPDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPDiscount.SelectedText = "";
            this.txtPDiscount.SelectionLength = 0;
            this.txtPDiscount.SelectionStart = 0;
            this.txtPDiscount.ShortcutsEnabled = true;
            this.txtPDiscount.Size = new System.Drawing.Size(271, 28);
            this.txtPDiscount.TabIndex = 45;
            this.txtPDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPDiscount.UseSelectable = true;
            this.txtPDiscount.WaterMark = "In %";
            this.txtPDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPDiscount.TextChanged += new System.EventHandler(this.txtPDiscount_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.Location = new System.Drawing.Point(16, 142);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(160, 23);
            this.metroLabel14.TabIndex = 44;
            this.metroLabel14.Text = "Price Per Unit :";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPPriceUnit
            // 
            // 
            // 
            // 
            this.txtPPriceUnit.CustomButton.Image = null;
            this.txtPPriceUnit.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtPPriceUnit.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPriceUnit.CustomButton.Name = "";
            this.txtPPriceUnit.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPPriceUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPPriceUnit.CustomButton.TabIndex = 1;
            this.txtPPriceUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPPriceUnit.CustomButton.UseSelectable = true;
            this.txtPPriceUnit.CustomButton.Visible = false;
            this.txtPPriceUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "PPU", true));
            this.txtPPriceUnit.Lines = new string[0];
            this.txtPPriceUnit.Location = new System.Drawing.Point(184, 142);
            this.txtPPriceUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPriceUnit.MaxLength = 32767;
            this.txtPPriceUnit.Name = "txtPPriceUnit";
            this.txtPPriceUnit.PasswordChar = '\0';
            this.txtPPriceUnit.PromptText = "Unit Price";
            this.txtPPriceUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPPriceUnit.SelectedText = "";
            this.txtPPriceUnit.SelectionLength = 0;
            this.txtPPriceUnit.SelectionStart = 0;
            this.txtPPriceUnit.ShortcutsEnabled = true;
            this.txtPPriceUnit.Size = new System.Drawing.Size(271, 28);
            this.txtPPriceUnit.TabIndex = 43;
            this.txtPPriceUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPPriceUnit.UseSelectable = true;
            this.txtPPriceUnit.WaterMark = "Unit Price";
            this.txtPPriceUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPPriceUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPPriceUnit.TextChanged += new System.EventHandler(this.txtPPriceUnit_TextChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.Location = new System.Drawing.Point(29, 106);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(147, 23);
            this.metroLabel13.TabIndex = 42;
            this.metroLabel13.Text = "Quantity :";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPQuantity
            // 
            // 
            // 
            // 
            this.txtPQuantity.CustomButton.Image = null;
            this.txtPQuantity.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtPQuantity.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPQuantity.CustomButton.Name = "";
            this.txtPQuantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPQuantity.CustomButton.TabIndex = 1;
            this.txtPQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPQuantity.CustomButton.UseSelectable = true;
            this.txtPQuantity.CustomButton.Visible = false;
            this.txtPQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "Quabtity", true));
            this.txtPQuantity.Lines = new string[0];
            this.txtPQuantity.Location = new System.Drawing.Point(184, 106);
            this.txtPQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtPQuantity.MaxLength = 32767;
            this.txtPQuantity.Name = "txtPQuantity";
            this.txtPQuantity.PasswordChar = '\0';
            this.txtPQuantity.PromptText = "Quantity";
            this.txtPQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPQuantity.SelectedText = "";
            this.txtPQuantity.SelectionLength = 0;
            this.txtPQuantity.SelectionStart = 0;
            this.txtPQuantity.ShortcutsEnabled = true;
            this.txtPQuantity.Size = new System.Drawing.Size(271, 28);
            this.txtPQuantity.TabIndex = 41;
            this.txtPQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPQuantity.UseSelectable = true;
            this.txtPQuantity.WaterMark = "Quantity";
            this.txtPQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.Location = new System.Drawing.Point(16, 70);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(160, 23);
            this.metroLabel12.TabIndex = 40;
            this.metroLabel12.Text = "Product Name :";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPName
            // 
            // 
            // 
            // 
            this.txtPName.CustomButton.Image = null;
            this.txtPName.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtPName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.CustomButton.Name = "";
            this.txtPName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPName.CustomButton.TabIndex = 1;
            this.txtPName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPName.CustomButton.UseSelectable = true;
            this.txtPName.CustomButton.Visible = false;
            this.txtPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "PName", true));
            this.txtPName.Lines = new string[0];
            this.txtPName.Location = new System.Drawing.Point(184, 70);
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
            this.txtPName.Size = new System.Drawing.Size(271, 28);
            this.txtPName.TabIndex = 39;
            this.txtPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPName.UseSelectable = true;
            this.txtPName.WaterMark = "Product Name";
            this.txtPName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel7.Location = new System.Drawing.Point(0, 0);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(824, 28);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Product Info";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.txtSupMobile);
            this.metroPanel4.Controls.Add(this.txtSupAddress);
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.Controls.Add(this.txtSupName);
            this.metroPanel4.Controls.Add(this.metroLabel11);
            this.metroPanel4.Controls.Add(this.cmbSupId);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(383, 5);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(447, 188);
            this.metroPanel4.TabIndex = 35;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            // 
            // txtSupMobile
            // 
            // 
            // 
            // 
            this.txtSupMobile.CustomButton.Image = null;
            this.txtSupMobile.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtSupMobile.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupMobile.CustomButton.Name = "";
            this.txtSupMobile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSupMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupMobile.CustomButton.TabIndex = 1;
            this.txtSupMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupMobile.CustomButton.UseSelectable = true;
            this.txtSupMobile.CustomButton.Visible = false;
            this.txtSupMobile.Lines = new string[] {
        "Auto Genatrate"};
            this.txtSupMobile.Location = new System.Drawing.Point(172, 144);
            this.txtSupMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupMobile.MaxLength = 32767;
            this.txtSupMobile.Name = "txtSupMobile";
            this.txtSupMobile.PasswordChar = '\0';
            this.txtSupMobile.ReadOnly = true;
            this.txtSupMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupMobile.SelectedText = "";
            this.txtSupMobile.SelectionLength = 0;
            this.txtSupMobile.SelectionStart = 0;
            this.txtSupMobile.ShortcutsEnabled = true;
            this.txtSupMobile.Size = new System.Drawing.Size(211, 28);
            this.txtSupMobile.TabIndex = 42;
            this.txtSupMobile.Text = "Auto Genatrate";
            this.txtSupMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupMobile.UseSelectable = true;
            this.txtSupMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSupAddress
            // 
            // 
            // 
            // 
            this.txtSupAddress.CustomButton.Image = null;
            this.txtSupAddress.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtSupAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupAddress.CustomButton.Name = "";
            this.txtSupAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSupAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupAddress.CustomButton.TabIndex = 1;
            this.txtSupAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupAddress.CustomButton.UseSelectable = true;
            this.txtSupAddress.CustomButton.Visible = false;
            this.txtSupAddress.Lines = new string[] {
        "Auto Genatrate"};
            this.txtSupAddress.Location = new System.Drawing.Point(172, 108);
            this.txtSupAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupAddress.MaxLength = 32767;
            this.txtSupAddress.Name = "txtSupAddress";
            this.txtSupAddress.PasswordChar = '\0';
            this.txtSupAddress.ReadOnly = true;
            this.txtSupAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupAddress.SelectedText = "";
            this.txtSupAddress.SelectionLength = 0;
            this.txtSupAddress.SelectionStart = 0;
            this.txtSupAddress.ShortcutsEnabled = true;
            this.txtSupAddress.Size = new System.Drawing.Size(271, 28);
            this.txtSupAddress.TabIndex = 41;
            this.txtSupAddress.Text = "Auto Genatrate";
            this.txtSupAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupAddress.UseSelectable = true;
            this.txtSupAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(53, 142);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 20);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Contact No :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Location = new System.Drawing.Point(4, 73);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(160, 23);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Suppiler Name :";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupName
            // 
            // 
            // 
            // 
            this.txtSupName.CustomButton.Image = null;
            this.txtSupName.CustomButton.Location = new System.Drawing.Point(245, 2);
            this.txtSupName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupName.CustomButton.Name = "";
            this.txtSupName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSupName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupName.CustomButton.TabIndex = 1;
            this.txtSupName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupName.CustomButton.UseSelectable = true;
            this.txtSupName.CustomButton.Visible = false;
            this.txtSupName.Lines = new string[] {
        "Auto Genatrate"};
            this.txtSupName.Location = new System.Drawing.Point(172, 73);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupName.MaxLength = 32767;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.PasswordChar = '\0';
            this.txtSupName.ReadOnly = true;
            this.txtSupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupName.SelectedText = "";
            this.txtSupName.SelectionLength = 0;
            this.txtSupName.SelectionStart = 0;
            this.txtSupName.ShortcutsEnabled = true;
            this.txtSupName.Size = new System.Drawing.Size(271, 28);
            this.txtSupName.TabIndex = 37;
            this.txtSupName.Text = "Auto Genatrate";
            this.txtSupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupName.UseSelectable = true;
            this.txtSupName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.Location = new System.Drawing.Point(47, 108);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(116, 28);
            this.metroLabel11.TabIndex = 36;
            this.metroLabel11.Text = "Address :";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSupId
            // 
            this.cmbSupId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "SupplierId", true));
            this.cmbSupId.FormattingEnabled = true;
            this.cmbSupId.ItemHeight = 24;
            this.cmbSupId.Location = new System.Drawing.Point(172, 30);
            this.cmbSupId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupId.Name = "cmbSupId";
            this.cmbSupId.Size = new System.Drawing.Size(196, 30);
            this.cmbSupId.TabIndex = 35;
            this.cmbSupId.UseSelectable = true;
            this.cmbSupId.TextChanged += new System.EventHandler(this.cmbSupId_TextChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(447, 28);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Supplier Info";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Location = new System.Drawing.Point(47, 30);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(116, 28);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Supplier ID :";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.datePo);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.txtPoID);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(5, 5);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(369, 188);
            this.metroPanel3.TabIndex = 34;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // datePo
            // 
            this.datePo.CustomFormat = "dd-MM-yyyy";
            this.datePo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productOrderBindingSource, "PODate", true));
            this.datePo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePo.Location = new System.Drawing.Point(112, 94);
            this.datePo.Name = "datePo";
            this.datePo.Size = new System.Drawing.Size(200, 22);
            this.datePo.TabIndex = 35;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(369, 28);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Invoice Info";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnClose);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.btnNew);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(867, 108);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(179, 442);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 93);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 116);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 97);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(21, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 90);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(21, 13);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 90);
            this.btnNew.TabIndex = 24;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseOrder";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productOrderBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPoID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox cmbSupId;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtPPriceUnit;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtPQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtPName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSupMobile;
        private MetroFramework.Controls.MetroTextBox txtSupAddress;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtSupName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtPDiscount;
        private MetroFramework.Controls.MetroLabel lblFinal;
        private MetroFramework.Controls.MetroLabel lblDiscont;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnNew;
        private System.Windows.Forms.DateTimePicker datePo;
        private System.Windows.Forms.BindingSource productOrderBindingSource;
    }
}