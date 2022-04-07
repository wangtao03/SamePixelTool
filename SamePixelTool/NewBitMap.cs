using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SamePixelTool
{
    public abstract class BmpBase<L, R> where L : RGB, new() where R : RGB, new()
    {
        public static bool TryMatch(Bitmap leftBmp, Bitmap rightBmp)
        {
            return (leftBmp.Width == rightBmp.Width && leftBmp.Height == rightBmp.Height);
        }

        public static void Match(Bitmap leftBmp, Bitmap rightBmp)
        {
            if (!TryMatch(leftBmp, rightBmp))
            {
                throw new FormatException("左右图像格式不匹配");
            }
        }

        #region 完全匹配

        public static bool TestColor(RGB left, RGB right)
        {
            return (left.red == right.red && left.green == right.green && left.blue == right.blue);
        }

        public static bool TestColor(ARGB left, ARGB right, bool discardAlpha = false)
        {
            var result = TestColor((RGB)left, (RGB)right);
            return discardAlpha ? result : (result && (left.alpha == right.alpha));
        }

        public static bool TestColor(RGB32 left, RGB32 right) => TestColor(left, right, true);

        public static bool TestColor(RGB left, ARGB right) => TestColor(left, (RGB)right);

        public static bool TestColor(RGB left, RGB32 right) => TestColor(left, (RGB)right);

        public static bool TestColor(ARGB left, RGB right) => TestColor((RGB)left, right);

        public static bool TestColor(ARGB left, RGB32 right) => TestColor(left, right, true);

        public static bool TestColor(RGB32 left, RGB right) => TestColor((RGB)left, right);

        public static bool TestColor(RGB32 left, ARGB right) => TestColor(left, right, true);

        #endregion 完全匹配

        #region 模糊匹配

        public static bool LikeColor(RGB left, RGB right, byte threshold = 10)
        {
            var absR = Math.Abs(left.red - right.red);
            var absG = Math.Abs(left.green - right.green);
            var absB = Math.Abs(left.blue - right.blue);

            return (absR <= threshold && absG <= threshold && absB <= threshold);
        }

        public static bool LikeColor(ARGB left, ARGB right, byte threshold = 10, bool discardAlpha = false)
        {
            var absA = Math.Abs(left.alpha - right.alpha);
            var result = LikeColor((RGB)left, (RGB)right, threshold);

            return discardAlpha ? result : result && (absA <= threshold);
        }

        public static bool LikeColor(RGB32 left, RGB32 right, byte threshold = 10) => LikeColor(left, right, threshold, true);

        public static bool LikeColor(RGB left, ARGB right, byte threshold = 10) => LikeColor(left, (RGB)right, threshold);

        public static bool LikeColor(RGB left, RGB32 right, byte threshold = 10) => LikeColor(left, (RGB)right, threshold);

        public static bool LikeColor(ARGB left, RGB right, byte threshold = 10) => LikeColor((RGB)left, right, threshold);

        public static bool LikeColor(ARGB left, RGB32 right, byte threshold = 10) => LikeColor(left, right, threshold, true);

        public static bool LikeColor(RGB32 left, RGB right, byte threshold = 10) => LikeColor((RGB)left, right, threshold);

        public static bool LikeColor(RGB32 left, ARGB right, byte threshold = 10) => LikeColor(left, right, threshold, true);

        #endregion 模糊匹配

        public abstract Bitmap NewBitMap(Bitmap leftBmp, Bitmap rightBmp, int threshold = 10);
    }

    public class NewBmp<L, R> : BmpBase<L, R> where L : RGB, new() where R : RGB, new()
    {
        public override Bitmap NewBitMap(Bitmap leftBmp, Bitmap rightBmp, int threshold = 10)
        {
            try
            {
                Match(leftBmp, rightBmp);
            }
            catch (FormatException)
            {
                throw;
            }

            var newBmp = new Bitmap(leftBmp.Width, leftBmp.Height, PixelFormat.Format32bppArgb);
            var rect = new Rectangle(0, 0, newBmp.Width, newBmp.Height);

            var leftBmpData = leftBmp.LockBits(rect, ImageLockMode.ReadOnly, leftBmp.PixelFormat);
            var rightBmpData = rightBmp.LockBits(rect, ImageLockMode.ReadOnly, rightBmp.PixelFormat);
            var newBmpData = newBmp.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            var pixelNum = leftBmp.Width * leftBmp.Height;

            var leftSize = Marshal.SizeOf(new L());
            var rightSize = Marshal.SizeOf(new R());

            for (int i = 0; i < pixelNum; i++)
            {
                var leftArgb = new L();
                var rightArgb = new R();
                var newArgb = new ARGB();

                Marshal.PtrToStructure(leftBmpData.Scan0 + i * leftSize, leftArgb);
                Marshal.PtrToStructure(rightBmpData.Scan0 + i * rightSize, rightArgb);

                if (LikeColor(leftArgb, rightArgb))
                {
                    newArgb.alpha = 0;
                }
                else
                {
                    newArgb.alpha = 255;
                    newArgb.red = leftArgb.red;
                    newArgb.green = leftArgb.green;
                    newArgb.blue = leftArgb.blue;
                }

                Marshal.StructureToPtr(newArgb, newBmpData.Scan0 + i * 4, true);
            }

            leftBmp.UnlockBits(leftBmpData);
            rightBmp.UnlockBits(rightBmpData);
            newBmp.UnlockBits(newBmpData);

            return newBmp;
        }
    }
}