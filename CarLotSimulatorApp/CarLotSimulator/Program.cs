using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

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

            var myCarLot = new CarLot();
            

            var myCar = new Car();
            myCar.Year = 2006;
            myCar.Make = "Toyota";
            myCar.Model = "4Runner";
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "honk";
            myCar.IsDriveable = true;

            myCarLot.CarList.Add(myCar);


            var yourCar = new Car(2007, "Chevrolet", "Suburban", "rev", "beep", false);

            myCarLot.CarList.Add(yourCar);


            var hisCar = new Car()
            {
                Year = 2015,
                Make = "Mazda",
                Model = "CX 5",
                EngineNoise = "zoom zoom",
                HonkNoise = "toot",
                IsDriveable = true
            };

            myCarLot.CarList.Add(hisCar);


            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            yourCar.MakeEngineNoise();
            yourCar.MakeHonkNoise();
            hisCar.MakeEngineNoise();
            hisCar.MakeHonkNoise();


            foreach (Car item in myCarLot.CarList)
            {
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
            }
        }
    }
}
