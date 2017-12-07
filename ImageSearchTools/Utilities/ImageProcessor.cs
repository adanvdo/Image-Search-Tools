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
        public static List<string> JPG = new List<string>() { ".jpg", ".jpeg", ".JPG", ".Jpeg", ".JPEG" };
        public static List<string> PNG = new List<string>() { ".png", ".PNG" };
        public static List<string> BMP = new List<string>() { ".bmp", ".BMP" };
        public static List<string> TIF = new List<string>() { ".tif", ".TIF" };
        public static List<string> GIF = new List<string>() { ".gif", ".GIF" };
        public static List<string> ALL = new List<string>() { ".jpg", ".jpeg", ".JPG", ".Jpeg", ".JPEG", ".png", ".PNG", ".bmp", ".BMP", ".tif", ".TIF", ".gif", ".GIF" };

        public static bool FileIsImage(FileInfo fileInfo)
        {
            bool b = false;
            if (ALL.IndexOf(fileInfo.Extension) >= 0)
                b = true;
            return b;
        }

        public static Image GetThumbnail(Image image)
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

        public static async Task<int> DeleteImages(List<string> imageList, DevExpress.XtraEditors.LabelControl lblStatus)
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