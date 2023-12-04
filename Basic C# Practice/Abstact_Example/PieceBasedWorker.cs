using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact_Example
{
    internal class PieceBasedWorker : Worker
    {
        public int NoOfPiecedsProduced { get; set; }
        public double AmountPerPiece { get; set; }

        public override double GetTotalWage()
        {
            if (NoOfPiecedsProduced <= 500)
                return AmountPerPiece * NoOfPiecedsProduced;

            else
                return AmountPerPiece * NoOfPiecedsProduced * 1.02;
        }
    }
}
