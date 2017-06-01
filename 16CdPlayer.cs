# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class CdPlayer : ICdPlayer
    {
        private int currentTrack = 0;

       
        public void Play()
        {
            
        }

        public void Stop()
        {
            
        }

        public int FastForward(float numberOfSeconds)
        {
         

            return 0;  
        }

        public int CurrentTrack  // read-only property
        {
            get
            {
                return currentTrack;
            }
            set
            {
                currentTrack = value;
            }
        }
        public int MyProperty
        {
            get
            {
                return 7;
            }
            set
            {
                MyProperty = value;
            }
        }

        
    }
}
