using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Bank;

namespace MathTest
{
    [TestFixture]
    public class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void Init()
        {
            source = new Account();
            source.Deposit(200.00F);
            destination = new Account();
            destination.Deposit(150.00F);
        }

        [Test]
        public void TransferFunds()
        {
            source.TransferFunds(destination, 100.00f);
            Assert.AreEqual(250.00F, destination.Balance);
            Assert.AreEqual(100.00F, source.Balance);
        }

        [Test]
        [ExpectedException(typeof(InsufficientFundsException))]
        public void TransferWithInsufficientFunds()
        {
            source.TransferFunds(destination, 300.00F);
        }

        [Test]
        [Ignore("Decide how to implement transaction management")]
        public void TransferWithInsufficientFundsAtomicity()
        {
            try
            {
                source.TransferFunds(destination, 300.00F);
            }
            catch (InsufficientFundsException expected)
            {
            }

            Assert.AreEqual(200.00F, source.Balance);
            Assert.AreEqual(150.00F, destination.Balance);
        }
    }
}
