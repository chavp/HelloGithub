using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectDemoTest
{
    public class CatMyService : IMyService
    {
        public string Hello(string msg)
        {
            return "Fuuuuuuuuuuu... " + msg;
        }


        public string Hello(MsgDto msg)
        {
            return "Fuuuuuuuuuuu... " + msg.Msg;
        }
    }
}
