using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace WorkingTitle
{
    /* 
     * MouseManager manages the inputs of the mouse and relays them to ScreenManager
     **/

    class MouseManager : GameComponent
    {
        private Texture2D cursor;
        private MouseState previous;
        private MouseState current;
        public ScreenManager manager;

        public MouseManager(Game game)
            : base(game)
        {
            previous = Mouse.GetState();
            Game.Services.AddService(typeof(MouseManager), this);
            Game.Components.Add(this);
            cursor = Game.Content.Load<Texture2D>("cursor");
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
        public void Draw(GameTime game)
        {
            manager.sb.Begin();
            manager.sb.Draw(cursor, new Rectangle(current.X-4,current.Y,20,20), Color.White);
            
            manager.sb.End();
        }

    }
}
