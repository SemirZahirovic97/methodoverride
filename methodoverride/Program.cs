namespace methodoverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FormatName("Anna", "Svensson"));
            Console.WriteLine(FormatName("Anna", "Maria", "Svensson"));
            Console.WriteLine(FormatName("Anna", "Maria", "Svensson", true));
        }
    }
}
