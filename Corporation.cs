using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldRush
{
    class Corporation
    {
        
        int cart;
        int truck;
        int excovator;
        int conveer;
        private int lv;
        protected int Lv
        {
            get { return lv; }
            set { lv = value; }
        }
        private int gold;
        private int[] money;
        
           // da, K, M, G, T, P, E, Z, Y
        

        private readonly ICorporationView view;
        public Corporation(ICorporationView view)
        {
            lv = 1;
            gold = 0;
            money = new int[9];
            money[8] = 800;
            this.view = view;
        }
        public void showMoney()
        {

            for (int i = 0; i < money.Length; i++)
            {
                if(i == 8)
                {
                    view.showTotalDollars(money[i]);
                    return;
                }
                if (money[i] != 0) 
                {
                    view.showTotalDollars(money[i], money[i+1]);
                    return;
                }
            }

        }
        public void plasMoney(int[] Money)
        {
            for (int i = 0; i < money.Length; i++)
            {
                money[i] += Money[i];
            }
            for (int i = 8; i > 0; i--)
            {
                if(money[i] > 999)
                {
                    int tmp = money[i] / 1000;
                    money[i] = money[i] % 1000;
                    money[i - 1] += tmp;
                }
            }
            showMoney();
        }
        public void minusMoney(int[] Money)
        {
            for (int i = 8; i >= 0; i++)
            {
                if(money[i] < Money[i])
                {
                    money[i - 1] -= 1;
                    money[i] += 1000;
                    money[i] -= Money[i];
                }
                if(money[i] >= Money[i])
                {
                    money[i] -= Money[i];
                }
            }
            showMoney();
        }
        public bool chekMoney(int[] Money)
        {
            for (int i = 0; i < money.Length; i++)
            {
                if (money[i] > Money[i])
                {
                    return true;
                }
                else if (money[i] < Money[i])
                {
                    return false;
                }
                else{}
            }
            return true;
        }
        public void showGold()
        {
            view.showTotalGold(gold);
        }
        public void showLv()
        {
            view.showLV(lv);
        }
    }
}
