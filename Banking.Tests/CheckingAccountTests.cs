using System;
using Xunit;

namespace Banking.Tests
{
    public class CheckingAccountTests

    {
        [Fact]
        public void Balance_Starts_At_Zero()
        {
            CheckingAccount account = new CheckingAccount();

            Assert.Equal(0M, account.Balance);

        }

        [Fact]
        public void Deposit_Increases_Balance()
        {
            CheckingAccount account = new CheckingAccount();

            account.Deposit(200M);

            Assert.Equal(200M, account.Balance);

        }

        [Fact]
        public void Withdraw_Reduces_Balance()
        {
            CheckingAccount account = new CheckingAccount();

            account.Deposit(100M);

            account.Withdraw(50M);

            Assert.Equal(50M, account.Balance);

        }
    }
}
