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
using ImageSearchTools.Utilities;

namespace ImageSearchTools
{
    public partial class MainForm : Form
    {
        private string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JAMGALACTIC", "IST");
        private Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>();
        private List<FileInfo> tempResults = new List<FileInfo>();
        private DirectoryInfo searchDir = null;
        private string fileName;
        private int width;
        private string wOperator;
        private int height;
        private string hOperator;
        private int size;
        private FileSizeType sizeType;        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.fileName = string.Empty;
            this.width = 0;
            this.height = 0;
            this.size = 0;
            this.wOperator = "==";
            this.hOperator = "==";
            this.sizeType = FileSizeType.MB;
            this.cbSizeType.SelectedIndex = 1;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult res = fbd.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    try
                    {
                        this.searchDir = new DirectoryInfo(fbd.SelectedPath);
                        this.txtDirectory.Text = fbd.SelectedPath;
                    }
                    catch (Exception ex)
                    {
                        Logger.LogException(appDataFolder, ex, true);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            if (!String.IsNullOrEmpty(txtDirectory.Text))
            {
                if (this.searchDir == null || this.searchDir.FullName != txtDirectory.Text)
                {
                    if (!Directory.Exists(txtDirectory.Text))
                    {
                        return;
                    }
                    else
                        this.searchDir = new DirectoryInfo(txtDirectory.Text);
                }
                this.tempResults.Clear();
                this.fileName = txtName.Text;
                this.width = (string.IsNullOrWhiteSpace(txtWidth.Text) ? 0 : Convert.ToInt32(txtWidth.Text));
                this.wOperator = (string.IsNullOrWhiteSpace(cbWidthOperator.EditValue.ToString()) ? "==" : cbWidthOperator.EditValue.ToString());
                this.height = (string.IsNullOrWhiteSpace(txtHeight.Text) ? 0 : Convert.ToInt32(txtHeight.Text));
                this.hOperator = (string.IsNullOrWhiteSpace(cbHeightOperator.EditValue.ToString()) ? "==" : cbHeightOperator.EditValue.ToString());
                this.size = (string.IsNullOrWhiteSpace(txtSize.Text) ? 0 : Convert.ToInt32(txtSize.Text));

                if ((width > 0 && height == 0) || (width == 0 && height > 0))
                {
                    MessageBox.Show("Please enter both a width and a height");
                    return;
                }

                try
                {
                    this.processSearch();
                }
                catch (Exception ex)
                {
                    Logger.LogException(appDataFolder, ex, true);
                }
            }
            else
            {
                MessageBox.Show("Please select a directory to search");
            }
        }

        private void enableDisableControls(bool b)
        {
            txtDirectory.Enabled = b;
            txtHeight.Enabled = b;
            txtName.Enabled = b;
            txtSize.Enabled = b;
            txtWidth.Enabled = b;
            btnBrowse.Enabled = b;
            btnSearch.Enabled = b;
            cbHeightOperator.Enabled = b;
            cbWidthOperator.Enabled = b;
            cbSizeType.Enabled = b;
        }

        private async void processSearch()
        {
            enableDisableControls(false);
            ImageDataSet.ImagesDataTable idt = null;
            this.imageDictionary.Clear();
            this.imageDataSet.Images.Clear();
            bool complete = await Task.Run(() =>
                {
                    if (!string.IsNullOrWhiteSpace(this.fileName))
                    {
                        string[] results = Directory.GetFiles(this.searchDir.FullName, "*" + this.fileName + "*", SearchOption.AllDirectories);
                        for (int i = 0; i < results.Length; i++)
                        {
                            FileInfo fi = new FileInfo(results[i]);
                            this.tempResults.Add(fi);
                        }
                    }
                    else
                    {
                        searchRecursive(this.searchDir.FullName);
                    }

                    idt = this.filterResults(this.tempResults);
                    return true;
                });
            lblStatus.Text = string.Empty;
            foreach (ImageDataSet.ImagesRow row in idt)
            {
                try
                {
                    ImageDataSet.ImagesRow newRow = imageDataSet.Images.NewImagesRow();
                    newRow.ImageNumberOdd = (row.IsImageNumberOddNull() ? 0 : row.ImageNumberOdd);
                    newRow.SelectOdd = (row.IsSelectOddNull() ? false : row.SelectOdd);
                    newRow.FullPathOdd = (row.IsFullPathOddNull() ? string.Empty : row.FullPathOdd);
                    newRow.ImageNumberEven = (row.IsImageNumberEvenNull() ? 0 : row.ImageNumberEven);
                    newRow.SelectEven = (row.IsSelectEvenNull() ? false : row.SelectEven);
                    newRow.FullPathEven = (row.IsFullPathEvenNull() ? string.Empty : row.FullPathEven);
                    newRow.ImageNumberOdd2 = (row.IsImageNumberOdd2Null() ? 0 : row.ImageNumberOdd2);
                    newRow.SelectOdd2 = (row.IsSelectOdd2Null() ? false : row.SelectOdd2);
                    newRow.FullPathOdd2 = (row.IsFullPathOdd2Null() ? string.Empty : row.FullPathOdd2);
                    newRow.ImageNumberEven2 = (row.IsImageNumberEven2Null() ? 0 : row.ImageNumberEven2);
                    newRow.SelectEven2 = (row.IsSelectEven2Null() ? false : row.SelectEven2);
                    newRow.FullPathEven2 = (row.IsFullPathEven2Null() ? string.Empty : row.FullPathEven2);
                    imageDataSet.Images.AddImagesRow(newRow);
                }
                catch (Exception ex)
                {
                    Logger.LogException(appDataFolder, ex);
                }
            }
            enableDisableControls(true);
        }

