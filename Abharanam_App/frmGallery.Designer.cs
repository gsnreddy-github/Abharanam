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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGallery));
            treeViewFolders = new TreeView();
            listViewImages = new ListView();
            imageListLarge = new ImageList(components);
            pictureBoxSelectedImage = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            linkLabel6 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            Home = new LinkLabel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // treeViewFolders
            // 
            treeViewFolders.BackColor = Color.Purple;
            treeViewFolders.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            treeViewFolders.ForeColor = Color.White;
            treeViewFolders.Location = new Point(4, 298);
            treeViewFolders.Margin = new Padding(4, 5, 4, 5);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(227, 747);
            treeViewFolders.TabIndex = 0;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // listViewImages
            // 
            listViewImages.BackColor = Color.Purple;
            listViewImages.Location = new Point(237, 298);
            listViewImages.Margin = new Padding(4, 5, 4, 5);
            listViewImages.Name = "listViewImages";
            listViewImages.Size = new Size(227, 747);
            listViewImages.TabIndex = 1;
            listViewImages.UseCompatibleStateImageBehavior = false;
            listViewImages.ItemSelectionChanged += listViewImages_ItemSelectionChanged;
            // 
            // imageListLarge
            // 
            imageListLarge.ColorDepth = ColorDepth.Depth8Bit;
            imageListLarge.ImageSize = new Size(100, 100);
            imageListLarge.TransparentColor = Color.Transparent;
            // 
            // pictureBoxSelectedImage
            // 
            pictureBoxSelectedImage.Location = new Point(472, 298);
            pictureBoxSelectedImage.Margin = new Padding(4, 5, 4, 5);
            pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            pictureBoxSelectedImage.Size = new Size(1022, 742);
            pictureBoxSelectedImage.TabIndex = 2;
            pictureBoxSelectedImage.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources._240_F_609814400_rMCzJ8CljPjvX6qXYqdqnVIhZQgCZIQ8;
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 275);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(linkLabel6);
            panel2.Controls.Add(linkLabel5);
            panel2.Controls.Add(linkLabel4);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(Home);
            panel2.Location = new Point(233, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(1484, 36);
            panel2.TabIndex = 5;
            // 
            // linkLabel6
            // 
            linkLabel6.AutoSize = true;
            linkLabel6.Location = new Point(1006, 3);
            linkLabel6.Name = "linkLabel6";
            linkLabel6.Size = new Size(73, 25);
            linkLabel6.TabIndex = 5;
            linkLabel6.TabStop = true;
            linkLabel6.Text = "Contact";
            // 
            // linkLabel5
            // 
            linkLabel5.ActiveLinkColor = Color.White;
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel5.ForeColor = Color.White;
            linkLabel5.LinkColor = Color.White;
            linkLabel5.Location = new Point(851, 8);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(102, 25);
            linkLabel5.TabIndex = 4;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "location";
            // 
            // linkLabel4
            // 
            linkLabel4.ActiveLinkColor = Color.White;
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(365, 9);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(101, 25);
            linkLabel4.TabIndex = 3;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Pintrest";
            linkLabel4.VisitedLinkColor = Color.White;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.White;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(227, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(117, 25);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Telegram";
            linkLabel3.VisitedLinkColor = Color.White;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(91, 8);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(127, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "WhatsApp";
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Home.ForeColor = Color.White;
            Home.LinkColor = Color.White;
            Home.Location = new Point(8, 8);
            Home.Name = "Home";
            Home.Size = new Size(77, 25);
            Home.TabIndex = 0;
            Home.TabStop = true;
            Home.Text = "Home";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(4, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1720, 289);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(233, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1478, 235);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // frmGallery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1727, 1050);
            Controls.Add(panel3);
            Controls.Add(pictureBoxSelectedImage);
            Controls.Add(listViewImages);
            Controls.Add(treeViewFolders);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmGallery";
            Text = "frmGallery";
            Load += frmGallery_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewFolders;
        private ListView listViewImages;
        private ImageList imageListLarge;
        private PictureBox pictureBoxSelectedImage;
        private PictureBox pictureBox1;
        private Panel panel2;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel5;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel Home;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}