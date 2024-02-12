using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Cat : Inter
    {
        // Клас кота
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public void Na()
        {
            Console.Write("Введіть ім'я кота: ");
            this.Name = Console.ReadLine();
        }
        public void Ag()
        {
            Console.Write("Введіть вік кота: ");
            this.Age = Console.ReadLine();
        }
        public void Hob()
        {
            Console.Write("Введіть хоббі кота: ");
            this.Hobby = Console.ReadLine();
        }
        public void Info()
        {
            Console.Clear();
            Console.WriteLine("Ім'я кота: " + Name + "\nВік кота: " + Age + "\nХоббі кота: " + Hobby);
        }
    }
}
