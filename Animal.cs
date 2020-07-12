using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
   abstract class AnimalBase
    {
        public string _name;

        public AnimalBase(string _name)
        {
            this._name = _name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"name {_name}";
        }
    }
}
