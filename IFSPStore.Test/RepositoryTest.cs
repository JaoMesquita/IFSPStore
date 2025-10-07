using IFSPStoreRepository.Context;
using System.Diagnostics;

namespace IFSPStore.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new IFSPStoreContext())
            {
                Console.WriteLine("Connected!");
            }
        }
    }
}
