using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Row
    {
        public Row()
        {
            CellList = new List<Cell>();
        }

        public uint Index { get; set; }
        public List<Cell> CellList { get; private set; }

        public void AddCell(Cell cell)
        {
            CellList.Add(cell);
        }
    }

    public class Cell
    {
        public uint Row { get; set; }
        public uint Index { get; set; }
        public string Data { get; set; }
    }
}