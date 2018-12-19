using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingSystem
{

    public class ColorHSL
    {
        public ColorHSL(int h, int s, int l)
        {
            this._h = h;
            this._s = s;
            this._l = l;
        }

        private int _h;
        private int _s;
        private int _l;

        /// <summary>
        /// 色相
        /// </summary>
        public int H
        {
            get { return this._h; }
            set
            {
                this._h = value;
                this._h = this._h > 360 ? 360 : this._h;
                this._h = this._h < 0 ? 0 : this._h;
            }
        }


        public int S
        {
            get { return this._s; }
            set
            {
                this._s = value;
                this._s = this._s > 255 ? 255 : this._s;
                this._s = this._s < 0 ? 0 : this._s;
            }
        }


        public int L
        {
            get { return this._l; }
            set
            {
                this._l = value;
                this._l = this._l > 255 ? 255 : this._l;
                this._l = this._l < 0 ? 0 : this._l;
            }
        }
    }


    public class ColorHSV
    {

        public ColorHSV(int h, int s, int v)
        {
            this._h = h;
            this._s = s;
            this._v = v;
        }

        private int _h;
        private int _s;
        private int _v;


        public int H
        {
            get { return this._h; }
            set
            {
                this._h = value;
                this._h = this._h > 360 ? 360 : this._h;
                this._h = this._h < 0 ? 0 : this._h;
            }
        }


        public int S
        {
            get { return this._s; }
            set
            {
                this._s = value;
                this._s = this._s > 255 ? 255 : this._s;
                this._s = this._s < 0 ? 0 : this._s;
            }
        }


        public int V
        {
            get { return this._v; }
            set
            {
                this._v = value;
                this._v = this._v > 255 ? 255 : this._v;
                this._v = this._v < 0 ? 0 : this._v;
            }
        }
    }


    public class ColorRGB
    {

        public ColorRGB(int r, int g, int b)
        {
            this._r = r;
            this._g = g;
            this._b = b;
        }

        private int _r;
        private int _g;
        private int _b;


        public int R
        {
            get { return this._r; }
            set
            {
                this._r = value;
                this._r = this._r > 255 ? 255 : this._r;
                this._r = this._r < 0 ? 0 : this._r;
            }
        }


        public int G
        {
            get { return this._g; }
            set
            {
                this._g = value;
                this._g = this._g > 255 ? 255 : this._g;
                this._g = this._g < 0 ? 0 : this._g;
            }
        }


        public int B
        {
            get { return this._b; }
            set
            {
                this._b = value;
                this._b = this._b > 255 ? 255 : this._b;
                this._b = this._b < 0 ? 0 : this._b;
            }
        }


        public Color GetColor()
        {
            return Color.FromArgb(this._r, this._g, this._b);
        }
    }

}
