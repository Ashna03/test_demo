using BankAccount;
using NUnit.Framework;
using System;
using Moq;

namespace BankUnitTest
{
    [TestFixture]
    public class Tests
    {

        SavingsAccount myaccount;          //initialising at top so it could be used with all functions

        //[SetUp]
        //public void setup_SavingAccount()
        //{
        //    //Arrange
        //    myaccount = new SavingsAccount(100);
        //}

        [Test]
        public void SavingsAccount_Deposit_AlwaysApproved_UpdatedBalance()
        {
            Mock<IApprovingAuthority> approver = new Mock<IApprovingAuthority>();
            approver.Setup(x => x.Approve(It.IsAny<string>())).Returns(true);   //.IsAn<string> is used to get any string and it will approve it
            myaccount = new SavingsAccount(100, approver.Object);           //To call the object of mock interface .object is appended to the object name
            myaccount.deposit(100);
            Assert.That(myaccount.Balance, Is.EqualTo(200));
        
        }

        [Test]
        public void SavingsAccount_Deposit_NeverApproved_BalanceShouldNotUpdate()
        {
            Mock<IApprovingAuthority> approver = new Mock<IApprovingAuthority>();
            approver.Setup(x => x.Approve(It.IsAny<string>())).Returns(false);
            myaccount = new SavingsAccount(100, approver.Object);
            myaccount.deposit(100);
            Assert.That(myaccount.Balance, Is.EqualTo(100));
        }





        //[Test]
        // public void SavingsAccount_Deposit_ThowExceptionForNegativeValue()
        // {
        //   var ex= Assert.Throws<ArgumentException>(() => myaccount.deposit(-1));
        //   StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        //}

        //[Test]
        //public void SavingsAccount_Deposit_ShouldIncreaseBalance()
        //{

        //act
        //myaccount.deposit(100);
        //assert
        //Assert.That(myaccount.Balance, Is.EqualTo(200));



        //}
        //[Test]
        //public void SavingsAccount_Withdraw_ShouldDecreaseBalance()
        //{



        //    //act
        //    myaccount.withdraw(500);
        //    //assert
        //    Assert.Multiple(() =>
        //    {
        //        Assert.That(myaccount.Balance, Is.EqualTo(0));
        //        Assert.That(myaccount.Balance, Is.Not.LessThan(0));
        //    }
        //    );



        //}



    //    [TestCase(50, true, 50)]
    //[TestCase(100, true, 0)]
    //[TestCase(1000, false, 100)]
    //public void SavingsAccount_Withdraw_TestMultipleScenarios(int AmountToWithdraw, bool ShouldSucceed, int ExpectedBalance)
    //{
    //    var result = false;
    //    try {
    //            result = myaccount.withdraw(AmountToWithdraw);
    //        }
    //    catch 
    //        { 
    //            result = false;
    //        }
    //    Assert.Multiple(() =>
    //    {
    //        Assert.That(result, Is.EqualTo(ShouldSucceed));
    //        Assert.That(ExpectedBalance, Is.EqualTo(myaccount.Balance));
    //    }
    //    );



    //}



}
}








