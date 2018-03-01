using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonAidStand;
using System.Collections.Generic;

namespace LemonaidTests.cs
{
    [TestClass]
    public class WalletUnitTest
    {
        [TestMethod]
            public void Wallet_TestDebitofAmountforLemonspurcahsed_ReturnsCashInWalletcorrectly()
            {
                Wallet wallet = new LemonAidStand.Wallet();
            // arrange
            double cash = 10.00;

            List<double> testLemons = new List<double>() { 10, 0.72, 30, 2.03, 75, 4.23 };
            double expected = 7.97;
            double actual;

            //act
            actual = wallet.DebitWalletForLemonsPurchased(cash, "30", testLemons);
            //assert

            Assert.AreEqual(expected, actual);
            }
        }
}
