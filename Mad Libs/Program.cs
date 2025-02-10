namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een naam. ");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef een zelfstandig naamwoord. ");
            string Zn = Console.ReadLine();
            Console.WriteLine("Geef een adjectief. ");
            string adjectief = Console.ReadLine();
            Console.WriteLine("Geef een werkwoord. ");
            string werkwoord = Console.ReadLine();

            Console.WriteLine($"Op een dag ging {naam} naar de AP Hogeschool. Hij zag daar een {adjectief} {Zn} en vond dat zo grappig dat hij begon te {werkwoord}.");
        }
    }
}
