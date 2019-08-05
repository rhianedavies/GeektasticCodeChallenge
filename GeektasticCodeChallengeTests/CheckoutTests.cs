using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeektasticCodeChallenge.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        /*
         * Assert.That(0, Is.EqualTo(price_of(“”)))
         * Assert.That(50, Is.EqualTo(price_of(“A”)))
         * Assert.That(80, Is.EqualTo(price_of(“AB”)))
         * Assert.That(115, Is.EqualTo(price_of(“CDBA”)))
         * Assert.That(100, Is.EqualTo(price_of(“AA”)))
         * Assert.That(130, Is.EqualTo(price_of(“AAA”)))
         * Assert.That(175, Is.EqualTo(price_of(“AAABB”)))
         */

        [TestMethod()]
        public void CalculateTotalTest0()
        {
            Checkout checkout = new Checkout("");
            Assert.AreEqual(0, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest50()
        {
            Checkout checkout = new Checkout("A");
            Assert.AreEqual(50, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest80()
        {
            Checkout checkout = new Checkout("AB");
            Assert.AreEqual(80, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest115()
        {
            Checkout checkout = new Checkout("CDBA");
            Assert.AreEqual(115, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest100()
        {
            Checkout checkout = new Checkout("AA");
            Assert.AreEqual(100, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest130()
        {
            Checkout checkout = new Checkout("AAA");
            Assert.AreEqual(130, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest175()
        {
            Checkout checkout = new Checkout("AAABB");
            Assert.AreEqual(175, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest100Lower()
        {
            Checkout checkout = new Checkout("aa");
            Assert.AreEqual(100, checkout.CalculateTotal(), 0.0001);
        }

        [TestMethod()]
        public void CalculateTotalTest115Extra()
        {
            Checkout checkout = new Checkout("ABCDEF");
            Assert.AreEqual(115, checkout.CalculateTotal(), 0.0001);
        }
    }
}