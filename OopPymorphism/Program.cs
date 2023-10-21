namespace OopPymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel1 = new Rektangel(9,5);

            Fyrkant fyrkant1 = new Fyrkant();

            Cirkel cirkel1 = new Cirkel();

            Parallellogram parallellogram1 = new Parallellogram();

            Ellips ellips1 = new Ellips();

            double RektangelArea = rektangel1.Area();
            double FyrkantArea = fyrkant1.Area();
            double CirkelArea = cirkel1.Area();
            double ParallellogramArea = parallellogram1.Area();
            double EllipsArea = ellips1.Area();

            Console.WriteLine($"Rektangel Area: {RektangelArea}");
            Console.WriteLine($"Fyrkant Area: {FyrkantArea}");
            Console.WriteLine($"Cirkel Area: {CirkelArea:0.00}");
            Console.WriteLine($"Parallellogram Area: {ParallellogramArea}");
            Console.WriteLine($"Ellips Area: {ellips1.Area():F2}"); // kan skrivas ut i console på detta sätt utan att anropas som ovan.

            // SAMI GORAN
        }
    }
}