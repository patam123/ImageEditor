using ImageEditorLibrary;
using System;
using System.Drawing;
using System.IO;

namespace ImageEditorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageEditor imageEditor = new ImageEditor();
            FileManager fileManager = new FileManager();

            string filePath;
            Bitmap image = null;
            if (args.Length != 0)
            {
                filePath = args[0];
            }
            else
            {
                Console.WriteLine("Choose an image to convert:");
                filePath = Console.ReadLine();
            }
            try
            {
                if (fileManager.TryValidExtension(filePath))
                {
                    image = new Bitmap(filePath);
                }
                else
                {
                    while (!fileManager.TryValidExtension(filePath))
                    {
                        Console.WriteLine("Your input \"{0}\" is not an image! Try again!", filePath);
                        filePath = Console.ReadLine();
                    }
                    image = new Bitmap(filePath);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input:\n\"{0}\" is not a valid file name. Could not find image.", filePath);
                Environment.Exit(0);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File \"{0}\" does not exist!", filePath);
                Environment.Exit(0);
            }

            using (var negative = imageEditor.TransformToNegative(image))
            {
                negative.Save(fileManager.GetNewFilePath(filePath, "negative"));
            }

            using (var greyScale = imageEditor.TransformToGreyScale(image))
            {
                greyScale.Save(fileManager.GetNewFilePath(filePath, "greyscale"));
            }

            using (var blurred = imageEditor.TransformToBlurred(image))
            {
                blurred.Save(fileManager.GetNewFilePath(filePath, "blurred"));
            }
            image.Dispose();
        }
    }
}
