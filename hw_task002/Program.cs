using System.Text;

namespace hw_task002
{
    internal class Program
    {
        static void Add(int arg1, int arg2) {
            Console.WriteLine((arg1 + arg2));
        }

        static void Sub(int arg1, int arg2)
        {
            Console.WriteLine((arg1 - arg2));
        }

        static void Mul(int arg1, int arg2)
        {
            Console.WriteLine((arg1 * arg2));
        }

        static void Div(int arg1, int arg2)
        {
            if (arg2 == 0)
            {
                Console.WriteLine("Помилка ділення на нуль!");
            }
            else {
                Console.WriteLine(((double)arg1 / arg2));
            }
            
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
                    Console.WriteLine("Введіть знак операції (+,-,*,/):");
                    string strOperation = Console.ReadLine();
                    Console.WriteLine("Результат:");
                    switch (strOperation)
                    {
                        case "+":
                            {
                                Add(arg1, arg2);
                                break;
                            }
                        case "-":
                            {
                                Sub(arg1, arg2);
                                break;
                            }
                        case "*":
                            {
                                Mul(arg1, arg2);
                                break;
                            }
                        case "/":
                            {
                                Div(arg1, arg2);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Невідомий знак операції!");
                                break;
                            }

                    }
                }
                else
                {
                    Console.WriteLine("Некоректний ввод другого аргументу!");
                }
            }
            else {
                Console.WriteLine("Некоректний ввод першого аргументу!");
            }

            Console.ReadKey();
        }
    }
}
