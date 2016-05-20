using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace DrawHouse
{
    class House
    {
        public int Wall { get; private set; }
        public int RendSpeed
        {
            set
            {
                if (value > 0)
                {
                    Turtle.Speed = value;
                }
            }
        }
        private bool cond;
        public House(int wall)
        {
            try
            {
                if (wall > 0)
                {
                    this.Wall = wall;
                    Turtle.Speed = 7;
                }
                else
                {
                    throw new Exception("Length of Wall cannot be negative or zero");
                }
                cond = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void DrawSquare()
        {
            try
            {
                if (cond)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        DrawSide(Wall, 90);
                    }
                }
                else
                {
                    throw new Exception("Length of WindwSides or WallSides are uncorrect, it cann't be drawable");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private void DrawSide(int HowMove, int HowTurn)
        {
            Turtle.Turn(HowTurn);
            Turtle.Move(HowMove);
        }

        public void DrawRoof()
        {
            DrawSide(Wall, 30);
            DrawSide(Wall, 120);
            Turtle.Turn(30);
        }

        public void DrawWindw()
        {
            try
            {
                if (2*Wall < 3)
                {
                    throw new Exception("Dividing by zero Exception");
                }
                else
                {
                    Turtle.PenUp();
                    Turtle.Move(2*Wall / 3);
                    DrawSide(Wall / 3, 90);
                    Turtle.PenDown();
                    Turtle.Move(Wall / 3);
                    for (int i = 0; i < 4; i++)
                    {
                        DrawSide(Wall / 3, 90);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
