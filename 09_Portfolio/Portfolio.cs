using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    public class Portfolio 
    {
        
        public Portfolio()
        {

        }
        public List<IAsset> a = new List<IAsset>();
        public Portfolio(List<IAsset> alist)
        {
           a = alist;
        }
        public double result;
        public double GetTotalValue()
        {
            foreach(IAsset element in a)
            {
                result += element.GetValue();
            }
            return result;
        }

        public void AddAsset(IAsset anobject)
        {

            a.Add(anobject);

        }
    }
}