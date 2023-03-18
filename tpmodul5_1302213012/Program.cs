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
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T inputData)
        {
            this.data = inputData;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    public static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Bimo");
        DataGeneric<int> objData = new DataGeneric<int>(1302213012);
        objData.PrintData();
    }
}
