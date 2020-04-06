using Microsoft.VisualStudio.TestTools.UnitTesting;
using MK.DataStructures.Implementations.DoublyLinkedList;

namespace MK.DataStructures.Implementations.Test
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        [TestMethod]
        public void Assert_Create_Empty_DoublyLinkedList()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            Assert.IsNull(doublyLinkedList.Head);
            Assert.IsNull(doublyLinkedList.Tail);
        }

        [TestMethod]
        public void Assert_Count_Add_To_Front_Integer()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();
            var _node = new Node<int>(5);

            doublyLinkedList.AddFirst(_node);

            Assert.AreEqual(doublyLinkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_Front_Integer()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();
            var _node = new Node<int>(5);

            doublyLinkedList.AddFirst(_node);

            Assert.AreEqual(doublyLinkedList.Head.Data, 5);
            Assert.AreEqual(doublyLinkedList.Tail.Data, 5);
        }

        [TestMethod]
        public void Assert_Count_Add_To_Front_String()
        {
            var doublyLinkedList = new DoublyLinkedList<string>();
            var _node = new Node<string>("Test_Data");

            doublyLinkedList.AddFirst(_node);

            Assert.AreEqual(doublyLinkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_Front_String()
        {
            var doublyLinkedList = new DoublyLinkedList<string>();
            var _node = new Node<string>("Test_Data");

            doublyLinkedList.AddFirst(_node);

            Assert.AreEqual(doublyLinkedList.Head.Data, "Test_Data");
            Assert.AreEqual(doublyLinkedList.Tail.Data, "Test_Data");
        }
    }
}
