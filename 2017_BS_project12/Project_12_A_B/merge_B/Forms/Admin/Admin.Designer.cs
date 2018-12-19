namespace merge_B
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomeLblAdmin = new System.Windows.Forms.Label();
            this.MngSch = new MetroFramework.Controls.MetroTile();
            this.ManageProfiles = new MetroFramework.Controls.MetroTile();
            this.PermissionsBtn = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.logoutbtn = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.TechBtn = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(456, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Portal";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userByToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // userByToolStripMenuItem
            // 
            this.userByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem});
            this.userByToolStripMenuItem.Name = "userByToolStripMenuItem";
            this.userByToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.userByToolStripMenuItem.Text = "User";
            this.userByToolStripMenuItem.Click += new System.EventHandler(this.userByToolStripMenuItem_Click);
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // WelcomeLblAdmin
            // 
            this.WelcomeLblAdmin.AutoSize = true;
            this.WelcomeLblAdmin.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLblAdmin.ForeColor = System.Drawing.Color.Coral;
            this.WelcomeLblAdmin.Location = new System.Drawing.Point(-6, 34);
            this.WelcomeLblAdmin.Name = "WelcomeLblAdmin";
            this.WelcomeLblAdmin.Size = new System.Drawing.Size(136, 31);
            this.WelcomeLblAdmin.TabIndex = 4;
            this.WelcomeLblAdmin.Text = "Welcome, ";
            // 
            // MngSch
            // 
            this.MngSch.Location = new System.Drawing.Point(513, 208);
            this.MngSch.Name = "MngSch";
            this.MngSch.Size = new System.Drawing.Size(297, 100);
            this.MngSch.TabIndex = 8;
            this.MngSch.Text = "Manage Schedules";
            this.MngSch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MngSch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MngSch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MngSch.Click += new System.EventHandler(this.MngSch_Click);
            // 
            // ManageProfiles
            // 
            this.ManageProfiles.Location = new System.Drawing.Point(816, 208);
            this.ManageProfiles.Name = "ManageProfiles";
            this.ManageProfiles.Size = new System.Drawing.Size(170, 255);
            this.ManageProfiles.Style = MetroFramework.MetroColorStyle.Lime;
            this.ManageProfiles.TabIndex = 9;
            this.ManageProfiles.Text = "Manage Profiles";
            this.ManageProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageProfiles.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ManageProfiles.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ManageProfiles.Click += new System.EventHandler(this.ManageProfiles_Click);
            // 
            // PermissionsBtn
            // 
            this.PermissionsBtn.Location = new System.Drawing.Point(513, 314);
            this.PermissionsBtn.Name = "PermissionsBtn";
            this.PermissionsBtn.Size = new System.Drawing.Size(168, 149);
            this.PermissionsBtn.Style = MetroFramework.MetroColorStyle.Magenta;
            this.PermissionsBtn.TabIndex = 10;
            this.PermissionsBtn.Text = "Permissions";
            this.PermissionsBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.PermissionsBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.PermissionsBtn.Click += new System.EventHandler(this.PermissionsBtn_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(687, 314);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 149);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Requests";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(687, 469);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(299, 53);
            this.logoutbtn.Style = MetroFramework.MetroColorStyle.Green;
            this.logoutbtn.TabIndex = 12;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutbtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.logoutbtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ForeColor = System.Drawing.Color.Coral;
            this.metroTile2.Location = new System.Drawing.Point(311, 314);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(196, 208);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "Post Announcement";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(311, 208);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(196, 100);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "Search Student";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // TechBtn
            // 
            this.TechBtn.Location = new System.Drawing.Point(513, 469);
            this.TechBtn.Name = "TechBtn";
            this.TechBtn.Size = new System.Drawing.Size(168, 53);
            this.TechBtn.Style = MetroFramework.MetroColorStyle.Silver;
            this.TechBtn.TabIndex = 15;
            this.TechBtn.Text = "Technical Request";
            this.TechBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TechBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TechBtn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TechBtn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TechBtn.Click += new System.EventHandler(this.TechBtn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.ControlBox = false;
            this.Controls.Add(this.TechBtn);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.PermissionsBtn);
            this.Controls.Add(this.ManageProfiles);
            this.Controls.Add(this.MngSch);
            this.Controls.Add(this.WelcomeLblAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.Label WelcomeLblAdmin;
        private MetroFramework.Controls.MetroTile MngSch;
        private MetroFramework.Controls.MetroTile ManageProfiles;
        private MetroFramework.Controls.MetroTile PermissionsBtn;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile logoutbtn;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile TechBtn;
    }
}