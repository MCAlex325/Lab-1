using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class TypeOfAnimal : Animal
    {
        // Наслідний клас
        public string KindOfAnimal {  get; set; }

        public void KindOfAnimals()
        {
            Console.Write("Введіть вид тварини: ");
            this.KindOfAnimal = Console.ReadLine();
        }
        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Вид тварини: " + KindOfAnimal +  "\nІм'я тварини: " + VarName + "\nВік тварини: " + VarAge + "\nХвороба тварини: " + VarDisease);
            Console.WriteLine("Лікування... ");
            Thread.Sleep(2000);
            Console.WriteLine("Лікування хвороби " + '"' + VarDisease + '"' + ": " + "завершене.");
            Console.ReadLine();
        }
    }
}
