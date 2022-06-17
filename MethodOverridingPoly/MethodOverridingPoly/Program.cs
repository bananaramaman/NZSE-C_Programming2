using System;

namespace MethodOverridingPoly
{
    class Animal    //base class
    {
        public virtual void animalSound()   //virtual allows the method to be manipulated
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal  //derived class
    {
        public override void animalSound()  //override changes the base class method
        {
            Console.WriteLine("The pig says: Hands up!  Squeeeel!");
        }
    }
    class Dog : Animal  //derived class
    {
        public override void animalSound()  //derived class overriding the base class method
        {
            Console.WriteLine("The dog says: don't shoot... woof!");
        }
    }
    class Prog
    {
        public static void Main(string[] args)
        {
            Animal myAnimal = new Animal(); //class objects
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
