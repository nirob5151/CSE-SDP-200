namespace WinFormsApp1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            donerToolStripMenuItem = new ToolStripMenuItem();
            addNewDonerToolStripMenuItem = new ToolStripMenuItem();
            updateDetailsToolStripMenuItem = new ToolStripMenuItem();
            allDonorDetailsToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            locationToolStripMenuItem = new ToolStripMenuItem();
            bloodGroupToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            increaseToolStripMenuItem = new ToolStripMenuItem();
            decreaseToolStripMenuItem = new ToolStripMenuItem();
            detailsToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem = new ToolStripMenuItem();
            deleteDonorToolStripMenuItem1 = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 128);
            menuStrip1.Items.AddRange(new ToolStripItem[] { donerToolStripMenuItem, searchToolStripMenuItem, stockToolStripMenuItem, deleteDonorToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1011, 68);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // donerToolStripMenuItem
            // 
            donerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewDonerToolStripMenuItem, updateDetailsToolStripMenuItem, allDonorDetailsToolStripMenuItem });
            donerToolStripMenuItem.Image = (Image)resources.GetObject("donerToolStripMenuItem.Image");
            donerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            donerToolStripMenuItem.Name = "donerToolStripMenuItem";
            donerToolStripMenuItem.Size = new Size(102, 64);
            donerToolStripMenuItem.Text = "Donor";
            // 
            // addNewDonerToolStripMenuItem
            // 
            addNewDonerToolStripMenuItem.Image = (Image)resources.GetObject("addNewDonerToolStripMenuItem.Image");
            addNewDonerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewDonerToolStripMenuItem.Name = "addNewDonerToolStripMenuItem";
            addNewDonerToolStripMenuItem.Size = new Size(166, 26);
            addNewDonerToolStripMenuItem.Text = "Add New Doner";
            addNewDonerToolStripMenuItem.Click += addNewDonerToolStripMenuItem_Click;
            // 
            // updateDetailsToolStripMenuItem
            // 
            updateDetailsToolStripMenuItem.Image = (Image)resources.GetObject("updateDetailsToolStripMenuItem.Image");
            updateDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            updateDetailsToolStripMenuItem.Size = new Size(166, 26);
            updateDetailsToolStripMenuItem.Text = "Update Details";
            updateDetailsToolStripMenuItem.Click += updateDetailsToolStripMenuItem_Click;
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            allDonorDetailsToolStripMenuItem.Image = (Image)resources.GetObject("allDonorDetailsToolStripMenuItem.Image");
            allDonorDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            allDonorDetailsToolStripMenuItem.Size = new Size(166, 26);
            allDonorDetailsToolStripMenuItem.Text = "All Donor Details";
            allDonorDetailsToolStripMenuItem.Click += allDonorDetailsToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locationToolStripMenuItem, bloodGroupToolStripMenuItem, nameToolStripMenuItem });
            searchToolStripMenuItem.Image = (Image)resources.GetObject("searchToolStripMenuItem.Image");
            searchToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(176, 64);
            searchToolStripMenuItem.Text = "Search Blood Doner ";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // locationToolStripMenuItem
            // 
            locationToolStripMenuItem.Image = (Image)resources.GetObject("locationToolStripMenuItem.Image");
            locationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            locationToolStripMenuItem.Size = new Size(145, 26);
            locationToolStripMenuItem.Text = "Location";
            locationToolStripMenuItem.Click += locationToolStripMenuItem_Click;
            // 
            // bloodGroupToolStripMenuItem
            // 
            bloodGroupToolStripMenuItem.Image = (Image)resources.GetObject("bloodGroupToolStripMenuItem.Image");
            bloodGroupToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            bloodGroupToolStripMenuItem.Size = new Size(145, 26);
            bloodGroupToolStripMenuItem.Text = "Blood Group";
            bloodGroupToolStripMenuItem.Click += bloodGroupToolStripMenuItem_Click;
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(145, 26);
            nameToolStripMenuItem.Text = "Name";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseToolStripMenuItem, decreaseToolStripMenuItem, detailsToolStripMenuItem });
            stockToolStripMenuItem.Image = (Image)resources.GetObject("stockToolStripMenuItem.Image");
            stockToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(98, 64);
            stockToolStripMenuItem.Text = "Stock";
            // 
            // increaseToolStripMenuItem
            // 
            increaseToolStripMenuItem.Image = (Image)resources.GetObject("increaseToolStripMenuItem.Image");
            increaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            increaseToolStripMenuItem.Size = new Size(184, 26);
            increaseToolStripMenuItem.Text = "Increase";
            increaseToolStripMenuItem.Click += increaseToolStripMenuItem_Click;
            // 
            // decreaseToolStripMenuItem
            // 
            decreaseToolStripMenuItem.Image = (Image)resources.GetObject("decreaseToolStripMenuItem.Image");
            decreaseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            decreaseToolStripMenuItem.Size = new Size(184, 26);
            decreaseToolStripMenuItem.Text = "Decrease";
            decreaseToolStripMenuItem.Click += decreaseToolStripMenuItem_Click;
            // 
            // detailsToolStripMenuItem
            // 
            detailsToolStripMenuItem.Image = (Image)resources.GetObject("detailsToolStripMenuItem.Image");
            detailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            detailsToolStripMenuItem.Size = new Size(184, 26);
            detailsToolStripMenuItem.Text = "Details";
            detailsToolStripMenuItem.Click += detailsToolStripMenuItem_Click;
            // 
            // deleteDonorToolStripMenuItem
            // 
            deleteDonorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteDonorToolStripMenuItem1 });
            deleteDonorToolStripMenuItem.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem.Image");
            deleteDonorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            deleteDonorToolStripMenuItem.Size = new Size(138, 64);
            deleteDonorToolStripMenuItem.Text = "Delete Donor";
            // 
            // deleteDonorToolStripMenuItem1
            // 
            deleteDonorToolStripMenuItem1.Image = (Image)resources.GetObject("deleteDonorToolStripMenuItem1.Image");
            deleteDonorToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            deleteDonorToolStripMenuItem1.Name = "deleteDonorToolStripMenuItem1";
            deleteDonorToolStripMenuItem1.Size = new Size(147, 26);
            deleteDonorToolStripMenuItem1.Text = "Delete Donor";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(122, 64);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1011, 704);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem donerToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem addNewDonerToolStripMenuItem;
        private ToolStripMenuItem updateDetailsToolStripMenuItem;
        private ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private ToolStripMenuItem locationToolStripMenuItem;
        private ToolStripMenuItem bloodGroupToolStripMenuItem;
        private ToolStripMenuItem nameToolStripMenuItem;
        private ToolStripMenuItem increaseToolStripMenuItem;
        private ToolStripMenuItem decreaseToolStripMenuItem;
        private ToolStripMenuItem detailsToolStripMenuItem;
        private ToolStripMenuItem deleteDonorToolStripMenuItem1;
    }
}