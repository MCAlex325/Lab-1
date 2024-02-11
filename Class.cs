using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Class
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public string AnimalHobby { get; set; }
        public string CatHobby { get; set; }
        public static int a;

        public void Human()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ім'я: "); Name = Console.ReadLine();
            Console.Write("Введіть Вік: "); Age = Console.ReadLine();
            Console.Write("Введіть своє хоббі: "); Hobby = Console.ReadLine();   
        }
        public void Animals()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ім'я: "); Name = Console.ReadLine();
            Console.Write("Введіть Вік: "); Age = Console.ReadLine();
            Console.Write("Що ваша тварина любить робити?: ");
            AnimalHobby = Console.ReadLine();
        }
        public void Cat()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть ім'я: "); Name = Console.ReadLine();
            Console.Write("Введіть Вік: "); Age = Console.ReadLine();
            Console.Write("Що ваш кіт любить робити?: ");
            AnimalHobby = Console.ReadLine();
        }
        public void Info()
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("");
            Console.Write("Ваше ім'я: " + Name + "\nВаш Вік: " + Age);
            if (Class.a == 1)
            {
                Console.Write("\nВаше хоббі: " + Hobby);
            }
            if (Class.a == 2)
            {
                Console.Write("\nЗвичка вашої тварини: " + AnimalHobby);
            }
            if (Class.a == 3)
            {
                Console.Write("\nЗвичка вашого кота: " + CatHobby);
            }
        }
    }
}
