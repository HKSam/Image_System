namespace ImageProcessingSystem
{
    partial class ImageProcess
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcess));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.GrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.GrayScaleInversion = new System.Windows.Forms.ToolStripMenuItem();
            this.Binaryzation = new System.Windows.Forms.ToolStripMenuItem();
            this.Cameo = new System.Windows.Forms.ToolStripMenuItem();
            this.Sharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.Atomize = new System.Windows.Forms.ToolStripMenuItem();
            this.Soften = new System.Windows.Forms.ToolStripMenuItem();
            this.Salt_change = new System.Windows.Forms.ToolStripMenuItem();
            this.img_MedianFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.Gray_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Erode_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Dilated_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Check_img = new System.Windows.Forms.ToolStripMenuItem();
            this.canny_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Sobel_img = new System.Windows.Forms.ToolStripMenuItem();
            this.HSV_img = new System.Windows.Forms.ToolStripMenuItem();
            this.sediao_img = new System.Windows.Forms.ToolStripMenuItem();
            this.baohe_img = new System.Windows.Forms.ToolStripMenuItem();
            this.light_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Light_reduction = new System.Windows.Forms.ToolStripMenuItem();
            this.Light_add = new System.Windows.Forms.ToolStripMenuItem();
            this.Dark_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Mosic = new System.Windows.Forms.ToolStripMenuItem();
            this.Spread = new System.Windows.Forms.ToolStripMenuItem();
            this.Decoloration = new System.Windows.Forms.ToolStripMenuItem();
            this.JH_img = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Clockwise_90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Rotate_90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Flip_img = new System.Windows.Forms.ToolStripMenuItem();
            this.FlipY_img = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.paishe_img = new System.Windows.Forms.ToolStripMenuItem();
            this.Write_img = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_canny = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Be = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImage,
            this.保存SCtrlSToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton1.Text = "文件(F)";
            // 
            // OpenImage
            // 
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(225, 22);
            this.OpenImage.Text = "打开(O)                 Ctrl+O";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // 保存SCtrlSToolStripMenuItem
            // 
            this.保存SCtrlSToolStripMenuItem.Name = "保存SCtrlSToolStripMenuItem";
            this.保存SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.保存SCtrlSToolStripMenuItem.Text = "保存(S)                  Ctrl+S";
            this.保存SCtrlSToolStripMenuItem.Click += new System.EventHandler(this.保存SCtrlSToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GrayScale,
            this.GrayScaleInversion,
            this.Binaryzation,
            this.Cameo,
            this.Sharpen,
            this.Atomize,
            this.Soften,
            this.Salt_change,
            this.img_MedianFilter,
            this.Gray_img,
            this.Erode_img,
            this.Dilated_img,
            this.Check_img,
            this.HSV_img,
            this.Dark_img,
            this.Mosic,
            this.Spread,
            this.Decoloration,
            this.JH_img});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "图像(I)";
            // 
            // GrayScale
            // 
            this.GrayScale.Name = "GrayScale";
            this.GrayScale.Size = new System.Drawing.Size(124, 22);
            this.GrayScale.Text = "灰度化";
            this.GrayScale.Click += new System.EventHandler(this.GrayScale_Click);
            // 
            // GrayScaleInversion
            // 
            this.GrayScaleInversion.Name = "GrayScaleInversion";
            this.GrayScaleInversion.Size = new System.Drawing.Size(124, 22);
            this.GrayScaleInversion.Text = "灰度反转";
            this.GrayScaleInversion.Click += new System.EventHandler(this.GrayScaleInversion_Click);
            // 
            // Binaryzation
            // 
            this.Binaryzation.Name = "Binaryzation";
            this.Binaryzation.Size = new System.Drawing.Size(124, 22);
            this.Binaryzation.Text = "二值化";
            this.Binaryzation.Click += new System.EventHandler(this.Binaryzation_Click);
            // 
            // Cameo
            // 
            this.Cameo.Name = "Cameo";
            this.Cameo.Size = new System.Drawing.Size(124, 22);
            this.Cameo.Text = "浮雕";
            this.Cameo.Click += new System.EventHandler(this.Cameo_Click);
            // 
            // Sharpen
            // 
            this.Sharpen.Name = "Sharpen";
            this.Sharpen.Size = new System.Drawing.Size(124, 22);
            this.Sharpen.Text = "锐化";
            this.Sharpen.Click += new System.EventHandler(this.Sharpen_Click);
            // 
            // Atomize
            // 
            this.Atomize.Name = "Atomize";
            this.Atomize.Size = new System.Drawing.Size(124, 22);
            this.Atomize.Text = "雾化";
            this.Atomize.Click += new System.EventHandler(this.Atomize_Click);
            // 
            // Soften
            // 
            this.Soften.Name = "Soften";
            this.Soften.Size = new System.Drawing.Size(124, 22);
            this.Soften.Text = "柔化";
            this.Soften.Click += new System.EventHandler(this.Soften_Click);
            // 
            // Salt_change
            // 
            this.Salt_change.Name = "Salt_change";
            this.Salt_change.Size = new System.Drawing.Size(124, 22);
            this.Salt_change.Text = "椒盐";
            this.Salt_change.Click += new System.EventHandler(this.Salt_change_Click);
            // 
            // img_MedianFilter
            // 
            this.img_MedianFilter.Name = "img_MedianFilter";
            this.img_MedianFilter.Size = new System.Drawing.Size(124, 22);
            this.img_MedianFilter.Text = "中值滤波";
            this.img_MedianFilter.Click += new System.EventHandler(this.img_MedianFilter_Click);
            // 
            // Gray_img
            // 
            this.Gray_img.Name = "Gray_img";
            this.Gray_img.Size = new System.Drawing.Size(124, 22);
            this.Gray_img.Text = "黑白化";
            this.Gray_img.Click += new System.EventHandler(this.Gray_img_Click);
            // 
            // Erode_img
            // 
            this.Erode_img.Name = "Erode_img";
            this.Erode_img.Size = new System.Drawing.Size(124, 22);
            this.Erode_img.Text = "腐蚀";
            this.Erode_img.Click += new System.EventHandler(this.Erode_img_Click);
            // 
            // Dilated_img
            // 
            this.Dilated_img.Name = "Dilated_img";
            this.Dilated_img.Size = new System.Drawing.Size(124, 22);
            this.Dilated_img.Text = "膨胀";
            this.Dilated_img.Click += new System.EventHandler(this.Dilated_img_Click);
            // 
            // Check_img
            // 
            this.Check_img.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canny_img,
            this.Sobel_img});
            this.Check_img.Name = "Check_img";
            this.Check_img.Size = new System.Drawing.Size(124, 22);
            this.Check_img.Text = "边缘检测";
            this.Check_img.Click += new System.EventHandler(this.Check_img_Click);
            // 
            // canny_img
            // 
            this.canny_img.Name = "canny_img";
            this.canny_img.Size = new System.Drawing.Size(136, 22);
            this.canny_img.Text = "Canny算子";
            this.canny_img.Click += new System.EventHandler(this.canny_img_Click);
            // 
            // Sobel_img
            // 
            this.Sobel_img.Name = "Sobel_img";
            this.Sobel_img.Size = new System.Drawing.Size(136, 22);
            this.Sobel_img.Text = "定向滤波器";
            this.Sobel_img.Click += new System.EventHandler(this.Sobel_img_Click);
            // 
            // HSV_img
            // 
            this.HSV_img.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sediao_img,
            this.baohe_img,
            this.light_img});
            this.HSV_img.Name = "HSV_img";
            this.HSV_img.Size = new System.Drawing.Size(124, 22);
            this.HSV_img.Text = "HSV";
            this.HSV_img.Click += new System.EventHandler(this.HSV_img_Click);
            // 
            // sediao_img
            // 
            this.sediao_img.Name = "sediao_img";
            this.sediao_img.Size = new System.Drawing.Size(112, 22);
            this.sediao_img.Text = "色调";
            this.sediao_img.Click += new System.EventHandler(this.sediao_img_Click);
            // 
            // baohe_img
            // 
            this.baohe_img.Name = "baohe_img";
            this.baohe_img.Size = new System.Drawing.Size(112, 22);
            this.baohe_img.Text = "饱和度";
            this.baohe_img.Click += new System.EventHandler(this.baohe_img_Click);
            // 
            // light_img
            // 
            this.light_img.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Light_reduction,
            this.Light_add});
            this.light_img.Name = "light_img";
            this.light_img.Size = new System.Drawing.Size(112, 22);
            this.light_img.Text = "亮度";
            this.light_img.Click += new System.EventHandler(this.light_img_Click);
            // 
            // Light_reduction
            // 
            this.Light_reduction.Name = "Light_reduction";
            this.Light_reduction.Size = new System.Drawing.Size(124, 22);
            this.Light_reduction.Text = "降低亮度";
            this.Light_reduction.Click += new System.EventHandler(this.Light_reduction_Click);
            // 
            // Light_add
            // 
            this.Light_add.Name = "Light_add";
            this.Light_add.Size = new System.Drawing.Size(124, 22);
            this.Light_add.Text = "增加亮度";
            this.Light_add.Click += new System.EventHandler(this.Light_add_Click);
            // 
            // Dark_img
            // 
            this.Dark_img.Name = "Dark_img";
            this.Dark_img.Size = new System.Drawing.Size(124, 22);
            this.Dark_img.Text = "暗角";
            this.Dark_img.Click += new System.EventHandler(this.Dark_img_Click);
            // 
            // Mosic
            // 
            this.Mosic.Name = "Mosic";
            this.Mosic.Size = new System.Drawing.Size(124, 22);
            this.Mosic.Text = "马赛克";
            this.Mosic.Click += new System.EventHandler(this.Mosic_Click);
            // 
            // Spread
            // 
            this.Spread.Name = "Spread";
            this.Spread.Size = new System.Drawing.Size(124, 22);
            this.Spread.Text = "扩散";
            this.Spread.Click += new System.EventHandler(this.Spread_Click);
            // 
            // Decoloration
            // 
            this.Decoloration.Name = "Decoloration";
            this.Decoloration.Size = new System.Drawing.Size(124, 22);
            this.Decoloration.Text = "去色";
            this.Decoloration.Click += new System.EventHandler(this.Decoloration_Click);
            // 
            // JH_img
            // 
            this.JH_img.Name = "JH_img";
            this.JH_img.Size = new System.Drawing.Size(124, 22);
            this.JH_img.Text = "均衡化";
            this.JH_img.Click += new System.EventHandler(this.JH_img_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clockwise_90,
            this.Rotate_90,
            this.Flip_img,
            this.FlipY_img});
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton3.Text = "变换(C)";
            // 
            // Clockwise_90
            // 
            this.Clockwise_90.Name = "Clockwise_90";
            this.Clockwise_90.Size = new System.Drawing.Size(155, 22);
            this.Clockwise_90.Text = "顺时针旋转90°";
            this.Clockwise_90.Click += new System.EventHandler(this.Clockwise_90_Click);
            // 
            // Rotate_90
            // 
            this.Rotate_90.Name = "Rotate_90";
            this.Rotate_90.Size = new System.Drawing.Size(155, 22);
            this.Rotate_90.Text = "逆时针旋转90°";
            this.Rotate_90.Click += new System.EventHandler(this.Rotate_90_Click);
            // 
            // Flip_img
            // 
            this.Flip_img.Name = "Flip_img";
            this.Flip_img.Size = new System.Drawing.Size(155, 22);
            this.Flip_img.Text = "水平翻转";
            this.Flip_img.Click += new System.EventHandler(this.Flip_img_Click);
            // 
            // FlipY_img
            // 
            this.FlipY_img.Name = "FlipY_img";
            this.FlipY_img.Size = new System.Drawing.Size(155, 22);
            this.FlipY_img.Text = "垂直翻转";
            this.FlipY_img.Click += new System.EventHandler(this.FlipY_img_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paishe_img,
            this.Write_img});
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton4.Text = "动态";
            // 
            // paishe_img
            // 
            this.paishe_img.Name = "paishe_img";
            this.paishe_img.Size = new System.Drawing.Size(100, 22);
            this.paishe_img.Text = "摄影";
            this.paishe_img.Click += new System.EventHandler(this.paishe_img_Click);
            // 
            // Write_img
            // 
            this.Write_img.Name = "Write_img";
            this.Write_img.Size = new System.Drawing.Size(100, 22);
            this.Write_img.Text = "写字";
            this.Write_img.Click += new System.EventHandler(this.Write_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pB
            // 
            this.pB.BackColor = System.Drawing.SystemColors.Control;
            this.pB.Location = new System.Drawing.Point(0, 25);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(800, 425);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 1;
            this.pB.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(620, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入pa&&pb";
            // 
            // btn_salt
            // 
            this.btn_salt.Location = new System.Drawing.Point(57, 142);
            this.btn_salt.Name = "btn_salt";
            this.btn_salt.Size = new System.Drawing.Size(75, 23);
            this.btn_salt.TabIndex = 4;
            this.btn_salt.Text = "确定";
            this.btn_salt.UseVisualStyleBackColor = true;
            this.btn_salt.Click += new System.EventHandler(this.btn_salt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pb:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pa:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_canny);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(620, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(180, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请输入高低阈值";
            // 
            // btn_canny
            // 
            this.btn_canny.Location = new System.Drawing.Point(57, 125);
            this.btn_canny.Margin = new System.Windows.Forms.Padding(2);
            this.btn_canny.Name = "btn_canny";
            this.btn_canny.Size = new System.Drawing.Size(75, 23);
            this.btn_canny.TabIndex = 6;
            this.btn_canny.Text = "确定";
            this.btn_canny.UseVisualStyleBackColor = true;
            this.btn_canny.Click += new System.EventHandler(this.btn_canny_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 39);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(108, 21);
            this.textBox5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "文件名：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 100);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(108, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 67);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 21);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "hight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "low:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(10, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(181, 98);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请输入要处理的图像名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "FileName:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 36);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(103, 21);
            this.textBox6.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Be);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(10, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 93);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "生成一个字";
            // 
            // btn_Be
            // 
            this.btn_Be.Location = new System.Drawing.Point(31, 59);
            this.btn_Be.Name = "btn_Be";
            this.btn_Be.Size = new System.Drawing.Size(75, 23);
            this.btn_Be.TabIndex = 2;
            this.btn_Be.Text = "生成";
            this.btn_Be.UseVisualStyleBackColor = true;
            this.btn_Be.Click += new System.EventHandler(this.btn_Be_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(65, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(103, 21);
            this.textBox7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "一个字：";
            // 
            // ImageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pB);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageProcess";
            this.Text = " ImageProcessingSystem";
            this.Load += new System.EventHandler(this.ImageProcess_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem OpenImage;
        private System.Windows.Forms.ToolStripMenuItem 保存SCtrlSToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem GrayScale;
        private System.Windows.Forms.ToolStripMenuItem GrayScaleInversion;
        private System.Windows.Forms.ToolStripMenuItem Binaryzation;
        private System.Windows.Forms.ToolStripMenuItem Cameo;
        private System.Windows.Forms.ToolStripMenuItem Sharpen;
        private System.Windows.Forms.ToolStripMenuItem Atomize;
        private System.Windows.Forms.ToolStripMenuItem Soften;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem Clockwise_90;
        private System.Windows.Forms.ToolStripMenuItem Rotate_90;
        private System.Windows.Forms.ToolStripMenuItem Salt_change;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_salt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem img_MedianFilter;
        private System.Windows.Forms.ToolStripMenuItem Flip_img;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem paishe_img;
        private System.Windows.Forms.ToolStripMenuItem FlipY_img;
        private System.Windows.Forms.ToolStripMenuItem Write_img;
        private System.Windows.Forms.ToolStripMenuItem Gray_img;
        private System.Windows.Forms.ToolStripMenuItem Erode_img;
        private System.Windows.Forms.ToolStripMenuItem Dilated_img;
        private System.Windows.Forms.ToolStripMenuItem Check_img;
        private System.Windows.Forms.ToolStripMenuItem canny_img;
        private System.Windows.Forms.ToolStripMenuItem Sobel_img;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_canny;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Be;
        private System.Windows.Forms.ToolStripMenuItem HSV_img;
        private System.Windows.Forms.ToolStripMenuItem sediao_img;
        private System.Windows.Forms.ToolStripMenuItem baohe_img;
        private System.Windows.Forms.ToolStripMenuItem light_img;
        private System.Windows.Forms.ToolStripMenuItem Dark_img;
        private System.Windows.Forms.ToolStripMenuItem Mosic;
        private System.Windows.Forms.ToolStripMenuItem Light_reduction;
        private System.Windows.Forms.ToolStripMenuItem Light_add;
        private System.Windows.Forms.ToolStripMenuItem Spread;
        private System.Windows.Forms.ToolStripMenuItem Decoloration;
        private System.Windows.Forms.ToolStripMenuItem JH_img;
    }
}

