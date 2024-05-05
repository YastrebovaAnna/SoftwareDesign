using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilderLib.Models
{
    public class Character
    {
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }

        public override string ToString()
        {
            return $"Height: {Height}; Build: {Build}; Hair Color: {HairColor}; Eye Color: {EyeColor}; Clothes: {Clothes}";
        }
    }
}
