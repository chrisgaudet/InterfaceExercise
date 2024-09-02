using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
           
        }

        public double EngineSize { get; set; } = 3.3;
        public string Make { get; set; } = "KIA";
        public string Model { get; set; } = "Sorento";
        public int SeatCount { get; set; } = 8;
        public string CompanyName { get; set; } = "KIA";
        public string Motto { get; set; } = "KIA is good";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward."); 
        }

        public void Park()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parking.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing ");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }
            
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
