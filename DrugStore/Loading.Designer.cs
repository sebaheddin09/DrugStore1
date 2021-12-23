
namespace DrugStore
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.loading_tm = new System.Windows.Forms.Timer(this.components);
            this.il_loading = new System.Windows.Forms.ImageList(this.components);
            this.pb_loading = new System.Windows.Forms.PictureBox();
            this.timer_image = new System.Windows.Forms.Timer(this.components);
            this.pnl_default = new System.Windows.Forms.Panel();
            this.pnl_loading = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // loading_tm
            // 
            this.loading_tm.Enabled = true;
            this.loading_tm.Interval = 30;
            this.loading_tm.Tick += new System.EventHandler(this.loading_tm_Tick);
            // 
            // il_loading
            // 
            this.il_loading.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_loading.ImageStream")));
            this.il_loading.TransparentColor = System.Drawing.Color.Transparent;
            this.il_loading.Images.SetKeyName(0, "-2-1920x1080.jpg");
            this.il_loading.Images.SetKeyName(1, "03860ed1ea2c441051327e0b0539e3b3.jpg");
            this.il_loading.Images.SetKeyName(2, "20378251.jpg");
            this.il_loading.Images.SetKeyName(3, "b83dcd53e8acd97e1d861a100329f2fe.jpg");
            this.il_loading.Images.SetKeyName(4, "Health-centre.jpg");
            this.il_loading.Images.SetKeyName(5, "let-us-help-you-fight-the-winter-blues-picture-id1127978625.jpg");
            this.il_loading.Images.SetKeyName(6, "Vietnam-drug-Store.jpg");
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(1, 0);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(999, 549);
            this.pb_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_loading.TabIndex = 1;
            this.pb_loading.TabStop = false;
            // 
            // timer_image
            // 
            this.timer_image.Enabled = true;
            this.timer_image.Interval = 1000;
            this.timer_image.Tick += new System.EventHandler(this.timer_image_Tick);
            // 
            // pnl_default
            // 
            this.pnl_default.BackColor = System.Drawing.Color.Transparent;
            this.pnl_default.ForeColor = System.Drawing.Color.White;
            this.pnl_default.Location = new System.Drawing.Point(13, 516);
            this.pnl_default.Name = "pnl_default";
            this.pnl_default.Size = new System.Drawing.Size(975, 22);
            this.pnl_default.TabIndex = 2;
            // 
            // pnl_loading
            // 
            this.pnl_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnl_loading.ForeColor = System.Drawing.Color.White;
            this.pnl_loading.Location = new System.Drawing.Point(13, 516);
            this.pnl_loading.Name = "pnl_loading";
            this.pnl_loading.Size = new System.Drawing.Size(59, 22);
            this.pnl_loading.TabIndex = 3;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.pnl_loading);
            this.Controls.Add(this.pb_loading);
            this.Controls.Add(this.pnl_default);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.pb_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer loading_tm;
        private System.Windows.Forms.ImageList il_loading;
        private System.Windows.Forms.PictureBox pb_loading;
        private System.Windows.Forms.Timer timer_image;
        private System.Windows.Forms.Panel pnl_default;
        private System.Windows.Forms.Panel pnl_loading;
    }
}