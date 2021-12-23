
namespace DrugStore
{
    partial class MainPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPicture));
            this.pb_mainpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_mainpicture
            // 
            this.pb_mainpicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_mainpicture.Image = ((System.Drawing.Image)(resources.GetObject("pb_mainpicture.Image")));
            this.pb_mainpicture.Location = new System.Drawing.Point(3, 3);
            this.pb_mainpicture.Name = "pb_mainpicture";
            this.pb_mainpicture.Size = new System.Drawing.Size(980, 474);
            this.pb_mainpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_mainpicture.TabIndex = 0;
            this.pb_mainpicture.TabStop = false;
            // 
            // MainPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 475);
            this.Controls.Add(this.pb_mainpicture);
            this.Name = "MainPicture";
            this.Text = "MainPicture";
            ((System.ComponentModel.ISupportInitialize)(this.pb_mainpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_mainpicture;
    }
}