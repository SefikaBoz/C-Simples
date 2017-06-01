# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public interface ICdPlayer
    {
        void Play();
        void Stop();
        int FastForward(float numberOfSeconds);
        int CurrentTrack { get; set;}
        int MyProperty { get; set; }


        

    }
}
