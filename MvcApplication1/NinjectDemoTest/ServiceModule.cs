using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using Moq;

namespace NinjectDemoTest
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMyService>().ToConstant(new CatMyService());
        }
    }
}
