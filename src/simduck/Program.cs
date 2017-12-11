using System;
using simduck.Ducks;

namespace simduck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = null;
            bool exitApplication = false;

            do
            {
                Console.WriteLine("What do you want to see?\n1)DecoyDuck\n2)MallardDuck\n3)RubberDuck\nanykey to exit");
                Console.WriteLine(string.Empty);                
                var response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        duck = new DecoyDuck();
                        break;
                    case "2":
                        duck = new MallardDuck();
                        break;
                    case "3":
                        duck = new RubberDuck();
                        break;
                    default:
                        exitApplication = true;
                        break;
                }                
                if(!exitApplication)
                {
                    duck.Display();
                    duck.PerformFly();
                    duck.PerformQuack();                
                }
                Console.WriteLine(string.Empty);
            }while(!exitApplication);

            Console.WriteLine("Bye Bye!!");
        }
    }
}
