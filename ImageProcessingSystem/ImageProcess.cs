using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using Point = System.Drawing.Point;
using System.Drawing.Printing;
using Size = System.Drawing.Size;
using OpenCvSharp.Extensions;


namespace ImageProcessingSystem
{
    public partial class ImageProcess : Form
    {
        public ImageProcess()
        {
            InitializeComponent();
        }
        public byte[,] Data;//保存像素矩阵

        private string curFileName;

        private System.Drawing.Bitmap curBitmap;

       

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
                "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "位图( *.bmp; *.jpg; *.png;...) | *.bmp; *.pcx; *.png; *.jpg; *.gif; *.tif; *.ico|" +
                "矢量图( *.wmf; *.eps; *.emf;...) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            opnDlg.Title = "打开图像文件";
            opnDlg.ShowHelp = true;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opnDlg.FileName;
                try
                {
                    curBitmap = (Bitmap)Image.FromFile(curFileName);
                    this.pB.Image = curBitmap;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

            }
        }

        private void 保存SCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curBitmap == null)
            {
                return;
            }
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Title = "保存为";
            saveDlg.OverwritePrompt = true;
            saveDlg.Filter =
                "BMP文件 (*.bmp) | *.bmp|" +
                "Gif文件 (*.gif) | *.gif|" +
                "JPEG文件 (*.jpg) | *.jpg|" +
                "PNG文件 (*.png) | *.png";
            saveDlg.ShowHelp = true;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDlg.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        curBitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }

        }

        internal void change_size(Bitmap pic)
        {
            throw new NotImplementedException();
        }

        public static Bitmap GrayReverse(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    Color newColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        public static Bitmap ToGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    //利用公式计算灰度值
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }
        private void GrayScale_Click(object sender, EventArgs e)
        {
            
            try
            {
                Bitmap bitmap = new Bitmap(pB.Image);
                this.pB.Image = ToGray(bitmap);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        
        private void GrayScaleInversion_Click(object sender, EventArgs e)
        {

            try
            {
                Bitmap bitmap = new Bitmap(pB.Image);
                this.pB.Image =GrayReverse(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        public static Bitmap ConvertTo1Bpp1(Bitmap bmp)
        {

            int average = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    average += color.B;
                }
            }
            average = (int)average / (bmp.Width * bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    int value = 255 - color.B;
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }
        private void Binaryzation_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(pB.Image);
                this.pB.Image = ConvertTo1Bpp1(bitmap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void Cameo_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap myBitmap = new Bitmap(pB.Image);//创建Bitmap对象：提取像素信息，转化为二维数组
                for (int i = 0; i < myBitmap.Width - 1; i++)
                {
                    for (int j = 0; j < myBitmap.Height - 1; j++)
                    {
                        Color Color1 = myBitmap.GetPixel(i, j);//调用GetPixel方法获得像素点颜色
                        Color Color2 = myBitmap.GetPixel(i + 1, j + 1);
                        int red = Math.Abs(Color1.R - Color2.R + 128); //调用绝对值Abs函数
                                                                       //颜色处理
                        int green = Math.Abs(Color1.G - Color2.G + 128);
                        int blue = Math.Abs(Color1.B - Color2.B + 128);
                        if (red > 255) red = 255;
                        if (red < 0) red = 0;
                        if (green > 255) green = 255;
                        if (green < 0) green = 0;
                        if (blue > 255) blue = 255;
                        if (blue < 0) blue = 0;
                        //用SetPixel()方法设置像素点颜色
                        myBitmap.SetPixel(i, j, Color.FromArgb(red, green, blue));
                    }
                }
                pB.Image = myBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void Sharpen_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap myBitmap = new Bitmap(pB.Image);
                //建立拉普拉斯模板
                int[] Laplacian = { -1, -1, -1, -1, 9, -1, -1, -1, -1 };
                Color pixel;
                //这里注意边界的像素暂不处理，否则超出数组范围
                for (int i = 1; i < myBitmap.Width - 1; i++)
                {
                    for (int j = 1; j < myBitmap.Height - 1; j++)
                    {
                        int red = 0, green = 0, blue = 0;
                        int index = 0;
                        for (int col = -1; col <= 1; col++) //3*3处理
                        {
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = myBitmap.GetPixel(i + row, j + col);
                                red += pixel.R * Laplacian[index];
                                green += pixel.G * Laplacian[index];
                                blue += pixel.B * Laplacian[index];
                                index++;
                            }
                        }
                        if (red > 255) red = 255;
                        if (red < 0) red = 0;
                        if (green > 255) green = 255;
                        if (green < 0) green = 0;
                        if (blue > 255) blue = 255;
                        if (blue < 0) blue = 0;
                        myBitmap.SetPixel(i - 1, j - 1, Color.FromArgb((int)red, (int)green, (int)blue)); //这里注意是i-1,j-1，否则效果很糟糕
                    }
                }
                pB.Image = myBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void Atomize_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pB.Image.Height;
                int Width = this.pB.Image.Width;
                Bitmap newBitmap = new Bitmap(Width, Height);
                Bitmap oldBitmap = (Bitmap)this.pB.Image;
                Color pixel;
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        System.Random MyRandom = new Random();
                        int k = MyRandom.Next(123456);
                        //像素块大小
                        int dx = x + k % 19;
                        int dy = y + k % 19;
                        if (dx >= Width)
                            dx = Width - 1;
                        if (dy >= Height)
                            dy = Height - 1;
                        pixel = oldBitmap.GetPixel(dx, dy);
                        newBitmap.SetPixel(x, y, pixel);
                    }
                this.pB.Image = newBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

        private void Soften_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pB.Image.Height;
                int Width = this.pB.Image.Width;
                Bitmap bitmap = new Bitmap(Width, Height);
                Bitmap MyBitmap = (Bitmap)this.pB.Image;
                Color pixel;
                //高斯模板
                int[] Gauss = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        int r = 0, g = 0, b = 0;
                        int Index = 0;
                        for (int col = -1; col <= 1; col++)
                            for (int row = -1; row <= 1; row++)
                            {
                                pixel = MyBitmap.GetPixel(x + row, y + col);
                                r += pixel.R * Gauss[Index];
                                g += pixel.G * Gauss[Index];
                                b += pixel.B * Gauss[Index];
                                Index++;
                            }
                        r /= 16;
                        g /= 16;
                        b /= 16;
                        //处理颜色值溢出
                        r = r > 255 ? 255 : r;
                        r = r < 0 ? 0 : r;
                        g = g > 255 ? 255 : g;
                        g = g < 0 ? 0 : g;
                        b = b > 255 ? 255 : b;
                        b = b < 0 ? 0 : b;
                        bitmap.SetPixel(x - 1, y - 1, Color.FromArgb(r, g, b));
                    }
                this.pB.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }

       

        private void ImageProcess_Load(object sender, EventArgs e)
        {

            this.MouseWheel +=ImageProcess_MouseWheel;
            this.groupBox2.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
        }
        void ImageProcess_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) //放大图片
            {
                pB.Size = new Size(pB.Width + 50, pB.Height + 50);
            }
            else
            {  //缩小图片
                pB.Size = new Size(pB.Width - 50, pB.Height - 50);
            }
            //设置图片在窗体居中
            pB.Location = new Point((this.Width - pB.Width) / 2, (this.Height - pB.Height) / 2);
        }

        public Bitmap Rotate(Bitmap b, int angle)
        {
            angle = angle % 360;

            //弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);

            //原图的宽和高
            int w = b.Width;
            int h = b.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));

            //目标位图
            Bitmap dsImage = new Bitmap(W, H);
            Graphics g = Graphics.FromImage(dsImage);

            g.InterpolationMode = InterpolationMode.Bilinear;

            g.SmoothingMode = SmoothingMode.HighQuality;

            //计算偏移量
            Point Offset = new Point((W - w) / 2, (H - h) / 2);

            //构造图像显示区域：让图像的中心与窗口的中心点一致
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - angle);

            //恢复图像在水平和垂直方向的平移
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);

            //重至绘图的所有变换
            g.ResetTransform();

            g.Save();
            g.Dispose();
            return dsImage;
        }

        private void Clockwise_90_Click(object sender, EventArgs e)
        {
            //this.pictureBoxIpl1.Image = Image.FromFile(curFileName);
            //Image tmp = Image.FromFile(curFileName);
            //tmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //this.pictureBoxIpl1.Image = tmp;
            try
            {

                Bitmap a = new Bitmap(pB.Image);//得到图片框中的图片
                pB.Image = Rotate(a, -90);


                pB.Refresh();//最后刷新图片框
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Rotate_90_Click(object sender, EventArgs e)
        {
            try
            {

                Bitmap a = new Bitmap(pB.Image);//得到图片框中的图片
                pB.Image = Rotate(a, 90);

                pB.Refresh();//最后刷新图片框
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Salt_change_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
        }

        private void btn_salt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    // Bitmap pic = (Bitmap)Bitmap.FromFile(filename, false);
                    Bitmap pic = new Bitmap(pB.Image);
                    double Pa = Convert.ToDouble(textBox1.Text);//接受输入的Pa
                    double Pb = Convert.ToDouble(textBox2.Text);//接受输入的Pb
                    double P = Pb / (1 - Pa);
                    int width = pic.Width;
                    int height = pic.Height;
                    Random rand = new Random();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            int gray;
                            int noise = 1;
                            double probility = rand.NextDouble();
                            if (probility < Pa)
                            {
                                noise = 255;//有Pa概率 噪声设为最大值
                            }
                            else
                            {
                                double temp = rand.NextDouble();
                                if (temp < P)//有1 - Pa的几率到达这里，再乘以 P ，刚好等于Pb
                                    noise = 0;
                            }
                            if (noise != 1)
                            {
                                gray = noise;
                            }
                            else gray = pic.GetPixel(j, i).R;
                            Color color = Color.FromArgb(gray, gray, gray);
                            pic.SetPixel(j, i, color);

                        }
                    }
                    this.pB.Image = pic;
                    this.groupBox1.Visible = false;
                }
                else
                {
                    MessageBox.Show("请先输入Pa和Pb^_^");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "信息提示");
            }
        }
        private void img_MedianFilter_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap pic = new Bitmap(pB.Image);
                int width = pic.Width;
                int height = pic.Height;
                int[,] resultPic = new int[height, width];
                int index;
                int[] filter = new int[9];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        index = 0;
                        int nowGray;
                        for (int ii = -1; ii < 2; ii++)
                        {
                            for (int jj = -1; jj < 2; jj++)
                            {
                                if (j + jj >= 0 && j + jj < width && i + ii >= 0 && i + ii < height)
                                {
                                    nowGray = pic.GetPixel(j + jj, i + ii).R;
                                }
                                else { nowGray = 0; }
                                if (index == 0) { filter[index] = nowGray; index++; }
                                else
                                {
                                    if (nowGray >= filter[index - 1])
                                    {
                                        filter[index++] = nowGray;
                                    }
                                    else
                                    {
                                        int current = index - 1;
                                        while (current > 0 && filter[current] > nowGray)
                                        {
                                            filter[current + 1] = filter[current];
                                            current--;
                                        }
                                        filter[current + 1] = nowGray;
                                        index++;
                                    }

                                }
                            }
                        }
                        resultPic[i, j] = filter[4];
                        // int temp = filter[4];
                        //  Color color = Color.FromArgb(temp, temp, temp);
                        // pic.SetPixel(j, i, color);
                    }
                }
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int temp = resultPic[i, j];
                        Color color = Color.FromArgb(temp, temp, temp);
                        pic.SetPixel(j, i, color);
                    }
                }
                this.pB.Image = pic;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

       
        private void Flip_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap RevPic(Bitmap mybm, int width, int height)
                {
                    Bitmap bm = new Bitmap(width, height);//初始化一个记录经过处理后的图片对象
                    int x, y, z;//x,y是循环次数,z是用来记录像素点的x坐标的变化的
                    Color pixel;

                    for (y = height - 1; y >= 0; y--)
                    {
                        for (x = width - 1, z = 0; x >= 0; x--)
                        {
                            pixel = mybm.GetPixel(x, y);//获取当前像素的值
                            bm.SetPixel(z++, y, Color.FromArgb(pixel.R, pixel.G, pixel.B));//绘图
                        }
                    }
                    return bm;//返回经过翻转后的图片
                }

                Bitmap a = new Bitmap(pB.Image);
                pB.Image = RevPic(a, a.Width, a.Height);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }
        private void paishe_img_Click(object sender, EventArgs e)
        {
            Camera f = new Camera();
            f.Show();

        } 
        private void FlipY_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap RevPic(Bitmap mybm, int width, int height)
                {
                    Bitmap bm = new Bitmap(width, height);
                    int x, y, z;
                    Color pixel;

                    for (x = 0; x < width; x++)

                    {
                        for (y = height - 1, z = 0; y >= 0; y--)
                        {
                            pixel = mybm.GetPixel(x, y);//获取当前像素的值
                            bm.SetPixel(x, z++, Color.FromArgb(pixel.R, pixel.G, pixel.B));//绘图
                        }
                    }
                    return bm;//返回翻转后的图片
                }

                Bitmap a = new Bitmap(pB.Image);
                pB.Image = RevPic(a, a.Width, a.Height);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Write_img_Click(object sender, EventArgs e)
        {
            this.groupBox4.Visible = true;
        }

        private void Gray_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap BWPic(Bitmap mybm, int width, int height)
                {
                    Bitmap bm = new Bitmap(width, height);//初始化一个Bitmap对象，用来记录处理后的图片
                    int x, y, result;//x,y是循环次数，result是记录处理后的像素值
                    Color pixel;

                    for (x = 0; x < width; x++)
                    {
                        for (y = 0; y < height; y++)
                        {
                            pixel = mybm.GetPixel(x, y);//获取当前坐标的像素值
                            result = (pixel.R + pixel.G + pixel.B) / 3;//取红绿蓝三色的平均值

                            //绘图，把处理后的值赋值到刚才定义的bm对象里面
                            bm.SetPixel(x, y, Color.FromArgb(result, result, result));
                        }
                    }

                    return bm;//返回黑白图片
                }
                Bitmap i = new Bitmap(pB.Image);
                pB.Image = BWPic(i, i.Width, i.Height);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Erode_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap GetFuShiImage(Bitmap image)
                {
                    List<Point> setList = new List<Point>();

                    Bitmap result = image.Clone() as Bitmap;

                    for (int i = 0; i < result.Width; i++)
                    {
                        for (int j = 0; j < result.Height; j++)
                        {
                            // 如果是应该设置为黑色的点，将其添加到我们要设的list中
                            if (SetPixelFuShi(result, i, j))
                            {
                                setList.Add(new Point(i, j));
                            }
                        }
                    }

                    // 遍历，设置相应的值
                    foreach (var item in setList)
                    {
                        result.SetPixel(item.X, item.Y, Color.White);
                    }

                    return result;
                }

                // 判断一个点是不是应该设置为白颜色
                bool SetPixelFuShi(Bitmap image, int i, int j)
                {
                    int origion;
                    int upPoint;
                    int leftPoint;

                    if (i != 0 && j != 0)
                    {
                        origion = image.GetPixel(i, j).ToArgb();
                        upPoint = image.GetPixel(i, j - 1).ToArgb();
                        leftPoint = image.GetPixel(i - 1, j).ToArgb();

                        // image.GetPixel(i,j) == Color.Black
                        if (origion == Color.Black.ToArgb() &&
                           upPoint == Color.Black.ToArgb() &&
                           leftPoint == Color.Black.ToArgb())
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else return true;
                }
                Bitmap a = new Bitmap(pB.Image);
                pB.Image = GetFuShiImage(a);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Dilated_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap GetPengZhangImage(Bitmap image)
                {
                    List<Point> setList = new List<Point>();

                    Bitmap result = image.Clone() as Bitmap;

                    for (int i = 0; i < result.Width; i++)
                    {
                        for (int j = 0; j < result.Height; j++)
                        {
                            // 如果应该设置为黑色的
                            if (SetPixelPengZhang(result, i, j))
                            {
                                setList.Add(new Point(i, j));
                            }
                        }
                    }

                    int x, y;
                    foreach (var item in setList)
                    {
                        x = item.X;
                        y = item.Y;

                        result.SetPixel(x - 1, y, Color.Black);
                        result.SetPixel(x, y - 1, Color.Black);
                    }
                    return result;
                }

                // 判断这个点应不应该设置为黑色
                bool SetPixelPengZhang(Bitmap image, int i, int j)
                {
                    Color c = image.GetPixel(i, j);

                    if (i != 0 && j != 0)
                    {
                        if (image.GetPixel(i, j).ToArgb() == Color.Black.ToArgb())
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                Bitmap a = new Bitmap(pB.Image);
                pB.Image = GetPengZhangImage(a);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        //边缘检测
        public Bitmap cn(Bitmap x)
        {
            Color c1 = new Color();
            Color c2 = new Color();
            Color c3 = new Color();
            Color c4 = new Color();
            int i, j;
            int rr, gg, bb;//
            int r1, r2, r3, r4, fxr, fyr;//
            int g1, g2, g3, g4, fxg, fyg;//
            int b1, b2, b3, b4, fxb, fyb;//
           
            Bitmap box1 = new Bitmap(x);
            for (i = 0; i <= x.Width - 2; i++)
            {
                for (j = 0; j <= x.Height - 2; j++)
                {
                    c1 = box1.GetPixel(i, j);
                    c2 = box1.GetPixel(i + 1, j + 1);
                    c3 = box1.GetPixel(i + 1, j);
                    c4 = box1.GetPixel(i, j + 1);
                    r1 = c1.R;
                    r2 = c2.R;
                    r3 = c3.R;
                    r4 = c4.R;
                    fxr = r1 - r2;
                    fyr = r3 - r4;
                    rr = Math.Abs(fxr) + Math.Abs(fyr) + 128;
                    if (rr < 0) rr = 0;
                    if (rr > 255) rr = 255;
                    g1 = c1.G;
                    g2 = c2.G;
                    g3 = c3.G;
                    g4 = c4.G;
                    fxg = g1 - g2;
                    fyg = g3 - g4;
                    gg = Math.Abs(fxg) + Math.Abs(fyg) + 128;
                    if (gg < 0) gg = 0;
                    if (gg > 255) gg = 255;
                    b1 = c1.B;
                    b2 = c2.B;
                    b3 = c3.B;
                    b4 = c4.B;
                    fxb = b1 - b2;
                    fyb = b3 - b4;
                    bb = Math.Abs(fxb) + Math.Abs(fyb) + 128;
                    if (bb < 0) bb = 0;
                    if (bb > 255) bb = 255;
                    Color cc = Color.FromArgb(rr, gg, bb);
                    box1.SetPixel(i, j, cc);
                }


            }
            return box1;
        }

        private void Check_img_Click(object sender, EventArgs e)
        {
            
        }  
        private void canny_img_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;            
        }
        private void Sobel_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap a = new Bitmap(pB.Image);
                pB.Image = cn(a);
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_canny_Click(object sender, EventArgs e)
        {
            try
            {
                Mat image = new Mat(textBox5.Text.ToString(), ImreadModes.Grayscale);
                Mat result = new Mat();
                double low = double.Parse(textBox3.Text);
                double hight = double.Parse(textBox4.Text);
                Cv2.Canny(image, result, low, hight);
                Cv2.ImShow("图像轮廓", result);
                Cv2.ImWrite("saved.jpg", result);
                curBitmap = (Bitmap)Image.FromFile("saved.jpg");
                this.pB.Image = curBitmap;
                pB.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Mat panda = new Mat(textBox6.Text.ToString(), ImreadModes.Grayscale);//读取为灰度图
                Mat[] mats = new Mat[] { panda };//一张图片，初始化为panda
                Mat hist = new Mat();//用来接收直方图
                int[] channels = new int[] { 0 };//一个通道,初始化为通道0
                int[] histsize = new int[] { 256 };//一个通道，初始化为256箱子
                Rangef[] range = new Rangef[1];//一个通道，值范围
                range[0].Start = 0.0F;//从0开始（含）
                range[0].End = 256.0F;//到256结束（不含）
                Mat mask = new Mat();//不做掩码
                Cv2.CalcHist(mats, channels, mask, hist, 1, histsize, range);//计算灰度图，dim为1 1维

                Console.WriteLine(hist.Rows + "行" + hist.Cols + "列");//把输出的行列打印出来


                Cv2.ImShow("直方图", panda);
                Cv2.ImWrite("ZFT.jpg", panda);
                curBitmap = (Bitmap)Image.FromFile("ZFT.jpg");
                this.pB.Image = curBitmap;
                pB.Refresh();
                this.groupBox3.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void btn_Be_Click(object sender, EventArgs e)
        {
            try
            {
                HSV f1 = new HSV();

                Bitmap CreateNodeImg(string txt, Color txtColor)
                {
                    if (txtColor == Color.Transparent)
                        txtColor = Color.Black;
                    Bitmap newBitMap = new Bitmap(12, 14);
                    Graphics g = Graphics.FromImage(newBitMap);
                    if (txtColor != Color.Black)
                    {
                        g.Clear(txtColor);//背景色
                    }
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    FontFamily fm = new FontFamily("Arial");
                    Font font = new Font(fm, 12, FontStyle.Regular, GraphicsUnit.Pixel);
                    SolidBrush sb = new SolidBrush(f1.picDestinationColor.BackColor);
                    g.DrawString(txt, font, sb, new PointF(0, 0));
                    g.Dispose();
                    return newBitMap;
                }
                Bitmap a = new Bitmap(pB.Image);
                pB.Image = CreateNodeImg(textBox7.Text.ToString(), Color.White);
                pB.Refresh();
                this.groupBox4.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }
       

        private void sediao_img_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Bitmap ConvertToInvert(System.Drawing.Image img)
                {

                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(img);
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            // 取得每一个 pixel
                            var pixel = bitmap.GetPixel(x, y);

                            // 负片效果 将其反转
                            System.Drawing.Color newColor = System.Drawing.Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B);

                            bitmap.SetPixel(x, y, newColor);

                        }
                    }
                    return bitmap;
                }
                pB.Image = ConvertToInvert(curBitmap);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }

        }
            
        private void Dark_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap  curBitmap= new Bitmap(pB.Image);
                if (curBitmap != null)
                {
                   
                    int width = curBitmap.Width;
                    int height = curBitmap.Height;
                    float cx = width / 2;
                    float cy = height / 2;
                    float maxDist = cx * cx + cy * cy;
                    float currDist = 0, factor;
                    Color pixel;

                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                        {
                            currDist = ((float)i - cx) * ((float)i - cx) + ((float)j - cy) * ((float)j - cy);
                            factor = currDist / maxDist;

                            pixel = curBitmap.GetPixel(i, j);
                            int red = (int)(pixel.R * (1 - factor));
                            int green = (int)(pixel.G * (1 - factor));
                            int blue = (int)(pixel.B * (1 - factor));
                            curBitmap.SetPixel(i, j, Color.FromArgb(red, green, blue));
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Mosic_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap curBitmap = new Bitmap(pB.Image);
                if (curBitmap != null)
                {
                
                    int RIDIO = 30;//马赛克的尺度，默认为周围两个像素
                    for (int h = 0; h < curBitmap.Height; h += RIDIO)
                    {
                        for (int w = 0; w < curBitmap.Width; w += RIDIO)
                        {
                            int avgRed = 0, avgGreen = 0, avgBlue = 0;
                            int count = 0;
                            //取周围的像素
                            for (int x = w; (x < w + RIDIO && x < curBitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < curBitmap.Height); y++)
                                {
                                    Color pixel = curBitmap.GetPixel(x, y);
                                    avgRed += pixel.R;
                                    avgGreen += pixel.G;
                                    avgBlue += pixel.B;
                                    count++;
                                }
                            }

                            //取平均值
                            avgRed = avgRed / count;
                            avgBlue = avgBlue / count;
                            avgGreen = avgGreen / count;

                            //设置颜色
                            for (int x = w; (x < w + RIDIO && x < curBitmap.Width); x++)
                            {
                                for (int y = h; (y < h + RIDIO && y < curBitmap.Height); y++)
                                {
                                    Color newColor = Color.FromArgb(avgRed, avgGreen, avgBlue);
                                    curBitmap.SetPixel(x, y, newColor);
                                }
                            }
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Light_reduction_Click(object sender, EventArgs e)
        {
            try
            {
                if (curBitmap != null)
                {
                  
                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < curBitmap.Width; x++)
                    {
                        for (int y = 0; y < curBitmap.Height; y++)
                        {
                            pixel = curBitmap.GetPixel(x, y);
                            red = (int)(pixel.R * 0.6);
                            green = (int)(pixel.G * 0.6);
                            blue = (int)(pixel.B * 0.6);
                            curBitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Light_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (curBitmap != null)
                {
                
                    Color pixel;
                    int red, green, blue;
                    for (int x = 0; x < curBitmap.Width; x++)
                    {
                        for (int y = 0; y < curBitmap.Height; y++)
                        {
                            pixel = curBitmap.GetPixel(x, y);
                            red = (int)(pixel.R * (0.8));
                            green = (int)(pixel.G *(0.8));
                            blue = (int)(pixel.B * (0.8));
                            curBitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Spread_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap curBitmap = new Bitmap(pB.Image);
                if (curBitmap != null)
                {
                 
                    Color pixel;
                    int red, green, blue;
                    int flag=0 ;
                    for (int x = 0; x < curBitmap.Width; x++)
                    {
                        for (int y = 0; y < curBitmap.Height; y++)
                        {
                            Random ran = new Random();
                            int RankKey = ran.Next(-5, 5);
                            if (x + RankKey >= curBitmap.Width || y + RankKey >= curBitmap.Height || x + RankKey < 0 || y + RankKey < 0)
                            {
                                flag = 1;
                                continue;
                            }

                            pixel = curBitmap.GetPixel(x + RankKey, y + RankKey);
                            red = (int)(pixel.R);
                            green = (int)(pixel.G);
                            blue = (int)(pixel.B);
                            curBitmap.SetPixel(x, y, Color.FromArgb(red, green, blue));
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void Decoloration_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap curBitmap = new Bitmap(pB.Image);
                if (curBitmap != null)
                {
                   
                    Color pixel;
                    int gray;
                    for (int x = 0; x < curBitmap.Width; x++)
                    {
                        for (int y = 0; y < curBitmap.Height; y++)
                        {
                            pixel = curBitmap.GetPixel(x, y);
                            gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                            curBitmap.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                        }
                    }
                    pB.Image = curBitmap.Clone() as Image;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void JH_img_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap  curBitmap= new Bitmap(pB.Image);
                if (curBitmap != null)
                {

                    int width = curBitmap.Width;
                    int height = curBitmap.Height;
                    int size = width * height;
                    //总像数个数
                    int[] gray = new int[256];
                    //定义一个int数组，用来存放各像元值的个数
                    double[] graydense = new double[256];
                    //定义一个float数组，存放每个灰度像素个数占比
                    for (int i = 0; i < width; ++i)
                        for (int j = 0; j < height; ++j)
                        {
                            Color pixel = curBitmap.GetPixel(i, j);
                            //计算各像元值的个数
                            gray[Convert.ToInt16(pixel.R)] += 1;
                            //由于是灰度只读取R值
                        }
                    for (int i = 0; i < 256; i++)
                    {
                        graydense[i] = (gray[i] * 1.0) / size;
                        //每个灰度像素个数占比
                    }

                    for (int i = 1; i < 256; i++)
                    {
                        graydense[i] = graydense[i] + graydense[i - 1];
                        //累计百分比
                    }

                    for (int i = 0; i < width; ++i)
                        for (int j = 0; j < height; ++j)
                        {
                            Color pixel = curBitmap.GetPixel(i, j);
                            int oldpixel = Convert.ToInt16(pixel.R);//原始灰度
                            int newpixel = 0;
                            if (oldpixel == 0)
                                newpixel = 0;
                            //如果原始灰度值为0则变换后也为0
                            else
                                newpixel = Convert.ToInt16(graydense[Convert.ToInt16(pixel.R)] * 255);
                            //如果原始灰度不为0，则执行变换公式为   <新像元灰度 = 原始灰度 * 累计百分比>
                            pixel = Color.FromArgb(newpixel, newpixel, newpixel);
                            curBitmap.SetPixel(i, j, pixel);
                        }
                    pB.Image = curBitmap.Clone() as Image;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "信息提示"); }
        }

        private void baohe_img_Click(object sender, EventArgs e)
        {
            
        }

        private void HSV_img_Click(object sender, EventArgs e)
        {
            HSV f = new HSV();
            f.Show();
           
        }

        private void light_img_Click(object sender, EventArgs e)
        {

        }
    }
}
