namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int doosGrootte = 8;
            int aantalEieren = 347;

            Console.WriteLine($"Je kan {aantalEieren / doosGrootte} dozen vullen.");
            Console.WriteLine($"Je hebt {aantalEieren % doosGrootte} eieren over.");
        }
    }
}
