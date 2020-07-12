using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
    class Poodle : Dog
    {
        public int  _numberOfPonyTails;


        public Poodle(string _name, string _FavoriteDogFood, int _numberOfPonyTails) : base(_name, _FavoriteDogFood)
        {
            this._numberOfPonyTails = _numberOfPonyTails;
        }
        public override void Bark()
        {
            base.Bark();
            Console.WriteLine("high pitch bark");
        }

        public override string ToString()
        {
            return base.ToString() + $"number of pony tails: {_numberOfPonyTails}";
        }
    }
}
