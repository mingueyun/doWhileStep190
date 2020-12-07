using System;


namespace doWhileStep190
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter amount 10 cans to return.  Please enter   10?");
            int canEnter = Convert.ToInt32(Console.ReadLine());
            bool totalCan = canEnter == 10;
            decimal price = Convert.ToDecimal(canEnter);
            decimal cost = price * .32m;
            while (true)
            {
                if (totalCan)
                {
                    Console.WriteLine(" this is the most we can give " + cost);
                    break;
                }
                else
                {
                    Console.WriteLine("please add the right amount");
                    break;
                }
            }
         
            Console.ReadLine();

            //Console.WriteLine("Enter amount of cans to return.  Please enter 2 or 4 at a time?");
            //int canEnter = Convert.ToInt32(Console.ReadLine());
            //bool totalCan = canEnter == 2 && canEnter == 4;
            //decimal price = Convert.ToDecimal(canEnter);
            //decimal cost = price * .32m;
            //do
            //{
            //    switch (canEnter)
            //    {
            //        case 1:
            //            Console.WriteLine("you entered 1 please add more ?");
            //            Console.WriteLine("Enter amount of cans to return.  Please enter 2 or 4 at a time?");
            //            canEnter = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 2:
            //            Console.WriteLine("you entered 2.");
            //            price = Convert.ToDecimal(canEnter);
            //            cost = price * .32m;
            //            totalCan = true;
            //            break;
            //        case 3:
            //            Console.WriteLine("you entered 3 please change the quantity!");
            //            Console.WriteLine("Enter amount of cans to return.  Please enter 2 or 4 at a time?");
            //            canEnter = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 4:
            //            Console.WriteLine("you entered 4.");
            //            price = Convert.ToDecimal(canEnter);
            //            cost = price * .32m;
            //            totalCan = true;
            //            break;
            //        default:
            //            Console.WriteLine("You entered the wrong amount please correct it!");
            //            Console.WriteLine("Enter amount of cans to return.  Please enter 2 or 4 at a time?");
            //            canEnter = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!totalCan);
            //Console.WriteLine(" this is the most we can give " + cost);
            //Console.ReadLine();

        }
    }
}
