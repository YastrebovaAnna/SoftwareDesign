using Decorator.HeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Clothes : HeroDecorator
    {
        private string _clothingType;
        public Clothes(IHero hero, string clothingType):base(hero)
        {
            _clothingType = clothingType;
        }
        public override string Name => $"{_hero.Name} in {_clothingType}\n";

    }
}
