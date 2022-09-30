using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance
{
    public class Car
    {

       internal string Carmodel { get; set; }
        
       internal string TypeofProblem { get; set; }

        bool IsProblemDone=true;

         
        public Car (string carmodel, string typeofProblem)
        {
            this.Carmodel = carmodel;
            this.TypeofProblem = typeofProblem;

        }
         
        public virtual void ShowInfo()
        {

            Console.WriteLine($"Model name : {Carmodel} ");
            Console.WriteLine($" Your problem is:{TypeofProblem}");
            


        }
        public  virtual void Repair()
        {
            if (IsProblemDone == true)
                Console.WriteLine("Your car has been repaired");
            else IsProblemDone = false;
            


        }


    }


}



