using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldRush
{
    interface ICorporationView
    {
        void showTotalDollars(int dollars, int cent);
        void showTotalDollars(int dollars);
        void showTotalGold(int gold);
        void showLV(int lv);
    }
}
