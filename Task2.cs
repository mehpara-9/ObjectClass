using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjcetClass
{
    public class Task2
    {
        public int Cem(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum = sum + a % 10;
                a = a / 10;
            }
            return sum;
        }

        public string  FullName(string Name,string Surname)
        {
            
            return Name+" "+Surname;
        }
    }


}
