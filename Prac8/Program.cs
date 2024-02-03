namespace Prac8
{
    internal class Program
    {
        static void Main()
        {
            Vector vector1 = new(1, 2, 3);
            Vector vector2 = new(4, 5, 6);

            Console.WriteLine("Original vectors:");
            vector1.Print();
            vector2.Print();

            Vector sum = vector1.Add(vector2);
            Console.WriteLine("\nSum vector:");
            sum.Print();

            Vector difference = vector1.Subtract(vector2);
            Console.WriteLine("\nDifference vector:");
            difference.Print();

            Console.WriteLine("\nLength of vector1: " + vector1.Length);
            Console.WriteLine("Length of sum: " + sum.Length);
            Console.WriteLine("Length of difference: " + difference.Length);
        }
    }
}
