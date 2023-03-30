using System;
class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Рэкс", 3, "Пудель");
        Cat cat = new Cat("Борис", 5, 7);
        Goldfish fish = new Goldfish("Дорис", 5, true);
        dog.AnimalPassport();
        cat.AnimalPassport();
        fish.AnimalPassport();
        
    }
}
public abstract class Animal
{
    public string Name;
    public int Age;
    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void AnimalPassport()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
public abstract class Fish : Animal
{
    public bool Tail;
    public Fish(string name, int age, bool tail) : base(name, age)
    {
        Tail = tail;
    }
    public override void AnimalPassport()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Наличие хвоста: {Tail}");
    }
}
public abstract class Predator : Animal
{
    public Predator(string name, int age) : base(name, age)
    {
    }
}
public abstract class Herbivore : Animal
{
    public Herbivore(string name, int age) : base(name, age){}
}
public abstract class Ungulate : Animal
{
    public Ungulate(string name, int age) : base(name, age){}
}
public class Bull : Ungulate
{
    public Bull(string name, int age) : base(name, age)
    {
    }
}
public class Hippopotamus : Ungulate
{
    public Hippopotamus(string name, int age) : base(name, age)
    {
    }
}
public class Tiger : Predator
{
    public Tiger(string name, int age) : base(name, age)
    {
    }
}
public class Shark : Fish
{
    public Shark(string name, int age, bool tail) : base(name, age, tail)
    {
    }
}
public class Goldfish : Fish
{
    
    public Goldfish(string name, int age, bool tail) : base(name, age, tail)
    {
    
    }
    public override void AnimalPassport()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Наличие хвоста: {Tail}");
    }
}
public class Dog : Animal
{
    public string Species;
    public Dog(string name, int age, string species) : base(name, age)
    {
        Species = species;
    }
    public override void AnimalPassport()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Порода: {Species}");
    }
}
public class Cat : Animal
{
    public int LivesLeft;
    public Cat(string name, int age, int livesLeft) : base(name, age * 15)
    {
        LivesLeft = livesLeft;
    }
    public override void AnimalPassport()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Оставшиеся жизни: {LivesLeft}");
    }
}
