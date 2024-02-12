using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Human : Inter
    {
        // Клас людини
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public void Na()
        {
            Console.Write("Введіть своє ім'я: ");
            this.Name = Console.ReadLine();
        }
        public void Ag()
        {
            Console.Write("Введіть свій вік: ");
            this.Age = Console.ReadLine();
        }
        public void Hob()
        {
            Console.Write("Введіть своє хоббі: ");
            this.Hobby = Console.ReadLine();
        }
        public void Info() 
        {
            Console.Clear();
            Console.WriteLine("Ваше ім'я: " + Name + "\nВаш вік: " + Age + "\nВаше хоббі: " + Hobby);
        }
    }
}
