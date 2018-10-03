using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog();
        dog.Bark();
        dog.Eat();

        var puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();

        var dog1 = new Dog();
        dog1.Eat();
        dog1.Bark();

        var cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}

