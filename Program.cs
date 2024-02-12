using Lab_1;
namespace Lab_1
{
    internal class Program
    {
        
        public static void Main()
        {
            // Виконувальний файл
            string a;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть тип 1 - Людина, 2 - Тварина, 3 - Кіт, 4 - Своя тварина: ");
            a = Console.ReadLine();
            if (a == "1")
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                var obj1 = new Human();
                obj1.Na();
                obj1.Ag();
                obj1.Hob();
                obj1.Info();
            }
            else if (a == "2")
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                var obj2 = new Animal();
                obj2.Na();
                obj2.Ag();
                obj2.Hob();
                obj2.Info();
            }
            else if (a == "3")
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                var obj3 = new Cat();
                obj3.Na();
                obj3.Ag();
                obj3.Hob();
                obj3.Info(); 
            }
            else if (a == "4")
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                var obj4 = new AdditionalClass();
                obj4.KOA();
                obj4.Na();
                obj4.Ag();
                obj4.Hob();
                obj4.Info();
            }
            else
            {
                Console.WriteLine("Неправильно введено число");
            }
        }
    }
}
