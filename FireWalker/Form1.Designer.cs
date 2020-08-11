namespace FireWalker
{
    partial class splashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashForm));
            this.splashPictureBox = new System.Windows.Forms.PictureBox();
            this.splashFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.splashNameLabel = new System.Windows.Forms.Label();
            this.splashBuildLabel = new System.Windows.Forms.Label();
            this.splashAuthorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashPictureBox
            // 
            this.splashPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("splashPictureBox.Image")));
            this.splashPictureBox.Location = new System.Drawing.Point(14, 12);
            this.splashPictureBox.Name = "splashPictureBox";
            this.splashPictureBox.Size = new System.Drawing.Size(390, 596);
            this.splashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.splashPictureBox.TabIndex = 0;
            this.splashPictureBox.TabStop = false;
            // 
            // splashFadeTimer
            // 
            this.splashFadeTimer.Enabled = true;
            this.splashFadeTimer.Tick += new System.EventHandler(this.splashFadeTimer_Tick);
            // 
            // splashNameLabel
            // 
            this.splashNameLabel.AutoSize = true;
            this.splashNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashNameLabel.ForeColor = System.Drawing.Color.White;
            this.splashNameLabel.Location = new System.Drawing.Point(144, 106);
            this.splashNameLabel.Name = "splashNameLabel";
            this.splashNameLabel.Size = new System.Drawing.Size(152, 36);
            this.splashNameLabel.TabIndex = 1;
            this.splashNameLabel.Text = "Fire Walker";
            // 
            // splashBuildLabel
            // 
            this.splashBuildLabel.AutoSize = true;
            this.splashBuildLabel.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashBuildLabel.ForeColor = System.Drawing.Color.White;
            this.splashBuildLabel.Location = new System.Drawing.Point(307, 207);
            this.splashBuildLabel.Name = "splashBuildLabel";
            this.splashBuildLabel.Size = new System.Drawing.Size(82, 11);
            this.splashBuildLabel.TabIndex = 2;
            this.splashBuildLabel.Text = "Build : .1a";
            // 
            // splashAuthorLabel
            // 
            this.splashAuthorLabel.AutoSize = true;
            this.splashAuthorLabel.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashAuthorLabel.ForeColor = System.Drawing.Color.White;
            this.splashAuthorLabel.Location = new System.Drawing.Point(12, 207);
            this.splashAuthorLabel.Name = "splashAuthorLabel";
            this.splashAuthorLabel.Size = new System.Drawing.Size(173, 11);
            this.splashAuthorLabel.TabIndex = 3;
            this.splashAuthorLabel.Text = "Author: Phillip Gilligan";
            // 
            // splashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(401, 227);
            this.Controls.Add(this.splashAuthorLabel);
            this.Controls.Add(this.splashBuildLabel);
            this.Controls.Add(this.splashNameLabel);
            this.Controls.Add(this.splashPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashForm";
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPictureBox;
        private System.Windows.Forms.Timer splashFadeTimer;
        private System.Windows.Forms.Label splashNameLabel;
        private System.Windows.Forms.Label splashBuildLabel;
        private System.Windows.Forms.Label splashAuthorLabel;
    }
}

