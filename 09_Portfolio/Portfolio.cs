using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    public class Portfolio 
    {
        
        public Portfolio()
        {

        }
        public List<Asset> a = new List<Asset>();
        public Portfolio(List<Asset> alist)
        {
           a = alist;
        }
        public double result;
        public double GetTotalValue()
        {
            foreach(Asset element in a)
            {
                result += element.GetValue();
            }
            return result;
        }

        public void AddAsset(Asset anobject)
        {

            a.Add(anobject);

        }
    }
}