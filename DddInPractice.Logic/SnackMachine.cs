using DddInPractice.Logic.Base;
using System;
using System.Linq;

using static DddInPractice.Logic.Money;

namespace DddInPractice.Logic
{
    public sealed class SnackMachine : AggregateRoot
    {     

        //Questions:
        //what is Aggreate, and aggregate root?
        //why this class is marked as aggregate root?
        public Money MoneyInside { get; private set; } 
        public Money MoneyInTransaction { get; private set; }

        public void InsertMoney(Money money)
        {

            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            //Set Money In Traction to zero 
            MoneyInTransaction = 0;
        }

        public void BuySnack()
        {
            //Set MoneyInside to MoneyInTransaction, then set Money In transaction to zero
        }


        //Earn credit points on purchases with voucher
        //string voucher = "//[***]\n1***2***3"; --> should return 6 credits
        public int CalculateTotalCreditVoucher (string voucherValud)
        {
            return 0;
        }
    }
}
