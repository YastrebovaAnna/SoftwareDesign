using CharacterBuilderLib.Interfaces;
using CharacterBuilderLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilderLib.Builders
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothes(string clothes)
        {
            _character.Clothes = clothes;
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
