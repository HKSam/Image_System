namespace ImageProcessingSystem
{
    partial class Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camera));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbxCameras = new System.Windows.Forms.ToolStripComboBox();
            this.link = new System.Windows.Forms.ToolStripButton();
            this.Img_save = new System.Windows.Forms.ToolStripButton();
            this.videPlayer = new AForge.Controls.VideoSourcePlayer();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tscbxCameras,
            this.link,
            this.Close,
            this.Img_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton1.Text = "视频输入设备：";
            // 
            // tscbxCameras
            // 
            this.tscbxCameras.DropDownWidth = 130;
            this.tscbxCameras.Name = "tscbxCameras";
            this.tscbxCameras.Size = new System.Drawing.Size(75, 25);
            // 
            // link
            // 
            this.link.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.link.Image = ((System.Drawing.Image)(resources.GetObject("link.Image")));
            this.link.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(36, 22);
            this.link.Text = "连接";
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // Img_save
            // 
            this.Img_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Img_save.Image = ((System.Drawing.Image)(resources.GetObject("Img_save.Image")));
            this.Img_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Img_save.Name = "Img_save";
            this.Img_save.Size = new System.Drawing.Size(60, 22);
            this.Img_save.Text = "保存图像";
            this.Img_save.Click += new System.EventHandler(this.Img_save_Click);
            // 
            // videPlayer
            // 
            this.videPlayer.Location = new System.Drawing.Point(12, 28);
            this.videPlayer.Name = "videPlayer";
            this.videPlayer.Size = new System.Drawing.Size(580, 316);
            this.videPlayer.TabIndex = 3;
            this.videPlayer.Text = "videPlayer";
            this.videPlayer.VideoSource = null;
            // 
            // Close
            // 
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 22);
            this.Close.Text = "关闭";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 356);
            this.Controls.Add(this.videPlayer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Camera";
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.Camera_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox tscbxCameras;
        private System.Windows.Forms.ToolStripButton link;
        private System.Windows.Forms.ToolStripButton Img_save;
        private AForge.Controls.VideoSourcePlayer videPlayer;
        private System.Windows.Forms.ToolStripButton Close;
    }
}