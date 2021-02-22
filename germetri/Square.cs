using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germetri
{
    public class Square
    {

        private double Side { get; set; }

        public Square(double længde)
        {
            Side = længde;
        }

        public void setside(double længde)
        {
            Side = længde;
        }
        public double omkreds()
        {
            return Side * 4;
            
        }
        public double areal()
        {
            return Math.Pow(Side, 2);

        }





    }
}
