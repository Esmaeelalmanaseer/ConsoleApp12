using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Console.WriteLine($"State: {car.currentState}");

            car.TakeAction(car.Action.Start);
            Console.WriteLine($"State: {car.currentState}");

            car.TakeAction(car.Action.Start);

            Console.WriteLine($"State: {car.currentState}");
        }
    }
}
