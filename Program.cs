namespace hw6sideT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            Console.WriteLine("Сторона a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Сторона c:");
            c = double.Parse(Console.ReadLine());


            Triangle trian = new Triangle(a, b, c);

            trian.Show();

            Console.WriteLine($"Площадь треугольника: {trian.Area}");


        }
    }
}