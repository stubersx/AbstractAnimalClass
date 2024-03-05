namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }

        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Rabbit : Animal
    {
        public override string Name { get; set; }
        public string Breed { get; set; }
        public double Age { get; set; }

        public Rabbit()
        {
            Name = string.Empty;
            Breed = string.Empty;
            Age = 0.0;
        }
        public Rabbit(string name, string breed, double age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public override string Describe()
        {
            return $"Rabbit Information\nName: {Name}\nBreed: {Breed}\nAge: {Age} years old";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit1 = new Rabbit();
            rabbit1.Name = "Ben";
            rabbit1.Breed = "French Lop";
            rabbit1.Age = 2.4;
            Rabbit rabbit2 = new Rabbit("Alice", "Continental Giant", 5.5);
            Console.WriteLine("\n*---------------------*");
            Console.WriteLine($"{rabbit1.Describe()}");
            Console.WriteLine($"{rabbit1.whatAmI()}");
            Console.WriteLine("\n*---------------------*");
            Console.WriteLine($"{rabbit2.Describe()}");
            Console.WriteLine($"{rabbit2.whatAmI()}");
        }
    }
}
