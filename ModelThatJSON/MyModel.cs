using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelThatJSON
{

    public class dealerShip
    {
        public _cars[] cars { get; set; }
        public _price[] price { get; set; }
    }
    public class _cars
    {
        public string model { get; set; }
        public string color { get; set; }
        public int pricemin { get; set; }
        public int pricemax { get; set; }
    }


    public class _price
    {
        public string color { get; set; }
        public int price { get; set; }
    }

    public class MyModel
    {
        public int cid { get; set; }
        public string entityName { get; set; }
        public _accounts accounts { get; set; }
    }
    
    public class _accounts
    {
        public worldInvestor usa { get; set; }
        public worldInvestor slovakia { get; set; }
        public worldInvestor ecuador { get; set; }
        public worldInvestor mexico { get; set; }
    }

    public class worldInvestor
    {
        public _EntityStockShares entityStockShares;
    }
    

    public class _EntityStockShares
    {
        public string label { get; set; }
        public string desc { get; set; }
        public _units units { get; set; }
    }

   public class _units
    {
        public _trades[] trades { get; set; }
    }

    public class _trades
    {
        public int acct { get; set; }
        public DateTime dateOfTrade { get; set; }
        public string ticker { get; set; }
        public string tranType { get; set; }
        public int qty { get; set; }
        public decimal costPerShare { get; set; }
    }
}
