using System;
using System.Collections.Generic;
using System.Text;
using BrushUpStudent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrushUpStudentTests
{
    [TestClass]
    public class TeacherTest : TesterBase
    {
        private Teacher _teacher;

        [TestMethod]
        public void TeacherSalaryTest()
        {
            RunTest(() =>
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => _teacher.Salary = -1);

                _teacher.Salary = 0;
                Assert.AreEqual(0, _teacher.Salary);
            });
        }

        public override void Setup()
        {
            _teacher = new Teacher("Magnus", "Address");
        }

        public override void Clean()
        {
            _teacher = null;
        }
    }
}
