using Lab_1;
namespace Lab_1
{
    internal class Program
    {
        public static void Main()
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var Output = new Class();
            int value = Class.a;
            Console.Write("Напишіть назву (1 - Людина) (2 - Тварина) (3 - Кіт): ");
            value = Convert.ToInt32(Console.ReadLine());
            if (value == 1)
            {
                Output.Human();
            }
            if (value == 2)
            {
                Output.Animals();
            }
            if (value == 3)
            {
                Output.Cat();
            }

            Output.Info();
        }
    }
}
