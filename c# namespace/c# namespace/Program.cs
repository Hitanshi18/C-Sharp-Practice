using System;
using PATA = ProjectA.TeamA; //Alias directive - resolve ambiquity between names & names are too long 
using PATB = ProjectA.TeamB;
using System.Collections;
using System.Configuration;
class Program
{
    public static void Main()
    {
        //ProjectA.TeamA.ClassA.Print();
        PATA.ClassA.Print();
        //ProjectA.TeamB.ClassA.Print();
        PATB.ClassA.Print();

    }
}


