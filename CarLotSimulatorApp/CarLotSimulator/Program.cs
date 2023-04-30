using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();


            Car bexCar = new Car();
            bexCar.Make = "Honda";
            bexCar.Model = "Civic";
            bexCar.Year = 2017;
            bexCar.EngineNoise = "vroom vroom";
            bexCar.HonkNoise = "beep beep";
            bexCar.IsDrivable = true;

            bexCar.MakeEngineNoise(bexCar.EngineNoise);
            bexCar.MakeHonkNoise(bexCar.HonkNoise);

            lot.CarList.Add(bexCar);


            var brettCar = new Car()
            {
                Make = "Nissan",
                Model = "Optima",
                Year = 2015,
                EngineNoise = "mmmeeeerrrrrrrrwwwww",
                HonkNoise = "wonk",
                IsDrivable = true
            };

            brettCar.MakeEngineNoise(brettCar.EngineNoise);
            brettCar.MakeHonkNoise(brettCar.HonkNoise);

            lot.CarList.Add(brettCar);


            var ianCar = new Car("Volkswagen", "Jetta", 2009, "zoom zoom", "toot", true);

            ianCar.MakeEngineNoise(ianCar.EngineNoise);
            ianCar.MakeHonkNoise(ianCar.HonkNoise);

            lot.CarList.Add(ianCar);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }

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
        }
    }
}
