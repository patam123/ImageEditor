using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageEditorLibrary
{
    public class ImageEditor
    {
        public Bitmap TransformToNegative(Bitmap orgImg)
        {
            Bitmap negative = new Bitmap(orgImg);
            for (int x = 0; x < negative.Width; x++)
            {
                for (int y = 0; y < negative.Height; y++)
                {
                    var pxl = negative.GetPixel(x, y);
                    var r = 255 - pxl.R;
                    var g = 255 - pxl.G;
                    var b = 255 - pxl.B;
                    var nCol = Color.FromArgb(r, g, b);
                    negative.SetPixel(x, y, nCol);
                }
            }
            return negative;
        }
        public Bitmap TransformToGreyScale(Bitmap orgImg)
        {
            Bitmap greyScale = new Bitmap(orgImg);
            for (int x = 0; x < greyScale.Width; x++)
            {
                for (int y = 0; y < greyScale.Height; y++)
                {
                    var pxl = greyScale.GetPixel(x, y);
                    var grey = (pxl.R + pxl.G + pxl.B) / 3;
                    var nCol = Color.FromArgb(grey, grey, grey);
                    greyScale.SetPixel(x, y, nCol);
                }
            }
            return greyScale;
        }
        public Bitmap TransformToBlurred(Bitmap orgImg)
        {
            Bitmap blurred = new Bitmap(orgImg);

            for (int x = 0; x < blurred.Width; x++)
            {
                for (int y = 0; y < blurred.Height; y++)
                {
                    var pixel = new List<Color>();
                    var rSum = 0;
                    var gSum = 0;
                    var bSum = 0;
                    pixel.Add(orgImg.GetPixel(x, y));

                    if (y > 0)
                    {
                        pixel.Add(orgImg.GetPixel(x, y - 1));
                    }
                    if (y < blurred.Height - 1)
                    {
                        pixel.Add(orgImg.GetPixel(x, y + 1));
                    }
                    if (x > 0)
                    {
                        pixel.Add(orgImg.GetPixel(x - 1, y));
                    }
                    if (x > 0 && y > 0)
                    {
                        pixel.Add(orgImg.GetPixel(x - 1, y - 1));
                    }
                    if (x > 0 && y < blurred.Height - 1)
                    {
                        pixel.Add(orgImg.GetPixel(x - 1, y + 1));
                    }
                    if (x < blurred.Width - 1)
                    {
                        pixel.Add(orgImg.GetPixel(x + 1, y));
                    }
                    if (x < blurred.Width - 1 && y > 0)
                    {
                        pixel.Add(orgImg.GetPixel(x + 1, y - 1));
                    }
                    if (x < blurred.Width - 1 && y < blurred.Height - 1)
                    {
                        pixel.Add(orgImg.GetPixel(x + 1, y + 1));
                    }

                    foreach (var pxl in pixel)
                    {
                        rSum += pxl.R;
                        gSum += pxl.G;
                        bSum += pxl.B;
                    }
                    var r = rSum / pixel.Count;
                    var g = gSum / pixel.Count;
                    var b = bSum / pixel.Count;
                    var nCol = Color.FromArgb(r, g, b);
                    blurred.SetPixel(x, y, nCol);
                }
            }
            return blurred;
        }
    }
}
