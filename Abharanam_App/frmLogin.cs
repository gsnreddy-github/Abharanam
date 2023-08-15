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
    public partial class frmLogin : Form
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
                this.Text = Resources.frmLogin_text;
                btnLogin.Text = Resources.frmLogin_btnLogin_text;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private bool formAuthentication()
        {
            return true;
        }

        private void ShowNewForm(Form childForm)
        {
            try
            {                
                childForm.WindowState = FormWindowState.Maximized; // Set the MDI parent form's window state to Maximized
                childForm.Show();
                this.Hide(); // Hide the login form
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region System Functions      
        public frmLogin()
        {
            InitializeComponent();

            int buttonWidth = btnLogin.Width;
            int buttonHeight = btnLogin.Height;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int buttonX = (formWidth - buttonWidth) / 2;
            int buttonY = (formHeight - buttonHeight) / 2;

            btnLogin.Location = new Point(buttonX, buttonY);
        }

        private void frmLogin_Load(object sender, EventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Perform authentication and validation here
                if (formAuthentication()) // Replace with your authentication logic
                {
                    ShowNewForm(new frmMDIParent());
                }
                else
                {
                    MessageBox.Show(Resources.msg_invalid_credentials);
                }
            }
            catch (Exception)
            {

                throw;
            }            
        }
        #endregion
    }
}
