using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SamePixelTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "btnLeftClear":
                    ListBoxItemsClear(lstLeft);
                    break;

                case "btnRightClear":
                    ListBoxItemsClear(lstRight);
                    break;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;

            switch (trackBar.Name)
            {
                case "trbRed":  //红色调节
                    labRed.Text = trackBar.Value.ToString("000");
                    break;

                case "trbGreen":    //绿色调节
                    labGreen.Text = trackBar.Value.ToString("000");
                    break;

                case "trbBlue": //蓝色调节
                    labBlue.Text = trackBar.Value.ToString("000");
                    break;

                case "trbThreshold":   //阈值调节
                    labThreshold.Text = trackBar.Value.ToString();
                    Properties.Settings.Default.Threshold = trackBar.Value;
                    Properties.Settings.Default.Save();
                    return;
            }

            var r = trbRed.Value;
            var g = trbGreen.Value;
            var b = trbBlue.Value;

            var color = Color.FromArgb(r, g, b);
            var rColor = Color.FromArgb(255 - r, 255 - g, 255 - b);

            labRed.BackColor = labGreen.BackColor = labBlue.BackColor = color;
            labRed.ForeColor = labGreen.ForeColor = labBlue.ForeColor = rColor;

            Properties.Settings.Default.Red = r;
            Properties.Settings.Default.Green = g;
            Properties.Settings.Default.Blue = b;
            Properties.Settings.Default.Color = color;
            Properties.Settings.Default.ReverseColor = rColor;
            Properties.Settings.Default.Save();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtSavePath.Text = Properties.Settings.Default.SavePath;

            var r = trbRed.Value = Properties.Settings.Default.Red;
            var g = trbGreen.Value = Properties.Settings.Default.Green;
            var b = trbBlue.Value = Properties.Settings.Default.Blue;
            trbThreshold.Value = Properties.Settings.Default.Threshold;
            txtSavePath.Text = Properties.Settings.Default.SavePath;

            labRed.Text = r.ToString("000");
            labGreen.Text = g.ToString("000");
            labBlue.Text = b.ToString("000");

            labRed.BackColor = labGreen.BackColor = labBlue.BackColor = Properties.Settings.Default.Color;
            labRed.ForeColor = labGreen.ForeColor = labBlue.ForeColor = Properties.Settings.Default.ReverseColor;
        }

        private void BtnBrower_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog()
            {
                Description = "请选择用于保存被处理图像的文件夹",
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = txtSavePath.Text
            };
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtSavePath.Text = folderBrowser.SelectedPath;
                Properties.Settings.Default.SavePath = folderBrowser.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "btnLeftDel":
                    ListBoxItemDel(lstLeft);
                    break;

                case "btnRightDel":
                    ListBoxItemDel(lstRight);
                    break;
            }
        }

        private void ListBoxItemDel(ListBox listBox)
        {
            var selIndex = listBox.SelectedIndex;
            if (selIndex < 0 || selIndex >= listBox.Items.Count) return;
            listBox.Items.RemoveAt(selIndex);
            listBox.SelectedIndex = Math.Min(selIndex, listBox.Items.Count - 1);

            ListBoxItemsChange(listBox);
        }

        private void ListBoxItemsMove(ListBox listBox, bool isMoveUp = true)
        {
            var selIndex = listBox.SelectedIndex;
            if (isMoveUp && selIndex <= 0) return;
            if (!isMoveUp && selIndex >= listBox.Items.Count - 1) return;

            var insIndex = selIndex;
            var item = listBox.Items[selIndex];
            listBox.Items.RemoveAt(selIndex);
            insIndex += isMoveUp ? -1 : 1;
            listBox.Items.Insert(insIndex, item);
            listBox.SelectedIndex = insIndex;
        }

        private void ListBoxItemsClear(ListBox listBox)
        {
            listBox.Items.Clear();

            ListBoxItemsChange(listBox);
        }

        private void ListBoxItemsChange(ListBox listBox)
        {
            switch (listBox.Name)
            {
                case "lstLeft":
                    btnLeftUp.Enabled = btnLeftDown.Enabled = btnLeftDel.Enabled = btnLeftClear.Enabled = listBox.Items.Count > 0;
                    break;

                case "lstRight":
                    btnRightUp.Enabled = btnRightDown.Enabled = btnRightDel.Enabled = btnRightClear.Enabled = listBox.Items.Count > 0;
                    break;
            }
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "btnLeftUp":
                    ListBoxItemsMove(lstLeft);
                    break;

                case "btnRightUp":
                    ListBoxItemsMove(lstRight);
                    break;

                case "btnLeftDown":
                    ListBoxItemsMove(lstLeft, false);
                    break;

                case "btnRightDown":
                    ListBoxItemsMove(lstRight, false);
                    break;
            }
        }

        private void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Control_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length <= 0) return;

            if (sender is TextBox textBox)
            {
                textBox.Text = Directory.Exists(files[0]) ? files[0] : Path.GetDirectoryName(files[0]);
                return;
            }
            if (sender is ListBox listBox)
            {
                foreach (var file in files)
                {
                    switch (Path.GetExtension(file).ToLower())
                    {
                        case ".jpg":
                        case ".jpeg":
                        case ".bmp":
                        case ".png":
                        case ".tif":
                            listBox.Items.Add(file);

                            Graphics g = listBox.CreateGraphics();
                            int hzSize = (int)g.MeasureString(file, listBox.Font).Width;
                            listBox.HorizontalExtent = Math.Max(listBox.HorizontalExtent, hzSize);

                            ListBoxItemsChange(listBox);
                            break;

                        default:
                            continue;
                    }
                }
            }
        }

        private void TxtSavePath_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            Properties.Settings.Default.SavePath = textBox.Text;
            Properties.Settings.Default.Save();
        }

        private void BtnProcessing_Click(object sender, EventArgs e)
        {
            if (lstLeft.Items.Count <= 0) return;

            trbThreshold.Enabled = btnProcessing.Enabled = false;
            try
            {
                var savePath = txtSavePath.Text;
                var threshold = trbThreshold.Value;
                var leftCount = lstLeft.Items.Count;

                toolStripProgressBar.Value = 0;
                toolStripProgressBar.Maximum = leftCount;
                tsLabel.Text = $"0 / {leftCount}";

                //ThreadPool.SetMinThreads(1, 1);
                ThreadPool.SetMaxThreads(10, 10);
                for (int i = 0; i < lstLeft.Items.Count; i++)
                {
                    if (i >= lstRight.Items.Count) return;
                    //Application.DoEvents();
                    ThreadPool.QueueUserWorkItem(TaskDo, new string[] { lstLeft.Items[i].ToString(), lstRight.Items[i].ToString(), savePath, threshold.ToString() });
                    //SamePixelProcessing(lstLeft.Items[i].ToString(), lstRight.Items[i].ToString(), savePath, threshold);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trbThreshold.Enabled = btnProcessing.Enabled = true;
            }
        }
    }
}