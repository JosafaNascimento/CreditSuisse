using CatTrade;

namespace CatTrade.Risk
{
    class MediumRisk : IRisk
    {
        public string Type { get; private set; }

        public bool CalculateRisk(ITrade trade)
        {
            if (trade.value > Constants.Constants.basevalue && trade.clientsector.Equals(SectorRisk.Public.ToString()))
            {
                this.Type = TypeRisk.MediumRisk.ToString().ToUpper();

                return true;
            }

            this.Type = NoneRisk.NONERISK.ToString();

            return false;
        }
    }
}
