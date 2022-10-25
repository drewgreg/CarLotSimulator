﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            var lot = new CarLot();


            var Toyota = new Car();
            Toyota.Year = 2014;
            Toyota.Make = "Toyota";
            Toyota.Model = "Tundra";
            Toyota.EngineNoise = "Loud";
            Toyota.HonkNoise = "Loud";
            Toyota.IsDriveable = true;

            lot.Cars.Add(Toyota);


            var Honda = new Car()
            {
                Year = 2020,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Low",
                HonkNoise = "Low",
                IsDriveable = true,
            };


            lot.Cars.Add(Honda);

            Car Ford = new Car(2022, "Ford", "Explorer", "Minimal", "Medium", true);

            lot.Cars.Add(Ford);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {                
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


        }
    }
}
