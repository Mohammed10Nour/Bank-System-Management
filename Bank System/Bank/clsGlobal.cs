using Business_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{
    public class clsGlobal
    {
        private static clsUser _CurrentUser;
        public static clsUser CurrentUser
        {
            get
            {
                return _CurrentUser;
            }
            set
            {
                _CurrentUser = value;
            }
        }
        public static bool hasPermission(int Permission)
        {
            return (clsGlobal.CurrentUser.Permission & Permission) == Permission;
          
        }
      
        private static string Path = "C:\\Users\\Lenovo\\Desktop\\Privite\\Projects\\Bank System version 2\\Bank System\\Bank\\Private.txt";
   
        public static void SotrageUserNameAndPassword(string UserName, string Password,bool UnStorage=false)
        {
            // if file not exist it will create new file and write on it
            try
            {
            
                using(StreamWriter sr=new StreamWriter(Path,false))
                {
                    if(UnStorage)
                    {
                        sr.Write(string.Empty);
                    }
                    else 
                        sr.WriteLine($"{UserName}##{Password}");
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

      
        public static bool LoadUserNameAndPassword(ref string UserName,ref string Password)
        {
            try
            {
                string Line = "";

                using (StreamReader sr = new StreamReader(Path))
                {
                    Line = sr.ReadLine();
                }
                if (string.IsNullOrEmpty(Line))
                    return false ;
               
                UserName = Line.Substring(0, Line.IndexOf("#"));
                Password = Line.Substring(Line.LastIndexOf("#")+1);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
    }

}
