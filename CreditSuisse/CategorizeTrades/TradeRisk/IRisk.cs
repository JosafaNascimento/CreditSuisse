using CatTrade;
using System;

namespace CatTrade.Risk
{
    interface IRisk
    {
        string Type { get; }
     
        bool CalculateRisk(ITrade trade);

        
    }
}
