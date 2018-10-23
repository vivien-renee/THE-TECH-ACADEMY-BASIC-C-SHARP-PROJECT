using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play () //the override means we will define what Play() means to this game
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers ()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
    }
}
