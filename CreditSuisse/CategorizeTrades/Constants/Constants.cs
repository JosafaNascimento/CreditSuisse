using System;
using System.Globalization;

namespace CatTrade.Constants
{
    class Constants
    {

        /// <summary>
        /// reference date
        /// </summary>
        public static readonly DateTime referencedate;       
        

        /// <summary>
        /// Trades value
        /// </summary>
        public const double basevalue = 1000000;

        /// <summary>
        /// 30 days reference
        /// </summary>
        public const int delaylimit = 30;


        static Constants()
        {
            referencedate = new DateTime(2022, 04, 18);

        }

        public Constants(DateTime referencedate, double basevalue, int delaylimit)
        {
            
        }

        public Constants()
        : this(referencedate, basevalue, delaylimit)
        {
        }
    }

}