        private int fileCount = 0;
        private int file = 0;

        private ImageDataSet.ImagesDataTable filterResults(List<FileInfo> list)
        {
            ImageDataSet.ImagesDataTable idt = new ImageDataSet.ImagesDataTable();
            this.file = 0;
            this.fileCount = list.Count;
            ImageDataSet.ImagesRow row = null;
            bool newRow = true;
            int column = 1;
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    file++;
                    if (newRow)
                    {
                        column = 1;
                        row = idt.NewImagesRow();
                    }

                    if (this.lblStatus.InvokeRequired)
                    {
                        this.lblStatus.BeginInvoke((MethodInvoker)delegate() { this.lblStatus.Text = @"Filtering Files: " + file.ToString() + " of " + fileCount.ToString(); }); ;
                    }
                    else
                    {
                        this.lblStatus.Text = @"Filtering Files: " + file.ToString() + " of " + fileCount.ToString();
                    }
                    bool match = true;
                    using (Image img = Image.FromFile(list[i].FullName))
                    {
                        if ((this.width > 0 && this.height > 0) || this.size > 0)
                            match = false;
                        if (this.width > 0 && this.height > 0)
                        {
                            if (
                                ((this.wOperator == "==" && img.Width == this.width)
                                || (this.wOperator == "<" && img.Width < this.width)
                                || (this.wOperator == ">" && img.Width > this.width)
                                || (this.wOperator == "<=" && img.Width <= this.width)
                                || (this.wOperator == ">=" && img.Width >= this.width)
                                )
                                && ((this.hOperator == "==" && img.Width == this.height)
                                || (this.hOperator == "<" && img.Width < this.height)
                                || (this.hOperator == ">" && img.Width > this.height)
                                || (this.hOperator == "<=" && img.Width <= this.height)
                                || (this.hOperator == ">=" && img.Width >= this.height)
                                )
                                )
                            {
                                match = true;
                            }
                        }
                        if (this.size > 0 && convertSize(Convert.ToInt32(list[i].Length), this.sizeType) == this.size)
                            match = true;
                        if (match)
                        {
                            imageDictionary.Add(list[i].FullName, ImageProcessor.GetThumbnail(img));
                            if (column == 1)
                            {
                                row.ImageNumberOdd = i;
                                row.SelectOdd = false;
                                row.FullPathOdd = list[i].FullName;
                                newRow = false;
                                column++;
                            }
                            else if (column == 2)
                            {
                                row.ImageNumberEven = i;
                                row.SelectEven = false;
                                row.FullPathEven = list[i].FullName;
                                column++;
                            }
                            else if (column == 3)
                            {
                                row.ImageNumberOdd2 = i;
                                row.SelectOdd2 = false;
                                row.FullPathOdd2 = list[i].FullName;
                                column++;
                            }
                            else if (column == 4)
                            {
                                row.ImageNumberEven2 = i;
                                row.SelectEven2 = false;
                                row.FullPathEven2 = list[i].FullName;
                                idt.AddImagesRow(row);
                                newRow = true;
                            }
                        }                       
                       
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.LogException(appDataFolder, ex, true);
            }

            if (!newRow)
            {
                if (row.IsImageNumberEvenNull() || row.ImageNumberEven == 0)
                {
                    row.ImageNumberEven = row.ImageNumberOdd + 1;
                    row.SelectEven = false;
                    row.FullPathEven = string.Empty;
                }
                if (row.IsImageNumberOdd2Null() || row.ImageNumberOdd2 == 0)
                {
                    row.ImageNumberOdd2 = row.ImageNumberEven + 1;
                    row.SelectOdd2 = false;
                    row.FullPathOdd2 = string.Empty;
                }
                if (row.IsImageNumberEven2Null() || row.ImageNumberEven2 == 0)
                {
                    row.ImageNumberEven2 = row.ImageNumberOdd2 + 1;
                    row.SelectEven2 = false;
                    row.FullPathEven2 = string.Empty;
                }
                idt.AddImagesRow(row);
            }
            return idt;
        }


