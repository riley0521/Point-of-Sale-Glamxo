
namespace POSWinforms.Transaction
{
    partial class frmSelectItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectItem));
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtItemDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtItemCode = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUnitPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtTotal = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.discountSelector = new System.Windows.Forms.NumericUpDown();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.btnAddToCart = new MetroSet_UI.Controls.MetroSetButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\riley\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = null;
            this.styleManager1.ThemeName = null;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(341, 1);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.AutoSize = true;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 103);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(75, 17);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Item Code:";
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.AutoSize = true;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(15, 149);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(113, 17);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = this.styleManager1;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "Item Description:";
            this.metroSetLabel2.ThemeAuthor = null;
            this.metroSetLabel2.ThemeName = null;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.AutoSize = true;
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(15, 196);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(73, 17);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = this.styleManager1;
            this.metroSetLabel3.TabIndex = 3;
            this.metroSetLabel3.Text = "Unit Price:";
            this.metroSetLabel3.ThemeAuthor = null;
            this.metroSetLabel3.ThemeName = null;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.AutoSize = true;
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(15, 241);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(65, 17);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = this.styleManager1;
            this.metroSetLabel4.TabIndex = 4;
            this.metroSetLabel4.Text = "Quantity:";
            this.metroSetLabel4.ThemeAuthor = null;
            this.metroSetLabel4.ThemeName = null;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.AutoSize = true;
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(15, 289);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(67, 17);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = this.styleManager1;
            this.metroSetLabel5.TabIndex = 5;
            this.metroSetLabel5.Text = "Discount:";
            this.metroSetLabel5.ThemeAuthor = null;
            this.metroSetLabel5.ThemeName = null;
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.AutoSize = true;
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(15, 340);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(44, 17);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = this.styleManager1;
            this.metroSetLabel6.TabIndex = 6;
            this.metroSetLabel6.Text = "Total:";
            this.metroSetLabel6.ThemeAuthor = null;
            this.metroSetLabel6.ThemeName = null;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.AutoCompleteCustomSource = null;
            this.txtItemDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtItemDescription.Enabled = false;
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtItemDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtItemDescription.Image = null;
            this.txtItemDescription.IsDerivedStyle = true;
            this.txtItemDescription.Lines = null;
            this.txtItemDescription.Location = new System.Drawing.Point(144, 136);
            this.txtItemDescription.MaxLength = 32767;
            this.txtItemDescription.Multiline = false;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = false;
            this.txtItemDescription.Size = new System.Drawing.Size(292, 30);
            this.txtItemDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.txtItemDescription.StyleManager = this.styleManager1;
            this.txtItemDescription.TabIndex = 7;
            this.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemDescription.ThemeAuthor = null;
            this.txtItemDescription.ThemeName = null;
            this.txtItemDescription.UseSystemPasswordChar = false;
            this.txtItemDescription.WatermarkText = "";
            // 
            // txtItemCode
            // 
            this.txtItemCode.AutoCompleteCustomSource = null;
            this.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemCode.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemCode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemCode.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtItemCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtItemCode.Image = null;
            this.txtItemCode.IsDerivedStyle = true;
            this.txtItemCode.Lines = null;
            this.txtItemCode.Location = new System.Drawing.Point(144, 90);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Multiline = false;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = false;
            this.txtItemCode.Size = new System.Drawing.Size(137, 30);
            this.txtItemCode.Style = MetroSet_UI.Enums.Style.Light;
            this.txtItemCode.StyleManager = this.styleManager1;
            this.txtItemCode.TabIndex = 8;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemCode.ThemeAuthor = null;
            this.txtItemCode.ThemeName = null;
            this.txtItemCode.UseSystemPasswordChar = false;
            this.txtItemCode.WatermarkText = "";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteCustomSource = null;
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUnitPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUnitPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUnitPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUnitPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUnitPrice.Image = null;
            this.txtUnitPrice.IsDerivedStyle = true;
            this.txtUnitPrice.Lines = null;
            this.txtUnitPrice.Location = new System.Drawing.Point(144, 183);
            this.txtUnitPrice.MaxLength = 32767;
            this.txtUnitPrice.Multiline = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(137, 30);
            this.txtUnitPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUnitPrice.StyleManager = this.styleManager1;
            this.txtUnitPrice.TabIndex = 9;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitPrice.ThemeAuthor = null;
            this.txtUnitPrice.ThemeName = null;
            this.txtUnitPrice.UseSystemPasswordChar = false;
            this.txtUnitPrice.WatermarkText = "";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteCustomSource = null;
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTotal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTotal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTotal.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTotal.Image = null;
            this.txtTotal.IsDerivedStyle = true;
            this.txtTotal.Lines = null;
            this.txtTotal.Location = new System.Drawing.Point(144, 327);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.Size = new System.Drawing.Size(180, 30);
            this.txtTotal.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTotal.StyleManager = this.styleManager1;
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.ThemeAuthor = null;
            this.txtTotal.ThemeName = null;
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.WatermarkText = "";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.AutoSize = true;
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(287, 281);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(31, 25);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = this.styleManager1;
            this.metroSetLabel7.TabIndex = 13;
            this.metroSetLabel7.Text = "%";
            this.metroSetLabel7.ThemeAuthor = null;
            this.metroSetLabel7.ThemeName = null;
            // 
            // quantitySelector
            // 
            this.quantitySelector.Location = new System.Drawing.Point(144, 231);
            this.quantitySelector.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.quantitySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.Name = "quantitySelector";
            this.quantitySelector.Size = new System.Drawing.Size(137, 27);
            this.quantitySelector.TabIndex = 1;
            this.quantitySelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.ValueChanged += new System.EventHandler(this.quantitySelector_ValueChanged);
            this.quantitySelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantitySelector_KeyDown);
            // 
            // discountSelector
            // 
            this.discountSelector.Location = new System.Drawing.Point(144, 279);
            this.discountSelector.Name = "discountSelector";
            this.discountSelector.Size = new System.Drawing.Size(137, 27);
            this.discountSelector.TabIndex = 2;
            this.discountSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountSelector.ValueChanged += new System.EventHandler(this.discountSelector_ValueChanged);
            this.discountSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountSelector_KeyDown);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.ForeColor = System.Drawing.Color.Black;
            this.btnSelectItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectItem.Image")));
            this.btnSelectItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectItem.Location = new System.Drawing.Point(287, 90);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSelectItem.Size = new System.Drawing.Size(149, 30);
            this.btnSelectItem.TabIndex = 0;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddToCart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddToCart.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddToCart.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddToCart.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddToCart.HoverTextColor = System.Drawing.Color.White;
            this.btnAddToCart.IsDerivedStyle = true;
            this.btnAddToCart.Location = new System.Drawing.Point(327, 400);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddToCart.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddToCart.NormalTextColor = System.Drawing.Color.White;
            this.btnAddToCart.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddToCart.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddToCart.PressTextColor = System.Drawing.Color.White;
            this.btnAddToCart.Size = new System.Drawing.Size(114, 35);
            this.btnAddToCart.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddToCart.StyleManager = this.styleManager1;
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.ThemeAuthor = null;
            this.btnAddToCart.ThemeName = null;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.discountSelector);
            this.Controls.Add(this.quantitySelector);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.MaximumSize = new System.Drawing.Size(456, 450);
            this.MinimumSize = new System.Drawing.Size(456, 450);
            this.Name = "frmSelectItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StyleManager = this.styleManager1;
            this.Text = "Select Item";
            this.ThemeAuthor = null;
            this.ThemeName = null;
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton btnAddToCart;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.NumericUpDown discountSelector;
        private System.Windows.Forms.NumericUpDown quantitySelector;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetTextBox txtTotal;
        private MetroSet_UI.Controls.MetroSetTextBox txtUnitPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtItemCode;
        private MetroSet_UI.Controls.MetroSetTextBox txtItemDescription;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}