
namespace Store_Management_System
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.ProdTab = new System.Windows.Forms.Panel();
            this.salepricetextbox = new System.Windows.Forms.TextBox();
            this.saleprice = new System.Windows.Forms.Label();
            this.CatDrop = new System.Windows.Forms.ComboBox();
            this.ProdTbl = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.StoreLb = new System.Windows.Forms.Label();
            this.StoreDrop = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdPriceLb = new System.Windows.Forms.Label();
            this.ProdNameLb = new System.Windows.Forms.Label();
            this.CategoryLb = new System.Windows.Forms.Label();
            this.ProdTitle = new System.Windows.Forms.Label();
            this.ProdsBTN = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuppsBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.SystemName = new System.Windows.Forms.Label();
            this.Cursor = new System.Windows.Forms.Panel();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.BillPurBtn = new System.Windows.Forms.Button();
            this.BillSalesBtn = new System.Windows.Forms.Button();
            this.RepPurBtn = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.ProdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdTab
            // 
            this.ProdTab.BackColor = System.Drawing.Color.GhostWhite;
            this.ProdTab.Controls.Add(this.salepricetextbox);
            this.ProdTab.Controls.Add(this.saleprice);
            this.ProdTab.Controls.Add(this.CatDrop);
            this.ProdTab.Controls.Add(this.ProdTbl);
            this.ProdTab.Controls.Add(this.DeleteBtn);
            this.ProdTab.Controls.Add(this.NewBtn);
            this.ProdTab.Controls.Add(this.StoreLb);
            this.ProdTab.Controls.Add(this.StoreDrop);
            this.ProdTab.Controls.Add(this.AddBtn);
            this.ProdTab.Controls.Add(this.ProdName);
            this.ProdTab.Controls.Add(this.ProdPrice);
            this.ProdTab.Controls.Add(this.ProdPriceLb);
            this.ProdTab.Controls.Add(this.ProdNameLb);
            this.ProdTab.Controls.Add(this.CategoryLb);
            this.ProdTab.Controls.Add(this.ProdTitle);
            this.ProdTab.Location = new System.Drawing.Point(280, 66);
            this.ProdTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdTab.Name = "ProdTab";
            this.ProdTab.Size = new System.Drawing.Size(1500, 1000);
            this.ProdTab.TabIndex = 0;
            // 
            // salepricetextbox
            // 
            this.salepricetextbox.BackColor = System.Drawing.Color.White;
            this.salepricetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salepricetextbox.ForeColor = System.Drawing.Color.DimGray;
            this.salepricetextbox.Location = new System.Drawing.Point(33, 463);
            this.salepricetextbox.Margin = new System.Windows.Forms.Padding(8);
            this.salepricetextbox.Name = "salepricetextbox";
            this.salepricetextbox.Size = new System.Drawing.Size(348, 30);
            this.salepricetextbox.TabIndex = 28;
            this.salepricetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salepricetextbox_KeyPress);
            // 
            // saleprice
            // 
            this.saleprice.AutoSize = true;
            this.saleprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleprice.ForeColor = System.Drawing.Color.Gray;
            this.saleprice.Location = new System.Drawing.Point(32, 435);
            this.saleprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saleprice.Name = "saleprice";
            this.saleprice.Size = new System.Drawing.Size(81, 20);
            this.saleprice.TabIndex = 27;
            this.saleprice.Text = "SalePrice";
            // 
            // CatDrop
            // 
            this.CatDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDrop.ForeColor = System.Drawing.Color.DimGray;
            this.CatDrop.FormattingEnabled = true;
            this.CatDrop.Location = new System.Drawing.Point(33, 220);
            this.CatDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDrop.Name = "CatDrop";
            this.CatDrop.Size = new System.Drawing.Size(352, 30);
            this.CatDrop.TabIndex = 25;
            this.CatDrop.SelectedIndexChanged += new System.EventHandler(this.CatDrop_SelectedIndexChanged);
            // 
            // ProdTbl
            // 
            this.ProdTbl.AllowUserToAddRows = false;
            this.ProdTbl.AllowUserToDeleteRows = false;
            this.ProdTbl.AllowUserToResizeColumns = false;
            this.ProdTbl.AllowUserToResizeRows = false;
            this.ProdTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdTbl.BackgroundColor = System.Drawing.Color.White;
            this.ProdTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdTbl.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ProdTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdTbl.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProdTbl.GridColor = System.Drawing.Color.Silver;
            this.ProdTbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProdTbl.Location = new System.Drawing.Point(424, 82);
            this.ProdTbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdTbl.MultiSelect = false;
            this.ProdTbl.Name = "ProdTbl";
            this.ProdTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ProdTbl.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTbl.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.ProdTbl.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.ProdTbl.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ProdTbl.RowTemplate.Height = 25;
            this.ProdTbl.RowTemplate.ReadOnly = true;
            this.ProdTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdTbl.ShowCellErrors = false;
            this.ProdTbl.ShowCellToolTips = false;
            this.ProdTbl.ShowEditingIcon = false;
            this.ProdTbl.ShowRowErrors = false;
            this.ProdTbl.Size = new System.Drawing.Size(1000, 849);
            this.ProdTbl.TabIndex = 24;
            this.ProdTbl.TabStop = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(33, 675);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(112, 35);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NewBtn.FlatAppearance.BorderSize = 0;
            this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.ForeColor = System.Drawing.Color.White;
            this.NewBtn.Location = new System.Drawing.Point(261, 597);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(112, 35);
            this.NewBtn.TabIndex = 20;
            this.NewBtn.Text = "NEW";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // StoreLb
            // 
            this.StoreLb.AutoSize = true;
            this.StoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreLb.ForeColor = System.Drawing.Color.Gray;
            this.StoreLb.Location = new System.Drawing.Point(32, 128);
            this.StoreLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StoreLb.Name = "StoreLb";
            this.StoreLb.Size = new System.Drawing.Size(49, 20);
            this.StoreLb.TabIndex = 19;
            this.StoreLb.Text = "Store";
            // 
            // StoreDrop
            // 
            this.StoreDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreDrop.ForeColor = System.Drawing.Color.DimGray;
            this.StoreDrop.FormattingEnabled = true;
            this.StoreDrop.Location = new System.Drawing.Point(33, 152);
            this.StoreDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreDrop.Name = "StoreDrop";
            this.StoreDrop.Size = new System.Drawing.Size(352, 30);
            this.StoreDrop.TabIndex = 18;
            this.StoreDrop.SelectedIndexChanged += new System.EventHandler(this.StoreDrop_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(52, 538);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(291, 35);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.ForeColor = System.Drawing.Color.DimGray;
            this.ProdName.Location = new System.Drawing.Point(32, 302);
            this.ProdName.Margin = new System.Windows.Forms.Padding(8);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(352, 30);
            this.ProdName.TabIndex = 15;
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.Color.White;
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPrice.ForeColor = System.Drawing.Color.DimGray;
            this.ProdPrice.Location = new System.Drawing.Point(33, 377);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(8);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(350, 30);
            this.ProdPrice.TabIndex = 17;
            this.ProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdPrice_KeyPress);
            // 
            // ProdPriceLb
            // 
            this.ProdPriceLb.AutoSize = true;
            this.ProdPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceLb.ForeColor = System.Drawing.Color.Gray;
            this.ProdPriceLb.Location = new System.Drawing.Point(32, 349);
            this.ProdPriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdPriceLb.Name = "ProdPriceLb";
            this.ProdPriceLb.Size = new System.Drawing.Size(48, 20);
            this.ProdPriceLb.TabIndex = 16;
            this.ProdPriceLb.Text = "Price";
            // 
            // ProdNameLb
            // 
            this.ProdNameLb.AutoSize = true;
            this.ProdNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameLb.ForeColor = System.Drawing.Color.Gray;
            this.ProdNameLb.Location = new System.Drawing.Point(32, 274);
            this.ProdNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdNameLb.Name = "ProdNameLb";
            this.ProdNameLb.Size = new System.Drawing.Size(53, 20);
            this.ProdNameLb.TabIndex = 14;
            this.ProdNameLb.Text = "Name";
            // 
            // CategoryLb
            // 
            this.CategoryLb.AutoSize = true;
            this.CategoryLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLb.ForeColor = System.Drawing.Color.Gray;
            this.CategoryLb.Location = new System.Drawing.Point(28, 195);
            this.CategoryLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLb.Name = "CategoryLb";
            this.CategoryLb.Size = new System.Drawing.Size(76, 20);
            this.CategoryLb.TabIndex = 10;
            this.CategoryLb.Text = "Category";
            // 
            // ProdTitle
            // 
            this.ProdTitle.AutoSize = true;
            this.ProdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTitle.ForeColor = System.Drawing.Color.Gray;
            this.ProdTitle.Location = new System.Drawing.Point(15, 58);
            this.ProdTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProdTitle.Name = "ProdTitle";
            this.ProdTitle.Size = new System.Drawing.Size(283, 37);
            this.ProdTitle.TabIndex = 9;
            this.ProdTitle.Text = "Manage Products";
            // 
            // ProdsBTN
            // 
            this.ProdsBTN.BackColor = System.Drawing.Color.Transparent;
            this.ProdsBTN.FlatAppearance.BorderSize = 0;
            this.ProdsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.ProdsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdsBTN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdsBTN.ForeColor = System.Drawing.Color.White;
            this.ProdsBTN.Location = new System.Drawing.Point(0, 315);
            this.ProdsBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdsBTN.Name = "ProdsBTN";
            this.ProdsBTN.Size = new System.Drawing.Size(280, 60);
            this.ProdsBTN.TabIndex = 2;
            this.ProdsBTN.Text = "Products";
            this.ProdsBTN.UseVisualStyleBackColor = false;
            // 
            // CatBtn
            // 
            this.CatBtn.BackColor = System.Drawing.Color.Transparent;
            this.CatBtn.FlatAppearance.BorderSize = 0;
            this.CatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.CatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatBtn.ForeColor = System.Drawing.Color.White;
            this.CatBtn.Location = new System.Drawing.Point(-2, 242);
            this.CatBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(280, 60);
            this.CatBtn.TabIndex = 3;
            this.CatBtn.Text = "Category";
            this.CatBtn.UseVisualStyleBackColor = false;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(1710, 3);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(68, 62);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SuppsBtn
            // 
            this.SuppsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SuppsBtn.FlatAppearance.BorderSize = 0;
            this.SuppsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.SuppsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppsBtn.ForeColor = System.Drawing.Color.White;
            this.SuppsBtn.Location = new System.Drawing.Point(2, 382);
            this.SuppsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SuppsBtn.Name = "SuppsBtn";
            this.SuppsBtn.Size = new System.Drawing.Size(280, 60);
            this.SuppsBtn.TabIndex = 27;
            this.SuppsBtn.Text = "Suppliers";
            this.SuppsBtn.UseVisualStyleBackColor = false;
            this.SuppsBtn.Click += new System.EventHandler(this.SuppsBtn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Store_Management_System.Properties.Resources.store_512;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(72, 18);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(116, 145);
            this.Logo.TabIndex = 35;
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.BackColor = System.Drawing.Color.Transparent;
            this.SystemName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemName.ForeColor = System.Drawing.Color.White;
            this.SystemName.Location = new System.Drawing.Point(298, 20);
            this.SystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(273, 23);
            this.SystemName.TabIndex = 37;
            this.SystemName.Text = "Store Management System";
            // 
            // Cursor
            // 
            this.Cursor.BackgroundImage = global::Store_Management_System.Properties.Resources.background_pink_yellow;
            this.Cursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor.Location = new System.Drawing.Point(2, 320);
            this.Cursor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cursor.Name = "Cursor";
            this.Cursor.Size = new System.Drawing.Size(18, 55);
            this.Cursor.TabIndex = 41;
            // 
            // StoreBtn
            // 
            this.StoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.StoreBtn.FlatAppearance.BorderSize = 0;
            this.StoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.StoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreBtn.ForeColor = System.Drawing.Color.White;
            this.StoreBtn.Location = new System.Drawing.Point(-2, 172);
            this.StoreBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(282, 60);
            this.StoreBtn.TabIndex = 30;
            this.StoreBtn.Text = "Store";
            this.StoreBtn.UseVisualStyleBackColor = false;
            this.StoreBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // BillPurBtn
            // 
            this.BillPurBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillPurBtn.FlatAppearance.BorderSize = 0;
            this.BillPurBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.BillPurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillPurBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillPurBtn.ForeColor = System.Drawing.Color.White;
            this.BillPurBtn.Location = new System.Drawing.Point(-2, 461);
            this.BillPurBtn.Name = "BillPurBtn";
            this.BillPurBtn.Size = new System.Drawing.Size(280, 60);
            this.BillPurBtn.TabIndex = 45;
            this.BillPurBtn.Text = "Bill (Purchases)";
            this.BillPurBtn.UseVisualStyleBackColor = false;
            // 
            // BillSalesBtn
            // 
            this.BillSalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillSalesBtn.FlatAppearance.BorderSize = 0;
            this.BillSalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.BillSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSalesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillSalesBtn.ForeColor = System.Drawing.Color.White;
            this.BillSalesBtn.Location = new System.Drawing.Point(-2, 538);
            this.BillSalesBtn.Name = "BillSalesBtn";
            this.BillSalesBtn.Size = new System.Drawing.Size(280, 60);
            this.BillSalesBtn.TabIndex = 48;
            this.BillSalesBtn.Text = "Bill (Sales)";
            this.BillSalesBtn.UseVisualStyleBackColor = false;
            // 
            // RepPurBtn
            // 
            this.RepPurBtn.BackColor = System.Drawing.Color.Transparent;
            this.RepPurBtn.FlatAppearance.BorderSize = 0;
            this.RepPurBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.RepPurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepPurBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepPurBtn.ForeColor = System.Drawing.Color.White;
            this.RepPurBtn.Location = new System.Drawing.Point(2, 689);
            this.RepPurBtn.Name = "RepPurBtn";
            this.RepPurBtn.Size = new System.Drawing.Size(280, 60);
            this.RepPurBtn.TabIndex = 47;
            this.RepPurBtn.Text = "Report (Purchases)";
            this.RepPurBtn.UseVisualStyleBackColor = false;
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Transparent;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Location = new System.Drawing.Point(-2, 604);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(280, 60);
            this.salesButton.TabIndex = 46;
            this.salesButton.Text = "Report (Sales)";
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BillPurBtn);
            this.Controls.Add(this.BillSalesBtn);
            this.Controls.Add(this.RepPurBtn);
            this.Controls.Add(this.StoreBtn);
            this.Controls.Add(this.Cursor);
            this.Controls.Add(this.SystemName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CatBtn);
            this.Controls.Add(this.ProdsBTN);
            this.Controls.Add(this.ProdTab);
            this.Controls.Add(this.SuppsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductView";
            this.Text = "Product";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.ProdTab.ResumeLayout(false);
            this.ProdTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ProdTab;
        private System.Windows.Forms.Button ProdsBTN;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label ProdTitle;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label StoreLb;
        private System.Windows.Forms.ComboBox StoreDrop;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.Label ProdPriceLb;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label ProdNameLb;
        private System.Windows.Forms.DataGridView ProdTbl;
        private System.Windows.Forms.Button SuppsBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.Panel Cursor;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.Button BillPurBtn;
        private System.Windows.Forms.Button BillSalesBtn;
        private System.Windows.Forms.Button RepPurBtn;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.ComboBox CatDrop;
        private System.Windows.Forms.Label CategoryLb;
        private System.Windows.Forms.TextBox salepricetextbox;
        private System.Windows.Forms.Label saleprice;
    }
}