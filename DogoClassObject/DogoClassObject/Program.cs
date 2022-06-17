using System;

namespace DogoClassObject
{
    class dog
    {
        string breed;
        string size;
        string colour;
        int age;
        string sex;

        static void Main(string[] args)
        {
            dog Dog1 = new dog();
            Dog1.breed = "German Shepherd";
            Dog1.size = "Large";
            Dog1.colour = "Dark brown";
            Dog1.age = 8;
            Dog1.sex = "Male";

            dog Dog2 = new dog();
            Dog2.breed = "Shiba inu";
            Dog2.size = "Small - Medium";
            Dog2.colour = "Light Yellow";
            Dog2.age = 3;
            Dog2.sex = "Male";

            dog Dog3 = new dog();
            Dog3.breed = "Great Dane";
            Dog3.size = "Large";
            Dog3.colour = "Light Borwn";
            Dog3.age = 6;
            Dog3.sex = "Female";

            dog Dog4 = new dog();
            Dog4.breed = "Dachshund";
            Dog4.size = "Small";
            Dog4.colour = "Orange brown";
            Dog4.age = 1;
            Dog4.sex = "Female";

            Console.WriteLine("Dog 1\nBreed: {0}\nSize: {1}\nColour: {2}\nAge: {3}\nSex: {4}", Dog1.breed, Dog1.size, Dog1.colour, Dog1.age, Dog1.sex);
            Console.WriteLine();
            Console.WriteLine("Dog 2\nBreed: {0}\nSize: {1}\nColour: {2}\nAge: {3}\nSex: {4}", Dog2.breed, Dog2.size, Dog2.colour, Dog2.age, Dog2.sex);
            Console.WriteLine();
            Console.WriteLine("Dog 3\nBreed: {0}\nSize: {1}\nColour: {2}\nAge: {3}\nSex: {4}", Dog3.breed, Dog3.size, Dog3.colour, Dog3.age, Dog3.sex);
            Console.WriteLine();
            Console.WriteLine("Dog 4\nBreed: {0}\nSize: {1}\nColour: {2}\nAge: {3}\nSex: {4}", Dog4.breed, Dog4.size, Dog4.colour, Dog4.age, Dog4.sex);
            Console.WriteLine();
        }
    }
}
