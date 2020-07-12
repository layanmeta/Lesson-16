using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
      sealed class PetWolf : Wolf
    {
        public PetWolf(string _name, string _FavoriteDogFood, string _nameOfPack) : base(_name, _FavoriteDogFood, _nameOfPack)
        {
        }

        public override void Bark()
        {
           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
