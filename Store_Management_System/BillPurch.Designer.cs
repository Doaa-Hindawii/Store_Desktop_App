
namespace Store_Management_System
{
    partial class BillPurch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPurch));
            this.BillingTitle = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.Datelb = new System.Windows.Forms.Label();
            this.ProdNameLb = new System.Windows.Forms.Label();
            this.ProdPriceLb = new System.Windows.Forms.Label();
            this.ProdQtyLb = new System.Windows.Forms.Label();
            this.AddToBillBtn = new System.Windows.Forms.Button();
            this.BillGv = new System.Windows.Forms.DataGridView();
            this.SubTotLb = new System.Windows.Forms.Label();
            this.PQty = new System.Windows.Forms.TextBox();
            this.categoryDrop = new System.Windows.Forms.ComboBox();
            this.BillTab = new System.Windows.Forms.Panel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.CatLb = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.StoreLb = new System.Windows.Forms.Label();
            this.SuppLb = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductCompoBox = new System.Windows.Forms.ComboBox();
            this.CBsupplier = new System.Windows.Forms.ComboBox();
            this.tbproductprice = new System.Windows.Forms.TextBox();
            this.NewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillGv)).BeginInit();
            this.BillTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BillingTitle
            // 
            this.BillingTitle.AutoSize = true;
            this.BillingTitle.BackColor = System.Drawing.Color.Transparent;
            this.BillingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingTitle.ForeColor = System.Drawing.Color.White;
            this.BillingTitle.Location = new System.Drawing.Point(64, 158);
            this.BillingTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BillingTitle.Name = "BillingTitle";
            this.BillingTitle.Size = new System.Drawing.Size(279, 37);
            this.BillingTitle.TabIndex = 10;
            this.BillingTitle.Text = "Billing Purchases";
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(1810, 2);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(31, 29);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "X";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Datelb
            // 
            this.Datelb.AutoSize = true;
            this.Datelb.BackColor = System.Drawing.Color.Transparent;
            this.Datelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb.ForeColor = System.Drawing.Color.White;
            this.Datelb.Location = new System.Drawing.Point(404, 28);
            this.Datelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(48, 22);
            this.Datelb.TabIndex = 13;
            this.Datelb.Text = "Date";
            // 
            // ProdNameLb
            // 
            this.ProdNameLb.AutoSize = true;
            this.ProdNameLb.BackColor = System.Drawing.Color.Transparent;
            this.ProdNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameLb.ForeColor = System.Drawing.Color.White;
            this.ProdNameLb.Location = new System.Drawing.Point(40, 368);
            this.ProdNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdNameLb.Name = "ProdNameLb";
            this.ProdNameLb.Size = new System.Drawing.Size(124, 22);
            this.ProdNameLb.TabIndex = 15;
            this.ProdNameLb.Text = "Product Name";
            // 
            // ProdPriceLb
            // 
            this.ProdPriceLb.AutoSize = true;
            this.ProdPriceLb.BackColor = System.Drawing.Color.Transparent;
            this.ProdPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceLb.ForeColor = System.Drawing.Color.White;
            this.ProdPriceLb.Location = new System.Drawing.Point(48, 452);
            this.ProdPriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdPriceLb.Name = "ProdPriceLb";
            this.ProdPriceLb.Size = new System.Drawing.Size(118, 22);
            this.ProdPriceLb.TabIndex = 16;
            this.ProdPriceLb.Text = "Product Price";
            // 
            // ProdQtyLb
            // 
            this.ProdQtyLb.AutoSize = true;
            this.ProdQtyLb.BackColor = System.Drawing.Color.Transparent;
            this.ProdQtyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyLb.ForeColor = System.Drawing.Color.White;
            this.ProdQtyLb.Location = new System.Drawing.Point(48, 539);
            this.ProdQtyLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdQtyLb.Name = "ProdQtyLb";
            this.ProdQtyLb.Size = new System.Drawing.Size(105, 22);
            this.ProdQtyLb.TabIndex = 17;
            this.ProdQtyLb.Text = "Product Qty";
            // 
            // AddToBillBtn
            // 
            this.AddToBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddToBillBtn.FlatAppearance.BorderSize = 0;
            this.AddToBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToBillBtn.ForeColor = System.Drawing.Color.White;
            this.AddToBillBtn.Location = new System.Drawing.Point(71, 732);
            this.AddToBillBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddToBillBtn.Name = "AddToBillBtn";
            this.AddToBillBtn.Size = new System.Drawing.Size(225, 46);
            this.AddToBillBtn.TabIndex = 28;
            this.AddToBillBtn.Text = "Add to bill";
            this.AddToBillBtn.UseVisualStyleBackColor = false;
            this.AddToBillBtn.Click += new System.EventHandler(this.AddToBillBtn_Click);
            // 
            // BillGv
            // 
            this.BillGv.AllowUserToAddRows = false;
            this.BillGv.AllowUserToDeleteRows = false;
            this.BillGv.AllowUserToResizeColumns = false;
            this.BillGv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.BillGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillGv.BackgroundColor = System.Drawing.Color.White;
            this.BillGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillGv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BillGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillGv.GridColor = System.Drawing.Color.Silver;
            this.BillGv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BillGv.Location = new System.Drawing.Point(13, 5);
            this.BillGv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillGv.MultiSelect = false;
            this.BillGv.Name = "BillGv";
            this.BillGv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BillGv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.BillGv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.BillGv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.BillGv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.BillGv.RowTemplate.Height = 25;
            this.BillGv.RowTemplate.ReadOnly = true;
            this.BillGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGv.ShowCellErrors = false;
            this.BillGv.ShowCellToolTips = false;
            this.BillGv.ShowEditingIcon = false;
            this.BillGv.ShowRowErrors = false;
            this.BillGv.Size = new System.Drawing.Size(1000, 850);
            this.BillGv.TabIndex = 29;
            this.BillGv.TabStop = false;
            // 
            // SubTotLb
            // 
            this.SubTotLb.AutoSize = true;
            this.SubTotLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotLb.ForeColor = System.Drawing.Color.Gray;
            this.SubTotLb.Location = new System.Drawing.Point(392, 574);
            this.SubTotLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubTotLb.Name = "SubTotLb";
            this.SubTotLb.Size = new System.Drawing.Size(88, 22);
            this.SubTotLb.TabIndex = 31;
            this.SubTotLb.Text = "total price";
            // 
            // PQty
            // 
            this.PQty.BackColor = System.Drawing.Color.White;
            this.PQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PQty.ForeColor = System.Drawing.Color.Gray;
            this.PQty.Location = new System.Drawing.Point(44, 580);
            this.PQty.Margin = new System.Windows.Forms.Padding(8);
            this.PQty.Name = "PQty";
            this.PQty.Size = new System.Drawing.Size(314, 23);
            this.PQty.TabIndex = 36;
            this.PQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PQty_KeyPress);
            // 
            // categoryDrop
            // 
            this.categoryDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDrop.ForeColor = System.Drawing.Color.Gray;
            this.categoryDrop.FormattingEnabled = true;
            this.categoryDrop.Location = new System.Drawing.Point(46, 309);
            this.categoryDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryDrop.Name = "categoryDrop";
            this.categoryDrop.Size = new System.Drawing.Size(312, 28);
            this.categoryDrop.TabIndex = 39;
            this.categoryDrop.SelectedIndexChanged += new System.EventHandler(this.categoryDrop_SelectedIndexChanged);
            // 
            // BillTab
            // 
            this.BillTab.BackColor = System.Drawing.Color.GhostWhite;
            this.BillTab.Controls.Add(this.labelTotalPrice);
            this.BillTab.Controls.Add(this.BuyBtn);
            this.BillTab.Controls.Add(this.SubTotLb);
            this.BillTab.Controls.Add(this.BillGv);
            this.BillTab.Location = new System.Drawing.Point(408, 62);
            this.BillTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillTab.Name = "BillTab";
            this.BillTab.Size = new System.Drawing.Size(1500, 1000);
            this.BillTab.TabIndex = 41;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(421, 610);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(31, 20);
            this.labelTotalPrice.TabIndex = 39;
            this.labelTotalPrice.Text = "0.0";
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyBtn.ForeColor = System.Drawing.Color.White;
            this.BuyBtn.Location = new System.Drawing.Point(498, 652);
            this.BuyBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(408, 62);
            this.BuyBtn.TabIndex = 38;
            this.BuyBtn.Text = "Enter Purchase";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // CatLb
            // 
            this.CatLb.AutoSize = true;
            this.CatLb.BackColor = System.Drawing.Color.Transparent;
            this.CatLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatLb.ForeColor = System.Drawing.Color.White;
            this.CatLb.Location = new System.Drawing.Point(48, 275);
            this.CatLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatLb.Name = "CatLb";
            this.CatLb.Size = new System.Drawing.Size(83, 22);
            this.CatLb.TabIndex = 39;
            this.CatLb.Text = "Catagory";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Store_Management_System.Properties.Resources.store_512;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(136, 8);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(116, 145);
            this.Logo.TabIndex = 42;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Store_Management_System.Properties.Resources.arrows_11__Converted_;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(12, 19);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 42);
            this.backButton.TabIndex = 43;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.ForeColor = System.Drawing.Color.Gray;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(44, 225);
            this.StoreComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(312, 28);
            this.StoreComboBox.TabIndex = 44;
            this.StoreComboBox.SelectedIndexChanged += new System.EventHandler(this.StoreComboBox_SelectedIndexChanged);
            // 
            // StoreLb
            // 
            this.StoreLb.AutoSize = true;
            this.StoreLb.BackColor = System.Drawing.Color.Transparent;
            this.StoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreLb.ForeColor = System.Drawing.Color.White;
            this.StoreLb.Location = new System.Drawing.Point(40, 195);
            this.StoreLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreLb.Name = "StoreLb";
            this.StoreLb.Size = new System.Drawing.Size(53, 22);
            this.StoreLb.TabIndex = 45;
            this.StoreLb.Text = "Store";
            // 
            // SuppLb
            // 
            this.SuppLb.AutoSize = true;
            this.SuppLb.BackColor = System.Drawing.Color.Transparent;
            this.SuppLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppLb.ForeColor = System.Drawing.Color.White;
            this.SuppLb.Location = new System.Drawing.Point(42, 624);
            this.SuppLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuppLb.Name = "SuppLb";
            this.SuppLb.Size = new System.Drawing.Size(76, 22);
            this.SuppLb.TabIndex = 47;
            this.SuppLb.Text = "Supplier";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-21, -24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 48;
            // 
            // ProductCompoBox
            // 
            this.ProductCompoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductCompoBox.FormattingEnabled = true;
            this.ProductCompoBox.Location = new System.Drawing.Point(44, 394);
            this.ProductCompoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductCompoBox.Name = "ProductCompoBox";
            this.ProductCompoBox.Size = new System.Drawing.Size(311, 28);
            this.ProductCompoBox.TabIndex = 49;
            // 
            // CBsupplier
            // 
            this.CBsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBsupplier.FormattingEnabled = true;
            this.CBsupplier.Location = new System.Drawing.Point(46, 651);
            this.CBsupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBsupplier.Name = "CBsupplier";
            this.CBsupplier.Size = new System.Drawing.Size(310, 28);
            this.CBsupplier.TabIndex = 50;
            // 
            // tbproductprice
            // 
            this.tbproductprice.BackColor = System.Drawing.Color.White;
            this.tbproductprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbproductprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproductprice.ForeColor = System.Drawing.Color.Gray;
            this.tbproductprice.Location = new System.Drawing.Point(42, 496);
            this.tbproductprice.Margin = new System.Windows.Forms.Padding(8);
            this.tbproductprice.Name = "tbproductprice";
            this.tbproductprice.Size = new System.Drawing.Size(314, 23);
            this.tbproductprice.TabIndex = 51;
            this.tbproductprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbproductprice_KeyPress);
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NewBtn.FlatAppearance.BorderSize = 0;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.ForeColor = System.Drawing.Color.White;
            this.NewBtn.Location = new System.Drawing.Point(288, 690);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(112, 35);
            this.NewBtn.TabIndex = 52;
            this.NewBtn.Text = "NEW";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // BillPurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1434, 795);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.tbproductprice);
            this.Controls.Add(this.CBsupplier);
            this.Controls.Add(this.ProductCompoBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SuppLb);
            this.Controls.Add(this.StoreLb);
            this.Controls.Add(this.StoreComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CatLb);
            this.Controls.Add(this.categoryDrop);
            this.Controls.Add(this.PQty);
            this.Controls.Add(this.AddToBillBtn);
            this.Controls.Add(this.ProdQtyLb);
            this.Controls.Add(this.ProdPriceLb);
            this.Controls.Add(this.ProdNameLb);
            this.Controls.Add(this.Datelb);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.BillingTitle);
            this.Controls.Add(this.BillTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillPurch";
            this.Text = "Bill";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGv)).EndInit();
            this.BillTab.ResumeLayout(false);
            this.BillTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BillingTitle;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.Label ProdNameLb;
        private System.Windows.Forms.Label ProdPriceLb;
        private System.Windows.Forms.Label ProdQtyLb;
        private System.Windows.Forms.Button AddToBillBtn;
        private System.Windows.Forms.DataGridView BillGv;
        private System.Windows.Forms.Label SubTotLb;
        private System.Windows.Forms.TextBox PQty;
        private System.Windows.Forms.ComboBox categoryDrop;
        private System.Windows.Forms.Panel BillTab;
        private System.Windows.Forms.Label CatLb;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox StoreComboBox;
        private System.Windows.Forms.Label StoreLb;
        private System.Windows.Forms.Label SuppLb;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox ProductCompoBox;
        private System.Windows.Forms.ComboBox CBsupplier;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox tbproductprice;
        private System.Windows.Forms.Button NewBtn;
    }
}