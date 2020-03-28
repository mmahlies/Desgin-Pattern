using GangOfFour;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractFactoryClient.Factories;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // this window will create objecs from theme1 family 
            Window window = new Window(new Themes1Factory());
        }


        
    }
}
