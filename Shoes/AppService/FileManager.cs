using Shoes.AppConstants;
using System;
using System.IO;
using System.Windows.Forms;

namespace Shoes.AppService
{
    internal class FileManager
    {
        public static void deleteFile(string fileName)
        {
            if (fileName.Trim().Equals(""))
            {
                return;
            }

            try
            {
                File.Delete(getImgPath(fileName));                
            }
            catch (Exception e)
            {
                int a = 0;
                // PKGH Ничего не делаем.
            }
        }

        public static string getImgPath(string fileName)
        {            
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }
    }
}
