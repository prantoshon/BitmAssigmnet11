using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
  
    public class RefrigeratorClass
    {
        public double maxWeight { get; set; }

        public  double itemNo { get; set; }
        public  double  weight { get; set; }

        public double CurretWeight()
        {
            return itemNo * weight;
        }

        public double Remain()
        {
            return maxWeight - CurretWeight();
        }


    }
}
