namespace PresentationLayer
{
    partial class AddUser
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
            this.pbUPic = new System.Windows.Forms.PictureBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtCPass = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUName = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbUPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUPic
            // 
            this.pbUPic.InitialImage = null;
            this.pbUPic.Location = new System.Drawing.Point(380, 65);
            this.pbUPic.Name = "pbUPic";
            this.pbUPic.Size = new System.Drawing.Size(154, 163);
            this.pbUPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUPic.TabIndex = 0;
            this.pbUPic.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(1, -1);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(545, 46);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "User Profile";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddUser_MouseDown);
            this.metroLabel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddUser_Move);
            this.metroLabel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddUser_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUType);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.txtCPass);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtUName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 324);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // txtUType
            // 
            // 
            // 
            // 
            this.txtUType.CustomButton.Image = null;
            this.txtUType.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtUType.CustomButton.Name = "";
            this.txtUType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUType.CustomButton.TabIndex = 1;
            this.txtUType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUType.CustomButton.UseSelectable = true;
            this.txtUType.CustomButton.Visible = false;
            this.txtUType.Lines = new string[0];
            this.txtUType.Location = new System.Drawing.Point(178, 263);
            this.txtUType.MaxLength = 32767;
            this.txtUType.Multiline = true;
            this.txtUType.Name = "txtUType";
            this.txtUType.PasswordChar = '\0';
            this.txtUType.PromptText = "Auto Generate";
            this.txtUType.ReadOnly = true;
            this.txtUType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUType.SelectedText = "";
            this.txtUType.SelectionLength = 0;
            this.txtUType.SelectionStart = 0;
            this.txtUType.ShortcutsEnabled = true;
            this.txtUType.Size = new System.Drawing.Size(162, 23);
            this.txtUType.TabIndex = 22;
            this.txtUType.UseSelectable = true;
            this.txtUType.WaterMark = "Auto Generate";
            this.txtUType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 263);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "User Type";
            // 
            // txtCPass
            // 
            // 
            // 
            // 
            this.txtCPass.CustomButton.Image = null;
            this.txtCPass.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtCPass.CustomButton.Name = "";
            this.txtCPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCPass.CustomButton.TabIndex = 1;
            this.txtCPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCPass.CustomButton.UseSelectable = true;
            this.txtCPass.CustomButton.Visible = false;
            this.txtCPass.Lines = new string[0];
            this.txtCPass.Location = new System.Drawing.Point(178, 216);
            this.txtCPass.MaxLength = 32767;
            this.txtCPass.Multiline = true;
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.PasswordChar = '*';
            this.txtCPass.PromptText = "Confirm Password";
            this.txtCPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCPass.SelectedText = "";
            this.txtCPass.SelectionLength = 0;
            this.txtCPass.SelectionStart = 0;
            this.txtCPass.ShortcutsEnabled = true;
            this.txtCPass.Size = new System.Drawing.Size(162, 23);
            this.txtCPass.TabIndex = 20;
            this.txtCPass.UseSelectable = true;
            this.txtCPass.WaterMark = "Confirm Password";
            this.txtCPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(178, 172);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Password";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(162, 23);
            this.txtPass.TabIndex = 19;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Password";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUName
            // 
            // 
            // 
            // 
            this.txtUName.CustomButton.Image = null;
            this.txtUName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtUName.CustomButton.Name = "";
            this.txtUName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUName.CustomButton.TabIndex = 1;
            this.txtUName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUName.CustomButton.UseSelectable = true;
            this.txtUName.CustomButton.Visible = false;
            this.txtUName.Lines = new string[0];
            this.txtUName.Location = new System.Drawing.Point(178, 121);
            this.txtUName.MaxLength = 32767;
            this.txtUName.Multiline = true;
            this.txtUName.Name = "txtUName";
            this.txtUName.PasswordChar = '\0';
            this.txtUName.PromptText = "Username";
            this.txtUName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUName.SelectedText = "";
            this.txtUName.SelectionLength = 0;
            this.txtUName.SelectionStart = 0;
            this.txtUName.ShortcutsEnabled = true;
            this.txtUName.Size = new System.Drawing.Size(162, 23);
            this.txtUName.TabIndex = 18;
            this.txtUName.UseSelectable = true;
            this.txtUName.WaterMark = "Username";
            this.txtUName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(178, 72);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Auto Generated";
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(162, 23);
            this.txtName.TabIndex = 17;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Auto Generated";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(178, 24);
            this.txtId.MaxLength = 32767;
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PromptText = "Auto Generated";
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(162, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMark = "Auto Generated";
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 216);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(119, 20);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Confirm Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 20);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 20);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "User Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 20);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(22, 20);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(380, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(380, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 35);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 401);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbUPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUPic;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtCPass;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtUName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtUType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}