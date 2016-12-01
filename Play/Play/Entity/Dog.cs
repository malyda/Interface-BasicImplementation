using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Play.Entity;
using Play.PlayingBehavior;

namespace Play
{
    class Dog : IAnimal
    {
      public IPlayingBehavior playingBehavior { get; set; } = new DogPlayingBehavior();

        public void Play()
        {
            playingBehavior.DisplayGame();
        }
    }
}
