using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("dog", "meat");

            Poodle p = new Poodle("luke", "dry dog food", 2);

            Wolf w = new Wolf("max", "meat", "moon stone");

            PetWolf smallWolf = new PetWolf("small wolf", "meat", "moon stone");

            Horse h = new Horse("horse", true) ;

            Horse[] horses = new Horse[7]
            {
                new Horse("1", false),
                new Horse("2", true),
                new Horse("3", true),
                new Horse("4", true),
                new Horse("5", false),
                new Horse("6", true),
                new Horse("7", false),
            };
            Horse[] newHorses = GetRacingHorses(horses);
        }
        
        static void AnimalSign(AnimalBase[] animals)
        {
            
            foreach (AnimalBase curAnimal in animals)
            {
                
                curAnimal.MakeSound(); 
            }
        }
       
        static Horse[] GetRacingHorses(Horse[] horses)
        {
         
            int counter = 0;
            for (int i = 0; i < horses.Length - 1; i++)
            {
                if (horses[i]._RacingHorse == true)
                    counter++; //= 4
            }
            Horse[] racingHorses = new Horse[counter];
            int arrayCounter = 0;
            for (int i = 0; i < horses.Length-1; i++)
            {
                
                if (horses[i]._RacingHorse == true)
                    racingHorses[arrayCounter++] = horses[i];
                
             
            }
            return racingHorses;
        }

    }
}
