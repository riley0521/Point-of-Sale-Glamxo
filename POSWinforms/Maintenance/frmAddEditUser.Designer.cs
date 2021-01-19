
namespace POSWinforms.Maintenance
{
    partial class frmAddEditUser
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
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtStaffID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtFirstName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMI = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtLastName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtContactNo = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbPositions = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnSave = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\riley\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLight";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 109);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Staff ID:";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLight";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(15, 145);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Username:";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLight";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(16, 181);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(79, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = this.styleManager1;
            this.metroSetLabel3.TabIndex = 1;
            this.metroSetLabel3.Text = "Password:";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLight";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(16, 260);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(79, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = this.styleManager1;
            this.metroSetLabel4.TabIndex = 1;
            this.metroSetLabel4.Text = "Name:";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLight";
            // 
            // txtStaffID
            // 
            this.txtStaffID.AutoCompleteCustomSource = null;
            this.txtStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStaffID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtStaffID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtStaffID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtStaffID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStaffID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtStaffID.Image = null;
            this.txtStaffID.IsDerivedStyle = true;
            this.txtStaffID.Lines = null;
            this.txtStaffID.Location = new System.Drawing.Point(101, 102);
            this.txtStaffID.MaxLength = 32767;
            this.txtStaffID.Multiline = false;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = false;
            this.txtStaffID.Size = new System.Drawing.Size(114, 30);
            this.txtStaffID.Style = MetroSet_UI.Enums.Style.Light;
            this.txtStaffID.StyleManager = this.styleManager1;
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStaffID.ThemeAuthor = "Narwin";
            this.txtStaffID.ThemeName = "MetroLight";
            this.txtStaffID.UseSystemPasswordChar = false;
            this.txtStaffID.WatermarkText = "";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoCompleteCustomSource = null;
            this.txtFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFirstName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFirstName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFirstName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFirstName.Image = null;
            this.txtFirstName.IsDerivedStyle = true;
            this.txtFirstName.Lines = null;
            this.txtFirstName.Location = new System.Drawing.Point(347, 253);
            this.txtFirstName.MaxLength = 55;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.Size = new System.Drawing.Size(209, 30);
            this.txtFirstName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtFirstName.StyleManager = this.styleManager1;
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.ThemeAuthor = "Narwin";
            this.txtFirstName.ThemeName = "MetroLight";
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.WatermarkText = "";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtMI
            // 
            this.txtMI.AutoCompleteCustomSource = null;
            this.txtMI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMI.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMI.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMI.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMI.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMI.Image = null;
            this.txtMI.IsDerivedStyle = true;
            this.txtMI.Lines = null;
            this.txtMI.Location = new System.Drawing.Point(602, 253);
            this.txtMI.MaxLength = 5;
            this.txtMI.Multiline = false;
            this.txtMI.Name = "txtMI";
            this.txtMI.ReadOnly = false;
            this.txtMI.Size = new System.Drawing.Size(106, 30);
            this.txtMI.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMI.StyleManager = this.styleManager1;
            this.txtMI.TabIndex = 4;
            this.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMI.ThemeAuthor = "Narwin";
            this.txtMI.ThemeName = "MetroLight";
            this.txtMI.UseSystemPasswordChar = false;
            this.txtMI.WatermarkText = "";
            this.txtMI.TextChanged += new System.EventHandler(this.txtMI_TextChanged);
            this.txtMI.Validating += new System.ComponentModel.CancelEventHandler(this.txtMI_Validating);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(102, 227);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = this.styleManager1;
            this.metroSetLabel5.TabIndex = 1;
            this.metroSetLabel5.Text = "Last name";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLight";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(347, 227);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = this.styleManager1;
            this.metroSetLabel6.TabIndex = 1;
            this.metroSetLabel6.Text = "First name";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLight";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(602, 227);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = this.styleManager1;
            this.metroSetLabel7.TabIndex = 1;
            this.metroSetLabel7.Text = "MI";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLight";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource = null;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsername.Image = null;
            this.txtUsername.IsDerivedStyle = true;
            this.txtUsername.Lines = null;
            this.txtUsername.Location = new System.Drawing.Point(101, 138);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(209, 30);
            this.txtUsername.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUsername.StyleManager = this.styleManager1;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.ThemeAuthor = "Narwin";
            this.txtUsername.ThemeName = "MetroLight";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WatermarkText = "";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource = null;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Image = null;
            this.txtPassword.IsDerivedStyle = true;
            this.txtPassword.Lines = null;
            this.txtPassword.Location = new System.Drawing.Point(101, 174);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(209, 30);
            this.txtPassword.Style = MetroSet_UI.Enums.Style.Light;
            this.txtPassword.StyleManager = this.styleManager1;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.ThemeAuthor = "Narwin";
            this.txtPassword.ThemeName = "MetroLight";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "";
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.AutoCompleteCustomSource = null;
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLastName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLastName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLastName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLastName.Image = null;
            this.txtLastName.IsDerivedStyle = true;
            this.txtLastName.Lines = null;
            this.txtLastName.Location = new System.Drawing.Point(102, 253);
            this.txtLastName.MaxLength = 55;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.Size = new System.Drawing.Size(209, 30);
            this.txtLastName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLastName.StyleManager = this.styleManager1;
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.ThemeAuthor = "Narwin";
            this.txtLastName.ThemeName = "MetroLight";
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.WatermarkText = "";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(16, 289);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(79, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = this.styleManager1;
            this.metroSetLabel8.TabIndex = 5;
            this.metroSetLabel8.Text = "Address:";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLight";
            // 
            // txtContactNo
            // 
            this.txtContactNo.AutoCompleteCustomSource = null;
            this.txtContactNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContactNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContactNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContactNo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContactNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContactNo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtContactNo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtContactNo.Image = null;
            this.txtContactNo.IsDerivedStyle = true;
            this.txtContactNo.Lines = null;
            this.txtContactNo.Location = new System.Drawing.Point(102, 360);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Multiline = false;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = false;
            this.txtContactNo.Size = new System.Drawing.Size(209, 30);
            this.txtContactNo.Style = MetroSet_UI.Enums.Style.Light;
            this.txtContactNo.StyleManager = this.styleManager1;
            this.txtContactNo.TabIndex = 6;
            this.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContactNo.ThemeAuthor = "Narwin";
            this.txtContactNo.ThemeName = "MetroLight";
            this.txtContactNo.UseSystemPasswordChar = false;
            this.txtContactNo.WatermarkText = "";
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNo_Validating);
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.IsDerivedStyle = true;
            this.metroSetLabel9.Location = new System.Drawing.Point(7, 367);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(88, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel9.StyleManager = this.styleManager1;
            this.metroSetLabel9.TabIndex = 7;
            this.metroSetLabel9.Text = "Contact No.:";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLight";
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.IsDerivedStyle = true;
            this.metroSetLabel10.Location = new System.Drawing.Point(15, 399);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(80, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel10.StyleManager = this.styleManager1;
            this.metroSetLabel10.TabIndex = 9;
            this.metroSetLabel10.Text = "Position:";
            this.metroSetLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLight";
            // 
            // cmbPositions
            // 
            this.cmbPositions.AllowDrop = true;
            this.cmbPositions.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPositions.BackColor = System.Drawing.Color.Transparent;
            this.cmbPositions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbPositions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPositions.CausesValidation = false;
            this.cmbPositions.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPositions.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbPositions.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbPositions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPositions.FormattingEnabled = true;
            this.cmbPositions.IsDerivedStyle = true;
            this.cmbPositions.ItemHeight = 20;
            this.cmbPositions.Location = new System.Drawing.Point(102, 396);
            this.cmbPositions.Name = "cmbPositions";
            this.cmbPositions.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbPositions.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPositions.Size = new System.Drawing.Size(209, 26);
            this.cmbPositions.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbPositions.StyleManager = this.styleManager1;
            this.cmbPositions.TabIndex = 7;
            this.cmbPositions.ThemeAuthor = "Narwin";
            this.cmbPositions.ThemeName = "MetroLight";
            this.cmbPositions.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPositions_Validating);
            // 
            // btnSave
            // 
            this.btnSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.IsDerivedStyle = true;
            this.btnSave.Location = new System.Drawing.Point(510, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSave.NormalTextColor = System.Drawing.Color.White;
            this.btnSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSave.PressTextColor = System.Drawing.Color.White;
            this.btnSave.Size = new System.Drawing.Size(113, 39);
            this.btnSave.Style = MetroSet_UI.Enums.Style.Light;
            this.btnSave.StyleManager = this.styleManager1;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeAuthor = "Narwin";
            this.btnSave.ThemeName = "MetroLight";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.IsDerivedStyle = true;
            this.btnCancel.Location = new System.Drawing.Point(629, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalTextColor = System.Drawing.Color.White;
            this.btnCancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(113, 39);
            this.btnCancel.Style = MetroSet_UI.Enums.Style.Light;
            this.btnCancel.StyleManager = this.styleManager1;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeAuthor = "Narwin";
            this.btnCancel.ThemeName = "MetroLight";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoCompleteCustomSource = null;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtAddress.Image = null;
            this.txtAddress.IsDerivedStyle = true;
            this.txtAddress.Lines = null;
            this.txtAddress.Location = new System.Drawing.Point(102, 289);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(606, 65);
            this.txtAddress.Style = MetroSet_UI.Enums.Style.Light;
            this.txtAddress.StyleManager = this.styleManager1;
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.ThemeAuthor = "Narwin";
            this.txtAddress.ThemeName = "MetroLight";
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.WatermarkText = "";
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 494);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPositions);
            this.Controls.Add(this.metroSetLabel10);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.metroSetLabel9);
            this.Controls.Add(this.metroSetLabel8);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "User Modal";
            this.ThemeName = "MetroLight";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddEditUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private MetroSet_UI.Controls.MetroSetButton btnSave;
        private MetroSet_UI.Controls.MetroSetComboBox cmbPositions;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private MetroSet_UI.Controls.MetroSetTextBox txtContactNo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetTextBox txtLastName;
        private MetroSet_UI.Controls.MetroSetTextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtMI;
        private MetroSet_UI.Controls.MetroSetTextBox txtFirstName;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsername;
        private MetroSet_UI.Controls.MetroSetTextBox txtStaffID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroSet_UI.Controls.MetroSetTextBox txtAddress;
    }
}