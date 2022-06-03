namespace PetzWorld.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public string Name { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public Pet() { }

        public Pet(string name)
        {
            Name = name;
        }
    }
}


//namespace PetzWorld.Models
//{
//    public class Dog
//    {
//        public int DogId { get; set; }
//        public string Name { get; set; }
//        public string Breed { get; set; }
//        public int Weight { get; set; }
//        public string Color { get; set; }
//        public string Sex { get; set; }
//        public string Age { get; set; }
//        public string Info { get; set; }
//        public string Pic { get; set; }
 

//        public Dog()
//        {
//        }

//        public Dog(string name, string breed, int weight, string color, string sex, string age, string info, string pic)
//        {
//            Name = name;
//            Breed = breed;
//            Weight = weight;
//            Color = color;
//            Sex = sex;
//            Age = age;
//            Info = info;
//            Pic = pic;
//        }
//    }
//}
