﻿
namespace Store_Management_System
{
    partial class CategoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryView));
            this.CatTab = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.StoreDrop = new System.Windows.Forms.ComboBox();
            this.CatTbl = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatNameLb = new System.Windows.Forms.Label();
            this.CatTitle = new System.Windows.Forms.Label();
            this.CatIDLb = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.ProdsBTN = new System.Windows.Forms.Button();
            this.SuppsBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.SystemName = new System.Windows.Forms.Label();
            this.Cursor = new System.Windows.Forms.Panel();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.BillPurBtn = new System.Windows.Forms.Button();
            this.BillSalesBtn = new System.Windows.Forms.Button();
            this.RepPurBtn = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.CatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // CatTab
            // 
            this.CatTab.BackColor = System.Drawing.Color.GhostWhite;
            this.CatTab.Controls.Add(this.EditBtn);
            this.CatTab.Controls.Add(this.StoreDrop);
            this.CatTab.Controls.Add(this.CatTbl);
            this.CatTab.Controls.Add(this.DeleteBtn);
            this.CatTab.Controls.Add(this.NewBtn);
            this.CatTab.Controls.Add(this.AddBtn);
            this.CatTab.Controls.Add(this.CatNameTb);
            this.CatTab.Controls.Add(this.CatNameLb);
            this.CatTab.Controls.Add(this.CatTitle);
            this.CatTab.Controls.Add(this.CatIDLb);
            this.CatTab.Location = new System.Drawing.Point(280, 66);
            this.CatTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatTab.Name = "CatTab";
            this.CatTab.Size = new System.Drawing.Size(1500, 1000);
            this.CatTab.TabIndex = 2;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(288, 675);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(112, 35);
            this.EditBtn.TabIndex = 24;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // StoreDrop
            // 
            this.StoreDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreDrop.ForeColor = System.Drawing.Color.DimGray;
            this.StoreDrop.FormattingEnabled = true;
            this.StoreDrop.Location = new System.Drawing.Point(32, 165);
            this.StoreDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreDrop.Name = "StoreDrop";
            this.StoreDrop.Size = new System.Drawing.Size(352, 30);
            this.StoreDrop.TabIndex = 23;
            this.StoreDrop.SelectedIndexChanged += new System.EventHandler(this.StoreDrop_SelectedIndexChanged);
            // 
            // CatTbl
            // 
            this.CatTbl.AllowUserToAddRows = false;
            this.CatTbl.AllowUserToDeleteRows = false;
            this.CatTbl.AllowUserToResizeColumns = false;
            this.CatTbl.AllowUserToResizeRows = false;
            this.CatTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatTbl.BackgroundColor = System.Drawing.Color.White;
            this.CatTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatTbl.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.CatTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatTbl.DefaultCellStyle = dataGridViewCellStyle1;
            this.CatTbl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CatTbl.GridColor = System.Drawing.Color.Silver;
            this.CatTbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CatTbl.Location = new System.Drawing.Point(424, 82);
            this.CatTbl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatTbl.MultiSelect = false;
            this.CatTbl.Name = "CatTbl";
            this.CatTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.CatTbl.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatTbl.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.CatTbl.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.CatTbl.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CatTbl.RowTemplate.Height = 25;
            this.CatTbl.RowTemplate.ReadOnly = true;
            this.CatTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatTbl.ShowCellErrors = false;
            this.CatTbl.ShowCellToolTips = false;
            this.CatTbl.ShowEditingIcon = false;
            this.CatTbl.ShowRowErrors = false;
            this.CatTbl.Size = new System.Drawing.Size(1000, 849);
            this.CatTbl.TabIndex = 22;
            this.CatTbl.TabStop = false;
            this.CatTbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatTbl_CellContentClick);
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
            this.NewBtn.Location = new System.Drawing.Point(272, 495);
            this.NewBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(112, 35);
            this.NewBtn.TabIndex = 20;
            this.NewBtn.Text = "NEW";
            this.NewBtn.UseVisualStyleBackColor = false;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(62, 408);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(291, 35);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CatNameTb
            // 
            this.CatNameTb.BackColor = System.Drawing.Color.White;
            this.CatNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.DimGray;
            this.CatNameTb.Location = new System.Drawing.Point(33, 249);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(8);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(352, 30);
            this.CatNameTb.TabIndex = 15;
            this.CatNameTb.TextChanged += new System.EventHandler(this.CatNameTb_TextChanged);
            // 
            // CatNameLb
            // 
            this.CatNameLb.AutoSize = true;
            this.CatNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameLb.ForeColor = System.Drawing.Color.Gray;
            this.CatNameLb.Location = new System.Drawing.Point(28, 222);
            this.CatNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatNameLb.Name = "CatNameLb";
            this.CatNameLb.Size = new System.Drawing.Size(53, 20);
            this.CatNameLb.TabIndex = 14;
            this.CatNameLb.Text = "Name";
            // 
            // CatTitle
            // 
            this.CatTitle.AutoSize = true;
            this.CatTitle.BackColor = System.Drawing.Color.Transparent;
            this.CatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.CatTitle.Location = new System.Drawing.Point(15, 57);
            this.CatTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatTitle.Name = "CatTitle";
            this.CatTitle.Size = new System.Drawing.Size(285, 37);
            this.CatTitle.TabIndex = 9;
            this.CatTitle.Text = "Manage Category";
            // 
            // CatIDLb
            // 
            this.CatIDLb.AutoSize = true;
            this.CatIDLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIDLb.ForeColor = System.Drawing.Color.Gray;
            this.CatIDLb.Location = new System.Drawing.Point(28, 128);
            this.CatIDLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CatIDLb.Name = "CatIDLb";
            this.CatIDLb.Size = new System.Drawing.Size(54, 20);
            this.CatIDLb.TabIndex = 10;
            this.CatIDLb.Text = "Store:";
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
            this.CloseBtn.Size = new System.Drawing.Size(68, 63);
            this.CloseBtn.TabIndex = 26;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CatBtn
            // 
            this.CatBtn.BackColor = System.Drawing.Color.Transparent;
            this.CatBtn.FlatAppearance.BorderSize = 0;
            this.CatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.CatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatBtn.ForeColor = System.Drawing.Color.White;
            this.CatBtn.Location = new System.Drawing.Point(-4, 242);
            this.CatBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(282, 60);
            this.CatBtn.TabIndex = 29;
            this.CatBtn.Text = "Category";
            this.CatBtn.UseVisualStyleBackColor = false;
            // 
            // ProdsBTN
            // 
            this.ProdsBTN.BackColor = System.Drawing.Color.Transparent;
            this.ProdsBTN.FlatAppearance.BorderSize = 0;
            this.ProdsBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.ProdsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdsBTN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdsBTN.ForeColor = System.Drawing.Color.White;
            this.ProdsBTN.Location = new System.Drawing.Point(-2, 315);
            this.ProdsBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdsBTN.Name = "ProdsBTN";
            this.ProdsBTN.Size = new System.Drawing.Size(282, 60);
            this.ProdsBTN.TabIndex = 28;
            this.ProdsBTN.Text = "Products";
            this.ProdsBTN.UseVisualStyleBackColor = false;
            this.ProdsBTN.Click += new System.EventHandler(this.ProdsBTN_Click);
            // 
            // SuppsBtn
            // 
            this.SuppsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SuppsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SuppsBtn.FlatAppearance.BorderSize = 0;
            this.SuppsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.SuppsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuppsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppsBtn.ForeColor = System.Drawing.Color.White;
            this.SuppsBtn.Location = new System.Drawing.Point(0, 383);
            this.SuppsBtn.Name = "SuppsBtn";
            this.SuppsBtn.Size = new System.Drawing.Size(280, 60);
            this.SuppsBtn.TabIndex = 23;
            this.SuppsBtn.Text = "Suppliers";
            this.SuppsBtn.UseVisualStyleBackColor = false;
            this.SuppsBtn.Click += new System.EventHandler(this.SuppsBtn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Store_Management_System.Properties.Resources.store_512;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(72, 17);
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
            this.SystemName.TabIndex = 36;
            this.SystemName.Text = "Store Management System";
            // 
            // Cursor
            // 
            this.Cursor.BackgroundImage = global::Store_Management_System.Properties.Resources.background_pink_yellow;
            this.Cursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor.Location = new System.Drawing.Point(-2, 248);
            this.Cursor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cursor.Name = "Cursor";
            this.Cursor.Size = new System.Drawing.Size(18, 55);
            this.Cursor.TabIndex = 38;
            // 
            // StoreBtn
            // 
            this.StoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.StoreBtn.FlatAppearance.BorderSize = 0;
            this.StoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.StoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreBtn.ForeColor = System.Drawing.Color.White;
            this.StoreBtn.Location = new System.Drawing.Point(-4, 172);
            this.StoreBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(282, 60);
            this.StoreBtn.TabIndex = 40;
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
            this.BillPurBtn.Location = new System.Drawing.Point(0, 449);
            this.BillPurBtn.Name = "BillPurBtn";
            this.BillPurBtn.Size = new System.Drawing.Size(280, 60);
            this.BillPurBtn.TabIndex = 45;
            this.BillPurBtn.Text = "Bill (Purchases)";
            this.BillPurBtn.UseVisualStyleBackColor = false;
            this.BillPurBtn.Click += new System.EventHandler(this.BillPurBtn_Click_1);
            // 
            // BillSalesBtn
            // 
            this.BillSalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillSalesBtn.FlatAppearance.BorderSize = 0;
            this.BillSalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.BillSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSalesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillSalesBtn.ForeColor = System.Drawing.Color.White;
            this.BillSalesBtn.Location = new System.Drawing.Point(-2, 511);
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
            this.RepPurBtn.Location = new System.Drawing.Point(0, 590);
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
            this.salesButton.Location = new System.Drawing.Point(-2, 674);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(280, 60);
            this.salesButton.TabIndex = 46;
            this.salesButton.Text = "Report (Sales)";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click_1);
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BillPurBtn);
            this.Controls.Add(this.StoreBtn);
            this.Controls.Add(this.BillSalesBtn);
            this.Controls.Add(this.Cursor);
            this.Controls.Add(this.RepPurBtn);
            this.Controls.Add(this.SystemName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.CatTab);
            this.Controls.Add(this.ProdsBTN);
            this.Controls.Add(this.SuppsBtn);
            this.Controls.Add(this.CatBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryView";
            this.Text = "Category";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryView_Load);
            this.CatTab.ResumeLayout(false);
            this.CatTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CatTab;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox CatNameTb;
        private System.Windows.Forms.Label CatNameLb;
        private System.Windows.Forms.Label CatIDLb;
        private System.Windows.Forms.Label CatTitle;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button ProdsBTN;
        private System.Windows.Forms.DataGridView CatTbl;
        private System.Windows.Forms.Button SuppsBtn;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.Panel Cursor;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.Button BillPurBtn;
        private System.Windows.Forms.Button BillSalesBtn;
        private System.Windows.Forms.Button RepPurBtn;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.ComboBox StoreDrop;
        private System.Windows.Forms.Button EditBtn;
    }
}