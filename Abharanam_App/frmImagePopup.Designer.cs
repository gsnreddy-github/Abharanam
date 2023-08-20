namespace Abharanam_App
{
    partial class frmImagePopup
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
            pictureBoxPopup = new PictureBox();
            btnPrevious = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPopup).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPopup
            // 
            pictureBoxPopup.Location = new Point(126, 60);
            pictureBoxPopup.Name = "pictureBoxPopup";
            pictureBoxPopup.Size = new Size(524, 324);
            pictureBoxPopup.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxPopup.TabIndex = 0;
            pictureBoxPopup.TabStop = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(317, 390);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(398, 390);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmImagePopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBoxPopup);
            Name = "frmImagePopup";
            Text = "frmImagePopup";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPopup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPopup;
        private Button btnPrevious;
        private Button btnNext;
    }
}