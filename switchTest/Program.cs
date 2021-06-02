using System;

namespace switchTest
{
    class SwitchTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee prize 1 = small ,2= miduam ,3=large");
            Console.WriteLine("please insrt your choise");
            string n = Console.ReadLine();
            int s = int.Parse(n);
            int Cost = 0;
            switch (s)
            {
                case 1:
                    Cost += 50;
                    break;
                case 2:
                    Cost += 50;
                    goto case 1;

                case 3:
                    Cost += 50;

                    goto case 1;
                default:
                    Console.WriteLine("please use a valid number");
                    break;

            }
            if(Cost != 0)
            {
                Console.WriteLine("you have to pay {0} tk", Cost);
            }
            
        }
    }
}
