using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Tests
{
    [TestClass()]
    public class BalanceTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            Balance bank = new Balance("rutvi",0);
            try
            {
                bank.Debit(2);

            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "amount<=0 r amount>balance");
                return;
         

            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, "balance=0");
                return;


            }
            Assert.Fail("no exception");
        }
        [TestMethod()]
        public void TestCreditCase()
        {
            Balance bank = new Balance("rutvi", 2);
            bank.Credit(2);
            Assert.AreEqual(4, bank.bal);
        }
        [TestMethod()]
        public void TestDebitCase()
        {
            Balance bank = new Balance("rutvi", 2);
            bank.Debit(2);
            Assert.AreEqual(0, bank.bal);
        }

        [TestMethod()]
        public void TestCreditDebitCase()
        {
            Balance bank = new Balance("rutvi", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.bal);
        }










    }
}