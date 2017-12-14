using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Klient
    {
        private float CurrentMoney=100;
        public float Money
        {
            get
            {
                return CurrentMoney;
            }
        }
        
        interface Bank
        {
            float Money { get; set; }

            void getMoney();
            void AddMoney();
        }
        public void AddMoney(float wplata)
        {
            CurrentMoney += wplata;
        }
        public void getMoney(float wyplata)
        {
            CurrentMoney -= wyplata;
        }
        static void Main(string[] args)
        {
            Klient Marcin = new Klient();
            Marcin.AddMoney(30);
            Marcin.getMoney(60);
            Console.WriteLine(Marcin.CurrentMoney);
            Console.ReadKey();
        }
    }
}
