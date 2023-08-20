namespace Abharanam_App
{
    partial class frmGallery
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
            tableLayoutPanelGalleryForm = new TableLayoutPanel();
            panelHeader = new Panel();
            panelHeaderMenu = new Panel();
            linkLabelContact = new LinkLabel();
            linkLabelLocation = new LinkLabel();
            linkLabelPintrest = new LinkLabel();
            linkLabelTeleGram = new LinkLabel();
            linkLabelWhatsApp = new LinkLabel();
            linkLabelHome = new LinkLabel();
            pictureBoxBanner = new PictureBox();
            pictureBoxLogo = new PictureBox();
            panelBody = new Panel();
            panelBodyGallery = new Panel();
            flowLayoutPanelGallery = new FlowLayoutPanel();
            treeViewFolders = new TreeView();
            tableLayoutPanelGalleryForm.SuspendLayout();
            panelHeader.SuspendLayout();
            panelHeaderMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelBody.SuspendLayout();
            panelBodyGallery.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelGalleryForm
            // 
            tableLayoutPanelGalleryForm.ColumnCount = 1;
            tableLayoutPanelGalleryForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelGalleryForm.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanelGalleryForm.Controls.Add(panelBody, 0, 1);
            tableLayoutPanelGalleryForm.Dock = DockStyle.Fill;
            tableLayoutPanelGalleryForm.Location = new Point(0, 0);
            tableLayoutPanelGalleryForm.Name = "tableLayoutPanelGalleryForm";
            tableLayoutPanelGalleryForm.RowCount = 2;
            tableLayoutPanelGalleryForm.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0023575F));
            tableLayoutPanelGalleryForm.RowStyles.Add(new RowStyle(SizeType.Percent, 75.99764F));
            tableLayoutPanelGalleryForm.Size = new Size(800, 450);
            tableLayoutPanelGalleryForm.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(panelHeaderMenu);
            panelHeader.Controls.Add(pictureBoxBanner);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(794, 102);
            panelHeader.TabIndex = 0;
            // 
            // panelHeaderMenu
            // 
            panelHeaderMenu.Controls.Add(linkLabelContact);
            panelHeaderMenu.Controls.Add(linkLabelLocation);
            panelHeaderMenu.Controls.Add(linkLabelPintrest);
            panelHeaderMenu.Controls.Add(linkLabelTeleGram);
            panelHeaderMenu.Controls.Add(linkLabelWhatsApp);
            panelHeaderMenu.Controls.Add(linkLabelHome);
            panelHeaderMenu.Location = new Point(162, 129);
            panelHeaderMenu.Name = "panelHeaderMenu";
            panelHeaderMenu.Size = new Size(629, 37);
            panelHeaderMenu.TabIndex = 2;
            // 
            // linkLabelContact
            // 
            linkLabelContact.AutoSize = true;
            linkLabelContact.Location = new Point(288, 6);
            linkLabelContact.Name = "linkLabelContact";
            linkLabelContact.Size = new Size(49, 15);
            linkLabelContact.TabIndex = 5;
            linkLabelContact.TabStop = true;
            linkLabelContact.Text = "Contact";
            // 
            // linkLabelLocation
            // 
            linkLabelLocation.AutoSize = true;
            linkLabelLocation.Location = new Point(229, 6);
            linkLabelLocation.Name = "linkLabelLocation";
            linkLabelLocation.Size = new Size(53, 15);
            linkLabelLocation.TabIndex = 4;
            linkLabelLocation.TabStop = true;
            linkLabelLocation.Text = "Location";
            // 
            // linkLabelPintrest
            // 
            linkLabelPintrest.AutoSize = true;
            linkLabelPintrest.Location = new Point(176, 6);
            linkLabelPintrest.Name = "linkLabelPintrest";
            linkLabelPintrest.Size = new Size(47, 15);
            linkLabelPintrest.TabIndex = 3;
            linkLabelPintrest.TabStop = true;
            linkLabelPintrest.Text = "Pintrest";
            // 
            // linkLabelTeleGram
            // 
            linkLabelTeleGram.AutoSize = true;
            linkLabelTeleGram.Location = new Point(114, 6);
            linkLabelTeleGram.Name = "linkLabelTeleGram";
            linkLabelTeleGram.Size = new Size(56, 15);
            linkLabelTeleGram.TabIndex = 2;
            linkLabelTeleGram.TabStop = true;
            linkLabelTeleGram.Text = "TeleGram";
            // 
            // linkLabelWhatsApp
            // 
            linkLabelWhatsApp.AutoSize = true;
            linkLabelWhatsApp.Location = new Point(46, 5);
            linkLabelWhatsApp.Name = "linkLabelWhatsApp";
            linkLabelWhatsApp.Size = new Size(62, 15);
            linkLabelWhatsApp.TabIndex = 1;
            linkLabelWhatsApp.TabStop = true;
            linkLabelWhatsApp.Text = "WhatsApp";
            // 
            // linkLabelHome
            // 
            linkLabelHome.AutoSize = true;
            linkLabelHome.Location = new Point(3, 6);
            linkLabelHome.Name = "linkLabelHome";
            linkLabelHome.Size = new Size(40, 15);
            linkLabelHome.TabIndex = 0;
            linkLabelHome.TabStop = true;
            linkLabelHome.Text = "Home";
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Image = Resources.AMJBanner;
            pictureBoxBanner.Location = new Point(162, 3);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(629, 128);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxBanner.TabIndex = 1;
            pictureBoxBanner.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.AMJLogo;
            pictureBoxLogo.Location = new Point(3, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(153, 152);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelBody
            // 
            panelBody.Controls.Add(panelBodyGallery);
            panelBody.Controls.Add(treeViewFolders);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(3, 111);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(794, 336);
            panelBody.TabIndex = 1;
            // 
            // panelBodyGallery
            // 
            panelBodyGallery.AllowDrop = true;
            panelBodyGallery.AutoScroll = true;
            panelBodyGallery.Controls.Add(flowLayoutPanelGallery);
            panelBodyGallery.Location = new Point(160, 4);
            panelBodyGallery.Name = "panelBodyGallery";
            panelBodyGallery.Size = new Size(631, 322);
            panelBodyGallery.TabIndex = 2;
            // 
            // flowLayoutPanelGallery
            // 
            flowLayoutPanelGallery.AutoScroll = true;
            flowLayoutPanelGallery.Dock = DockStyle.Fill;
            flowLayoutPanelGallery.Location = new Point(0, 0);
            flowLayoutPanelGallery.Name = "flowLayoutPanelGallery";
            flowLayoutPanelGallery.Size = new Size(631, 322);
            flowLayoutPanelGallery.TabIndex = 1;
            // 
            // treeViewFolders
            // 
            treeViewFolders.AccessibleDescription = "";
            treeViewFolders.Dock = DockStyle.Left;
            treeViewFolders.Location = new Point(0, 0);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(154, 336);
            treeViewFolders.TabIndex = 0;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // frmGalleryNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelGalleryForm);
            Name = "frmGalleryNew";
            Text = "frmGalleryNew";
            Load += frmGalleryNew_Load;
            tableLayoutPanelGalleryForm.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeaderMenu.ResumeLayout(false);
            panelHeaderMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelBody.ResumeLayout(false);
            panelBodyGallery.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelGalleryForm;
        private Panel panelHeader;
        private Panel panelBody;
        private PictureBox pictureBoxBanner;
        private PictureBox pictureBoxLogo;
        private Panel panelHeaderMenu;
        private LinkLabel linkLabelHome;
        private LinkLabel linkLabelWhatsApp;
        private LinkLabel linkLabelTeleGram;
        private LinkLabel linkLabelPintrest;
        private LinkLabel linkLabelContact;
        private LinkLabel linkLabelLocation;
        private TreeView treeViewFolders;
        private FlowLayoutPanel flowLayoutPanelGallery;
        private Panel panelBodyGallery;
    }
}