namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Sea";
            string output = "";
            int length = name.Length - 1;
            while(length >= 0)
            {
                output = output + name[length];
                length --;
            }
            Console.WriteLine(output);
        }
    }
}