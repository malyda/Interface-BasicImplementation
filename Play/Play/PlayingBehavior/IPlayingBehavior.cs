using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.Entity
{
    interface IPlayingBehavior
    {
        string GameName { get; set; }

        void DisplayGame();
    }
}
