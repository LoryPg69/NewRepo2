using FileEsercizio;
using System;

Utilities.ReadFile();
Console.WriteLine("---------------------------");
Utilities.DirectoryAnalyst();

Utilities.ProcessFile();
try
{
    Utilities.ReadFile();
}
catch (Exception ex)
{
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("error");
}
finally
{
    Console.WriteLine("opp");  //viene sempre eseguito  
}
