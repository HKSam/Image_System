namespace ImageProcessingSystem
{
    partial class HSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picV = new System.Windows.Forms.TrackBar();
            this.pic_H = new System.Windows.Forms.PictureBox();
            this.pic_S = new System.Windows.Forms.PictureBox();
            this.pic_V = new System.Windows.Forms.PictureBox();
            this.picS = new System.Windows.Forms.TrackBar();
            this.picH = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.nudV = new System.Windows.Forms.NumericUpDown();
            this.nudS = new System.Windows.Forms.NumericUpDown();
            this.picDestinationColor = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestinationColor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picV);
            this.groupBox1.Controls.Add(this.pic_H);
            this.groupBox1.Controls.Add(this.pic_S);
            this.groupBox1.Controls.Add(this.pic_V);
            this.groupBox1.Controls.Add(this.picS);
            this.groupBox1.Controls.Add(this.picH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudH);
            this.groupBox1.Controls.Add(this.nudV);
            this.groupBox1.Controls.Add(this.nudS);
            this.groupBox1.Location = new System.Drawing.Point(36, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSV";
            // 
            // picV
            // 
            this.picV.Location = new System.Drawing.Point(75, 216);
            this.picV.Maximum = 255;
            this.picV.Name = "picV";
            this.picV.Size = new System.Drawing.Size(255, 45);
            this.picV.SmallChange = 5;
            this.picV.TabIndex = 9;
            this.picV.TickFrequency = 5;
            this.picV.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.picV.Scroll += new System.EventHandler(this.nudV_ValueChanged);
            this.picV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picV_Scroll);
            // 
            // pic_H
            // 
            this.pic_H.Location = new System.Drawing.Point(75, 32);
            this.pic_H.Name = "pic_H";
            this.pic_H.Size = new System.Drawing.Size(360, 18);
            this.pic_H.TabIndex = 1;
            this.pic_H.TabStop = false;
            // 
            // pic_S
            // 
            this.pic_S.Location = new System.Drawing.Point(75, 107);
            this.pic_S.Name = "pic_S";
            this.pic_S.Size = new System.Drawing.Size(255, 18);
            this.pic_S.TabIndex = 2;
            this.pic_S.TabStop = false;
            // 
            // pic_V
            // 
            this.pic_V.Location = new System.Drawing.Point(75, 192);
            this.pic_V.Name = "pic_V";
            this.pic_V.Size = new System.Drawing.Size(255, 18);
            this.pic_V.TabIndex = 3;
            this.pic_V.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(75, 141);
            this.picS.Maximum = 255;
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(255, 45);
            this.picS.SmallChange = 5;
            this.picS.TabIndex = 8;
            this.picS.TickFrequency = 5;
            this.picS.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.picS.Scroll += new System.EventHandler(this.nudS_ValueChanged);
            this.picS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picS_Scroll);
            // 
            // picH
            // 
            this.picH.Location = new System.Drawing.Point(75, 56);
            this.picH.Maximum = 360;
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(360, 45);
            this.picH.SmallChange = 5;
            this.picH.TabIndex = 7;
            this.picH.TickFrequency = 5;
            this.picH.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.picH.Scroll += new System.EventHandler(this.nudH_ValueChanged);
            this.picH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picH_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "明度(V)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "纯度(S)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "色相(H)";
            // 
            // nudH
            // 
            this.nudH.Location = new System.Drawing.Point(511, 39);
            this.nudH.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(52, 21);
            this.nudH.TabIndex = 2;
            // 
            // nudV
            // 
            this.nudV.Location = new System.Drawing.Point(511, 190);
            this.nudV.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudV.Name = "nudV";
            this.nudV.Size = new System.Drawing.Size(52, 21);
            this.nudV.TabIndex = 1;
            // 
            // nudS
            // 
            this.nudS.Location = new System.Drawing.Point(511, 111);
            this.nudS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudS.Name = "nudS";
            this.nudS.Size = new System.Drawing.Size(52, 21);
            this.nudS.TabIndex = 0;
            // 
            // picDestinationColor
            // 
            this.picDestinationColor.Location = new System.Drawing.Point(36, 12);
            this.picDestinationColor.Name = "picDestinationColor";
            this.picDestinationColor.Size = new System.Drawing.Size(575, 124);
            this.picDestinationColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDestinationColor.TabIndex = 4;
            this.picDestinationColor.TabStop = false;
            // 
            // HSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.picDestinationColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "HSV";
            this.Text = "HSV";
            this.Load += new System.EventHandler(this.HSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestinationColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.NumericUpDown nudV;
        private System.Windows.Forms.NumericUpDown nudS;
        private System.Windows.Forms.TrackBar picV;
        private System.Windows.Forms.TrackBar picS;
        private System.Windows.Forms.TrackBar picH;
        private System.Windows.Forms.PictureBox pic_H;
        private System.Windows.Forms.PictureBox pic_S;
        private System.Windows.Forms.PictureBox pic_V;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox picDestinationColor;
    }
}