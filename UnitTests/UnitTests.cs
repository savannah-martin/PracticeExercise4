using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercise4;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestStackPush()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);

            Assert.AreEqual(5, stack.Length);
            Assert.AreEqual("8\n5\n3\n2\n1\n", stack.ToString());

        }

        [TestMethod]
        public void TestStackPop()
        {

        }

        [TestMethod]
        public void TestStackPeek()
        {

        }

        [TestMethod]
        public void TestStackLength()
        {

        }

        [TestMethod]
        public void TestStackIsEmpty()
        {

        }



        [TestMethod]
        public void TestQueueDequeue()
        {

        }

        [TestMethod]
        public void TestQueueEnqueue()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Assert.AreEqual(5, queue.Length);
            Assert.AreEqual("<Back> 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

            queue.Enqueue(6);
            queue.Enqueue(7);

            Assert.AreEqual(7, queue.Length);
            Assert.AreEqual("<Back> 7 → 6 → 5 → 4 → 3 → 2 → 1 <Front>", queue.ToString());

        }

        [TestMethod]
        public void TestQueueFirst()
        {

        }

        [TestMethod]
        public void TestQueueLast()
        {

        }

        [TestMethod]
        public void TestQueueIsEmpty()
        {

        }

        [TestMethod]
        public void TestQueueLength()
        {

        }

        [TestMethod]
        public void TestDequeAddFront()
        {

        }

        [TestMethod]
        public void TestDequeAddBack()
        {

        }

        [TestMethod]
        public void TestDequeRemoveFront()
        {

        }

        [TestMethod]
        public void TestDequeRemoveBack()
        {

        }


        [TestMethod]
        public void TestDequeIsEmpty()
        {

        }

        [TestMethod]
        public void TestDequeLength()
        {

        }

        [TestMethod]
        public void TestDequeFront()
        {

        }

        [TestMethod]
        public void TestDequeBack()
        {

        }
    }
}
