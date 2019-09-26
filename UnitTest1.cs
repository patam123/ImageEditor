using NUnit.Framework;
using ImageEditorLibrary;
using System;
using System.Drawing;
using System.IO;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TransformToNegative_HappyDays()
        {
            ImageEditor imageEditor = new ImageEditor();
            var test = new Bitmap(3, 3);
            for (int x = 0; x < test.Width; x++)
            {
                for (int y = 0; y < test.Height; y++)
                {
                    test.SetPixel(x, y, Color.FromArgb(100, 150, 200));
                }
            }

            var expected = new Bitmap(3, 3);
            for (int x = 0; x < expected.Width; x++)
            {
                for (int y = 0; y < expected.Height; y++)
                {
                    expected.SetPixel(x, y, Color.FromArgb(155, 105, 55));
                }
            }

            var actual = imageEditor.TransformToNegative(test);
            for (int x = 0; x < actual.Width; x++)
            {
                for (int y = 0; y < actual.Height; y++)
                {
                    Assert.AreEqual(expected.GetPixel(x, y), actual.GetPixel(x, y));
                }
            }
        }
        [Test]
        public void TransformToGreyScale_HappyDays()
        {
            ImageEditor imageEditor = new ImageEditor();
            var test = new Bitmap(3, 3);
            for (int x = 0; x < test.Width; x++)
            {
                for (int y = 0; y < test.Height; y++)
                {
                    test.SetPixel(x, y, Color.FromArgb(100, 150, 200));
                }
            }
            var expected = new Bitmap(3, 3);
            for (int x = 0; x < expected.Width; x++)
            {
                for (int y = 0; y < expected.Height; y++)
                {
                    expected.SetPixel(x, y, Color.FromArgb(150, 150, 150));
                }
            }
            var actual = imageEditor.TransformToGreyScale(test);
            for (int x = 0; x < actual.Width; x++)
            {
                for (int y = 0; y < actual.Height; y++)
                {
                    Assert.AreEqual(expected.GetPixel(x, y), actual.GetPixel(x, y));
                }
            }
        }
        [Test]
        public void TransformToBlurred_HappyDays()
        {
            ImageEditor imageEditor = new ImageEditor();
            var test = new Bitmap(3, 3);
            for (int x = 0; x < test.Width; x++)
            {
                for (int y = 0; y < test.Height; y++)
                {
                    if (x == 1 && y == 1)
                    {
                        test.SetPixel(x, y, Color.FromArgb(100, 100, 100));
                    }
                    else
                    {
                        test.SetPixel(x, y, Color.FromArgb(100, 150, 200));
                    }
                }
            }
            var expected = new Bitmap(3, 3);
            for (int x = 0; x < expected.Width; x++)
            {
                for (int y = 0; y < expected.Height; y++)
                {
                    if (x == 1 && y == 1)
                    {
                        expected.SetPixel(x, y, Color.FromArgb(100 * 9 / 9, (150 * 8 + 100) / 9, (200 * 8 + 100) / 9));
                    }
                    else if (x != 1 && y != 1)
                    {
                        expected.SetPixel(x, y, Color.FromArgb(100 * 4 / 4, (150 * 3 + 100) / 4, (200 * 3 + 100) / 4));
                    }
                    else
                    {
                        expected.SetPixel(x, y, Color.FromArgb(100 * 6 / 6, (150 * 5 + 100) / 6, (200 * 5 + 100) / 6));
                    }
                }
            }
            var actual = imageEditor.TransformToBlurred(test);
            for (int x = 0; x < actual.Width; x++)
            {
                for (int y = 0; y < actual.Height; y++)
                {
                    Assert.AreEqual(expected.GetPixel(x, y), actual.GetPixel(x, y));
                }
            }
        }
        [Test]
        public void GetNewFilePath_HappyDays()
        {
            FileManager filemanager = new FileManager();
            var expected = @"C:\Users\91patham\Desktop\Prog\applepie_negative.jfif";
            var actual = filemanager.GetNewFilePath(@"C:\Users\91patham\Desktop\Prog\applepie.jfif", "negative");

            Assert.AreEqual(expected, actual);
        }
    }
}