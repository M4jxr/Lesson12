using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;


namespace Inheritance
{
      class Wheels:Car
    {
        string Matherial { get; set; }
        int IdWheel { get; set; }

        public Wheels(string carmodel, string typeofProblem ,string matherial, int idWheel) : base( carmodel , typeofProblem  )
        {
            this.Matherial = matherial;
            this.IdWheel = idWheel;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(Matherial, IdWheel);
        }
    }
}
