namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sid;
            string sName;

            double math, english, science, total, presentage;

            Console.WriteLine("input the student id");
            sid = Console.ReadLine();

            Console.WriteLine("input the name of the students");
            sName = Console.ReadLine();

            Console.WriteLine("input the marks of maths");
            math=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input the marks of english");
            english=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input the marks of science");
            science=Convert.ToDouble(Console.ReadLine()); 
            
            //calculate the total
            total=math+english+science;
            //presentage
            presentage = total / 3;
            //Detaermain the grade
            if(presentage <= 80)
                
            {
                Console.WriteLine("very good pass");

            }else if(presentage <= 60 && presentage <=80)
            {
                Console.WriteLine("good pass");

            }else if(presentage <=60 && presentage <= 45)
            {
                Console.WriteLine("normal");

            }
            else
            {
                Console.WriteLine("faile");
            }

            //out put
            Console.WriteLine("\n sid (0): \n sName (1) \n", sid, sName);
            Console.WriteLine("marks in maths :(0) \n marks in science :(1) \n marks in english :(2)", math, english, science);
            Console.WriteLine(total, presentage);

            Console.ReadLine();





        }
    }
}