        private void searchRecursive(string folderPath)
        {
            foreach (string file in Directory.GetFiles(folderPath))
            {
                FileInfo fi = new FileInfo(file);
                if (ImageProcessor.FileIsImage(fi))
                    this.tempResults.Add(fi);
            }
            foreach (string dir in Directory.GetDirectories(folderPath))
            {
                searchRecursive(dir);
            }
        }

        private void cbSizeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizeType.SelectedText == "KB")
                this.sizeType = FileSizeType.KB;
            else if (cbSizeType.SelectedText == "MB")
                this.sizeType = FileSizeType.MB;
            else if (cbSizeType.SelectedText == "GB")
                this.sizeType = FileSizeType.GB;
        }

        private int convertSize(int bytes, FileSizeType toType)
        {
            int i = (toType == FileSizeType.KB ? (bytes * 1000) : (toType == FileSizeType.MB ? (bytes * 1000) * 1000 : (toType == FileSizeType.GB ? ((bytes * 1000) * 1000) * 1000 : 0)));
            return i;
        }

        private void gvImages_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == colFullPathOdd || e.Column == colFullPathEven)
            {
                if (string.IsNullOrWhiteSpace((e.Column == colFullPathOdd ? gvImages.GetRowCellValue(e.RowHandle, colFullPathOdd).ToString() : gvImages.GetRowCellValue(e.RowHandle, colFullPathEven).ToString())))
                    return;
                e.Handled = true;
                Point pos = new Point(e.Bounds.X, e.Bounds.Y);
                e.Graphics.DrawImage((Image)imageDictionary[gvImages.GetRowCellValue(e.RowHandle, (e.Column == colFullPathOdd ? colFullPathOdd : colFullPathEven)).ToString()], pos);
            }
            if (e.Column == colFullPathOdd2 || e.Column == colFullPathEven2)
            {
                if (string.IsNullOrWhiteSpace((e.Column == colFullPathOdd2 ? gvImages.GetRowCellValue(e.RowHandle, colFullPathOdd2).ToString() : gvImages.GetRowCellValue(e.RowHandle, colFullPathEven2).ToString())))
                    return;
                e.Handled = true;
                Point pos = new Point(e.Bounds.X, e.Bounds.Y);
                e.Graphics.DrawImage((Image)imageDictionary[gvImages.GetRowCellValue(e.RowHandle, (e.Column == colFullPathOdd2 ? colFullPathOdd2 : colFullPathEven2)).ToString()], pos);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Delete the selected images?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    List<string> files = new List<string>();
                    foreach (ImageDataSet.ImagesRow row in imageDataSet.Images)
                    {
                        if (row.SelectOdd)
                            files.Add(row.FullPathOdd);
                        if (row.SelectEven && !string.IsNullOrWhiteSpace(row.FullPathEven))
                            files.Add(row.FullPathEven);
                        if (row.SelectOdd2 && !string.IsNullOrWhiteSpace(row.FullPathOdd2))
                            files.Add(row.FullPathOdd2);
                        if (row.SelectEven2 && !string.IsNullOrWhiteSpace(row.FullPathEven2))
                            files.Add(row.FullPathEven2);
                    }
                    this.deleteFilesAsync(files);
                }
                catch (Exception ex)
                {
                    Logger.LogException(appDataFolder, ex, true);
                }
            }
        }

        private async void deleteFilesAsync(List<string> files)
        {
            int deleted = await ImageProcessor.DeleteImages(files, this.lblStatus);
            this.lblStatus.Text = string.Empty;
            MessageBox.Show("Deleted " + deleted.ToString() + " Images");
            imageDataSet.Images.Clear();
        }        

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ImageDataSet.ImagesRow row in imageDataSet.Images)
                {
                    row.SelectOdd = true;
                    row.SelectEven = (row.IsSelectEvenNull() || string.IsNullOrWhiteSpace(row.FullPathEven) ? false : true);
                    row.SelectOdd2 = (row.IsSelectOdd2Null() || string.IsNullOrWhiteSpace(row.FullPathOdd2) ? false : true);
                    row.SelectEven2 = (row.IsSelectEven2Null() || string.IsNullOrWhiteSpace(row.FullPathEven2) ? false : true);
                }
            }
            catch (Exception ex)
            {
                Logger.LogException(appDataFolder, ex);
            }
        }

        private void resetSearchTerms()
        {
            txtName.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtSize.Text = string.Empty;
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            resetSearchTerms();
        }
    }
}
