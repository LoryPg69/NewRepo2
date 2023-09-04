using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ReportWriter.Utility;

namespace ReportWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get file to read
            string path = @"C:\Users\lorenzo.pioggia\Downloads\FileManagement\forReport.txt";
             

            // check if file exist, if not from console
            FileInfo f = new FileInfo(path);
            if (!f.Exists)
            {
                Console.WriteLine("starter file path is not correct");
                return;
            }
            // step 1 read a test file with a list of directories
            List <string> contents = File.ReadLines(path).ToList();


            //step 2 - exract files from directory ina recursive any
            List<string> results = new List<string>();
            foreach (string content in contents) {
                string files = ReportUtilities.GetInfoForReport(content);
                results.Add(files);
            }
            // step 2.1 prepare data for writing
            

            // step 3 - write a report
            File.AppendAllLines(@"C:\\Users\\lorenzo.pioggia\\Downloads\\FileManagement\\report.txt\", results);

          

        }

        
    }
}
