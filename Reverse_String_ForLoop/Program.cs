namespace ForLoop
{
    class Program
    {
        public static void Main (string[] args)
        {
            string name = "sea";
            string output = "";
            char [] input = name.ToCharArray();
            for (int i = input.Length - 1; i >=0; i--)
            {
                output += input[i];
            } 
            Console.WriteLine(output);
        }
    }
}