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
        static string FormatName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
        static string FormatName(string firstName, string middleName, string lastName)
        {
            return $"{firstName} {middleName} {lastName}";
        }
        static string FormatName(string firstName, string middleName, string lastName, bool uppercase)
        {
            string fullName = $"{firstName} {middleName} {lastName}";
            if (uppercase)
            {
                return fullName.ToUpper();
            }
            return fullName;
        }
    }
}
