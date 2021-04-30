using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActionsApp.Test
{
    [TestClass]
    public class CharacterCounterTest
    {
        [TestMethod]
        public void CountingEmpty()
        {
            CharacterCounter cc = new CharacterCounter();
            int length = cc.Characters("");

            Assert.IsTrue(length == 1);
        }
    }
}
