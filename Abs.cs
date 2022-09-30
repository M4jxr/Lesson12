using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    public class Abs:Car
    {
        public Abs(string carmodel, string typeofProblem) : base(carmodel, typeofProblem)
        {
        }

        public double TypeOfEngine { get; set; }

        public Abs(string Engine, double typeOfEngine) : base(carmodel, typeofProblem)
        {
            
            this.TypeOfEngine = typeOfEngine;
        }

        public virtual void Print()
        {
            Console.WriteLine($"This car have {TypeOfEngine} liters engine");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
           
        }
    }
    public class EngineClass : Abs
    {
        public string Engine { get; set; }
        public EngineClass(string Engine, double TypeOfEngine) : base( Engine,TypeOfEngine)
        {
            this.TypeOfEngine = TypeOfEngine;
        }

        public override void Print()
        {
            Console.WriteLine($"This car have {TypeOfEngine} liters engine {Engine}");

        }
        
    }

    
}
