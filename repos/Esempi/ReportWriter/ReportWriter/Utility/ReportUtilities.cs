using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriter.Utility
{
    public class ReportUtilities
    {
        public static string GetInfoForReport(string folder)
        {
            //ricover file list from folder
            DirectoryInfo di = new DirectoryInfo(folder);
            FileInfo[] files = null;
            // check folder path is correct
            try
            {
                files = di.GetFiles("*", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
       
            }

            string[] convertedFiles = files == null ?
                new string[] {""} :
                files.Select(f => f.FullName).ToArray();
            string result = string.Join(",", convertedFiles);  // se invece estrai gli array dal file info

            return result;

        }
        //public StateChangeEventArgs void PrefereData() { }
        
    }
}
