using System;

namespace bbG
{
    class name
    {
        static void Main(string[] args)
        {
            string dis;

            char grade;

            Console.WriteLine("input the grade");
            grade=Convert.ToChar(Console.ReadLine().ToLower().ToUpper());

            switch(grade) {
                case "A";
                    dis = "excelent";
                    break;
                    case "B";
                    dis = "very veryGood";
                    break;
                    case "C";
                    dis = "good";
                    break;
                    case= "D";
                    dis = "avarage";
                    break;
                    case ="F"
                        dis = "fails";
                    break;
                    default;
                    dis = "invalid grade found";
                    break;

                    Console.WriteLine("you have got :(0) \n",dis);
                    Console.ReadLine();
        }
}
