using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_methods_homework
{
    class Wolf : Dog
    {
        public string _nameOfPack;
        public Wolf(string _name, string _FavoriteDogFood, string _nameOfPack) : base(_name, _FavoriteDogFood)
        {
            this._nameOfPack = _nameOfPack;
        }

        public override string ToString()
        {
            return base.ToString() + $"name of pack is: {_nameOfPack}";
        }

        public override void Bark()
        {
            base.Bark();
        }
    }
}
