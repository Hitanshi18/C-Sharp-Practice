using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__diff__abstract___interface
{
   public abstract class customer
    {
        int ID; //field
        public void print()
        {
            Console.WriteLine("print");
        }
    }

    public interface  Icustomer
    {
       
        void print();
        
    }
    public class program 
    {
        public static void Main()
        {

        }
    }

}
