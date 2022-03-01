using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePro
{
     class LineCompaProb
    {
        public  double ComparisonProb()
        {
            int x1, x2, x3,x4, y1, y2, y3, y4;
            double line1,line2;
            
           
            Console.WriteLine("Enter the values of x1 and y1 coordinates of first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x2 and y2 coordinates of second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
          
           line1= Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Enter the values of x3 and y3 coordinates of third point");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of x4 and y4 coordinates of third point");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
           
            line2=Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Lenght of line1 is:" + line1);
            Console.WriteLine("Lenght of line2 is:" + line2);

            if (line1 > line2)
              {
               
                    Console.WriteLine("{0} is greater than {1}", line1, line2);
               }
            
            else if (line2 > line1)
            {
                Console.WriteLine("{1} is less than {0}", line2, line1);
            }
            else
            {
                Console.WriteLine("{0} and {1} are equal", line1, line2);
            }
            Console.ReadLine();
            return line1;
           
        }
    }
}
      