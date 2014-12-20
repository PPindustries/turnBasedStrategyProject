using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace WorkingTitle
{
    /* NEEDS TO BE IMPLEMENTED
     * MainMenu is the main title screen that is displayed when the game boots up 
     **/

    class MainMenu: GameScreen
    {
        private Texture2D MenuBackground;
        private SpriteFont font;
        private Vector2 initialDraw;
        private Vector2 drawPosition;
        private Vector2 outputOrigin;
        private readonly string[] CHOICES={"New Game","Load Game","Options","About","Exit"};
        private drawnObjects[] arrObjects;

         public MainMenu(Game game) : base(game)
        {
            font = game.Content.Load<SpriteFont>("MenuFont");
            MenuBackground = game.Content.Load<Texture2D>("MenuBackground");
            initialDraw = new Vector2(Game1.screenWidth/2, Game1.screenHeight*2/10);
        }

        class drawnObjects
        {
            string words;
            Vector2 drawPosition;
            Vector2 outputOrigin;
        }


        //draws the background
         public override void Draw(GameTime gameTime)
         {
             drawPosition = initialDraw;

             manager.sb.Begin();
             //code to draw background of Main Menu
             //need a better background
             manager.sb.Draw(MenuBackground, new Rectangle(0, 0, Game1.screenWidth, Game1.screenHeight), Color.White);


             foreach(string output in CHOICES)
             {
                 outputOrigin = font.MeasureString(output) / 2;
                 manager.sb.DrawString(font, output, drawPosition, Color.Black,
                     0, outputOrigin, 1.0f, SpriteEffects.None, 0.5f);
                 drawPosition.Y += outputOrigin.Y * 2;
             }


             manager.sb.End();

             base.Draw(gameTime);
         }


         public override void Update(GameTime gameTime)
         {
             
             
             base.Update(gameTime);
         }

       


    }

    /* NEEDS TO BE IMPLEMENTED
     * Option is the option screen that players can change volume and other things
     **/
    class Option : GameScreen
    {
        public Option(Game game): base(game)
        {
        }
    }


}
