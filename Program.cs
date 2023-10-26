namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Skapar objekt och utskrift på deras resultat
            Cirkel cirkel = new Cirkel();
            Console.WriteLine($"Area cirkel: {cirkel.Area()}");

            Fyrkant fyrkant = new Fyrkant();
            Console.WriteLine($"Area fyrkant: {fyrkant.Area()}");

            Rektangel rektangel = new Rektangel();
            Console.WriteLine($"Area rektangel: {rektangel.Area()}");

            Parallellogram parallellogram = new Parallellogram();
            Console.WriteLine($"Area parallellogram: {parallellogram.Area()}");

            Ellips ellips = new Ellips();
            Console.WriteLine($"Area ellips: {ellips.Area()}");

           
        }
    }
}