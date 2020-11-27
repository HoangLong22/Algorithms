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
        private static int Recurse(double taget, int month, double money, int rate)
        {
            if(taget >= money * 2)
            {
                return month;
            }
            month++;
            return Recurse(taget += taget * rate / 100, month, money, rate);
        }
        public static int CalMonth_recurse(double money, int rate)
        {
            if (money == 0 || rate < 1)           
                return 0;
            double taget = money + money * rate / 100;
            return Recurse(taget, 1, money, rate);
        }
    }
}
