using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            ////var cars = new List<string>();

            ////var car1 = "BMW";
            ////var car2 = "Lada";
            ////var car3 = "Mercedes";
            ////var car4 = "Ferrari";
            ////var car5 = "Opel";
            ////var car6 = "Saab";



            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}

            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };

            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}



            //bool loop = true;

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Peeter", Age = 20},
            //    new Human(){Name = "Johannes", Age = 25},
            //    new Human(){Name = "Debiil", Age = 30},
            //    new Human(){Name = "Muhammed", Age = 22},
            //    new Human(){Name = "Cyka", Age = 52},
            //    new Human(){Name = "Bljat", Age = 48},
            //};

            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 87;
            //humans1.Add(human1);

            //while (loop == true)
            //{
            //    var human2 = new Human();
            //    Console.WriteLine("Sisestage nimi: ");
            //    human2.Name = Console.ReadLine();
            //    Console.WriteLine("Sisestage vanus: ");
            //    human2.Age = Int32.Parse(Console.ReadLine());
            //    humans1.Add(human2);

            //    foreach (var item in humans1)
            //    {
            //        Console.WriteLine(item.Name + " " + item.Age);
            //    }

            //    Console.WriteLine("Insert N to stop!\nPress Enter to continue!");
            //    if (Console.ReadLine() == "N")
            //    {
            //        loop = false;
            //    }
            //}

            // Dictionary

            var openWith = new Dictionary<string, string>();

            //            key   Value
            openWith.Add("txt", "notepad.exe");
            openWith.Add("imp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //Console.WriteLine("For key = rtf, value = {0} ", openWith["rtf"]);

            try
            {
                openWith.Add("txt", "word.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key \"txt\" already exists.");
            }

            Console.ReadLine();
        }
    }
}
