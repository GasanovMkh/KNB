using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public interface IForm1
    {
        event EventHandler NewGameClick;
        event EventHandler StartClick;
        event EventHandler StopClick;
        void NewGame();
        void StartGame();
        void StopGame();
    }

    public class Game : IForm1
    {
        public event EventHandler NewGameClick;
        public event EventHandler StartClick;
        public event EventHandler StopClick;


        public void NewGame()
        {
            NewGameClick?.Invoke(this, EventArgs.Empty);
        }

        public void StartGame()
        {
            StartClick?.Invoke(this, EventArgs.Empty);
        }

        public void StopGame()
        {
            StopClick.Invoke(this, EventArgs.Empty);
        }
    }
}

