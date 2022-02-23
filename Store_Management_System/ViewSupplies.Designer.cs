
namespace Store_Management_System
{
    partial class ViewSupplies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSupplies));
            this.backButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.SuppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.CompsBd = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdBd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesDataGridView)).BeginInit();
            this.CompsBd.SuspendLayout();
            this.AdBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = global::Store_Management_System.Properties.Resources.arrows_11__Converted_;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(16, 17);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 42);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Gray;
            this.companyLabel.Location = new System.Drawing.Point(38, 49);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(294, 47);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Supplier Name";
            // 
            // SuppliesDataGridView
            // 
            this.SuppliesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SuppliesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SuppliesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.SuppliesDataGridView.Location = new System.Drawing.Point(46, 117);
            this.SuppliesDataGridView.Name = "SuppliesDataGridView";
            this.SuppliesDataGridView.RowHeadersWidth = 51;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            this.SuppliesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.SuppliesDataGridView.RowTemplate.Height = 24;
            this.SuppliesDataGridView.Size = new System.Drawing.Size(753, 457);
            this.SuppliesDataGridView.TabIndex = 2;
            this.SuppliesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliesDataGridView_CellContentClick);
            // 
            // CompsBd
            // 
            this.CompsBd.BackColor = System.Drawing.Color.GhostWhite;
            this.CompsBd.Controls.Add(this.companyLabel);
            this.CompsBd.Controls.Add(this.panel3);
            this.CompsBd.Controls.Add(this.SuppliesDataGridView);
            this.CompsBd.Location = new System.Drawing.Point(190, 200);
            this.CompsBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompsBd.Name = "CompsBd";
            this.CompsBd.Size = new System.Drawing.Size(846, 649);
            this.CompsBd.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Store_Management_System.Properties.Resources.vector60_2623_01;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(711, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 95);
            this.panel3.TabIndex = 3;
            // 
            // AdBd
            // 
            this.AdBd.BackgroundImage = global::Store_Management_System.Properties.Resources.background_pink_yellow;
            this.AdBd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdBd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdBd.Controls.Add(this.label1);
            this.AdBd.Location = new System.Drawing.Point(1035, 200);
            this.AdBd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdBd.Name = "AdBd";
            this.AdBd.Size = new System.Drawing.Size(356, 648);
            this.AdBd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 340);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check\r\nYour\r\nSupplies\r\nHere!";
            // 
            // ViewSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.CompsBd);
            this.Controls.Add(this.AdBd);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSupplies";
            this.Text = "ViewSupplies";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewSupplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesDataGridView)).EndInit();
            this.CompsBd.ResumeLayout(false);
            this.CompsBd.PerformLayout();
            this.AdBd.ResumeLayout(false);
            this.AdBd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.DataGridView SuppliesDataGridView;
        private System.Windows.Forms.Panel CompsBd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel AdBd;
        private System.Windows.Forms.Label label1;
    }
}