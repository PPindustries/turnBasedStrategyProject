using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace WorkingTitle
{
    /* 
     * MouseManager manages the inputs of the mouse and relays them to ScreenManager
     **/

    class MouseManager : GameComponent
    {

        private MouseState previous;
        private MouseState current;

        public MouseManager(Game game)
            : base(game)
        {
            previous = Mouse.GetState();
            Game.Services.AddService(typeof(MouseManager), this);
            Game.Components.Add(this);
        }

        public override void Update(GameTime gameTime)
        {
            previous = current;
            current = Mouse.GetState();
            base.Update(gameTime);
        }

        public bool WasLeftPressed()
        {
            return ((previous.LeftButton == ButtonState.Pressed) && (current.LeftButton == ButtonState.Pressed));
        }

        public bool WasRightPressed()
        {
            return ((previous.RightButton == ButtonState.Pressed) && (current.RightButton == ButtonState.Pressed));
        }

        public Vector2 MousePosition()
        {
            return new Vector2(current.X, current.Y);
        }
    }
}
