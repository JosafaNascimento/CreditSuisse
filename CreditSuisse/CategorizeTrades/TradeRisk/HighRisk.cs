using CatTrade;

namespace CatTrade.Risk
{
    class HighRisk : IRisk
    {
        public string Type { get; private set; }
        Constants.Constants constants = new Constants.Constants();

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.value > Constants.Constants.basevalue && trade.clientsector.Equals(SectorRisk.Private.ToString()))
            {
                this.Type = TypeRisk.HighRisk.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
