using Lab_1;
namespace Lab_1
{
    internal class Program
    {
        
        public static void Main()
        {
            int a;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть тип 1 - Людина, 2 - Тварина, 3 - Кіт: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                var obj1 = new Human();
                obj1.Na();
                obj1.Ag();
                obj1.Hob();
                obj1.Info();
            }
            else if (a == 2)
            {
                var obj2 = new Animal();
                obj2.Na();
                obj2.Ag();
                obj2.Hob();
                obj2.Info();
            }
            else if (a == 3)
            {
                var obj3 = new Cat();
                obj3.Na();
                obj3.Ag();
                obj3.Hob();
                obj3.Info(); 
            }
            else
            {
                Console.WriteLine("Неправильно введено число");
            }
        }
    }
}
