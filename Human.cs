using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lab_1;

namespace Lab_1
{
    internal class Human : IPatient
    {
        // Клас людини
        public string VarName { get; set; }
        public int VarAge { get; set; }
        public string VarDisease { get; set; }
        public void Name()
        {
            Console.Write("Введіть своє ім'я: ");
            this.VarName = Console.ReadLine();
        }
        public void Age()
        {
            Console.Write("Введіть свій вік: ");
            this.VarAge = Convert.ToInt32(Console.ReadLine());
        }
        public void Disease()
        {
            Console.Write("Введіть свою хворобу: ");
            this.VarDisease = Console.ReadLine();
        }
        public void Results() 
        {
            Console.Clear();
            Console.WriteLine("Ваше ім'я: " + VarName + "\nВаш вік: " + VarAge + "\nВаша хвороба: " + VarDisease);
            Console.WriteLine("Лікування... ");
            Thread.Sleep(2000);
            Console.WriteLine("Лікування хвороби " + '"' + VarDisease + '"' + ": " + "завершене.");
            Console.ReadLine();
        }
    }
}
