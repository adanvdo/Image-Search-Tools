using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSearchTools.Utilities
{
    public static class ImageProcessor
    {
        public List<string> JPG = new List<string>() { ".jpg", ".jpeg", ".JPG", ".Jpeg", ".JPEG" };
        public List<string> PNG = new List<string>() { ".png", ".PNG" };
        public List<string> BMP = new List<string>() { ".bmp", ".BMP" };
        public List<string> TIF = new List<string>() { ".tif", ".TIF" };
        public List<string> GIF = new List<string>() { ".gif", ".GIF" };
        public List<string> ALL = new List<string>() { ".jpg", ".jpeg", ".JPG", ".Jpeg", ".JPEG", ".png", ".PNG", ".bmp", ".BMP", ".tif", ".TIF", ".gif", ".GIF" };

        public bool FileIsImage(FileInfo fileInfo)
        {
            bool b = false;
            if (ALL.IndexOf(fileInfo.Extension) >= 0)
                b = true;
            return b;
        }

        public Image GetThumbnail(Image image)
        {
            decimal w = image.Width;
            decimal h = image.Height;
            decimal mw = 100 / w;
            decimal mh = 100 / h;
            decimal nw = (w > h ? (w * mw) : (w * mh));
            decimal nh = (h > w ? (h * mh) : (h * mw));
            int nwr = Convert.ToInt32(Math.Round(nw));
            int nhr = Convert.ToInt32(Math.Round(nh));
            Image newImage = new Bitmap(nwr, nhr);
            using (Graphics graphicsHandle = Graphics.FromImage(newImage))
            {
                graphicsHandle.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphicsHandle.DrawImage(image, 0, 0, nwr, nhr);
            }
            return newImage;
        }

        public async Task<int> DeleteImages(List<string> imageList, DevExpress.XtraEditors.LabelControl lblStatus)
        {
            int count = 0;

            for (int i = 0; i < imageList.Count; i++)
            {
                if (lblStatus.InvokeRequired)
                {
                    lblStatus.BeginInvoke((MethodInvoker)delegate() { lblStatus.Text = @"Deleting Files: " + count.ToString() + " of " + imageList.Count.ToString(); }); ;
                }
                else
                {
                    lblStatus.Text = @"Deleting Files: " + count.ToString() + " of " + imageList.Count.ToString();
                }
                try
                {
                    File.Delete(imageList[i]);
                    count++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete file " + imageList[i]);
                }
            }
            return count;
        }
    }
}