using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevAssessment;

namespace SafeConvertUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
           

        //    SafeConvert sa = new SafeConvert();
        //    // sa.runSafeInt();
        //    SafeConvert.RunSafeInt("3339");
        //    Assert.AreEqual(1, 3, 3, "Test");
        //}
        [TestMethod]
        public void SafeRunTest()
        {
           SafeConvert.SafeConverToInteger("        9          ") ;
            SafeConvert.SafeConverToInteger("p");
            SafeConvert.SafeConverToInteger("pO");

        }
        [TestMethod]
        public void SafeRunCallTest()
        {
            SafeConvert.ToSafeIntCallMethod("1");
            SafeConvert.ToSafeIntCallMethod("p");
            SafeConvert.ToSafeIntCallMethod("@");
            SafeConvert.SafeConverToInteger("        9          ");

        }
    }
}
