using DataStructureAndAlgorithms.DataStructures.Basic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataStructureAndAlgorithms.UnitTests.DataStructures.Basic
{
    [TestClass]
    public class StackUnitTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            MyStack<string> StringStack = new MyStack<string>();
            Assert.AreEqual(StringStack.Top, -1);
            Assert.AreEqual(StringStack.Capacity, 10);
        }

        [TestMethod]
        public void PushTest()
        {
            MyStack<string> StringStack = new MyStack<string>();
            Assert.AreEqual(StringStack.Top, -1);
            StringStack.Push("Test");
            Assert.AreEqual(StringStack.Top, 0);
        }

        [TestMethod]
        public void PopTest()
        {
            MyStack<string> StringStack = new MyStack<string>();
            StringStack.Push("Test");
            Assert.AreEqual(StringStack.Top, 0);
            StringStack.Pop();
            Assert.AreEqual(StringStack.Top, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void OverflowTest()
        {
            int stackSize = 5;
            MyStack<string> StringStack = new MyStack<string>(stackSize);
            for (int i = 0; i < stackSize + 1; i++)
            {
                StringStack.Push("Test");
            }
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UnderflowTest()
        {
            int stackSize = 5;
            MyStack<string> StringStack = new MyStack<string>(stackSize);
            for (int i = 0; i < stackSize + 1; i++)
            {
                StringStack.Pop();
            }
        }
    }
}
