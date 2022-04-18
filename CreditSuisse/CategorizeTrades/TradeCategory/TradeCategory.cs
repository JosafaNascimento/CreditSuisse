using System;
using System.Collections.Generic;
using CatTrade.Risk;
using CatTrade;

namespace CatTrade.Categories
{
    class TradeCategory
    {
        private List<ITrade> portfolio;

        public TradeCategory(List<ITrade> portfolio)
        {
            this.portfolio = portfolio;
        }

        public List<string> GetCategories()
        {
            IRisk risk = null;

            List<string> tradeCategories = new List<string>();

            List<IRisk> risks = new List<IRisk> {
                RiskFactory.Create(TypeRisk.Expired),
                RiskFactory.Create(TypeRisk.MediumRisk),
                RiskFactory.Create(TypeRisk.HighRisk)
            };

            foreach (Trade trade in portfolio)
            {
                foreach (IRisk r in risks)
                {
                    risk = r;
                    
                    if (trade.CalculateRisk(r))
                    {
                        break;
                    }
                }
                
                tradeCategories.Add(risk.Type);
            }

            return tradeCategories;
        }
    }
}
