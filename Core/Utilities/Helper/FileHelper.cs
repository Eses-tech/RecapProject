using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        static string directory = Directory.GetCurrentDirectory()+@"\wwwroot\";
        static string path = @"Images\";

        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName).ToUpper();
            string newFileName = Guid.NewGuid().ToString("N") + extension;
            var sourcePath = Path.GetTempFileName();

            if (!Directory.Exists(directory+path))
            {
                Directory.CreateDirectory(directory + path);
            }

            using (FileStream stream=new FileStream(sourcePath,FileMode.Create))
            {
                file.CopyTo(stream);
                File.Move(sourcePath, directory + newFileName);
            }

            return (path+newFileName).Replace("\\","/");
            
        }

        public static string Update(string oldImage,IFormFile file)
        {

            Delete(oldImage);
            return Add(file);

        }

        public static void  Delete(string imagePath)
        {
           
            if(File.Exists(directory+imagePath.Replace("/","\\"))&&
                Path.GetFileName(imagePath) != "default.jpg")
            {
                File.Delete(directory + imagePath.Replace("/", "\\"));
            }
        }
    }
}
