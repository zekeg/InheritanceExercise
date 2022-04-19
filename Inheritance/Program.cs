using System;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE
            // give this class 4 members that all Animals have in common DONE


            // Create a class Bird DONE
            // give this class 4 members that are specific to Bird DONE
            // Set this class to inherit from your Animal Class DONE

            // Create a class Reptile DONE
            // give this class 4 members that are specific to Reptile DONE
            // Set this class to inherit from your Animal Class DONE




            /*Create an object of your Bird classDONE
             *  give values to your members using the object of your Bird class DONE
             *  
             * Creatively display the class member values DONE
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class DONE
             *  
             * Creatively display the class member values DONE...i guess
             */
            var rand = new Random();


            Bird bird1 = new Bird();
            bird1.CanFly = false;
            bird1.Diet = "carnivore";
            bird1.LifespanInDays = 365 * 15;
            bird1.WingspanCm = 80;
            bird1.BirdSong = "cooo honk coo honk";
            bird1.EggClutchSize = 1;
            bird1.GestationTimeInDays = 65;
            bird1.Sex = "female";

            Reptile reptile1 = new Reptile();
            reptile1.Aquatic = true;
            reptile1.Diet = "herbivore";
            reptile1.LifespanInDays = 365 * 12;
            reptile1.ActiveCamouflage = false;
            reptile1.EggClutchSize = 20;
            reptile1.GestationTimeInDays = 100;
            reptile1.Sex = "male";
            reptile1.RaisesYoung = false;

            //I'm not sure how to access the inate properties of the object ie "creature.CanFly" so, sadly, i had to use the proper variable names
            void displayCreature(Animal creature) {
                if (creature is Bird) {
                    Console.WriteLine("it's a bird");
                    Console.WriteLine($"Can it fly? {bird1.CanFly}");
                    Console.WriteLine($"This bird is a {bird1.Sex}");
                    Console.WriteLine($"It has a wingspan of {bird1.WingspanCm} cm");
                    Console.WriteLine($"It loves to say: {bird1.BirdSong}");
                    Console.WriteLine($"This bird is a {bird1.Diet}");
                    Console.WriteLine($"It's going to live {bird1.LifespanInDays} days if it's lucky");
                    Console.WriteLine($"it's likely to lay {bird1.EggClutchSize} egg(s)");
                    Console.WriteLine($"each egg will take apprx {bird1.GestationTimeInDays} days to hatch");
                }
                if (creature is Reptile) {
                    Console.WriteLine("it's a reptile");
                    Console.WriteLine($"This reptile is a {reptile1.Sex}");
                    Console.WriteLine($"Is this reptile aquatic? {reptile1.Aquatic}");
                    Console.WriteLine($"Does this reptile use active camouflage? {reptile1.ActiveCamouflage}");
                    Console.WriteLine($"This reptile is a {reptile1.Diet}");
                    Console.WriteLine($"This reptile lays a clutch of {reptile1.EggClutchSize} egg(s)");
                    Console.WriteLine($"This reptile's eggs take {reptile1.GestationTimeInDays} to hatch");
                    Console.WriteLine($"This reptile will live apprx {reptile1.LifespanInDays} if it's lucky");
                    Console.WriteLine($"Does this reptile raise its young? {reptile1.RaisesYoung}");
                }
            }

            int CoinFlip() {
                int[] options = { 0, 1 };                
                return rand.Next(options.Length);
            }

            Animal[] animals = { bird1, reptile1 };

            Console.WriteLine("Press a key to flip a coin to decide which creature you will see...");
            Console.ReadLine();
            Console.WriteLine("\n\n\n---------");

            displayCreature(animals[CoinFlip()]);
        }
    }
}
