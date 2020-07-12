using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
    class Dog : AnimalBase
    {
        public string _FavoriteDogFood;
        public Dog(string _name, string _FavoriteDogFood) : base(_name)
        {
            this._FavoriteDogFood = _FavoriteDogFood;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Loud bark");
        }

        public override void MakeSound()
        {
             Bark();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, favorite food is: {_FavoriteDogFood}";
        }

    }
}
