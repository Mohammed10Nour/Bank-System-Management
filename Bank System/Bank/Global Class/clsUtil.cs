using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Global_Class
{
    public class clsUtil
    {
        private static string NewGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        private static string NewFileName(string SourceImage)
        {
            string fileName = SourceImage;
            FileInfo fi = new FileInfo(fileName);
            string exn = fi.Extension;
            return NewGuid() + exn;
         
        }
        public static bool CopyeImageFromCurrentFolderToSpecialFolder(ref string SourceFile)
        {
            string DestinationFolder = "C:\\Users\\Lenovo\\Desktop\\Privite\\Projects\\The Begginning\\Bank System version 2\\Bank System\\Bank\\Images\\";
            if (!Directory.Exists(DestinationFolder))
            {
                try
                {
                    Directory.CreateDirectory(DestinationFolder);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            string DestinationFile = DestinationFolder + NewFileName(SourceFile);

            try
            {
                File.Copy(SourceFile,DestinationFile,true);
                SourceFile = DestinationFile;
            }
            catch(IOException Iox)
            {
                return false;
            }

            return true;
        }
    }
}
