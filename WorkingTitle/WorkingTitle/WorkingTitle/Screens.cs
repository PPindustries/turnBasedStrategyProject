using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WorkingTitle
{
    /* NEEDS TO BE IMPLEMENTED
     * MainMenu is the main title screen that is displayed when the game boots up 
     **/

    class MainMenu: GameScreen
    {
        private Texture2D MenuBackground;
        private SpriteFont font;
        private Vector2 drawPosition;

         public MainMenu(Game game) : base(game)
        {
            font = game.Content.Load<SpriteFont>("MenuFont");
            MenuBackground = game.Content.Load<Texture2D>("MenuBackground");
            drawPosition = new Vector2(Game1.screenWidth/2, Game1.screenHeight*8/10);
        }

         public override void Draw(GameTime gameTime)
         {
             manager.sb.Begin();
             string output1 = "New Game";
             Vector2 output1Origin = font.MeasureString(output1) / 2;
             manager.sb.DrawString(font, output1, drawPosition, Color.Black,
                 0, output1Origin, 1.0f, SpriteEffects.None, 0.5f);
             manager.sb.End();

             base.Draw(gameTime);
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
