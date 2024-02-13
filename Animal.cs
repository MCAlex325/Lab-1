using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{

    internal class Animal : IPatient
    {
        // Клас тварини
        public string VarName { get; set; }
        public string VarAge { get; set; }
        public string VarDisease { get; set; }
        public void Name()
        {
            Console.Write("Введіть ім'я тварини: ");
            this.VarName = Console.ReadLine();
        }
        public void Age()
        {
            Console.Write("Введіть вік тварини: ");
            this.VarAge = Console.ReadLine();
        }
        public void Disease()
        {
            Console.Write("Введіть хворобу тварини: ");
            this.VarDisease = Console.ReadLine();
        }
        public void Results()
        {
            Console.Clear();
            Console.WriteLine("Ім'я тварини: " + VarName + "\nВік тварини: " + VarAge + "\nХвороба тварини: " + VarDisease);
            Thread.Sleep(2000);
            Console.WriteLine("Лікування хвороби " + '"' + VarDisease + '"' + ": " + "завершене.");
            Console.ReadLine();
        }
    }
}
