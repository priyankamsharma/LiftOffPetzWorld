namespace PetzWorld.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public Dog() { }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
    }
}
