using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldRush 
{
    class Mine 
    {
        int countShaftMan = 1;
        int countDripMan = 1;
        int countBrigMan = 1;
        private readonly ITimerMine timeMine;
        public Mine(ITimerMine timeMine)
        {
            this.timeMine = timeMine;
        }
        public int goShaft()
        {
            timeMine.iTimerShaftMan(countShaftMan);
            int result = countShaftMan * 1;
            return result;
        }
        public int goDrip()
        {
            timeMine.iTimerDripMan(countDripMan);
            int result = countDripMan * 1;
            return result;
        }
        public int goBrig()
        {
            timeMine.iTimerBrigMan(countBrigMan);
            int result = countBrigMan * 1;
            return result;
        }
        public void iTimerBrigMan()
        {
            throw new NotImplementedException();
        }

        public void iTimerBuilderMan()
        {
            throw new NotImplementedException();
        }

        public void iTimerDripMan()
        {
            throw new NotImplementedException();
        }
    }
}
