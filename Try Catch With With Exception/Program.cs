using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_With_With_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter BDT Amount :");
                decimal sales = decimal.Parse(Console.ReadLine());
                decimal commmition = sales * 7.5M / 100;

                Console.WriteLine($"Commssion Rate {sales} BDT 7.5% is :{commmition}");


            }catch(Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }


        }//Main
    }//Class
}//Namespace
