using System;

namespace PeopleInCars
{
    class Program
    {
        static void Main(string[] args)
        {
            HarleyDavidson newHarley = new HarleyDavidson();
            Honda newHonda = new Honda();
            Volvo newVolvo = new Volvo();
            BMW newBMW = new BMW();
            Garage newGarage = new Garage();


            //testar så att alla metoder gör det de ska
            newHarley.Accelerate();
            newHarley.Accelerate();
            newHarley.HonkHorn();
            newHarley.Decelerate();
            newHarley.Accelerate();

            newVolvo.Accelerate();
            newVolvo.Accelerate();
            newVolvo.HonkHorn();
            newVolvo.Decelerate();
            newVolvo.Accelerate();

            newBMW.Accelerate();
            newBMW.Accelerate();
            newBMW.HonkHorn();
            newBMW.Decelerate();
            newBMW.Accelerate();

            newHonda.Accelerate();
            newHonda.Accelerate();
            newHonda.HonkHorn();
            newHonda.Decelerate();
            newHonda.Accelerate();

            newGarage.ParkVehicle(newHonda);
            newGarage.ParkVehicle(newBMW);
            newGarage.ParkVehicle(newBMW);
            newGarage.ListParkedVehicles();
            newGarage.GetVehicle(1);
            newGarage.ListParkedVehicles();
            Console.WriteLine(newHonda.isParked);
        }
    }
}
