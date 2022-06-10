using System;
using System.Collections.Generic;

namespace PetzWorld.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Info { get; set; }
        public string Pic { get; set; }
        public ICollection<Favourite> Favourites { get; set; }

        public Dog() { }

        public Dog(string name, string breed, int weight, string color, string sex, int age, string info, string pic)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
            Color = color;
            Sex = sex;
            Age = age;
            Info = info;
            Pic = pic;

        }
    }
}