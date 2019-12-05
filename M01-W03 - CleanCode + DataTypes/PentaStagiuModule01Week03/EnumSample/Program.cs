using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample
{
    class Program
    {
        public enum PlayerStates
        {
            NotInitialized, // implicit = 0
            MediaLoaded, // implicit = 1
            Playing, // implicit = 2
            Paused, // implicit = 3
            Stopped // implicit = 4
        }

        public enum CustomPlayerStates
        {
            NotInitialized = 1,
            MediaLoaded = 2,
            Playing = 4,
            Paused = 8,
            Stopped = 16
        }
        
        static void Main(string[] args)
        {
            // initialization
            PlayerStates currentState = PlayerStates.NotInitialized;
            int numericValue = (int)currentState;

            // check current value
            if (currentState == PlayerStates.MediaLoaded)
            {
                // start player
            }
        }
    }
}
