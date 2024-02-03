class Vector
{
    // Поля
    private readonly double x, y, z;

    // Конструкторы
    public Vector()
    {
        x = y = z = 0;
    }

    public Vector(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Свойства
    public double Length
    {
        get { return Math.Sqrt(x * x + y * y + z * z); }
    }

    // Методы
    public void Print()
    {
        Console.WriteLine($"({x}, {y}, {z})");
    }

    public Vector Add(Vector otherVector)
    {
        return new Vector(x + otherVector.x, y + otherVector.y, z + otherVector.z);
    }

    public Vector Subtract(Vector otherVector)
    {
        return new Vector(x - otherVector.x, y - otherVector.y, z - otherVector.z);
    }
}
