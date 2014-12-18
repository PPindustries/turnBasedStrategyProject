using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace WorkingTitle.Screens.TechnicalScreens
{
    /*
     * KeyBoardManager manages the inputs of the keyboard and relays them to ScreenManager
    **/

    class KeyBoardManager : GameComponent
    {
        private KeyboardState previous;
        private KeyboardState current;
        public ScreenManager manager;

        public KeyBoardManager(Game game) : base(game)
        {
            previous = Keyboard.GetState();
            Game.Services.AddService(typeof(KeyBoardManager),this);
            Game.Components.Add(this);
        }

        public bool WasKeyPressed(Keys key)
        {
            return (previous.IsKeyDown(key) && current.IsKeyUp(key));
        }

        public override void Update(GameTime gameTime)
        {
            previous = current;
            current = Keyboard.GetState();
            
            base.Update(gameTime);
        }


    }
}
