using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using WorkingTitle.Screens.TechnicalScreens;

namespace WorkingTitle
{
    /*
     * ScreenManager controls all the screens and drawing
     * 
     **/

    class ScreenManager : DrawableGameComponent
    {
        Stack<GameScreen> screens = new Stack<GameScreen>();
        public SpriteBatch sb;
        public KeyBoardManager keyManager;
        public MouseManager mouse;

        public ScreenManager(Game g) : base(g)
        {
            sb = Game.Services.GetService(typeof (SpriteBatch)) as SpriteBatch;
            keyManager = new KeyBoardManager(g);
            keyManager.manager = this;
            mouse = new MouseManager(g);
            mouse.manager = this;
            AddScreen(new MainMenu(g));
        }

        public void AddScreen(GameScreen screen)
        {
            screens.Push(screen);
            screen.manager = this;
        }

        public void RemoveScreen()
        {
            screens.Pop();
        }

        public override void Draw(GameTime gameTime)
        {
            screens.Peek().Draw(gameTime);

            mouse.Draw(gameTime);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            screens.Peek().Update(gameTime);


            base.Update(gameTime);
        }


        public GameScreen RemoveAndGetScreen()
        {
            return screens.Pop();
        }

    }
}
