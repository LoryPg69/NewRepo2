using System;

namespace Opetation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Utilities.DirectoryAnalyst();
            ////Utilities.FileManagement();
            //Utilities.BinaryReader();

            try
            {
                Utilities.BinaryReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("error");
            }
            finally {
                Console.WriteLine("opp");  //viene sempre eseguito  
                    }

        }
    }
    }

