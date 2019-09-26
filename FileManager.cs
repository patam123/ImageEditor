using System;
using System.IO;

namespace ImageEditorLibrary
{
    public class FileManager
    {
        public bool TryValidExtension(string filePath)
        {
            filePath = Path.GetExtension(filePath);
            switch (filePath)
            {
                case ".jpg":
                case ".bmp":
                case ".gif":
                case ".png":
                case ".jfif":
                    return true;
                default:
                    return false;
            }
        }

        public string GetNewFilePath(string filePath, string textAddOn)
        {
            var fileDirectory = Path.GetDirectoryName(filePath);
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            var extension = Path.GetExtension(filePath);
            string newFileName = fileDirectory + Path.DirectorySeparatorChar + fileNameWithoutExtension + "_" + textAddOn + extension;

            return newFileName;
        }

    }
}
