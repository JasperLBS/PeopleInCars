using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleInCars
{
    public class Veichle
    {
        public int topSpeed;
        public int currentSpeed;
        public int changeInSpeed;
        public string model;
        Random rand = new Random();
        public bool isParked;
        public string honk;

        public Veichle()
        {
            //properties som gäller för alla viechles så länge det inte blir överskrivet
            topSpeed = 60;
            model = "No model";
            currentSpeed = 0;
            isParked = false;
            honk = "meow";
        }

        public void Accelerate()
        {
            //ökar hastigheten av veichle med en slumpmässig siffra mellan 1 och veichles maxhastiget
            changeInSpeed = rand.Next(1, topSpeed);
            if (currentSpeed + changeInSpeed >= topSpeed)
            {
                //om den nya hastigheten skulle gå över maxhastigheten sätts den till maxhastigheten istället
                currentSpeed = topSpeed;
            } else
            {
                currentSpeed = currentSpeed + changeInSpeed;
            } 
            ShowCurrentSpeed();
        }

        public void Decelerate()
        {
            //minskar hastigheten med en slumpmässig siffra mellan 1 och veichles maxhastiget
            changeInSpeed = rand.Next(1, topSpeed);
            if (currentSpeed - changeInSpeed <= 0)
            {
                //om hastigheten skulle bli negativ, sätt den till noll
                currentSpeed = 0;
            } else
            {
                currentSpeed = currentSpeed - changeInSpeed;
            }
            ShowCurrentSpeed();
        }

        public void ShowCurrentSpeed()
        {
            Console.WriteLine(model + " is going " + currentSpeed + "km/h \n");
        }

        public void HonkHorn()
        {
            Console.WriteLine(honk +"\n");
        }

    }
}
