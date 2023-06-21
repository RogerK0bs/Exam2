using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Exam2
{
    internal class Program
    {
        partial class Service_manager:ZOO
        {
            public string Name;
            public string Last_name;
            public DateTime Bday;

            public override string ToString()
            {
                return base.ToString();
            }
            // Salary_log (in KPI, params 
        }

        partial class Keeper:Service_manager
        {
             public double KPI;


        }
        partial class Senior_keeper : Service_manager
        {
            public double KPI;
            public void Feeding()
            {

            }

        }

        abstract class Animal
        {
       
            public int ID;
            virtual public void Feed()
            {

            }
           virtual public void Voice() { }

        }
        class Lion:Animal
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public double Height { get; set; }

            public override void Feed()
            {
                Console.WriteLine("Я ем мясо");
            }
            public override string ToString() 
            {
                return base.ToString();
            }
            public override void Voice()
            {
                Console.WriteLine("Рык-мяу-рык-мяу");
            }
               
           
        }
        class Elephant:Animal
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public double Height { get; set; }
            
            public override void Feed()
            {
               Console.WriteLine("Я ем зелень");
            }
            public override string ToString()
            {
                return base.ToString();
            }
            public override void Voice()
            {
                Console.WriteLine("Ту-дуууууу-Ту-дуууууу");
            }

        }
        class ZOO:Animal
        {
            public int TimeToFeed { get; set; }
            Animal[] animal = { };
            List<Service_manager> services = new List<Service_manager>();
        }
        static void Main(string[] args)
        {
        }
    }
}
