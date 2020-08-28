using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpStudent;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using BrushUpStudentTests;

namespace BrushUpStudent.Tests
{
    [TestClass]
    public class PersonTests : TesterBase
    {
        private Person _person;

        //[TestMethod]
        //public void ConstructerTest()
        //{
        //    Assert.ThrowsException<ArgumentException>(() => _person = new Person(null, "None"));


        //    _person = new Person("Magnus", "None");

        //    Assert.AreEqual("Magnus", _person.Name);
        //    Assert.AreEqual("None", _person.Address);
        //}

        [TestMethod]
        public void PersonNameTest()
        {
            RunTest(() =>
            {
                Assert.ThrowsException<ArgumentException>(() => _person.Name = null);

                Assert.ThrowsException<ArgumentException>(() => _person.Name = "X");

                _person.Name = "Bo";
                Assert.AreEqual("Bo", _person.Name);
            });
        }

        [TestMethod]
        public void PersonAddressTest()
        {
            RunTest(() =>
            {
                Assert.ThrowsException<ArgumentNullException>(() => _person.Address = null);

                string str = "New Address";
                _person.Address = str;

                Assert.AreEqual(str, _person.Address);
            });
        }

        public override void Setup()
        {
            _person = new Person("Magnus", "None");
        }

        public override void Clean()
        {
            _person = null;
        }
    }
}

namespace BrushUpStudentTests
{
    class PersonTests
    {
    }
}
