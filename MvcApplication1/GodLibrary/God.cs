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

            Humans = new List<Human>();
            Humans.Add(new Human { Name = "Parinya", Bod = new DateTime(1980, 1, 6)});
            Humans.Add(new Human { Name = "Renu", Bod = new DateTime(1981, 1, 16) });
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public List<Human> Humans { get; set; }
    }
}
