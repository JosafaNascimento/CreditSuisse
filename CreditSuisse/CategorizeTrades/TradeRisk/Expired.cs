using System;

namespace CatTrade.Risk
{
    class Expired : IRisk
    {
        public string Type { get; private set; }


        public bool CalculateRisk(ITrade trade)
        {
            //EXPIRED: Trades whose next payment date is late by more than 30
            //days based on a reference date which will be given.           
            TimeSpan date = Convert.ToDateTime(Constants.Constants.referencedate) -
            Convert.ToDateTime(trade.nextpaymentdate);           

            int delay = date.Days;

            if (delay > Constants.Constants.delaylimit)
            {
                this.Type = TypeRisk.Expired.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
