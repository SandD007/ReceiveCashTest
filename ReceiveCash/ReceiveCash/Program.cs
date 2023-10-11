// See https://aka.ms/new-console-template for more information
using ReceiveCash;

Person person1 = new Person { Name = "Ваня", Cash = 100 };
Person person2 = new Person { Name = "Саша", Cash = 100 };

while (true)
{
    person1.WriteMyInfo();
    person2.WriteMyInfo();

    Console.Write("Введи кількість: ");
    string howMutch = Console.ReadLine();
    if (howMutch == " ") return;
    if (int.TryParse(howMutch, out int result))
    {
        int cash = int.Parse(howMutch);
        Console.Write("Хто повинен дати кошти: ");
        string witchPerson = Console.ReadLine();
        if(witchPerson == "Ваня")
        {
            person2.ReceiveCash(person1.GiveCash(cash));
        }
        else if (witchPerson == "Саша")
        {
            person1.ReceiveCash(person2.GiveCash(cash));
        }
        else
        {
            Console.WriteLine("Напише це Саша чи Ваня");
        }
    }
    else
    {
        Console.WriteLine("Веди кількість грошей або пробіл  для виходу.");
    }
}
