using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class AdditionalClass : Animal
    {
        // Наслідний клас
        public string AddAttr {  get; set; }
        public string KindOfAnimal {  get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }

        public void KOA()
        {
            Console.Write("Введіть вид тварини: ");
            this.KindOfAnimal = Console.ReadLine();
        }
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
            Console.WriteLine("Вид тварини: " + KindOfAnimal +  "\nІм'я тварини: " + Name + "\nВік тварини: " + Age + "\nХоббі тварини: " + Hobby);
        }
    }
}
