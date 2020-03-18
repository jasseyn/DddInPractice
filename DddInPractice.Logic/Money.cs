using System;

namespace DddInPractice.Logic
{
    public sealed class Money : ValueObject<Money>
    {

        //Questions:
        //1. What is ValudeObject?
        //2. What is 'operator' key word?
        //3 what is sealed class?
        //4. How do you create a fixed value on Money value object, let's say zero dolar?
   
        public int FiveCentCount { get; }
        public int TenCentCount { get; }
        public int QuarterCount { get; }
        public int OneDollarCount { get; }


        public decimal Amount =>
            FiveCentCount * 0.05m +
            TenCentCount * 0.10m +
            QuarterCount * 0.25m +
            OneDollarCount;
         

        public Money(
            int fiveCentCount,
            int tenCentCount,
            int quarterCount,
            int oneDollarCount
            )
        {
            if (fiveCentCount < 0)
                throw new InvalidOperationException();
            if (tenCentCount < 0)
                throw new InvalidOperationException();
            if (quarterCount < 0)
                throw new InvalidOperationException();
            if (oneDollarCount < 0)
                throw new InvalidOperationException();
 
            FiveCentCount = fiveCentCount;
            TenCentCount = tenCentCount;
            QuarterCount = quarterCount;
            OneDollarCount = oneDollarCount;
        
        }

        public static Money operator +(Money money1, Money money2)
        {
            Money sum = new Money(
                money1.FiveCentCount + money2.FiveCentCount,
                money1.TenCentCount + money2.TenCentCount,
                money1.QuarterCount + money2.QuarterCount,
                money1.OneDollarCount + money2.OneDollarCount);

            return sum;
        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money(
                money1.FiveCentCount - money2.FiveCentCount,
                money1.TenCentCount - money2.TenCentCount,
                money1.QuarterCount - money2.QuarterCount,
                money1.OneDollarCount - money2.OneDollarCount
               );
        }

        protected override bool EqualsCore(Money other)
        {
            return FiveCentCount == other.FiveCentCount
                && TenCentCount == other.TenCentCount
                && QuarterCount == other.QuarterCount
                && OneDollarCount == other.OneDollarCount;
       
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = FiveCentCount;
                hashCode = (hashCode * 397) ^ TenCentCount;
                hashCode = (hashCode * 397) ^ QuarterCount;
                hashCode = (hashCode * 397) ^ OneDollarCount;
                return hashCode;
            }
        }
    }
}
