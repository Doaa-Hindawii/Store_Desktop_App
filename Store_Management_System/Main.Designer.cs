namespace Store_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Logo = new System.Windows.Forms.Panel();
            this.SystemName = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStore = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecificDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Buy = new System.Windows.Forms.ToolStripMenuItem();
            this.Sell = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(253, 58);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(273, 297);
            this.Logo.TabIndex = 14;
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.BackColor = System.Drawing.Color.Transparent;
            this.SystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemName.ForeColor = System.Drawing.Color.White;
            this.SystemName.Location = new System.Drawing.Point(154, 379);
            this.SystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(480, 33);
            this.SystemName.TabIndex = 15;
            this.SystemName.Text = "STORE MANAGEMENT SYSTEM";
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ReportsMenu,
            this.SalesMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 33);
            this.Menu.TabIndex = 16;
            this.Menu.Text = "Menu";
            // 
            // AddMenu
            // 
            this.AddMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProduct,
            this.AddCategory,
            this.AddStore});
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(62, 29);
            this.AddMenu.Text = "Add";
            // 
            // AddProduct
            // 
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(270, 34);
            this.AddProduct.Text = "Product";
            // 
            // AddCategory
            // 
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(270, 34);
            this.AddCategory.Text = "Category";
            // 
            // AddStore
            // 
            this.AddStore.Name = "AddStore";
            this.AddStore.Size = new System.Drawing.Size(270, 34);
            this.AddStore.Text = "Store";
            // 
            // ReportsMenu
            // 
            this.ReportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllDetails,
            this.SpecificDetails});
            this.ReportsMenu.Name = "ReportsMenu";
            this.ReportsMenu.Size = new System.Drawing.Size(89, 29);
            this.ReportsMenu.Text = "Reports";
            // 
            // AllDetails
            // 
            this.AllDetails.Name = "AllDetails";
            this.AllDetails.Size = new System.Drawing.Size(270, 34);
            this.AllDetails.Text = "All Details";
            // 
            // SpecificDetails
            // 
            this.SpecificDetails.Name = "SpecificDetails";
            this.SpecificDetails.Size = new System.Drawing.Size(270, 34);
            this.SpecificDetails.Text = "Specific Details";
            // 
            // SalesMenu
            // 
            this.SalesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Buy,
            this.Sell});
            this.SalesMenu.Name = "SalesMenu";
            this.SalesMenu.Size = new System.Drawing.Size(68, 29);
            this.SalesMenu.Text = "Sales";
            // 
            // Buy
            // 
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(270, 34);
            this.Buy.Text = "Buy";
            // 
            // Sell
            // 
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(270, 34);
            this.Sell.Text = "Sell";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SystemName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Main";
            this.Text = "Main";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem AddProduct;
        private System.Windows.Forms.ToolStripMenuItem AddCategory;
        private System.Windows.Forms.ToolStripMenuItem AddStore;
        private System.Windows.Forms.ToolStripMenuItem ReportsMenu;
        private System.Windows.Forms.ToolStripMenuItem AllDetails;
        private System.Windows.Forms.ToolStripMenuItem SpecificDetails;
        private System.Windows.Forms.ToolStripMenuItem SalesMenu;
        private System.Windows.Forms.ToolStripMenuItem Buy;
        private System.Windows.Forms.ToolStripMenuItem Sell;
    }
}