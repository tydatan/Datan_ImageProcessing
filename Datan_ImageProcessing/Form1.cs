using System.Drawing.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Datan_ImageProcessing
{
    public partial class ImageProcessing : Form
    {
        Bitmap loadImage, resultImage, loadBackground;

        public ImageProcessing()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, pixel);
                }
            pictureBox3.Image = resultImage;
        }

        private void greyBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            pictureBox3.Image = resultImage;
        }

        private void histoBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            Color sample;
            int[] histdata = new int[256];
            for (int x = 0; x < resultImage.Width; x++)
                for (int y = 0; y < resultImage.Height; y++)
                {
                    sample = resultImage.GetPixel(x, y);
                    histdata[sample.R]++;
                }

            Bitmap mydata = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
                for (int y = 0; y < 800; y++)
                {
                    mydata.SetPixel(x, y, Color.White);
                }

            for (int x = 0; x < 256; x++)
                for (int y = 0; y < Math.Min(histdata[x] / 5, 800); y++)
                {
                    mydata.SetPixel(x, 799 - y, Color.Black);
                }
            pictureBox3.Image = mydata;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap Image (*.bmp)|*.bmp|All Files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            pictureBox3.Image = resultImage;
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            for (int y = 0; y < resultImage.Height; y++)
                for (int x = 0; x < resultImage.Width; x++)
                {
                    Color pixelColor = loadImage.GetPixel(x, y);

                    int outputRed = (int)(pixelColor.R * 0.393 + pixelColor.G * 0.769 + pixelColor.B * 0.189);
                    int outputGreen = (int)(pixelColor.R * 0.349 + pixelColor.G * 0.686 + pixelColor.B * 0.168);
                    int outputBlue = (int)(pixelColor.R * 0.272 + pixelColor.G * 0.534 + pixelColor.B * 0.131);


                    outputRed = Math.Min(255, Math.Max(0, outputRed));
                    outputGreen = Math.Min(255, Math.Max(0, outputGreen));
                    outputBlue = Math.Min(255, Math.Max(0, outputBlue));

                    Color outputColor = Color.FromArgb(outputRed, outputGreen, outputBlue);
                    resultImage.SetPixel(x, y, outputColor);
                }

            pictureBox3.Image = resultImage;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (resultImage != null)
            {

                if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
                {

                    string fileExtension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                    resultImage.Save(saveFileDialog1.FileName, GetImageFormatFromExtension(fileExtension));
                }
            }
        }

        private ImageFormat GetImageFormatFromExtension(string fileExtension)
        {
            switch (fileExtension.ToLower())
            {
                case ".png":
                    return ImageFormat.Png;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".bmp":
                    return ImageFormat.Bmp;
                default:
                    return ImageFormat.Png;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;


            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    Color backpixel = loadBackground.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);


                    if (subtractvalue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            pictureBox3.Image = resultImage;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            loadBackground = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = loadBackground;
        }
    }
}