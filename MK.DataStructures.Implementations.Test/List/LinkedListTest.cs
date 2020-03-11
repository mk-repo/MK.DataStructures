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
            var _node = new Node<int>(5);

            linkedList.AddFirst(_node);

            Assert.AreEqual(linkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_Front_Integer()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>(5);

            linkedList.AddFirst(_node);

            Assert.AreEqual(linkedList.Head.Data, 5);
            Assert.AreEqual(linkedList.Tail.Data, 5);
        }

        [TestMethod]
        public void Assert_Count_Add_To_Front_String()
        {
            var linkedList = new LinkedList<string>();
            var _node = new Node<string>("Test_Data");

            linkedList.AddFirst(_node);

            Assert.AreEqual(linkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_Front_String()
        {
            var linkedList = new LinkedList<string>();
            var _node = new Node<string>("Test_Data");

            linkedList.AddFirst(_node);

            Assert.AreEqual(linkedList.Head.Data, "Test_Data");
            Assert.AreEqual(linkedList.Tail.Data, "Test_Data");
        }

        [TestMethod]
        public void Assert_Count_Add_To_End_Integer()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>(5);

            linkedList.AddLast(_node);

            Assert.AreEqual(linkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_End_Integer()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>(5);

            linkedList.AddLast(_node);

            Assert.AreEqual(linkedList.Head.Data, 5);
            Assert.AreEqual(linkedList.Tail.Data, 5);
        }

        [TestMethod]
        public void Assert_Count_Add_To_End_String()
        {
            var linkedList = new LinkedList<string>();
            var _node = new Node<string>("Test_Data");

            linkedList.AddLast(_node);

            Assert.AreEqual(linkedList.Count(), 1);
        }

        [TestMethod]
        public void Assert_Data_Add_To_End_String()
        {
            var linkedList = new LinkedList<string>();
            var _node = new Node<string>("Test_Data");

            linkedList.AddLast(_node);

            Assert.AreEqual(linkedList.Head.Data, "Test_Data");
            Assert.AreEqual(linkedList.Tail.Data, "Test_Data");
        }

        [TestMethod]
        public void Assert_Clear_List()
        {
            var linkedList = new LinkedList<int>();
            var _node = new Node<int>(1);
            var _node1 = new Node<int>(2);

            linkedList.AddFirst(_node);
            linkedList.AddFirst(_node1);

            linkedList.Clear();

            Assert.IsNull(linkedList.Head);
            Assert.IsNull(linkedList.Tail);
            Assert.AreEqual(linkedList.Count(), 0);
        }
    }
}
