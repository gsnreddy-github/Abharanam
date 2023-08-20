using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abharanam_App
{
    public partial class frmGallery : Form
    {
        #region Variable Declaration
        private bool isInitialized = false;
        #endregion

        #region Initialization      
        #endregion

        #region User Functions         
        private void InitializeForm()
        {
            try
            {
                this.Text = Resources.frmGallery_text;
            }
            catch (Exception)
            {
                throw;
            }
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
        #endregion

        #region System Functions
        public frmGallery()
        {
            InitializeComponent();
        }

        private void frmGalleryNew_Load(object sender, EventArgs e)
        {
            string rootPath = ConfigurationManager.AppSettings["RootFolderPathGallery"];

            PopulateTreeView(rootPath, treeViewFolders.Nodes);
        }



        #endregion


        private void treeViewFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flowLayoutPanelGallery.Controls.Clear();
            try
            {



                if (e.Node != null)
                {
                    string selectedFolderPath = Path.Combine(ConfigurationManager.AppSettings["RootFolderPath"], e.Node.FullPath);

                    LoadThumbnailImages(selectedFolderPath);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void LoadThumbnailImages(string folderPath)
        {
            flowLayoutPanelGallery.Controls.Clear(); // Clear existing thumbnail controls

            string[] imageExtensions = GetSupportedImageExtensions();
            List<string> imageFiles = new List<string>();

            foreach (string ext in imageExtensions)
            {
                string[] imageFilesSelected = Directory.GetFiles(folderPath, ext.Trim(), SearchOption.TopDirectoryOnly);
                if (imageFilesSelected.Length > 0)
                {
                    imageFiles.AddRange(imageFilesSelected);
                }
            }

            if (imageFiles.Count > 0)
            {
                int thumbnailSize = int.Parse(ConfigurationManager.AppSettings["ThumbnailSize"]);
                int maxColumns = flowLayoutPanelGallery.Width / thumbnailSize;

                int currentRow = 0;
                int currentColumn = 0;

                foreach (string imageFile in imageFiles)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imageFile),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = thumbnailSize,
                        Height = thumbnailSize,
                        Tag = imageFile // Store image file path in Tag property
                    };

                    pictureBox.Click += PictureBox_Click;

                    flowLayoutPanelGallery.Controls.Add(pictureBox);

                    pictureBox.Location = new Point(currentColumn * thumbnailSize, currentRow * thumbnailSize);

                    currentColumn++;
                    if (currentColumn >= maxColumns)
                    {
                        currentColumn = 0;
                        currentRow++;
                    }
                }
            }
            else
            {
                MessageBox.Show("No images found in the selected folder.");
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            List<string> imagePaths = flowLayoutPanelGallery.Controls
                .OfType<PictureBox>()
                .Select(pb => pb.Tag.ToString())
                .ToList();

            int selectedIndex = imagePaths.IndexOf(clickedPictureBox.Tag.ToString());

            if (selectedIndex != -1)
            {
                using (frmImagePopup popupForm = new frmImagePopup(imagePaths, selectedIndex))
                {
                    popupForm.ShowDialog();
                }
            }
        }




        private string[] GetSupportedImageExtensions()
        {
            string imageExtensionsSetting = ConfigurationManager.AppSettings["ImageExtensions"];
            string[] imageExtensions = imageExtensionsSetting.Split(',');

            for (int i = 0; i < imageExtensions.Length; i++)
            {
                imageExtensions[i] = imageExtensions[i].TrimStart('.');
            }

            return imageExtensions;
        }



    }
}
