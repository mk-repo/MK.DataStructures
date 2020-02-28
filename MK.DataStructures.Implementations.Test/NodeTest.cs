using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MK.DataStructures.Implementations.Test
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void Create_Integer_Node()
        {
            var node = new Node<int>() { Data = 5, Next = null };

            Assert.AreEqual(node.Data, 5);
            Assert.IsNull(node.Next);
        }

        [TestMethod]
        public void Create_String_Node()
        {
            var node = new Node<string>() { Data = "TestData", Next = null };

            Assert.AreEqual(node.Data, "TestData");
            Assert.IsNull(node.Next);
        }

        [TestMethod]
        public void Create_Float_Node()
        {
            var node = new Node<float>() { Data = 5.5f, Next = null };

            Assert.AreEqual(node.Data, 5.5f);
            Assert.IsNull(node.Next);
        }
    }
}
