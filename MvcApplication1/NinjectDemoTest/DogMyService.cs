using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectDemoTest
{
    public class DogMyService : IMyService
    {
        public string Hello(string msg)
        {
            return "Bof bof.... " + msg;
        }

        public string Hello(MsgDto msg)
        {
            return "Bof bof.... " + msg.Msg;
        }
    }
}
