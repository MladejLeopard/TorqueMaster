using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.Contracts
{
    public class IgnitionKeyLockPosition
    {
        int currentPosition;

        public enum IgnitionKeyLockPositions
        {
            PositionZero = 180,
            PositionI = 45,
            PositionII = 75,
            PositionIII = 90
        }

        public IgnitionKeyLockPosition()
        {
           // while(!_isRunning)
        }

    }
}
