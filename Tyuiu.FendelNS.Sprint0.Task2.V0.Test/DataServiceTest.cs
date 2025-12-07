using Tyuiu.FendelNS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.FendelNS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Коля";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Коля", res);
        }
    }
}
