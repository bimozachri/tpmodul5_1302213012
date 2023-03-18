// See https://aka.ms/new-console-template for more information
internal class Program
{
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
        DataGeneric<int> objData = new DataGeneric<int>(1302213012);
        objData.PrintData();
    }
}
