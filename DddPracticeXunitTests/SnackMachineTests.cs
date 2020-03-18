using DddInPractice.Logic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static DddInPractice.Logic.Money;

namespace DddPracticeXunitTests
{
    public class SnackMachineTests
    {
                      
        [Fact]
        public void Inserted_money_goes_to_money_in_transaction()
        {
            //Arrange:
            //Expected Amount inserted
            decimal expectedAmount = 1.05m;
            //create a dollar and five cents money objects
            //Create Snack Machine object
            //Insert money

            //Assert
          
        }

        [Fact]
        public void Return_money_empties_money_in_transaction()
        {
            decimal expectedAmount = 0;
      

          
        }

        [Fact]
        public void Money_in_transaction_goes_to_money_inside_after_purchase() //buy snack
        {
          //Implement TDD buysnack method
        }

        [Fact]
        public void Calculate_credit_voucher_string_with_parameter_in_bracket()
        {
            //TDD: make this test to fail fist and make it passes
            string voucher = "//[*]\n1*2*3";
            int expectedTotalCredit = 6;
       
        

        }


        [Theory]
        [InlineData("//[***]\n1***2***3", 6)]
        [InlineData("//[;;]\n1;;2;;3", 6)]
        [InlineData("//[###]\n1###2###3", 6)]
        public void Calculate_credit_voucher_string_with_string_test_cases(string inputvalue, int expected)
        {
            //TDD: make this test to fail fist and make it passes
            var mystring = inputvalue;
            int expectedTotalCredit = expected;

            //Copy previous test here to run for above test cases
      


        }

    }
}
