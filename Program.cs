using System;
using Inheritance;


namespace Homework
{
    class Program
    {

        static void Main()
        {

            Car car = new Car("Audi A6", "Wheels are disbalanced , ABS need to change");
            Wheels wheels = new Wheels("Audi A6", "Wheels are disbalanced", "Gum", 1234);
            Abs CarEngine = new Abs("3,5" , "Audi");
            EngineClass CarEnginFull = new EngineClass("V-6", 3);
            
            car.ShowInfo();
            CarEngine.Print();
            CarEnginFull.Print();
            wheels.ShowInfo();
            wheels.Repair();
           


        }
    }

}   
 
