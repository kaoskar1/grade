using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {

            GradeBook book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(50f);
            book.AddGrade(100f);


            GradeStatistics stats = book.ComputeStatistics();

            Assert.AreEqual(100f, stats.HighGrade);
        }

        [TestMethod]
        public void PassByValue()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not Set";
            SetName(book);

            Assert.AreEqual("", book.Name);

        }

        void SetName(GradeBook book)
        {
            book.Name = "Name set";
        }
    }
}
 