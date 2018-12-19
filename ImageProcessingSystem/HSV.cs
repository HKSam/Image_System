using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingSystem
{
    public partial class HSV : Form
    {
        public HSV()
        {
            InitializeComponent();
            
        }
       
        private void HSV_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            var rgb = new ColorRGB(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            var hsv = ColorHelper.RgbToHsv(rgb);
            picDestinationColor.BackColor = Color.FromArgb(255, rgb.R, rgb.G, rgb.B);
            nudH.Value = hsv.H;
            nudS.Value = hsv.S;
            nudV.Value = hsv.V;
            refreshColorPanel(hsv);
            picH.Value = Convert.ToInt32(nudH.Value);
            picS.Value = Convert.ToInt32(nudS.Value);
            picV.Value= Convert.ToInt32( nudV.Value);
          
        }

        public void refreshColorPanel(ColorHSV hsv)
        {
            var bm = new Bitmap(pic_H.Width, pic_H.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                for (var i = 0; i < pic_H.Width; i++)
                {
                    var hsvColor = new ColorHSV(360 * i / pic_H.Width, 255, 255);
                    var rgbColor = ColorHelper.HsvToRgb(hsvColor);
                    var color = Color.FromArgb(255, rgbColor.R, rgbColor.G, rgbColor.B);
                    g.DrawLine(new Pen(color, 1), i, 0, i, pic_H.Height);
                }
                g.Save();
            }
            pic_H.Image = bm;

            var Sm = new Bitmap(pic_S.Width, pic_S.Height);
            using (Graphics g = Graphics.FromImage(Sm))
            {
                for (var i = 0; i < pic_S.Width; i++)
                {
                    var hsvColor = new ColorHSV(hsv.H, 255 * i / pic_S.Width, hsv.V);
                    var rgbColor = ColorHelper.HsvToRgb(hsvColor);
                    var color = Color.FromArgb(255, rgbColor.R, rgbColor.G, rgbColor.B);
                    g.DrawLine(new Pen(color, 1), i, 0, i, pic_S.Height);
                }
                g.Save();
            }
            pic_S.Image =Sm;

            var Vm = new Bitmap(pic_V.Width, pic_V.Height);
            using (Graphics g = Graphics.FromImage(Vm))
            {
                for (var i = 0; i < pic_V.Width; i++)
                {
                    var hsvColor = new ColorHSV(hsv.H, hsv.S, 255 * i / pic_S.Width);
                    var rgbColor = ColorHelper.HsvToRgb(hsvColor);
                    var color = Color.FromArgb(255, rgbColor.R, rgbColor.G, rgbColor.B);
                    g.DrawLine(new Pen(color, 1), i, 0, i, pic_V.Height);
                }
                g.Save();
            }
            pic_V.Image = Vm;

            var destRgbColor = ColorHelper.HsvToRgb(hsv);
            picDestinationColor.BackColor = Color.FromArgb(255, destRgbColor.R, destRgbColor.G, destRgbColor.B);
            this.picDestinationColor.Refresh();
           
        }

        void colorChanged()
        {
            var hsv = new ColorHSV((int)nudH.Value, (int)nudS.Value, (int)nudV.Value);
            refreshColorPanel(hsv);
        }

        private void nudH_ValueChanged(object sender, EventArgs e)
        {
            
            colorChanged();
        }

        private void nudS_ValueChanged(object sender, EventArgs e)
        {
           
            colorChanged();
        }

        private void nudV_ValueChanged(object sender, EventArgs e)
        {
            
            colorChanged();
        }

        private void picH_Scroll(object sender, MouseEventArgs e)
        {
            this.nudH.Value = decimal.Parse(picH.Value.ToString());
            this.nudH.Refresh();
        }

        private void picS_Scroll(object sender, MouseEventArgs e)
        {

           
            this.nudS.Value = decimal.Parse(picS.Value.ToString());
            this.nudS.Refresh();
        }

        private void picV_Scroll(object sender, MouseEventArgs e)
        {
            
            this.nudV.Value= decimal.Parse(picV.Value.ToString());
            this.nudV.Refresh();
        }

    }
}
