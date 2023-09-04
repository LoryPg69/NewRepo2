using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEsercizio
{
    internal class Utilities
    {
        //public static void FileManagement()
        //{
        //    //File.Create(@"C:\Users\lorenzo.pioggia\Downloads\FileManagement\Test.txt").Close(); //crea file
        //    string percorso = @"C:\Users\lorenzo.pioggia\Downloads\FileManagement\Esercizio.txt";
            
        //     //STREAM creazione soluzione 2
        //    using (StreamWriter sw = new StreamWriter(percorso))
        //    {
        //        if (!File.Exists(percorso))
        //        {
        //            //STREAM creazione soluzione 1
        //            FileStream fs = File.Create(percorso);
        //            // trasformazioni eventuali
        //        }
        //        sw.WriteLine("C:\\Users\\lorenzo.pioggia\\Downloads\\Game"); //scopo d1 computazione
        //        sw.WriteLine("C:\\Users\\lorenzo.pioggia\\Downloads\\Pippo");
        //        sw.WriteLine("C:\\Users\\lorenzo.pioggia\\Documents\\IISExpress");
        //    }

        //    using (StreamReader sr = new StreamReader(percorso))
        //    {

        //        string s = "";
        //        while ((s = sr.ReadLine()) != null)
        //        {
        //            Console.WriteLine(s);

        //        }
        //    }
        //    if (!File.Exists(percorso))
        //    {
                
        //        FileStream fs = File.Create(percorso);
                
        //    }

        //}

        public static string[] ReadFile()
        {
            string path = @"C:\Users\lorenzo.pioggia\Downloads\FileManagement\Esercizio.txt";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { 
                    "C:\\Users\\lorenzo.pioggia\\Downloads\\Game",
                    "C:\\Users\\lorenzo.pioggia\\Downloads\\Pippo",
                    "C:\\\\Users\\\\lorenzo.pioggia\\\\Documents\\\\IISExpress\"" 
                };
                File.WriteAllLines(path, createText);
            }

            //// This text is always added, making the file longer over time
            //// if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }
            return readText;
        }

        public void WriteFile()
        {
            // Create a string with a line of text.
            string text = "First line" + Environment.NewLine;

            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the text to a new file named "WriteFile.txt".
            File.WriteAllText(Path.Combine(docPath, "Report.txt"), text);

            // Create a string array with the additional lines of text
            string[] lines = { "New line 1", "New line 2" };

            // Append new lines of text to the file
            File.AppendAllLines(Path.Combine(docPath, "Report.txt"), lines);
        }

        public static void DirectoryAnalyst()
        {
            DirectoryInfo d1 = new DirectoryInfo(@"C:\Users\lorenzo.pioggia\Downloads\Game");
            /*Console.WriteLine(d1.EnumerateDirectories());*/ //metodo per ritorna quante cartelle ci sono 
            IEnumerable<DirectoryInfo> infos1 = d1.EnumerateDirectories("*", SearchOption.TopDirectoryOnly); //IEnurable non è in memoria 

            DirectoryInfo d2 = new DirectoryInfo(@"C:\Users\lorenzo.pioggia\Downloads\Pippo");
            /*Console.WriteLine(d1.EnumerateDirectories());*/ //metodo per ritorna quante cartelle ci sono 
            IEnumerable<DirectoryInfo> infos2 = d2.EnumerateDirectories("*", SearchOption.TopDirectoryOnly);

            DirectoryInfo d3 = new DirectoryInfo(@"C:\Users\lorenzo.pioggia\Documents\IISExpress");
            /*Console.WriteLine(d1.EnumerateDirectories());*/ //metodo per ritorna quante cartelle ci sono 
            IEnumerable<DirectoryInfo> infos3 = d3.EnumerateDirectories("*", SearchOption.TopDirectoryOnly);

            foreach (DirectoryInfo d in infos1)
            {
                Console.WriteLine(d.FullName);

            }

            foreach (DirectoryInfo d in infos2)
            {
                Console.WriteLine(d.FullName);

            }

            foreach (DirectoryInfo d in infos3)
            {
                Console.WriteLine(d.FullName);

            }

            List<DirectoryInfo> dis1 = infos1.ToList();  
            Console.WriteLine(dis1.Count);

            List<DirectoryInfo> dis2 = infos2.ToList(); 
            Console.WriteLine(dis2.Count);

            List<DirectoryInfo> dis3 = infos3.ToList(); 
            Console.WriteLine(dis3.Count);


        }
        public static void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }
    }


