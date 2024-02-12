using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{

    internal class Animal : Inter
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public void Na()
        {
            Console.Write("Введіть ім'я тварини: ");
            this.Name = Console.ReadLine();
        }
        public void Ag()
        {
            Console.Write("Введіть вік тварини: ");
            this.Age = Console.ReadLine();
        }
        public void Hob()
        {
            Console.Write("Введіть хоббі тварини: ");
            this.Hobby = Console.ReadLine();
        }
        public void Info()
        {
            Console.Clear();
            Console.WriteLine("Ім'я тварини: " + Name + "\nВік тварини: " + Age + "\nХоббі тварини: " + Hobby);
        }
    }
}
