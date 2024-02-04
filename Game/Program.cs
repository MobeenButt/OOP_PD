using EZInput;
using System;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {
        static int height = 27;
        static int width = 100;
        static bool EnemyMove = false;
        static bool EnemyMove2 = false;
        static bool isFiring = false;
       
        static void Main()
        {
           
            PLAYER p = new PLAYER('P', 2, 2);

            int number_Enemies = 2;

            ENEMYClass[] e = new ENEMYClass[number_Enemies];
            e[0] = new ENEMYClass('E', 55, 18);
            e[1] = new ENEMYClass('L', 15, 5);


           
            MAZE();

   
            DISPLAY(p.pX, p.pY, p.Symbol);
            for(int i=0;i<number_Enemies;i++)
            {
                DISPLAY(e[i].eX, e[i].eY, e[i].Symbol);
            }
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    REMOVE(p.pX, p.pY,p.Symbol);
                    MOVE("left",ref p.pX,ref  p.pY, ref width);
               DISPLAY(p.pX,p.pY,p.Symbol); 
                }
                else if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    REMOVE(p.pX, p.pY, p.Symbol);
                    MOVE("right", ref p.pX, ref p.pY, ref width);
                    DISPLAY(p.pX, p.pY, p.Symbol);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    REMOVE(p.pX, p.pY, p.Symbol);
                    MOVEPLAYERUP("UP", ref p.pX, ref p.pY, ref height);
                    DISPLAY(p.pX, p.pY, p.Symbol);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    REMOVE(p.pX, p.pY, p.Symbol);
                    MOVEPLAYERUP("DOWN", ref p.pX, ref p.pY, ref height);
                    DISPLAY(p.pX, p.pY, p.Symbol);
                }
             
                
                    REMOVE(e[0].eX, e[0].eY, e[0].Symbol);
                    MOVEENEMY(ref e[0].eX, ref e[0].eY, ref width);
                    DISPLAY(e[0].eX, e[0].eY, e[0].Symbol);
                REMOVE(e[1].eX, e[1].eY, e[1].Symbol);
                MOVEENEMY2UP(ref e[1].eX, ref e[1].eY, ref height);
                DISPLAY(e[1].eX, e[1].eY, e[1].Symbol);
                Thread.Sleep(50);
            }

        }

        static void DISPLAY( int x,  int y,char Symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(Symbol);
        }
        static void MOVE(string direction, ref int x, ref int y, ref int width)
        {
            int nextX = x;
            int nextY = y;

            if (direction == "left" && x > 1)
            {
                nextX = x - 1;
            }
            else if (direction == "right" && x < width)
            {
                nextX = x + 1;
            }

            if (IsMazeCellEmpty(nextX, nextY))
            {
                x = nextX;
                y = nextY;
            }
        }

        static void MOVEENEMY(ref int x, ref int y, ref int width)
        {
            int nextX = x;
            int nextY = y;

            if (x > 1 && EnemyMove)
            {
                nextX = x - 1;
            }
            else if (x < width && !EnemyMove)
            {
                nextX = x + 1;
            }

            if (IsMazeCellEmpty(nextX, nextY))
            {
                x = nextX;
                y = nextY;
            }

            // Switch direction when reaching the boundary
            if (x <= 1 || x >= width)
            {
                EnemyMove = !EnemyMove;
            }
        }

        static void MOVEPLAYERUP(string direction, ref int x, ref int y, ref int height)
        {
            int nextX = x;
            int nextY = y;

            if (direction == "UP" && y > 1)
            {
                nextY = y - 1;
            }
            else if (direction == "DOWN" && y < height)
            {
                nextY = y + 1;
            }

            if (IsMazeCellEmpty(nextX, nextY))
            {
                x = nextX;
                y = nextY;
            }
        }

        static void MOVEENEMY2UP(ref int x, ref int y, ref int height)
        {
            int nextX = x;
            int nextY = y;

            if (y > 1 && EnemyMove2)
            {
                nextY = y - 1;
            }
            else if (y < height && !EnemyMove2)
            {
                nextY = y + 1;
            }

            if (IsMazeCellEmpty(nextX, nextY))
            {
                x = nextX;
                y = nextY;
            }

            // Switch direction when reaching the boundary
            if (y <= 1 || y >= height)
            {
                EnemyMove2 = !EnemyMove2;
            }
        }

        static bool IsMazeCellEmpty(int x, int y)
        {
            char cell = GetMazeCell(x, y);
            return cell != '#';
        }

        static char GetMazeCell(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return Console.ReadKey().KeyChar;
        }




        //static void MOVE(string direction, ref int x, ref int y, ref int width)
        //{


        //    if (direction == "left" && x > 1)
        //    {
        //        x = x - 1;
        //    }
        //    else if (direction == "right" && x < width)
        //    {
        //        x = x + 1;
        //    }


        //}

        //static void MOVEENEMY(ref int x, ref int y, ref int width)
        //{
        //    //
        //    Console.SetCursorPosition(x, y);

        //    if (x > 1 && EnemyMove)
        //    {
        //        x = x - 1;
        //    }
        //    else if (x < width && !EnemyMove)
        //    {
        //        x = x + 1;
        //    }

        //    // Switch direction when reaching the boundary
        //    if (x <= 1 || x >= width)
        //    {
        //        EnemyMove = !EnemyMove;
        //    }


        //}

        //static void MOVEPLAYERUP(string direction, ref int x, ref int y, ref int height)
        //{


        //    if (direction == "UP" && y > 1)
        //    {
        //        y = y - 1;
        //    }
        //    else if (direction == "DOWN" && y < height)
        //    {
        //        y = y + 1;
        //    }


        //}

        //static void MOVEENEMY2UP(ref int x, ref int y, ref int height)
        //{

        //    Console.SetCursorPosition(x, y);

        //    if (y > 1 && EnemyMove2)
        //    {
        //        y = y - 1;
        //    }
        //    else if (y < height && !EnemyMove2)
        //    {
        //        y = y + 1;
        //    }

        //    // Switch direction when reaching the boundary
        //    if (y <= 1 || y >= height)
        //    {
        //        EnemyMove2 = !EnemyMove2;
        //    }


        //}

        static void REMOVE( int x,  int y,char Symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(' ');
        }

        
        static void REMOVEBULLET(ref int bx, ref int by)
        {
            Console.SetCursorPosition(bx, by);
            Console.WriteLine(" ");
        }
      
        static void MAZE()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################################");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("######################################################################################################");
        }
    }
}
