using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {             //  012345678901  
            /*const string msg = "Hello World!";

            int indexOfFirstW = msg.IndexOf('H');
            
            Console.WriteLine(msg);
            Console.WriteLine(indexOfFirstW);*/

            string number = "55s";
            int realNum; // = Convert.ToInt32(number);
            //bool b = int.TryParse(number, out realNum);
           
            if (/*b*/int.TryParse(number, out realNum) == true)
            {
            Console.WriteLine("Good number");
            }
            else
            {
                Console.WriteLine("Bad number");
            }
            Console.WriteLine(number + 5);

            
        }
    }
}
