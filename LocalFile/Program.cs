using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Write Operation Start");

            string FolderName = "myappLogs";
            string FileName = DateTime.Now.Second.ToString() +"Logs.txt";

            //Cutom Log Message 
            string strLogText = "Log Information Found on " + DateTime.Now;

            string strFolderName = Environment.GetEnvironmentVariable("HOME") + @"\site\wwwroot" + FolderName;

            string strLogFilePath = strFolderName.Trim() + FileName;

            //If the directory doesn't exist, create it.
            if (!Directory.Exists(strFolderName))
            {
                Directory.CreateDirectory(strFolderName);
            }

            //Once Directory Exists Create or Writre File 
            using (StreamWriter writer = new StreamWriter(strLogFilePath, true))
            {
                writer.WriteLine(strLogText);
            }

            Console.WriteLine("File Created On Location " + strLogFilePath);

            Console.WriteLine("File Write Operation End");


        }
    }
}
