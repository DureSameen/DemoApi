using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Data
{
    public enum AnimalType
    {
        Herbivore, Carnivore, Omnivore
    }
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AnimalType AnimalType { get; set; }

        public bool IsPet { get; set; }

        //constructor
        public Animal()
        {
            Id = 0;
            Name = "animal name here";
            AnimalType = AnimalType.Herbivore;
            IsPet = false;
        }
    }
}
