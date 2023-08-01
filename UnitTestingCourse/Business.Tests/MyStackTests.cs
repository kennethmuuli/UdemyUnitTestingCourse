using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    internal class MyStackTests
    {

        [Test]
        public void IsEmpty_Empty_ReturnsTrue()
        {
            var stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }
        
        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty);
            Assert.AreEqual(1, stack.Count);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationError()
        {
            var stack = new MyStack<int>();
            Assert.Throws<InvalidOperationException>(()=> stack.Pop());
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem() 
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void Peek_PushTwoItemsAndPop_ReturnsHeadItem()
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }
}
