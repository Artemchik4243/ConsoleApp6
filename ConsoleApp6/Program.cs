
//1. Интерфейс IAnimal:

public interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}

public class Dog : IAnimal
{
    public string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Woof woof!");
    }
}

public class Cat : IAnimal
{
    public string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}


//2.Интерфейс IShape:

public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area
    {
        get { return Math.PI * radius * radius; }
    }

    public double Perimeter
    {
        get { return 2 * Math.PI * radius; }
    }
}

public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Area
    {
        get { return length * width; }
    }

    public double Perimeter
    {
        get { return 2 * (length + width); }
    }
}

public class Triangle : IShape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public double Area
    {
        get
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }

    public double Perimeter
    {
        get { return side1 + side2 + side3; }
    }
}


//3.Интерфейс IComparable<T>:

public interface IComparable<T>
{
    int CompareTo(T other);
}

public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public int CompareTo(Student other)
    {
        return Name.CompareTo(other.Name);
    }
}

public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public int CompareTo(Book other)
    {
        return Title.CompareTo(other.Title);
    }
}


