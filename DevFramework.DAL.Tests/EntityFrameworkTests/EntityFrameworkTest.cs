using System;
using DevFramework.DAL.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DAL.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(77, result.Count);
        }

        [TestMethod]
        public void Get_all_with_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList(x=>x.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
