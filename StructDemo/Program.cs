using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        struct Car 
        {
            public string Brand;
            public string Model;
            public int Year;           
            public float Price;
        }

        struct Employee 
        {
            public string firstName;
            public string lastName;
            public float hourlyWage;
            public bool completedTraining;


        }
        static void Main(string[] args)
        {
            Car car1;
            Car car2;
            Car car3;

            
            Console.Write("Whats the brand of the car?  ");
            car1.Brand = Console.ReadLine();
            
            Console.Write("What is the model of the car?  ");
            car1.Model = Console.ReadLine();
            
            Console.Write("What is the year of the car?  ");
            car1.Year = int.Parse(Console.ReadLine());
            
            Console.Write("What is the price of the car?  ");
            car1.Price = float.Parse(Console.ReadLine());

            Console.WriteLine(car1);



            Employee employee1;
            employee1.firstName = "Jarno";
            employee1.lastName = "Maes";
            employee1.hourlyWage = 10.55f;
            employee1.completedTraining = true;





        }
    }
}
