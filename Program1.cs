using System;

namespace newK{

    class hjkM
    {
        static void Main(string[] args)
        {
            string customNmae, cId;
            int unit;
            double charge, amount, serviceCh=0, netAmount;

            Console.WriteLine("\n\n");
            Console.WriteLine("Calculater Electrisity Bils");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\n\n");

            //input
            Console.WriteLine("input customer id");
            cId= Console.ReadLine();
            Console.WriteLine("name of customers");
            customNmae= Console.ReadLine();

            Console.WriteLine("input the unote the consume by the customers");
            unit=Convert.ToInt32(Console.ReadLine());

            if(unit <200)
            {
                charge = 2.20;
            }else if(unit <200 && unit < 400)
            {
                charge = 1.6;

            }else if (unit <400 && unit < 600)
            {
                charge = 3.9;

            }
            else
            {
                charge = 7.00;
            }

            amount = unit + charge;

            if(amount < 300)
            {
                serviceCh = amount * 15 / 100.00;
            }

            netAmount = amount +serviceCh;

            if (netAmount < 100)
            {
                netAmount = 100;
            }

            //print 
            Console.WriteLine("\n electricity bil");
            Console.WriteLine("Customers id  : (0)\n", customNmae);
            Console.ReadLine();

            
        }

    }
}
