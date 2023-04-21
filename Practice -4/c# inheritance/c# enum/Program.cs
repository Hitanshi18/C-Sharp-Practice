using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c__enum
{
    /*
  public class Enums
    {
        public static void Main()
        {
            Customer customer = new Customer[3];
            customer[0] = new Customer();
            {
                name = "mark";
                Gender = 1;
            };
            customer[1] = new Customer();
            {
                name = "marry";
                Gender = 2;
            };
            customer[2] = new Customer();
            {
                name = "sam";
                Gender = 0;
            };

            foreach(Customer customer1 in customer)
            {
                Console.WriteLine("name = {0} && gender = { 1}", cusomer.name, customer.gender);
            }

        }
    }

    public static string GetGender (int gender)
    {
        switch (gender)
        {
            case 0:
                return "unknown";
            case 1:
                return "male";
            case 2:
                return "female";
            default:
                return "invalid data detected";
        }
    }

    // 0 - unknown
    // 1- male
    // 2- female

    public class Customer
    {
        public string name { get; set; }
        public int Gender { get; set; }
    }
    
    */

    enum daysofweek
    {
        sunday = 0,
        monday = 1,
        tuesday=3,
        wednesday =4,
        thursday =5,
        friday =6,
        saturday =7,
    }
    class Program
    {
        static void Main()
        {
            daysofweek today = daysofweek.tuesday;


            // Use enum values in switch statements
            switch (today)
            {
                case daysofweek.monday:
                case daysofweek.tuesday:
                case daysofweek.wednesday:
                case daysofweek.thursday:
                case daysofweek.friday:
                    Console.WriteLine("It's a weekday.");
                    break;
                case daysofweek.saturday:
                case daysofweek.sunday:
                    Console.WriteLine("It's a weekend.");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }


            if (today == daysofweek.saturday || today == daysofweek.sunday)
            {
                Console.WriteLine("it's the weekend");
            }
            else
            {
                Console.WriteLine("it's a weekday.");
            }

            //convert enum to int
            int dayvalue = (int)today;
            Console.WriteLine("today is day {0} of the week .", dayvalue);

            // Convert int to enum
            int dayValue = 3;
            DayOfWeek day = (DayOfWeek)dayValue;
            Console.WriteLine($"The value {dayValue} represents {day} in the enum.");
        }
    }
}
