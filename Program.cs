using System.Text;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Captalize(input);
        }
        public static void Captalize(string input)
        {
            input= input.Trim();
            string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i=0;i<arr.Length;i++)
            {
                arr[i]=(Char.ToUpper(arr[i][0]) + arr[i].Substring(1).ToLower()+" ");
                stringBuilder.Append(arr[i]);
            }
            Console.WriteLine(stringBuilder);
        }
    }
}