using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Bai22_calMonth
    {
        public static int calMonth(double money, int rate)
        {
            if(money == 0 || rate < 1)
            {
                return 0;
            }
            int month = 1;
            double taget = money + money * rate / 100;
            //so tien tiet kiem = tien goc + tien lai
            while(taget < money*2)
            {
                taget += taget * rate / 100;
                month++;
            }
            return month;
        }

        //De quy
        private static int Recurse(double taget, int month, double money, int rate)
        {
            double x = money + money * rate / 100;
            if(x >= taget)
            {
                return month;
            }
            return Recurse(x, rate, taget, month + 1);
        }
        public static int CalMonth_recurse(double money, int rate)
        {
            if (money <= 0 || rate == 1 || rate <= 0)           
                return 0;
            double taget = 2 * money;
            return Recurse(taget, 1, money, rate);
        }
    }
}
