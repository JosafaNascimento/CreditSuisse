
using System;

namespace CatTrade
{
    interface ITrade
    {
        /// <summary>
        /// //indicates the transaction amount in dollars
        /// </summary>
        double value { get; }
        /// <summary>
        /// //indicates the client´s sector which can be "Public" or "Private"
        /// </summary>
        string clientsector { get; }
        /// <summary>
        /// //indicates when the next payment from the client to the bank is expected
        /// </summary>
        DateTime nextpaymentdate { get; }
    }
}
