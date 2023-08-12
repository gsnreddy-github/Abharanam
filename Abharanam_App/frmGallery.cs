using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Abharanam_App
{
    public partial class frmGallery : Form
    {
        public frmGallery()
        {
            InitializeComponent();
        }

        private void frmGallery_Load(object sender, EventArgs e)
        {
            string rootPath = ConfigurationManager.AppSettings["RootFolderPathGallery"];

            PopulateTreeView(rootPath, treeViewFolders.Nodes);
        }

        private void PopulateTreeView(string path, TreeNodeCollection nodes)
        {
            var directory = new DirectoryInfo(path);
            var node = new TreeNode(directory.Name);

            foreach (var subdirectory in directory.GetDirectories())
            {
                PopulateTreeView(subdirectory.FullName, node.Nodes);
            }

            nodes.Add(node);
        }

        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewImages.Items.Clear();
            imageListLarge.Images.Clear();
            pictureBoxSelectedImage.Image = null;

            if (e.Node != null)
            {
                string selectedFolder = Path.Combine(ConfigurationManager.AppSettings["RootFolderPath"], e.Node.FullPath);

                HashSet<string> uniqueImagePaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                string imageExtensionsSetting = ConfigurationManager.AppSettings["ImageExtensions"];
                string[] imageExtensions = imageExtensionsSetting.Split(',');

                foreach (string extension in imageExtensions)
                {
                    string[] imageFiles = Directory.GetFiles(selectedFolder, extension.Trim(), SearchOption.TopDirectoryOnly);
                    foreach (string imagePath in imageFiles)
                    {
                        uniqueImagePaths.Add(imagePath);
                    }
                }

                foreach (string imageFile in uniqueImagePaths)
                {
                    using (Bitmap image = new Bitmap(imageFile))
                    {
                        imageListLarge.Images.Add(image);
                        ListViewItem item = new ListViewItem(Path.GetFileName(imageFile), imageListLarge.Images.Count - 1);
                        listViewImages.Items.Add(item);
                    }
                }

                listViewImages.LargeImageList = imageListLarge;
            }
        }



        private void listViewImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string selectedImage = e.Item.Text;
                string selectedFolder = ConfigurationManager.AppSettings["RootFolderPath"] + treeViewFolders.SelectedNode.FullPath;
                string imagePath = Path.Combine(selectedFolder, selectedImage);

                using (Bitmap originalImage = new Bitmap(imagePath))
                {
                    // Calculate the aspect ratio
                    float aspectRatio = (float)originalImage.Width / originalImage.Height;

                    // Set the maximum dimensions for the resized image
                    int maxWidth = 450;
                    int maxHeight = 450;

                    // Calculate the new dimensions while fitting within the maximum size
                    int newWidth, newHeight;

                    if (originalImage.Width > originalImage.Height)
                    {
                        newWidth = maxWidth;
                        newHeight = (int)(maxWidth / aspectRatio);
                    }
                    else
                    {
                        newHeight = maxHeight;
                        newWidth = (int)(maxHeight * aspectRatio);
                    }

                    // Resize the image
                    Bitmap resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                    // Display the resized image in the PictureBox
                    pictureBoxSelectedImage.Image = resizedImage;
                }
            }
        }


    }
}
