using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleInCars
{  
     public class Garage
    {
        public int parkingSpaces;
        Veichle[] parkedVehicles;

        public Garage()
        {
            parkingSpaces = 3;
            parkedVehicles = new Veichle[parkingSpaces];

        }

        public void ParkVehicle(Veichle incomingVehicle)
        {
            for (int i = 0; i < parkingSpaces; i++)
            {
                if (parkedVehicles[i] == null && incomingVehicle.isParked != true)
                {
                    //kollar vaje parkeringsplats tills den hittar en som är tom och parkerar bilen och fyller parkeringsplatsen så länge bilen inte redan är parkerad
                    parkedVehicles[i] = incomingVehicle;
                    incomingVehicle.isParked = true;
                    i = parkingSpaces;
                } else if (incomingVehicle.isParked == true)
                {
                    //om bilen redan är parkerad ger den ett felmedelande
                    Console.WriteLine(incomingVehicle.model + " is already parked");
                    i = parkingSpaces;
                }
            }
        }

        public void ListParkedVehicles()
        {
            foreach (var item in parkedVehicles)
            {
                //om det finns något parkerat skriv ut vad som är parkerat
                //annars skriv att platen är tom
                if (item != null)
                {
                    Console.WriteLine(item.model + " is parked");
                } else
                {
                    Console.WriteLine("this slot is empty");
                }
            }
        }


        public void GetVehicle(int parkingSpot)
        {
            //gör så att veichle inte längre är parkerad och gör parkeringsplaten tom
            parkedVehicles[parkingSpot].isParked = false;
            parkedVehicles[parkingSpot] = null;
        }


    }
}
