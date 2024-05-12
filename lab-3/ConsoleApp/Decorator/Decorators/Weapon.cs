using Decorator.HeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Weapon : HeroDecorator
    {
        private string _weapon;
        public Weapon(IHero hero, string weapon):base(hero) { this._weapon = weapon; }
        public override string Name => $"{_hero.Name} has {_weapon} for battle\n";
    }
}
