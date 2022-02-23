
namespace Store_Management_System
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.exitButton = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.SalesTap = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cursor = new System.Windows.Forms.Panel();
            this.storeLabel = new System.Windows.Forms.Label();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.SalesTitle = new System.Windows.Forms.Label();
            this.BillSalesBtn = new System.Windows.Forms.Button();
            this.suppliersButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.BillPurBtn = new System.Windows.Forms.Button();
            this.PurchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SalesTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1710, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(68, 63);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.salesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.salesDataGridView.GridColor = System.Drawing.Color.Silver;
            this.salesDataGridView.Location = new System.Drawing.Point(424, 82);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.salesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(1000, 850);
            this.salesDataGridView.TabIndex = 3;
            // 
            // SalesTap
            // 
            this.SalesTap.BackColor = System.Drawing.Color.GhostWhite;
            this.SalesTap.Controls.Add(this.label2);
            this.SalesTap.Controls.Add(this.Cursor);
            this.SalesTap.Controls.Add(this.storeLabel);
            this.SalesTap.Controls.Add(this.StoreComboBox);
            this.SalesTap.Controls.Add(this.SalesTitle);
            this.SalesTap.Controls.Add(this.salesDataGridView);
            this.SalesTap.Controls.Add(this.BillSalesBtn);
            this.SalesTap.Location = new System.Drawing.Point(280, 66);
            this.SalesTap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesTap.Name = "SalesTap";
            this.SalesTap.Size = new System.Drawing.Size(1500, 1000);
            this.SalesTap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Filter By Store";
            // 
            // Cursor
            // 
            this.Cursor.BackgroundImage = global::Store_Management_System.Properties.Resources.background_pink_yellow;
            this.Cursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor.Location = new System.Drawing.Point(-44, 138);
            this.Cursor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cursor.Name = "Cursor";
            this.Cursor.Size = new System.Drawing.Size(18, 97);
            this.Cursor.TabIndex = 41;
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.ForeColor = System.Drawing.Color.Gray;
            this.storeLabel.Location = new System.Drawing.Point(23, 193);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(48, 20);
            this.storeLabel.TabIndex = 27;
            this.storeLabel.Text = "Store";
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(108, 190);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(264, 28);
            this.StoreComboBox.TabIndex = 26;
            this.StoreComboBox.SelectedIndexChanged += new System.EventHandler(this.StoreComboBox_SelectedIndexChanged);
            // 
            // SalesTitle
            // 
            this.SalesTitle.AutoSize = true;
            this.SalesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTitle.ForeColor = System.Drawing.Color.Gray;
            this.SalesTitle.Location = new System.Drawing.Point(15, 57);
            this.SalesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesTitle.Name = "SalesTitle";
            this.SalesTitle.Size = new System.Drawing.Size(202, 37);
            this.SalesTitle.TabIndex = 10;
            this.SalesTitle.Text = "Sales Board";
            // 
            // BillSalesBtn
            // 
            this.BillSalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillSalesBtn.FlatAppearance.BorderSize = 0;
            this.BillSalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.BillSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSalesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillSalesBtn.ForeColor = System.Drawing.Color.White;
            this.BillSalesBtn.Location = new System.Drawing.Point(-44, 315);
            this.BillSalesBtn.Name = "BillSalesBtn";
            this.BillSalesBtn.Size = new System.Drawing.Size(280, 97);
            this.BillSalesBtn.TabIndex = 11;
            this.BillSalesBtn.Text = "Bill (Sales)";
            this.BillSalesBtn.UseVisualStyleBackColor = false;
            this.BillSalesBtn.Click += new System.EventHandler(this.BillSalesBtn_Click);
            // 
            // suppliersButton
            // 
            this.suppliersButton.BackColor = System.Drawing.Color.Transparent;
            this.suppliersButton.FlatAppearance.BorderSize = 0;
            this.suppliersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.suppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersButton.ForeColor = System.Drawing.Color.White;
            this.suppliersButton.Location = new System.Drawing.Point(-2, 435);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Size = new System.Drawing.Size(280, 97);
            this.suppliersButton.TabIndex = 12;
            this.suppliersButton.Text = "Suppliers";
            this.suppliersButton.UseVisualStyleBackColor = false;
            this.suppliersButton.Click += new System.EventHandler(this.suppliersButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.Color.Transparent;
            this.salesButton.FlatAppearance.BorderSize = 0;
            this.salesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.ForeColor = System.Drawing.Color.White;
            this.salesButton.Location = new System.Drawing.Point(-2, 608);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(280, 97);
            this.salesButton.TabIndex = 13;
            this.salesButton.Text = "Report (Sales)";
            this.salesButton.UseVisualStyleBackColor = false;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.Transparent;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.Location = new System.Drawing.Point(-4, 332);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(280, 97);
            this.productsButton.TabIndex = 14;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.BackColor = System.Drawing.Color.Transparent;
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Location = new System.Drawing.Point(-2, 229);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(280, 97);
            this.categoryButton.TabIndex = 15;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = false;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Store_Management_System.Properties.Resources.store_512;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(72, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 130);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(298, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Store Management System";
            // 
            // StoreBtn
            // 
            this.StoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.StoreBtn.FlatAppearance.BorderSize = 0;
            this.StoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.StoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreBtn.ForeColor = System.Drawing.Color.White;
            this.StoreBtn.Location = new System.Drawing.Point(-4, 157);
            this.StoreBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(282, 97);
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
            this.BillPurBtn.Location = new System.Drawing.Point(-2, 518);
            this.BillPurBtn.Name = "BillPurBtn";
            this.BillPurBtn.Size = new System.Drawing.Size(280, 97);
            this.BillPurBtn.TabIndex = 17;
            this.BillPurBtn.Text = "Bill (Purchases)";
            this.BillPurBtn.UseVisualStyleBackColor = false;
            this.BillPurBtn.Click += new System.EventHandler(this.BillPurBtn_Click);
            // 
            // PurchBtn
            // 
            this.PurchBtn.BackColor = System.Drawing.Color.Transparent;
            this.PurchBtn.FlatAppearance.BorderSize = 0;
            this.PurchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.PurchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurchBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchBtn.ForeColor = System.Drawing.Color.White;
            this.PurchBtn.Location = new System.Drawing.Point(-2, 686);
            this.PurchBtn.Name = "PurchBtn";
            this.PurchBtn.Size = new System.Drawing.Size(280, 97);
            this.PurchBtn.TabIndex = 42;
            this.PurchBtn.Text = "Report (Purchases)";
            this.PurchBtn.UseVisualStyleBackColor = false;
            this.PurchBtn.Click += new System.EventHandler(this.PurchBtn_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1434, 795);
            this.Controls.Add(this.PurchBtn);
            this.Controls.Add(this.BillPurBtn);
            this.Controls.Add(this.StoreBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.suppliersButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.SalesTap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales";
            this.Text = "Sales";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.SalesTap.ResumeLayout(false);
            this.SalesTap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Panel SalesTap;
        private System.Windows.Forms.Button BillSalesBtn;
        private System.Windows.Forms.Button suppliersButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Label SalesTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Cursor;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.Button BillPurBtn;
        private System.Windows.Forms.Button PurchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox StoreComboBox;
    }
}