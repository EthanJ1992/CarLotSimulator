using System;

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

            Car myCar = new Car();
            Car ourCar= new Car();
            Car yourCar = new Car();
    
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "beep beep";
            myCar.IsDriveable = true;
            myCar.Year = 2022;
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);
            
            ourCar.EngineNoise = "vroom";
            ourCar.HonkNoise = "beep beep";
            ourCar.IsDriveable = true;
            ourCar.Year = 2022;
            ourCar.Make = "Honda";
            ourCar.Model = "Accord";
            ourCar.MakeEngineNoise(ourCar.EngineNoise);
            ourCar.MakeHonkNoise(ourCar.HonkNoise);

            yourCar.EngineNoise = "vroom";
            yourCar.HonkNoise = "beep beep";
            yourCar.IsDriveable = true;
            yourCar.Year = 2022;
            yourCar.Make = "Honda";
            yourCar.Model = "Accord";
            yourCar.MakeEngineNoise(yourCar.EngineNoise);
            yourCar.MakeHonkNoise(yourCar.HonkNoise);










            our.Make = "";

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
