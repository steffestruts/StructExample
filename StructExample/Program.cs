using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    struct Order
    {
        public string ItemName { get; set; }
        public int UnitCount { get; set; }
        public double UnitCost { get; set; }

        public double TotalCost()
        {
            double res = UnitCount * UnitCost;
            return res;
        }

        public string WriteOrder()
        {
            return String.Format("Lager har {0} {1} som kostar {2} styck och total kostnad blir {3}", UnitCount, ItemName, UnitCost, TotalCost());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.ItemName = "poster";
            order1.UnitCost = 154.53;
            order1.UnitCount = 7;

            Console.WriteLine(order1.WriteOrder());
        }
    }
}
