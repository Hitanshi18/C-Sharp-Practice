using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace c__exception_handling
{
    class ExceptionHandling 
    { 
    public static void Main()
    {
            try
            {
                StreamReader streamReader = new StreamReader(@"E:\C# Practice\data.txt"); // by change the name of the file it throw error : unhandled exception : system.io.filenot found exception
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            } 
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }       
    }
   }
}


