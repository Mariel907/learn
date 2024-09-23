using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
namespace inherit
{
    class Inheritance
    {
        public static void Main(string[] args)
        {
            string name1, gender1, fave;
            int age1;
            int sibNum;
            List<Child01> children = new List<Child01>();
            Console.WriteLine();
            Console.Write("Enter your name         : ");
            name1 = Console.ReadLine();
            Console.Write("Enter your age          : ");
            age1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your gender       : ");
            gender1 = Console.ReadLine();
            Console.Write("Enter your favorite game: ");
            fave = Console.ReadLine();
            Console.WriteLine();
            Child02 b = new Child02(name1, age1, gender1, fave);
            Console.Write("How many sibling/s do you have ? : ");
            Console.WriteLine();
            sibNum = int.Parse(Console.ReadLine());
            Child01 sib1 = new Child01(name1, age1, gender1);
            for (int i = 0; i < sibNum; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter the information of your sibling/s {i + 1}:");
                Console.Write($"Sibling no.        {i + 1}: ");
                name1 = Console.ReadLine();
                Console.Write($"Sibling age no.    {i + 1}: ");
                age1 = int.Parse(Console.ReadLine());
                Console.Write($"Sibling gender no. {i + 1}: ");
                gender1 = Console.ReadLine();
                Child01 sibling = new Child01(name1, age1, gender1);
                children.Add(sibling);
            }
            Console.WriteLine();
            Console.Write("Enter your Father name  : ");
            name1 = Console.ReadLine();
            Console.Write("Father age              : ");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Person c = new Person(name1, age1);
            Console.Write("Enter your Mother name : ");
            name1 = Console.ReadLine();
            Console.Write("Mother age             : ");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Person01 d = new Person01(name1, age1);
            b.game();
            Console.WriteLine("\nSibling/s Name");
            foreach (var item in children)
            {
                Console.WriteLine($"Name: {item.name}\nAge: {item.age}\nGender: {item.gender}\n");
            }
            Console.WriteLine("- - - - - - - - - - - - - - - - - ");
            c.fatherName();
            d.motherName();
        }
    }
}
class Person
{
    public string name { get; set; }
    public int age { get; set; }
    public Person(string Name, int Age)
    {
        name = Name;
        age = Age;
    }
    public void fatherName()
    {
        Console.WriteLine("Name of Father");
        Console.WriteLine("Father name : " + " " + name);
        Console.WriteLine("Age  : " + " " + age);
        Console.WriteLine("- - - - - - - - - - - - - - - - - ");
    }
}
class Person01 : Person
{
    public Person01(string Name, int Age) : base(Name, Age) { }
    public void motherName()
    {
        Console.WriteLine();
        Console.WriteLine("Name of Mother");
        Console.WriteLine("Mother name  : " + " " + name);
        Console.WriteLine("Age          : " + " " + age);
    }
}
class Child01 : Person01
{
    public string gender { get; set; }
    public Child01(string Name, int Age, string Gender) : base(Name, Age)
    {
        gender = Gender;
    }
}
class Child02 : Child01
{
    public string favegame { get; set; }
    public Child02(string Name, int Age, string Gender, string Favegame) : base(Name, Age, Gender)
    {
        favegame = Favegame;
    }
    public void game()
    {
        Console.WriteLine();
        Console.WriteLine("Student Family");
        Console.WriteLine("Name of student: " + " " + name);
        Console.WriteLine("Age            : " + " " + age);
        Console.WriteLine("Gender         : " + " " + gender);
        Console.WriteLine("Favorite game  : " + " " + favegame);
        Console.WriteLine("- - - - - - - - - - - - - - - - - ");
    }
}
