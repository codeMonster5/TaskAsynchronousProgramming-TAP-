using System;
using System.Threading.Tasks;

namespace TaskAsynchronousProgramming_TAP_
{
    public  class Program
    {
        static async Task  Main(string[] args)
        {
            // Driver Load Distributor Model

            // Driver BACK TO OFFICE

            // Verify the load

            // Task assign to Driver

            Driver dr = new Driver();
            DateTime time = DateTime.Now;
            var task1 = dr.BackToOffice();
            var task2= dr.LoadVerify();
            var task3 = dr.TaskAssign();

           

            Console.WriteLine("mani");


            Console.WriteLine(DateTime.Now.Subtract(time).TotalSeconds);
        }
    }
}
