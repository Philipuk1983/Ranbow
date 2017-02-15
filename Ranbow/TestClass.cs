using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranbow
{
    public class TestClass
    {
        public static TestClass GetInstance()
        {
            return new TestClass();
        }

        protected TestClass()
        {

        }

        public int TestAdding(int addThis, int andThis)
        {
            return addThis + andThis;
        }
    }
}
