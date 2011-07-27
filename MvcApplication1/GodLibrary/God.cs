using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GodLibrary
{
    public class God
    {
        public God()
        {
            Name = "ฉันคือพระเจ้า";
            Description = "ฉันเป็นผู้ประดิษฐ์โลกของเธอขึ้นมา";
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
