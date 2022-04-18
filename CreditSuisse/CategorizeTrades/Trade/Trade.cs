using CatTrade.Risk;
using System;

namespace CatTrade
{
    class Trade : ITrade
    {
        private static int id = 1;

        private string name;

        public double value { get; set; }
        public string clientsector { get; set; }
        public DateTime nextpaymentdate { get; set; }

        public Trade()
        {
            this.name = "Trade" + id++;
            
        }

        public bool CalculateRisk(IRisk risk)
        {
            return risk.CalculateRisk(this);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
