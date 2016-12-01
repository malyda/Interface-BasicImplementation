using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Play.Entity;

namespace Play.PlayingBehavior
{
    class DogPlayingBehavior : IPlayingBehavior
    {
        private string _name;
        public string GameName
        {
            get
            {
                return _name;
            }

            set { _name = value; }
        }

        public void DisplayGame()
        {
            Console.WriteLine("Playing like a dog.");
        }
    }
}
