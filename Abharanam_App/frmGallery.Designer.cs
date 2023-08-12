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
            treeViewFolders = new TreeView();
            listViewImages = new ListView();
            imageListLarge = new ImageList(components);
            pictureBoxSelectedImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).BeginInit();
            SuspendLayout();
            // 
            // treeViewFolders
            // 
            treeViewFolders.Location = new Point(1, 2);
            treeViewFolders.Name = "treeViewFolders";
            treeViewFolders.Size = new Size(160, 450);
            treeViewFolders.TabIndex = 0;
            treeViewFolders.AfterSelect += treeViewFolders_AfterSelect;
            // 
            // listViewImages
            // 
            listViewImages.Location = new Point(167, 4);
            listViewImages.Name = "listViewImages";
            listViewImages.Size = new Size(160, 450);
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
            pictureBoxSelectedImage.Location = new Point(335, 4);
            pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            pictureBoxSelectedImage.Size = new Size(450, 450);
            pictureBoxSelectedImage.TabIndex = 2;
            pictureBoxSelectedImage.TabStop = false;
            // 
            // frmGallery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 521);
            Controls.Add(pictureBoxSelectedImage);
            Controls.Add(listViewImages);
            Controls.Add(treeViewFolders);
            Name = "frmGallery";
            Text = "frmGallery";
            Load += frmGallery_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectedImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewFolders;
        private ListView listViewImages;
        private ImageList imageListLarge;
        private PictureBox pictureBoxSelectedImage;
    }
}