
namespace Store_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Title = new System.Windows.Forms.Label();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.PwdLb = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Slogan = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.RoleDrop = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LoginTb = new System.Windows.Forms.Panel();
            this.RoleLb = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.SystemName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Panel();
            this.LoginTb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.DarkGray;
            this.Title.Location = new System.Drawing.Point(38, 91);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(178, 55);
            this.Title.TabIndex = 1;
            this.Title.Text = "LOGIN";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLb.ForeColor = System.Drawing.Color.Gray;
            this.UserNameLb.Location = new System.Drawing.Point(44, 265);
            this.UserNameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(94, 20);
            this.UserNameLb.TabIndex = 3;
            this.UserNameLb.Text = "User Name";
            // 
            // PwdLb
            // 
            this.PwdLb.AutoSize = true;
            this.PwdLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdLb.ForeColor = System.Drawing.Color.Gray;
            this.PwdLb.Location = new System.Drawing.Point(44, 354);
            this.PwdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PwdLb.Name = "PwdLb";
            this.PwdLb.Size = new System.Drawing.Size(83, 20);
            this.PwdLb.TabIndex = 4;
            this.PwdLb.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(45, 675);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(406, 48);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.BackColor = System.Drawing.Color.Transparent;
            this.Slogan.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Slogan.Location = new System.Drawing.Point(760, 692);
            this.Slogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(335, 25);
            this.Slogan.TabIndex = 8;
            this.Slogan.Text = "STORE YOU CAN BANK ON";
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(1390, 14);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(27, 25);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "X";
            // 
            // RoleDrop
            // 
            this.RoleDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDrop.ForeColor = System.Drawing.Color.Gray;
            this.RoleDrop.FormattingEnabled = true;
            this.RoleDrop.Items.AddRange(new object[] {
            "Admin"});
            this.RoleDrop.Location = new System.Drawing.Point(216, 208);
            this.RoleDrop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoleDrop.Name = "RoleDrop";
            this.RoleDrop.Size = new System.Drawing.Size(222, 28);
            this.RoleDrop.TabIndex = 19;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.ClearBtn.Location = new System.Drawing.Point(350, 448);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(88, 34);
            this.ClearBtn.TabIndex = 20;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoginTb
            // 
            this.LoginTb.BackColor = System.Drawing.Color.GhostWhite;
            this.LoginTb.Controls.Add(this.RoleLb);
            this.LoginTb.Controls.Add(this.Pwd);
            this.LoginTb.Controls.Add(this.UName);
            this.LoginTb.Controls.Add(this.RoleDrop);
            this.LoginTb.Controls.Add(this.ClearBtn);
            this.LoginTb.Controls.Add(this.Title);
            this.LoginTb.Controls.Add(this.UserNameLb);
            this.LoginTb.Controls.Add(this.LoginBtn);
            this.LoginTb.Controls.Add(this.PwdLb);
            this.LoginTb.Location = new System.Drawing.Point(0, 5);
            this.LoginTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.Size = new System.Drawing.Size(500, 794);
            this.LoginTb.TabIndex = 21;
            // 
            // RoleLb
            // 
            this.RoleLb.AutoSize = true;
            this.RoleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLb.ForeColor = System.Drawing.Color.Gray;
            this.RoleLb.Location = new System.Drawing.Point(212, 183);
            this.RoleLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLb.Name = "RoleLb";
            this.RoleLb.Size = new System.Drawing.Size(95, 20);
            this.RoleLb.TabIndex = 23;
            this.RoleLb.Text = "Select Role";
            // 
            // Pwd
            // 
            this.Pwd.BackColor = System.Drawing.Color.White;
            this.Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.ForeColor = System.Drawing.Color.DimGray;
            this.Pwd.Location = new System.Drawing.Point(48, 382);
            this.Pwd.Margin = new System.Windows.Forms.Padding(8);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(390, 30);
            this.Pwd.TabIndex = 22;
            // 
            // UName
            // 
            this.UName.BackColor = System.Drawing.Color.White;
            this.UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.ForeColor = System.Drawing.Color.DimGray;
            this.UName.Location = new System.Drawing.Point(48, 303);
            this.UName.Margin = new System.Windows.Forms.Padding(8);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(390, 30);
            this.UName.TabIndex = 21;
            // 
            // SystemName
            // 
            this.SystemName.AutoSize = true;
            this.SystemName.BackColor = System.Drawing.Color.Transparent;
            this.SystemName.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SystemName.Location = new System.Drawing.Point(508, 20);
            this.SystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SystemName.Name = "SystemName";
            this.SystemName.Size = new System.Drawing.Size(613, 71);
            this.SystemName.TabIndex = 23;
            this.SystemName.Text = "STORE MANAGEMENT SYSTEM";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Store_Management_System.Properties.Resources.store_512;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(728, 188);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(454, 474);
            this.Logo.TabIndex = 22;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Store_Management_System.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1434, 795);
            this.Controls.Add(this.SystemName);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.LoginTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginTb.ResumeLayout(false);
            this.LoginTb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label UserNameLb;
        private System.Windows.Forms.Label PwdLb;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.ComboBox RoleDrop;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel LoginTb;
        private System.Windows.Forms.Label SystemName;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label RoleLb;
    }
}

