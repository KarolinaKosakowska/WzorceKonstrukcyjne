using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WzorceKonstrukcyjne.Budowniczy;
using WzorceKonstrukcyjne.Budowniczy.AbstractFactory;

namespace WzorceKonstrukcyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeePrototype employeePrototype = new EmployeePrototype();
            //EmployeePrototype employeePrototype1 = employeePrototype.Clone();
            //employeePrototype1.Name = "Roman";
            //employeePrototype1.LastName = "Kowalski";   

            //Console.WriteLine(employeePrototype1.ToString());
            //Console.WriteLine(employeePrototype.ToString());

            //Console.ReadKey();

            //Console.WriteLine("zapisz jako txt");
            //Director dyrektor = new Director(new TxtBuilder() { Path = "D:/test.txt" });
            //dyrektor.Construct("tu jest jakis tekst");
            //if (dyrektor.IsSuccess())
            //{
            //    Console.WriteLine("Zapisano txt");
            //}
            //Console.WriteLine("zapisz jako xml");
            //Director xDyrektor = new Director(new XMLBuilder() { Path = "D:/tekst.xml" });
            //xDyrektor.Construct("tu jest jakiś tekst");
            //if(xDyrektor.IsSuccess())
            //{
            //    Console.WriteLine("Zapisano XML");
            //}

            //Console.WriteLine("zapisz jako csv");
            //Director CsvDyrektor = new Director(new TxtBuilder() { Path = "D:/test.csv" });
            factory();
        }
        private static void factory()
        {
            Console.WriteLine("Fabryka abstrackji");
            IFileEditor editor = AbstractFactory.GetFileEditor("D:/test.csv");
            editor.ClearAllText();
            editor.Add("Roman");
            Console.Read();
          
        }

        




        
    }
}
