
using System;

namespace newA
{
    class nmk
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("input the temp");
            temp=Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 0:
                    Console.WriteLine("new temp");

                break;

                case 10:
                    Console.WriteLine("it is very cold whther");
                    break;

                    case 20:
                    Console.WriteLine("this is normal cold");
                    break;

                    case 30:
                    Console.WriteLine("this i sthe h");
                    break;

                case 40:
                    Console.WriteLine("this is the the fuck");
                    break;

                default:
                    Console.WriteLine("none temper");
                    break;
            }

        }
    }
}