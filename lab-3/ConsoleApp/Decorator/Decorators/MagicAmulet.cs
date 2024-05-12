using Decorator.HeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class MagicAmulet : HeroDecorator
    {
        private bool _amulet;
        public MagicAmulet(IHero hero, bool amulet):base(hero)
        {
            _amulet = amulet;
        }
        public override string Name
        {
            get
            {
                if (_amulet)
                    return $"{_hero.Name} has an active amulet\n";
                else
                    return $"{_hero.Name} has an inactive amulet\n";
            }
        }
    }
}
