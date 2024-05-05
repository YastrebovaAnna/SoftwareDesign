using CharacterBuilderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilderLib.Interfaces
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBuild(string build);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothes(string clothes);
        Character Build();
    }
}
