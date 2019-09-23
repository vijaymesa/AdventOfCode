using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new Day9.Controllers.AssignmentController();
            var response = controller.Day9();
        }
    }
}
