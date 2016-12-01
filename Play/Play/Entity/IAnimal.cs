using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play.Entity
{
    interface IAnimal
    {
        IPlayingBehavior playingBehavior { get; set; }
        void Play();
    }
}
