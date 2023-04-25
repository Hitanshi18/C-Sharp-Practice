using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c__Generics
{

    public class Program
    {
        public static void Main()
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World!";
            //strStorage.Data = 123; // compile-time error
            Console.WriteLine(strStore.Data);

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            //intStorage.Data = "Hello World!"; // compile-time error
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            Console.WriteLine(kvp1.Key + ", " + kvp1.Value);


            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine(kvp2.Key + ", " + kvp2.Value);

            // generics method

            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            Console.WriteLine(cities.GetData(100));

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine(empIds.GetData(0));

            //generics in non-generic class
            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Heyy");
            printer.Print("Beautifull!"); // type infer from the specified value
        }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    class DataStore<T>
    {
        public T Data { get; set; }

        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }     
    }
    class Printer
    {
        public void Print<T>(T data)
        {

            Console.WriteLine(data);
        }
    }
}
