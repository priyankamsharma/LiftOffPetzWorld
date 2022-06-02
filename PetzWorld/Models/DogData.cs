namespace PetzWorld.Models
{
    public class DogData
    {
        // we need an id primary key
        public int Id { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Info { get; set; }
        public string Pic { get; set; }


        public DogData() { }

        public DogData(string breed, int weight, string color, string sex, int age, string info, string pic)
        {
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
