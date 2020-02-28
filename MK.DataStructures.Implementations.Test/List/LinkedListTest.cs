using Microsoft.VisualStudio.TestTools.UnitTesting;
using MK.DataStructures.Implementations.List;

namespace MK.DataStructures.Implementations.Test
{
    [TestClass]
    public class LinkedListTest
    {

        [TestMethod]
        public void Assert_Create_Empty_List()
        {
            var linkedList = new LinkedList<int>();

            Assert.IsNull(linkedList.Head);
            Assert.IsNull(linkedList.Tail);
        }

        [TestMethod]
        public void Assert_Count_Add_To_Front_Integer()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>() { Data = 5, Next = null };

            linkedList.AddToFront(_node);

            Assert.AreEqual(linkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_Front_Integer()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>() { Data = 5, Next = null };

            linkedList.AddToFront(_node);

            Assert.AreEqual(linkedList.Head.Data, 5);
            Assert.AreEqual(linkedList.Tail.Data, 5);
        }
    }
}
