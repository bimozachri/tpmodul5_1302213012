// See https://aka.ms/new-console-template for more information
internal class Program
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T inputUser)
        {
            Console.WriteLine("Halo User " + inputUser);
        }
    }

    public static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Bimo");
    }
}


