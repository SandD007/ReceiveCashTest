using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiveCash
{
    public class Person
    {
        public string Name { get; set; }

        public int Cash { get; set; }


        public void WriteMyInfo()
        {
            Console.WriteLine("Я " +  Name + ". Я маю - " + Cash + "гривень.");
        }

        public int GiveCash(int cash)
        {
            int myCash = Cash;
            if (cash < 0)
            {
                Console.WriteLine("Ти ввів суму меньшу за 0!");
                return 0;
            }
            if (myCash < cash)
            {
                Console.WriteLine("В мене немає сітльки грошей.");
                return 0;
            }
            else
            {
                Cash = myCash - cash;
                return cash;
            }
        }

        public void ReceiveCash(int cash)
        {
            int myCash = Cash;
            if (cash < 0)
            {
                return;
            }
            else
            {
                Cash = myCash + cash;
            }
        }
    }
}
