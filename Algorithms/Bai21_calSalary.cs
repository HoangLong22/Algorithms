using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai21_calSalary
    {
        public static double calSalary(double salary, int n)
        {
            int i;
            for(i = 0; i < n; i++)
            {
                salary+= salary * 0.1;
            }
            return salary;
        }

        public static double calSalary_recursive(double salary, int n)
        {
            if (n == 0)
            {
                return salary;
            }
            return calSalary_recursive(salary, n-1) + calSalary_recursive(salary, n-1)*0.1;
        }
    }
}
