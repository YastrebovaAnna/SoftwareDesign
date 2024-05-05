using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusLibrary
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(double weight, int age, string name, string species)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Species = species;
            Children = new List<Virus>();
        }

        public object Clone()
        {
            Virus clonedVirus = new Virus(Weight, Age, Name, Species);
            foreach (var child in Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }
            return clonedVirus;
        }
    }
}
