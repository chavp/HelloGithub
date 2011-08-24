using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Moq;

namespace NinjectDemoTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            IKernel ninjectKernel = new StandardKernel();

            Mock<IMyService> mock = new Mock<IMyService>();

            mock.Setup(m => m.Hello(It.IsAny<string>())).Throws(new NotImplementedException());
            mock.Setup(m => m.Hello(It.IsAny<MsgDto>())).Throws(new NotImplementedException());

            mock.Setup(m => m.Hello("Chavp")).Returns("Mock... Chavp");
            //mock.Setup(m => m.Hello(It.IsAny<string>())).Returns("Mock... IsAny String");
            mock.Setup(m => m.Hello(It.Is<MsgDto>( dto => dto.Msg == "Chavp" ))).Returns("Mock... MsgDto.Chavp");

            ninjectKernel.Bind<IMyService>().ToConstant(mock.Object);

            IMyService service = ninjectKernel.Get<IMyService>();

            Console.WriteLine(service.Hello(new MsgDto { Msg = "Chavp" }));
            Console.WriteLine(service.Hello("Chavp"));
        }
    }
}
