using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjectDemoTest
{
    public interface IMyService
    {
        string Hello(string msg);
        string Hello(MsgDto msg);
    }

    public class MsgDto
    {
        public string Msg { get; set; }
    }
}
