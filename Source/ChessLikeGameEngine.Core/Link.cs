using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace ChessLikeGameEngine.Core
{
    public class Link : Edge<Position>
    {
        public Link(Position pos1, Position pos2)
            : base(pos1, pos2) { }
    }
}
