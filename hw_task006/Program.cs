using System.Text;

namespace hw_task006
{
    internal class Program
    {
        static void Calculate(int arg1, int arg2, int arg3)
        {
            Console.WriteLine("Середнє арифметичне:");
            Console.WriteLine((double)(arg1+arg2+arg3)/3);
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть перший аргумент:");
            string strArg1 = Console.ReadLine();
            if (int.TryParse(strArg1, out int arg1))
            {
                Console.WriteLine("Введіть другий аргумент:");
                string strArg2 = Console.ReadLine();
                if (int.TryParse(strArg2, out int arg2))
                {
                    Console.WriteLine("Введіть третій аргумент:");
                    string strArg3 = Console.ReadLine();
                    if (int.TryParse(strArg3, out int arg3))
                    {
                        Calculate(arg1, arg2, arg3);
                    }
                    else
                    {
                        Console.WriteLine("Некоректний ввод третього аргументу!");
                    }
                }
                else
                {
                    Console.WriteLine("Некоректний ввод другого аргументу!");
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввод першого аргументу!");
            }

            Console.ReadKey();
        }
    }
}
