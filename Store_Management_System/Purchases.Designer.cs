
namespace Store_Management_System
{
    partial class Purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchases));
            this.exitButton = new System.Windows.Forms.Button();
            this.PurchsDataGridView = new System.Windows.Forms.DataGridView();
            this.PurchsTap = new System.Windows.Forms.Panel();
            this.HRow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storeLabel = new System.Windows.Forms.Label();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.monthLabel = new System.Windows.Forms.Label();
            this.PurchsTitle = new System.Windows.Forms.Label();
            this.BillSalesBtn = new System.Windows.Forms.Button();
            this.suppliersButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Cursor = new System.Windows.Forms.Panel();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.BillPurBtn = new System.Windows.Forms.Button();
            this.RepPurBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PurchsDataGridView)).BeginInit();
            this.PurchsTap.SuspendLayout();
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
            // PurchsDataGridView
            // 
            this.PurchsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PurchsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PurchsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.PurchsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.PurchsDataGridView.Location = new System.Drawing.Point(424, 82);
            this.PurchsDataGridView.Name = "PurchsDataGridView";
            this.PurchsDataGridView.RowHeadersWidth = 51;
            this.PurchsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.PurchsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.PurchsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PurchsDataGridView.RowTemplate.Height = 24;
            this.PurchsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchsDataGridView.Size = new System.Drawing.Size(1000, 850);
            this.PurchsDataGridView.TabIndex = 3;
            this.PurchsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchsDataGridView_CellContentClick);
            // 
            // PurchsTap
            // 
            this.PurchsTap.BackColor = System.Drawing.Color.GhostWhite;
            this.PurchsTap.Controls.Add(this.HRow);
            this.PurchsTap.Controls.Add(this.label2);
            this.PurchsTap.Controls.Add(this.storeLabel);
            this.PurchsTap.Controls.Add(this.StoreComboBox);
            this.PurchsTap.Controls.Add(this.monthCalendar);
            this.PurchsTap.Controls.Add(this.monthLabel);
            this.PurchsTap.Controls.Add(this.PurchsTitle);
            this.PurchsTap.Controls.Add(this.PurchsDataGridView);
            this.PurchsTap.Location = new System.Drawing.Point(280, 66);
            this.PurchsTap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchsTap.Name = "PurchsTap";
            this.PurchsTap.Size = new System.Drawing.Size(1500, 1000);
            this.PurchsTap.TabIndex = 10;
            this.PurchsTap.Paint += new System.Windows.Forms.PaintEventHandler(this.PurchsTap_Paint);
            // 
            // HRow
            // 
            this.HRow.BackColor = System.Drawing.Color.Silver;
            this.HRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HRow.ForeColor = System.Drawing.Color.Silver;
            this.HRow.Location = new System.Drawing.Point(22, 303);
            this.HRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HRow.Name = "HRow";
            this.HRow.Size = new System.Drawing.Size(375, 3);
            this.HRow.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Filter By Store";
            // 
            // storeLabel
            // 
            this.storeLabel.AutoSize = true;
            this.storeLabel.ForeColor = System.Drawing.Color.Gray;
            this.storeLabel.Location = new System.Drawing.Point(23, 196);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(48, 20);
            this.storeLabel.TabIndex = 23;
            this.storeLabel.Text = "Store";
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(108, 193);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(264, 28);
            this.StoreComboBox.TabIndex = 21;
            this.StoreComboBox.SelectedIndexChanged += new System.EventHandler(this.StoreComboBox_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.ForeColor = System.Drawing.Color.Teal;
            this.monthCalendar.Location = new System.Drawing.Point(60, 366);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 22;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.ForeColor = System.Drawing.Color.Gray;
            this.monthLabel.Location = new System.Drawing.Point(55, 335);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(115, 20);
            this.monthLabel.TabIndex = 19;
            this.monthLabel.Text = "Filter By Month";
            // 
            // PurchsTitle
            // 
            this.PurchsTitle.AutoSize = true;
            this.PurchsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchsTitle.ForeColor = System.Drawing.Color.Gray;
            this.PurchsTitle.Location = new System.Drawing.Point(15, 57);
            this.PurchsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurchsTitle.Name = "PurchsTitle";
            this.PurchsTitle.Size = new System.Drawing.Size(278, 37);
            this.PurchsTitle.TabIndex = 10;
            this.PurchsTitle.Text = "Purchases Board";
            // 
            // BillSalesBtn
            // 
            this.BillSalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.BillSalesBtn.FlatAppearance.BorderSize = 0;
            this.BillSalesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.BillSalesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillSalesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillSalesBtn.ForeColor = System.Drawing.Color.White;
            this.BillSalesBtn.Location = new System.Drawing.Point(2, 543);
            this.BillSalesBtn.Name = "BillSalesBtn";
            this.BillSalesBtn.Size = new System.Drawing.Size(280, 60);
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
            this.suppliersButton.Location = new System.Drawing.Point(2, 396);
            this.suppliersButton.Name = "suppliersButton";
            this.suppliersButton.Size = new System.Drawing.Size(280, 60);
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
            this.salesButton.Location = new System.Drawing.Point(2, 609);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(280, 60);
            this.salesButton.TabIndex = 13;
            this.salesButton.Text = "Report (Sales)";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.Transparent;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.Location = new System.Drawing.Point(-7, 330);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(280, 60);
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
            this.categoryButton.Location = new System.Drawing.Point(-7, 259);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(280, 60);
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
            this.panel2.Size = new System.Drawing.Size(131, 143);
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
            // Cursor
            // 
            this.Cursor.BackgroundImage = global::Store_Management_System.Properties.Resources.background_pink_yellow;
            this.Cursor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cursor.Location = new System.Drawing.Point(-9, 693);
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
            this.StoreBtn.Location = new System.Drawing.Point(-9, 191);
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
            this.BillPurBtn.Location = new System.Drawing.Point(2, 462);
            this.BillPurBtn.Name = "BillPurBtn";
            this.BillPurBtn.Size = new System.Drawing.Size(280, 60);
            this.BillPurBtn.TabIndex = 17;
            this.BillPurBtn.Text = "Bill (Purchases)";
            this.BillPurBtn.UseVisualStyleBackColor = false;
            this.BillPurBtn.Click += new System.EventHandler(this.BillPurBtn_Click);
            // 
            // RepPurBtn
            // 
            this.RepPurBtn.BackColor = System.Drawing.Color.Transparent;
            this.RepPurBtn.FlatAppearance.BorderSize = 0;
            this.RepPurBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.RepPurBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepPurBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepPurBtn.ForeColor = System.Drawing.Color.White;
            this.RepPurBtn.Location = new System.Drawing.Point(2, 693);
            this.RepPurBtn.Name = "RepPurBtn";
            this.RepPurBtn.Size = new System.Drawing.Size(280, 60);
            this.RepPurBtn.TabIndex = 42;
            this.RepPurBtn.Text = "Report (Purchases)";
            this.RepPurBtn.UseVisualStyleBackColor = false;
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1434, 795);
            this.Controls.Add(this.BillPurBtn);
            this.Controls.Add(this.StoreBtn);
            this.Controls.Add(this.Cursor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.salesButton);
            this.Controls.Add(this.suppliersButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.BillSalesBtn);
            this.Controls.Add(this.PurchsTap);
            this.Controls.Add(this.RepPurBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Purchases";
            this.Text = "Sales";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchsDataGridView)).EndInit();
            this.PurchsTap.ResumeLayout(false);
            this.PurchsTap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView PurchsDataGridView;
        private System.Windows.Forms.Panel PurchsTap;
        private System.Windows.Forms.Button BillSalesBtn;
        private System.Windows.Forms.Button suppliersButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Label PurchsTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Cursor;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.Button BillPurBtn;
        private System.Windows.Forms.Button RepPurBtn;
        private System.Windows.Forms.Label HRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label storeLabel;
        private System.Windows.Forms.ComboBox StoreComboBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label monthLabel;
    }
}