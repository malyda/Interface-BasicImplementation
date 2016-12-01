using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Play.PlayingBehavior;

namespace Play.Entity
{
    class Cat : IAnimal
    {

        public IPlayingBehavior playingBehavior { get; set; } = new CatPlayingBehavior();

        public void Play()
        {
            playingBehavior.DisplayGame();
        }
    }
}
