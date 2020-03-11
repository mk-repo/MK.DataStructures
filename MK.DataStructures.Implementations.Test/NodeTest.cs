using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MK.DataStructures.Implementations.Test
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void Create_Integer_Node()
        {
            var node = new Node<int>(5);

            Assert.AreEqual(node.Data, 5);
            Assert.IsNull(node.Next);
        }

        [TestMethod]
        public void Create_String_Node()
        {
            var node = new Node<string>("Test_Data");

            Assert.AreEqual(node.Data, "Test_Data");
            Assert.IsNull(node.Next);
        }

        [TestMethod]
        public void Create_Float_Node()
        {
            var node = new Node<float>(5.5f);

            Assert.AreEqual(node.Data, 5.5f);
            Assert.IsNull(node.Next);
        }
    }
}
