using System;
using System.Collections.Generic;
using System.Globalization;
using CatTrade;
using CatTrade.Categories;

namespace CategorizeTrades
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            List<ITrade> portfolio;
            List<string> tradeCategory;
          
          
            Trade t0 = new Trade { value = 2000000, clientsector = "Private", nextpaymentdate = new DateTime(2022, 01, 31)};
            Trade t1 = new Trade { value = 2000000, clientsector = "Private", nextpaymentdate = new DateTime(2022, 02, 20)};
            Trade t2 = new Trade { value = 400000,  clientsector = "Public", nextpaymentdate = new DateTime(2022, 03, 30)};
            Trade t3 = new Trade { value = 500000,  clientsector = "Private", nextpaymentdate = new DateTime(2022, 04, 30)};
            Trade t4 = new Trade { value = 3000000, clientsector = "Public", nextpaymentdate = new DateTime(2022, 05, 10)};
            Trade t5 = new Trade { value = 3000000, clientsector = "Private", nextpaymentdate = new DateTime(2022, 06, 06)};
            Trade t6 = new Trade { value = 3000000, clientsector = "Public", nextpaymentdate = new DateTime(2022, 07, 17)};
            Trade t7 = new Trade { value = 3000000, clientsector = "Private", nextpaymentdate = new DateTime(2022, 08, 18)};
            Trade t8 = new Trade { value = 3000000, clientsector = "Public", nextpaymentdate = new DateTime(2022, 11, 29)};
            Trade t9 = new Trade { value = 3000000, clientsector = "Private", nextpaymentdate = new DateTime(2022, 12, 31)};

          

            portfolio = new List<ITrade> { t0,t1, t2, t3, t4, t5, t6, t7, t8, t9 };

            tradeCategory = new TradeCategory(portfolio).GetCategories();

            int NumberOfTrades = tradeCategory.Count;
            Console.Title = "Category";
            Console.WriteLine("Input:\n");

            Console.WriteLine("Reference date: " + CatTrade.Constants.Constants.referencedate.ToString("MM/dd/yyyy") + "\n");
            Console.WriteLine("number of trades in the portfolio: " + NumberOfTrades + "\n");

            foreach (ITrade trade in portfolio)
            {                

                Console.WriteLine("{0} = {{ Value = {1}, ClientSector = \"{2}\" , NextPaymentDate = \"{3}\" }}", (Trade)trade, trade.value, trade.clientsector, trade.nextpaymentdate.ToString("MM/dd/yyyy"));
            }
            Console.WriteLine("\nportfolio = {{ {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9} }}"
                , t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
            
            Console.WriteLine("\nOutput:\n");
            
            Console.WriteLine("tradeCategories = {{ \"{0}\", \"{1}\", \"{2}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\" , \"{8}\", \"{9}\"}}", 
                  tradeCategory[0]
                , tradeCategory[1]
                , tradeCategory[2]
                , tradeCategory[3]
                , tradeCategory[4]
                , tradeCategory[5]
                , tradeCategory[6]
                , tradeCategory[7]
                , tradeCategory[8]
                , tradeCategory[9]);
            
            Console.Write("\n\nPress any key to out...");
            
            Console.ReadKey();
        }
    }
}
