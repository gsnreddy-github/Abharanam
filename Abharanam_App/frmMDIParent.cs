using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abharanam_App
{
    public partial class frmMDIParent : Form
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
                this.Text = Resources.frmMDIParent_text;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ShowNewForm(Form childForm)
        {
            try
            {             
                
                childForm.MdiParent = this;
                childForm.Size = this.ClientSize;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region System Functions        
        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isInitialized)
                {
                    InitializeForm();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ShowNewForm(new frmGallery());              
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion        
    }
}
