using DevopsCaseStudyDemoProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevopsCaseStudyDemoProjectTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void ExceptionCaseTest()
        {
            BankAccount bank = new BankAccount("Lucky", 0);

            try
            {
                bank.Debit(2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Amount <= 0 or Amount > Balance");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Balance is 0");
            }
        }

        [TestMethod]
        public void DebitTest()
        {
            BankAccount bank = new BankAccount("Lucky", 2);
            bank.Debit(2);
            Assert.AreEqual(0, bank.Balance);
        }

        [TestMethod]
        public void CreditTest()
        {
            BankAccount bank = new BankAccount("Lucky", 2);
            bank.Credit(2);
            Assert.AreEqual(4, bank.Balance);
        }

        [TestMethod]
        public void CreditDebitTest()
        {
            BankAccount bank = new BankAccount("Lucky", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.Balance);
        }
    }
}