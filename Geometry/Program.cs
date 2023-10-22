namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri;

            geometri = new Rektangel();
            Console.WriteLine($"The area of the rectangle is: {Math.Round(geometri.Area(), 2)}");

            geometri = new Fyrkant();
            Console.WriteLine($"The area of the square is: {Math.Round(geometri.Area(), 2)}");

            geometri = new Cirkel();
            Console.WriteLine($"The area of the circle is: {Math.Round(geometri.Area(), 2)}");

            geometri = new Parallellogram();
            Console.WriteLine($"The area of the parallellogram is: {Math.Round(geometri.Area(), 2)}");

            geometri = new Ellips();
            Console.WriteLine($"The area of the ellipse is: {Math.Round(geometri.Area(), 2)}");
        }
    }
}