using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamePixelTool
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 用于更新进度条的委托
        /// </summary>
        private delegate void UpdatePercent();

        /// <summary>
        /// 执行进度条更新
        /// </summary>
        private void UpdateProgressBar()
        {
            toolStripProgressBar.PerformStep();
            tsLabel.Text = $"{toolStripProgressBar.Value} / {toolStripProgressBar.Maximum}";

            if (toolStripProgressBar.Value >= toolStripProgressBar.Maximum)
            {
                MessageBox.Show("完成!");
                trbThreshold.Enabled = btnProcessing.Enabled = true;
            }
        }

        /// <summary>
        /// 对比两个Bmp,将重复值变为透明,返回新的Bmp
        /// </summary>
        /// <param name="leftBmp">原图像</param>
        /// <param name="rightBmp">背景图像</param>
        /// <param name="threshold">模糊阈值</param>
        /// <returns></returns>
        private Bitmap GetNewBmp(Bitmap leftBmp, Bitmap rightBmp, int threshold = 10)
        {
            Bitmap newBmp = new Bitmap(leftBmp.Width, leftBmp.Height, PixelFormat.Format32bppArgb);
            try
            {
                switch (leftBmp.PixelFormat)
                {
                    case PixelFormat.Format24bppRgb:
                        switch (rightBmp.PixelFormat)
                        {
                            case PixelFormat.Format24bppRgb:
                                newBmp = new NewBmp<RGB, RGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppRgb:
                                newBmp = new NewBmp<RGB, RGB32>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppArgb:
                                newBmp = new NewBmp<RGB, ARGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            default:
                                break;
                        }
                        break;

                    case PixelFormat.Format32bppRgb:
                        switch (rightBmp.PixelFormat)
                        {
                            case PixelFormat.Format24bppRgb:
                                newBmp = new NewBmp<RGB32, RGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppRgb:
                                newBmp = new NewBmp<RGB32, RGB32>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppArgb:
                                newBmp = new NewBmp<RGB32, ARGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            default:
                                break;
                        }
                        break;

                    case PixelFormat.Format32bppArgb:
                        switch (rightBmp.PixelFormat)
                        {
                            case PixelFormat.Format24bppRgb:
                                newBmp = new NewBmp<ARGB, RGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppRgb:
                                newBmp = new NewBmp<ARGB, RGB32>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            case PixelFormat.Format32bppArgb:
                                newBmp = new NewBmp<ARGB, ARGB>().NewBitMap(leftBmp, rightBmp, threshold);
                                break;

                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                return newBmp;
            }
            catch (FormatException)
            {
                throw;
            }
        }

        /// <summary>
        /// 处理图像文件并保存
        /// </summary>
        /// <param name="leftPath">原图像文件</param>
        /// <param name="rightPath">背景图像文件</param>
        /// <param name="savePath">保存路径</param>
        /// <param name="threshold">模糊阈值</param>
        private void SamePixelProcessing(string leftPath, string rightPath, string savePath, int threshold = 10)
        {
            var leftBmp = new Bitmap(leftPath);
            var rightBmp = new Bitmap(rightPath);
            var fileName = Path.GetFileNameWithoutExtension(leftPath);

            try
            {
                Bitmap newBmp = GetNewBmp(leftBmp, rightBmp, threshold);
                newBmp.Save($@"{savePath}\{fileName}.png", ImageFormat.Png);
            }
            catch (FormatException)
            {
                throw;
            }
        }

        /// <summary>
        /// 用于多线程执行的任务
        /// </summary>
        /// <param name="obj"></param>
        private void TaskDo(object obj)
        {
            try
            {
                var parm = (string[])obj;
                SamePixelProcessing(parm[0], parm[1], parm[2], int.Parse(parm[3]));

                var update = new UpdatePercent(UpdateProgressBar);
                this.Invoke(update);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}