using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bronte_w_sdd_at2
{
    public class GameSettings
    {

        public string CurrentPlayer { get; set; } = X;
        private const string X = "X";
        private const string O = "O";
        private string[,] Board=new string[3, 3];


        public void SetNextPlayer()
        {
            if (CurrentPlayer == X)
            {
                CurrentPlayer = O;
            }
            else
            {
                CurrentPlayer = X;
            }


        }

        public bool PlayerWin()
        {
            //horizontal wins
            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, 0]))
                {
                    if (Board[0,0] == Board[1,0] && Board[0,0] == Board[2,0])
                    {
                        return true;
                    }

                }
            }

            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0,1]))
                {
                    if (Board[0,1] == Board[1,1] && Board[0,1] == Board[2, 1])
                    {
                        return true;
                    }

                }
            }


            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0,2]))
                {
                    if (Board[0,2] == Board[1,2] && Board[0,2] == Board[2, 2])
                    {
                        return true;
                    }

                }
            }






            //vertical wins
            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, 0]))
                {
                    if (Board[0, 0] == Board[0,1] && Board[0, 0] == Board[0,2])
                    {
                        return true;
                    }

                }
            }


            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[1,0]))
                {
                    if (Board[1,0] == Board[1, 1] && Board[1,0] == Board[1,2])
                    {
                        return true;
                    }

                }
            }



            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[2,0]))
                {
                    if (Board[2,0] == Board[2,1] && Board[2,0] == Board[2, 2])
                    {
                        return true;
                    }

                }
            }

            //diagonal wins

            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, 0]))
                {
                    if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2])
                    {
                        return true;
                    }

                }
            }


            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[2,0]))
                {
                    if (Board[2,0] == Board[1, 1] && Board[2,0] == Board[0, 2])
                    {
                        return true;
                    }

                }
            }























            return false;



            
        }
        internal void UpdateBoard(position position, string value)
        {
            Board[position.x, position.y] = value;
        }

    }
}
