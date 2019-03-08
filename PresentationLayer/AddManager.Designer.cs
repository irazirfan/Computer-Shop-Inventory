namespace PresentationLayer
{
    partial class AddManager
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtMRemarks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbMCity = new MetroFramework.Controls.MetroComboBox();
            this.txtMCommission = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMMobile = new MetroFramework.Controls.MetroTextBox();
            this.txtMPostalCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtMAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pbM = new System.Windows.Forms.PictureBox();
            this.managerdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 93);
            this.btnClose.TabIndex = 12;
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
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(21, 13);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(140, 90);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(709, 220);
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
            this.btnBrowse.Location = new System.Drawing.Point(607, 220);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 28);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtMRemarks
            // 
            // 
            // 
            // 
            this.txtMRemarks.CustomButton.Image = null;
            this.txtMRemarks.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.txtMRemarks.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMRemarks.CustomButton.Name = "";
            this.txtMRemarks.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtMRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMRemarks.CustomButton.TabIndex = 1;
            this.txtMRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMRemarks.CustomButton.UseSelectable = true;
            this.txtMRemarks.CustomButton.Visible = false;
            this.txtMRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Remarks", true));
            this.txtMRemarks.Lines = new string[0];
            this.txtMRemarks.Location = new System.Drawing.Point(185, 320);
            this.txtMRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtMRemarks.MaxLength = 32767;
            this.txtMRemarks.Multiline = true;
            this.txtMRemarks.Name = "txtMRemarks";
            this.txtMRemarks.PasswordChar = '\0';
            this.txtMRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMRemarks.SelectedText = "";
            this.txtMRemarks.SelectionLength = 0;
            this.txtMRemarks.SelectionStart = 0;
            this.txtMRemarks.ShortcutsEnabled = true;
            this.txtMRemarks.Size = new System.Drawing.Size(353, 76);
            this.txtMRemarks.TabIndex = 7;
            this.txtMRemarks.UseSelectable = true;
            this.txtMRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(92, 320);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(69, 20);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Remarks :";
            // 
            // cmbMCity
            // 
            this.cmbMCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "City", true));
            this.cmbMCity.FormattingEnabled = true;
            this.cmbMCity.ItemHeight = 24;
            this.cmbMCity.Location = new System.Drawing.Point(185, 111);
            this.cmbMCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMCity.Name = "cmbMCity";
            this.cmbMCity.Size = new System.Drawing.Size(183, 30);
            this.cmbMCity.TabIndex = 2;
            this.cmbMCity.UseSelectable = true;
            // 
            // txtMCommission
            // 
            // 
            // 
            // 
            this.txtMCommission.CustomButton.Image = null;
            this.txtMCommission.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtMCommission.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCommission.CustomButton.Name = "";
            this.txtMCommission.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMCommission.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMCommission.CustomButton.TabIndex = 1;
            this.txtMCommission.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMCommission.CustomButton.UseSelectable = true;
            this.txtMCommission.CustomButton.Visible = false;
            this.txtMCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Commission", true));
            this.txtMCommission.Lines = new string[0];
            this.txtMCommission.Location = new System.Drawing.Point(185, 266);
            this.txtMCommission.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCommission.MaxLength = 32767;
            this.txtMCommission.Name = "txtMCommission";
            this.txtMCommission.PasswordChar = '\0';
            this.txtMCommission.PromptText = "In %";
            this.txtMCommission.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMCommission.SelectedText = "";
            this.txtMCommission.SelectionLength = 0;
            this.txtMCommission.SelectionStart = 0;
            this.txtMCommission.ShortcutsEnabled = true;
            this.txtMCommission.Size = new System.Drawing.Size(167, 28);
            this.txtMCommission.TabIndex = 6;
            this.txtMCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMCommission.UseSelectable = true;
            this.txtMCommission.WaterMark = "In %";
            this.txtMCommission.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMCommission.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(40, 266);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 20);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Commission % :";
            // 
            // txtMEmail
            // 
            // 
            // 
            // 
            this.txtMEmail.CustomButton.Image = null;
            this.txtMEmail.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.txtMEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMEmail.CustomButton.Name = "";
            this.txtMEmail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMEmail.CustomButton.TabIndex = 1;
            this.txtMEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMEmail.CustomButton.UseSelectable = true;
            this.txtMEmail.CustomButton.Visible = false;
            this.txtMEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Email", true));
            this.txtMEmail.Lines = new string[0];
            this.txtMEmail.Location = new System.Drawing.Point(185, 225);
            this.txtMEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMEmail.MaxLength = 32767;
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.PasswordChar = '\0';
            this.txtMEmail.PromptText = "example@mail.com";
            this.txtMEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMEmail.SelectedText = "";
            this.txtMEmail.SelectionLength = 0;
            this.txtMEmail.SelectionStart = 0;
            this.txtMEmail.ShortcutsEnabled = true;
            this.txtMEmail.Size = new System.Drawing.Size(265, 28);
            this.txtMEmail.TabIndex = 5;
            this.txtMEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMEmail.UseSelectable = true;
            this.txtMEmail.WaterMark = "example@mail.com";
            this.txtMEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(92, 225);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 20);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Email ID :";
            // 
            // txtMMobile
            // 
            // 
            // 
            // 
            this.txtMMobile.CustomButton.Image = null;
            this.txtMMobile.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.txtMMobile.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMMobile.CustomButton.Name = "";
            this.txtMMobile.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMMobile.CustomButton.TabIndex = 1;
            this.txtMMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMMobile.CustomButton.UseSelectable = true;
            this.txtMMobile.CustomButton.Visible = false;
            this.txtMMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Contact", true));
            this.txtMMobile.Lines = new string[0];
            this.txtMMobile.Location = new System.Drawing.Point(185, 190);
            this.txtMMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMMobile.MaxLength = 32767;
            this.txtMMobile.Name = "txtMMobile";
            this.txtMMobile.PasswordChar = '\0';
            this.txtMMobile.PromptText = "Mobile No or phone No";
            this.txtMMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMMobile.SelectedText = "";
            this.txtMMobile.SelectionLength = 0;
            this.txtMMobile.SelectionStart = 0;
            this.txtMMobile.ShortcutsEnabled = true;
            this.txtMMobile.Size = new System.Drawing.Size(265, 28);
            this.txtMMobile.TabIndex = 4;
            this.txtMMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMMobile.UseSelectable = true;
            this.txtMMobile.WaterMark = "Mobile No or phone No";
            this.txtMMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMPostalCode
            // 
            // 
            // 
            // 
            this.txtMPostalCode.CustomButton.Image = null;
            this.txtMPostalCode.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.txtMPostalCode.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPostalCode.CustomButton.Name = "";
            this.txtMPostalCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMPostalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMPostalCode.CustomButton.TabIndex = 1;
            this.txtMPostalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMPostalCode.CustomButton.UseSelectable = true;
            this.txtMPostalCode.CustomButton.Visible = false;
            this.txtMPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Postal_code", true));
            this.txtMPostalCode.Lines = new string[0];
            this.txtMPostalCode.Location = new System.Drawing.Point(185, 154);
            this.txtMPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMPostalCode.MaxLength = 32767;
            this.txtMPostalCode.Name = "txtMPostalCode";
            this.txtMPostalCode.PasswordChar = '\0';
            this.txtMPostalCode.PromptText = "Postal code";
            this.txtMPostalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMPostalCode.SelectedText = "";
            this.txtMPostalCode.SelectionLength = 0;
            this.txtMPostalCode.SelectionStart = 0;
            this.txtMPostalCode.ShortcutsEnabled = true;
            this.txtMPostalCode.Size = new System.Drawing.Size(184, 28);
            this.txtMPostalCode.TabIndex = 3;
            this.txtMPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMPostalCode.UseSelectable = true;
            this.txtMPostalCode.WaterMark = "Postal code";
            this.txtMPostalCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMPostalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(63, 154);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 20);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Postal Code :";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(127, 111);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 20);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "City :";
            // 
            // txtMAddress
            // 
            // 
            // 
            // 
            this.txtMAddress.CustomButton.Image = null;
            this.txtMAddress.CustomButton.Location = new System.Drawing.Point(338, 2);
            this.txtMAddress.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAddress.CustomButton.Name = "";
            this.txtMAddress.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMAddress.CustomButton.TabIndex = 1;
            this.txtMAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMAddress.CustomButton.UseSelectable = true;
            this.txtMAddress.CustomButton.Visible = false;
            this.txtMAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "Address", true));
            this.txtMAddress.Lines = new string[0];
            this.txtMAddress.Location = new System.Drawing.Point(185, 75);
            this.txtMAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAddress.MaxLength = 32767;
            this.txtMAddress.Name = "txtMAddress";
            this.txtMAddress.PasswordChar = '\0';
            this.txtMAddress.PromptText = "Address";
            this.txtMAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMAddress.SelectedText = "";
            this.txtMAddress.SelectionLength = 0;
            this.txtMAddress.SelectionStart = 0;
            this.txtMAddress.ShortcutsEnabled = true;
            this.txtMAddress.Size = new System.Drawing.Size(364, 28);
            this.txtMAddress.TabIndex = 1;
            this.txtMAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMAddress.UseSelectable = true;
            this.txtMAddress.WaterMark = "Address";
            this.txtMAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(29, 75);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 23);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Address :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMName
            // 
            // 
            // 
            // 
            this.txtMName.CustomButton.Image = null;
            this.txtMName.CustomButton.Location = new System.Drawing.Point(295, 2);
            this.txtMName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.CustomButton.Name = "";
            this.txtMName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMName.CustomButton.TabIndex = 1;
            this.txtMName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMName.CustomButton.UseSelectable = true;
            this.txtMName.CustomButton.Visible = false;
            this.txtMName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "MName", true));
            this.txtMName.Lines = new string[0];
            this.txtMName.Location = new System.Drawing.Point(185, 39);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.MaxLength = 32767;
            this.txtMName.Name = "txtMName";
            this.txtMName.PasswordChar = '\0';
            this.txtMName.PromptText = "Manager Name";
            this.txtMName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMName.SelectedText = "";
            this.txtMName.SelectionLength = 0;
            this.txtMName.SelectionStart = 0;
            this.txtMName.ShortcutsEnabled = true;
            this.txtMName.Size = new System.Drawing.Size(321, 28);
            this.txtMName.TabIndex = 0;
            this.txtMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMName.UseSelectable = true;
            this.txtMName.WaterMark = "Manager Name";
            this.txtMName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(29, 39);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(148, 23);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Manager Name :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMID
            // 
            // 
            // 
            // 
            this.txtMID.CustomButton.Image = null;
            this.txtMID.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.txtMID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMID.CustomButton.Name = "";
            this.txtMID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMID.CustomButton.TabIndex = 1;
            this.txtMID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMID.CustomButton.UseSelectable = true;
            this.txtMID.CustomButton.Visible = false;
            this.txtMID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerdetailsBindingSource, "MId", true));
            this.txtMID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMID.Lines = new string[0];
            this.txtMID.Location = new System.Drawing.Point(185, 4);
            this.txtMID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMID.MaxLength = 32767;
            this.txtMID.Name = "txtMID";
            this.txtMID.PasswordChar = '\0';
            this.txtMID.PromptText = "Auto Generated";
            this.txtMID.ReadOnly = true;
            this.txtMID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMID.SelectedText = "";
            this.txtMID.SelectionLength = 0;
            this.txtMID.SelectionStart = 0;
            this.txtMID.ShortcutsEnabled = true;
            this.txtMID.Size = new System.Drawing.Size(184, 28);
            this.txtMID.TabIndex = 30;
            this.txtMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMID.UseSelectable = true;
            this.txtMID.WaterMark = "Auto Generated";
            this.txtMID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(29, 4);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 28);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Manager ID :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.metroPanel2.Location = new System.Drawing.Point(857, 103);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(179, 442);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(21, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 90);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(1054, 91);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Manager Entry";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.metroLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.metroLabel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(67, 190);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 20);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Contact No :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnRemove);
            this.metroPanel1.Controls.Add(this.btnBrowse);
            this.metroPanel1.Controls.Add(this.pbM);
            this.metroPanel1.Controls.Add(this.txtMRemarks);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.cmbMCity);
            this.metroPanel1.Controls.Add(this.txtMCommission);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txtMEmail);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.txtMMobile);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtMPostalCode);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtMAddress);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtMName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtMID);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(16, 103);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(833, 442);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // pbM
            // 
            this.pbM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbM.Location = new System.Drawing.Point(607, 23);
            this.pbM.Margin = new System.Windows.Forms.Padding(4);
            this.pbM.Name = "pbM";
            this.pbM.Size = new System.Drawing.Size(193, 190);
            this.pbM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbM.TabIndex = 22;
            this.pbM.TabStop = false;
            // 
            // managerdetailsBindingSource
            // 
            this.managerdetailsBindingSource.DataSource = typeof(CMS.Data.Manager_details);
            // 
            // AddManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 556);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddManager";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddManager_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnRemove;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox pbM;
        private MetroFramework.Controls.MetroTextBox txtMRemarks;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbMCity;
        private MetroFramework.Controls.MetroTextBox txtMCommission;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtMEmail;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtMMobile;
        private MetroFramework.Controls.MetroTextBox txtMPostalCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtMAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private System.Windows.Forms.BindingSource managerdetailsBindingSource;
    }
}