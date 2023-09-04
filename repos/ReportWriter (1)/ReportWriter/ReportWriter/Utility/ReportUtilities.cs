using ReportWriter.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWriter.Utility
{

    public class ReportUtilities
    {
        public static void SaveReportToTxt(string path, ref List<FolderAnalisys> data)
        {
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var d in data)
                {
                    tw.WriteLine(d.ToString());
                }
            }
        }

        public static string PrepareData(FileInfo[] files)
        {
            string[] convertedFiles = files == null ?
                new string[] { "" } :
                files.Select(f => f.FullName).ToArray();

            string result = string.Join('\n', convertedFiles);

            return result;
        }

        public static FolderAnalisys GetFolderAnalisysForReport(string folder)
        {
            // recover file list from folder
            DirectoryInfo di = new DirectoryInfo(folder);
            FolderAnalisys fa = new FolderAnalisys();
            fa.FolderName = folder;

            // check folder path is correct
            try
            {
                fa.Files= di.GetFiles("*", SearchOption.AllDirectories);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                fa.Error = ex;
            }

            return fa;
        }

        public static FileInfo[] GetInfoForReport(string folder)
        {
            // recover file list from folder
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

            return files;
        }
    }
}
