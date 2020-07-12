using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
    class Horse : AnimalBase
    {
        public bool _RacingHorse;
        public Horse(string _name, bool _RacingHorse) : base(_name)
        {
            this._RacingHorse = _RacingHorse;
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Neigh sound");
        }
        public override void MakeSound()
        {
            Neigh();
        }

        public override string ToString()
        {
            return base.ToString() + $"is this a racing horse: {_RacingHorse}";
        }
    }
}
