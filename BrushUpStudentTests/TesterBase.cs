using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudentTests
{
    public abstract class TesterBase
    {
        public void RunTest(Action test)
        {
            Setup();

            test();

            Clean();
        }

        public abstract void Setup();

        public abstract void Clean();
    }
}
