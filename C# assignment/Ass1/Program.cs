using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            char[] name = new char[5];

            do
            {
                
                Console.WriteLine("Enter your name");
                //string name = Console.ReadLine();
               
                for (int j = 0; j < 5; j++)
                {
                    name[j] = char.Parse(Console.ReadLine());
                    if ((name[j] >= 'A' && name[j] <= 'Z') || (name[j] >= 'a' && name[j] <= 'z'))
                    {


                        
                        count++;
                     }

             
                   
                }
            } while (count==0);

                Console.WriteLine("Enter your Graduation year");
                int n = int.Parse(Console.ReadLine());
            if (count==1)
            {
                Console.WriteLine("my name is" + name + "and i ll graduate in" + n);
            }
                
                Console.ReadKey();


       




















        }
    }
}
