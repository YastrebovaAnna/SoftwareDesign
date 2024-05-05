using CharacterBuilderLib.Interfaces;
using CharacterBuilderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilderLib.Services
{
    public class Director
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder.SetHeight(180).SetBuild("Muscly")
                .SetHairColor("Ginger").SetEyeColor("Grey")
                .SetClothes("Robe").Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder.SetHeight(190).SetBuild("Petite")
                .SetHairColor("Golden").SetEyeColor("Green")
                .SetClothes("Robe").Build();
        }
    }
}
