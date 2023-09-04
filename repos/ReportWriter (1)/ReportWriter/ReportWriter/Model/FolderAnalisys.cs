using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReportWriter.Model
{
    public class FolderAnalisys
    {
        public string FolderName { get; set; }
        public FileInfo[] Files { get; set; }
        public Exception Error { get; set; }

        public override string ToString()
        {
            if (Error != null)
            {
                return $"folder {FolderName} has an error \n{Error.Message}";
            }
            else
            {
                // questa soluzion usa LINQ
                // non lo abbiamo ancora fatto
                // ma immaginate che dietro le quinte ci sia un foreach
                IEnumerable<string> files = Files.Select(f => f.FullName);
                string fileListInOneString = string.Join('\n', files);

                return $"folder {FolderName} contains these files:\n{fileListInOneString}";
            }
        }
    }
}
