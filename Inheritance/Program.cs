using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Bird();
            bird.WingSpan = 7;
            bird.Migrate = true;
            bird.CanFly = true;
            bird.LongShortBeak = "Short";

            Console.WriteLine($" Bald Eagle Stats:\n Age: {bird.Age}\n Limbs: {bird.Limbs}\n Wingspan: {bird.WingSpan}\n Migrate: {bird.Migrate}\n Flight: {bird.CanFly}\n Beak: {bird.LongShortBeak} ");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var reptile = new Reptile();
            reptile.WillBurrow = false;
            reptile.Shell = false;
            reptile.EggsOrLiveBirth = "Eggs";
            reptile.HasLegs = false;

            Console.WriteLine($"Snake Stats:\n Age = {reptile.Age}\n Limbs: {reptile.Limbs}\n Burrows: {reptile.WillBurrow}\n Shell: {reptile.Shell}\n Reproduction: {reptile.EggsOrLiveBirth}\n");

        }
    }
}
