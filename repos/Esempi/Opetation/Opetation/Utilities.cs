using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opetation
{
    public class Utilities
    {
        public static void DriveAnalyst()
        {

            DriveInfo di = new DriveInfo(@"C:\Users\lorenzo.pioggia\Documents\IISExpress");
            Console.WriteLine(di.Name);
            Console.WriteLine(di.AvailableFreeSpace);
            DriveInfo[] dinfps = DriveInfo.GetDrives();
        }

        public static void DirectoryAnalyst()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\lorenzo.pioggia\Documents\IISExpress");
            /*Console.WriteLine(di.EnumerateDirectories());*/ //metodo per ritorna quante cartelle ci sono 
            IEnumerable<DirectoryInfo> infos = di.EnumerateDirectories("*", SearchOption.TopDirectoryOnly); //IEnurable non è in memoria 

            foreach (DirectoryInfo d in infos)
            {
                Console.WriteLine(d.FullName);

            }

            List<DirectoryInfo> dis = infos.ToList(); //l'abbiamo trasformato in una lista --> preso i dati enuremable e il comando ToList li ha copiati dentro una lista
            Console.WriteLine(dis.Count);


        }
        public static void FileAnalyst()
        {
            DirectoryInfo dis = new DirectoryInfo("Directory Folder");
            FileInfo[] fileInfos = dis.GetFiles();
            foreach (var fileInfo in fileInfos)
            {
                Console.WriteLine($"Name is: {0}", fileInfo.DirectoryName);
                Console.WriteLine($"Name is: {1}", fileInfo.Name);
            }

        }

        public static void FileManagement()
        {
            //File.Create(@"C:\Users\lorenzo.pioggia\Downloads\FileManagement\Test.txt").Close(); //crea file
            string percorso = @"C:\Users\lorenzo.pioggia\Downloads\FileManagement\Pippo.txt";
            if (!File.Exists(percorso))
            {
                //STREAM creazione soluzione 1
                FileStream fs = File.Create(percorso);
                // trasformazioni eventuali
            }
            #region //STREAM creazione soluzione 2
            using (StreamWriter sw = new StreamWriter(percorso))
            {
                sw.WriteLine("Hello"); //scopo di computazione
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            using (StreamReader sr = new StreamReader(percorso))
            {

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }
            // using

        }
        #endregion

        public static void BinaryReader()
        {
            FileStream file = File.Create(@"C:\\Users\\lorenzo.pioggia\\Downloads\\FileManagement\\pi.txt");
            BinaryWriter bw = new BinaryWriter(file);
            bw.Write(Encoding.BigEndianUnicode.GetBytes("String value"));
            bw.Write("A");
            bw.Write(true);
            bw.Close();

            //FileStream fileOpen = File.Open("Simple.dat", FileMode.Open);
            //BinaryReader br = new BinaryReader(fileOpen);
            //Console.WriteLine(bw.ToString());


        }
    }
}
