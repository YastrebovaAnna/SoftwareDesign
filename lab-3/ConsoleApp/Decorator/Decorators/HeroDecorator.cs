using Decorator.HeroBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    abstract public class HeroDecorator : IHero
    {
        protected IHero _hero;
        public HeroDecorator(IHero hero)
        {
            this._hero = hero;
        }
        public virtual string Name => _hero.Name;
    }
}
