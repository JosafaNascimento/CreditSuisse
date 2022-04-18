using System;

namespace CatTrade.Risk
{
    static class RiskFactory
    {
        public static IRisk Create(TypeRisk risk)
        {
            return Create(risk.ToString());
        }

        public static IRisk Create(string risk)
        {
            switch (risk)
            {
                case "Expired":
                    return new Expired();
                case "HighRisk":
                    return new HighRisk();
                case "MediumRisk":
                    return new MediumRisk();               
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
