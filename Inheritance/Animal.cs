using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    //base class Animal
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Speak()
        {
            Console.WriteLine($"The {Name} is speaking");
        }
    }

}
//derived Dog class
internal class Dog : Animal
{

    public override void Speak()
    {
        Console.WriteLine($"{Name} is barking");

    }


}

//derived Snake class
internal class Snake : Animal
{
    public override void Speak()
    {
        Console.WriteLine($" {Name} is rattling");
    }
}
