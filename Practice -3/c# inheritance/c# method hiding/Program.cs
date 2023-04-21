using System;

namespace c__Method_hiding
{
    public class employee
    {
        public string firstname;
        public string lastname;

        public void Printfullname()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }

    public class parttimeemployee : employee
    {
        public new void Printfullname()
        {

            // base.Printfullname();
            Console.Write(firstname + " " + lastname + " - Constructor");
        }
    }

    public class fulltimeemployee : employee { }

    public class program
    {
        public static void Main(string[] args)
        {
            fulltimeemployee FTE = new fulltimeemployee();
            FTE.firstname = "fulltime";
            FTE.lastname = "employee";
            FTE.Printfullname();

            // parttimeemployee PTE = new parttimeemployee();
            employee PTE = new parttimeemployee();
            PTE.firstname = "parttime";
            PTE.lastname = "employee";
            PTE.Printfullname();
            // ((employee)PTE).Printfullname();
        }
    }
}
