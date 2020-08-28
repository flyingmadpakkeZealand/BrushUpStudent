using System;
using System.Collections.Generic;
using System.Text;
using BrushUpStudent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrushUpStudentTests
{
    [TestClass]
    public class StudentTest : TesterBase
    {
        private Student _student;

        [TestMethod]
        public void StudentSemesterTest()
        {
            RunTest(() =>
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 0);
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => _student.Semester = 9);

                _student.Semester = 1;
                Assert.AreEqual(1, _student.Semester);

                _student.Semester = 8;
                Assert.AreEqual(8, _student.Semester);
            });
        }


        public override void Setup()
        {
            _student = new Student("Magnus", "Address");
        }

        public override void Clean()
        {
            _student = null;
        }
    }
}
