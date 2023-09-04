using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ReportWriter.Model;
using ReportWriter.Utility;

namespace ReportWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get file to read
            // esc from console
            Console.WriteLine("File name where to read folders list:");
            string path = Console.ReadLine();
            Console.WriteLine("File name file to write report:");
            string reportPath = Console.ReadLine();

            // hardcoded path
            //string path = @"C:\Users\info\Downloads\FIleManagement\ForReport.txt";
            //string reportPath = @"C:\Users\info\Downloads\FIleManagement\Report.txt";

            // check if file exist, if not esc from console
            FileInfo f = new FileInfo(path);
            if (!f.Exists)
            {
                Console.WriteLine("starter file path in not correct");
                return;
            }

            // step 1 - read a text file with a list of directories
            List<string> contents = File.ReadLines(path).ToList();

            // step 2 - extract files from directory in a recursive way
            List<FolderAnalisys> results = new List<FolderAnalisys>();
            foreach (string content in contents) 
            {
                FolderAnalisys r = ReportUtilities.GetFolderAnalisysForReport(content);
                results.Add(r);
            }

            // step 2.1 prepare data for writing
            // using FolderAnalysis, we don't need this step anymore


            // step 3 - write report
            ReportUtilities.SaveReportToTxt(reportPath, ref results);
        }

        
    }
}
