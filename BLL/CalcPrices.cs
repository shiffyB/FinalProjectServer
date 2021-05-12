using System;

namespace BLL
{
    public class CalcPrices
    {
        //function for calculating 
        public double CalcUserGambopackage(int amountInPackage,double amountUser, double packagePrice)
        {
            return (amountUser / amountInPackage) * packagePrice;
        }

        
    }
}
