using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Store
{
    [TestClass]
    public class StoreTest
    {
       
        private static List<Product> getList()
        {
            Product productA = new Product("Product A", 100, 5);
            Product productB = new Product("Product B", 200, 3);
            Product productC = new Product("Product C", 50, 10);
            return new List<Product>() { productA, productB, productC };
        }

        [TestMethod]
        public void TestSortByName()
        {

            List<Product> listSorted = Sort.getProductSorted(getList(), "name", true);

            foreach (Product product in listSorted)
            {
                Debug.WriteLine(product.ToString());
            }

            Assert.AreEqual(listSorted.First().name, getList().First().name);
            Assert.AreEqual(listSorted.Last().name, getList().Last().name);

        }

        [TestMethod]
        public void TestSortByPrice()
        {

            List<Product> listSorted = Sort.getProductSorted(getList(), "price", false);

            foreach (Product product in listSorted)
            {
                Debug.WriteLine(product.ToString());
            }

            Assert.AreEqual(listSorted.First().name, getList()[1].name);
            Assert.AreEqual(listSorted.Last().name, getList().Last().name);
        }

        [TestMethod]
        public void TestSortByStock()
        {

            List<Product> listSorted = Sort.getProductSorted(getList(), "stock", false);

            foreach (Product product in listSorted)
            {
                Debug.WriteLine(product.ToString());
            }

            Assert.AreEqual(listSorted.First().name, getList().Last().name);
            Assert.AreEqual(listSorted.Last().name, getList()[1].name);
        }
    }
}