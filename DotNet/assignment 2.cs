//Write a C# program to read product details from end user and display the following details:	
//		Product Id :  102566

//        Product Name :  LG Printer
//		Unit Price :   2500

//        Quantity: 20

//        Total Amount:    50000

//        Discount Amount:   5000

//        Final Amount :     45000


//    Hint: Total Amount need to be calculate based on the Unit Price and Quantity. 
	
//		a.  If qty is greater than 10   ---    10% discount on total amount
//		b.  If qty is greater than 30   ---    20% discount on total amount 
//		c.  If qty is greater than 50   ---    30% discount  on total amount



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter unit price");
            int price = Convert.ToInt32(Console.ReadLine());  
            
            Console.WriteLine("Enter quantity");
            int quant = Convert.ToInt32(Console.ReadLine());
            int total = price * quant;
            int discount = 0;
            int final=0;
            
            if (quant>50)
            {
                discount = total / 30;
            }

            else if (quant > 30)
            {
                discount = total / 20;
            }
            else
            {
                discount = total / 10;
            }
            

            Console.WriteLine("Total amount is {0}", total);
            Console.WriteLine("Discount is {0}", discount);
            Console.WriteLine("Final price is  {0}", total-discount);


            Console.ReadLine();

        }
    }
}
