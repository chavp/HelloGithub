using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ninject.Modules;
using Moq;

namespace NinjectDemoTest
{
    public class MockModule : NinjectModule
    {
        public override void Load()
        {

            Mock<IMyService> mock = new Mock<IMyService>();

            mock.Setup(m => m.Hello(It.IsAny<string>())).Throws(new NotImplementedException());
            mock.Setup(m => m.Hello(It.IsAny<MsgDto>())).Throws(new NotImplementedException());

            mock.Setup(m => m.Hello("Chavp")).Returns("Mock... Chavp");
            //mock.Setup(m => m.Hello(It.IsAny<string>())).Returns("Mock... IsAny String");
            mock.Setup(m => m.Hello(It.Is<MsgDto>(dto => dto.Msg == "Chavp"))).Returns("Mock... MsgDto.Chavp");

            Bind<IMyService>().ToConstant(mock.Object);
        }
    }
}
