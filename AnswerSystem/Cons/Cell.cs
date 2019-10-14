using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace AnswerSystem.Cons
{
    public class Cell
    {
        public Cell() { }
        public Cell(int index, Rectangle rec)
        {
            this.index = index;
            this.rec = rec;
        }

        public int index { get; set; }
        public Rectangle rec { get; set; }

    }
}
