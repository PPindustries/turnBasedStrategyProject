using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WorkingTitle
{
    /*
     * GameScreen is the base class for all screens
     * each component needs to be overwritten for a screen to work well
     * not drawable,needs to draw through ScreenMananger
     * 
     **/

    class GameScreen : GameComponent
    {
        public ScreenManager manager;

        public GameScreen(Game game) : base(game)
        {
        }

        public virtual void Draw(GameTime gameTime)
        {
            
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }
    }
}
