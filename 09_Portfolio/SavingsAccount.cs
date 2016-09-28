namespace _09_Portfolio
{
    public class SavingsAccount : IAsset
    {
        public SavingsAccount()
        {

        }
        public string account;
        public double value;
        public double interestrate;
        public SavingsAccount(string accountnum, double val, double i)
        {
            account = accountnum;
            value = val;
            interestrate = i;
        }

        public double InterestRate
        {
            get { return this.interestrate; }
            set { this.interestrate = value; }
        }
        int c = 0;
       public int ApplyInterest()
        {
            return c++;
        }


        public double GetValue()
        {
            if (c > 0)
            {
                return value * (1 + (InterestRate/100.0));
            }
            else 
            {
                return value;
            }
            
        }

        public override string ToString()
        {
            
            return "SavingsAccount[value="+value+".0,interestRate="+InterestRate+"]";
        }

    }
}