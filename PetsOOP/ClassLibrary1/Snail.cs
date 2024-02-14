using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Snail : Pet
    {
        public Snail(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " meows at you.");
        }
    }
}
