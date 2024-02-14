using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " moews at you.");
        }
        public void Climb()
        {
            Console.WriteLine(Name + " climbs the wall");
        }
        public void Meet(Chimpanzee newFriend)
        {
            Console.WriteLine(Name + " scratches at " + newFriend.Name);
        }
        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + " scratches at " + newFriend.Name);
        }
    }
}
