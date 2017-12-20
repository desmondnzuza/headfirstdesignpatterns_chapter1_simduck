using System;
using simduck.Behaviours;
using simduck.Ducks;
using simduck.Equipment;

namespace simduck
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RunEquipment();
            RunDucks();            

            Console.WriteLine("Bye Bye!!");
        }

        private static void RunEquipment()
        {
            var silence = new SilentQuack();
            var tools = new DuckCall[]
            {
                new SteelDuckCall(),
                new WoodenDuckCall()
            };

            foreach(var tool in tools)
            {
                Console.Write($"{tool.Description()} Says: ");
                tool.MakeSound();
                tool.ChangeQuackBehaviour(silence); 
                Console.WriteLine(string.Empty);
                Console.Write($"{tool.Description()} Now Says: ");           
                tool.MakeSound();
                Console.WriteLine(string.Empty);
            }
        }

        private static void RunDucks()
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
        }
    }
}
