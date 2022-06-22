using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Board
    {
        public Cell[,] universe;
        private int Rows;
        private int Cols;

        public Board()
        {
            newUniverse(10, 10);
        }

        public void newUniverse(int row, int col)
        {
            Rows = row;
            Cols = col;
            universe = new Cell[row, col];
            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Cols; y++)
                {
                    universe[x, y] = new Cell();
                }
            }
        }

        public void randomUniverse(int seed)
        {
            Random rnd = new Random(seed);

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Cols; y++)
                {
                    if(rnd.Next(0,2) == 1)
                    {
                        universe[x, y].setIsAlive(true);
                    }
                    else
                    {
                        universe[x, y].setIsAlive(false);
                    }
                }
            }
        }

        public int getHeight() { return Rows; }
        public int getWidth() { return Cols; }

        public void nextGeneration()
        {
            for(int x = 0; x < Rows; x++ )
            {
                for (int y = 0; y < Cols; y++)
                {
                    int neighbors = getLivingNeigbors(x, y);
                    //is dead and has 3 living neigbors, it lives
                    if (!universe[x, y].getIsAlive() && neighbors == 3)
                    {
                        universe[x, y].setIsAlive(true);
                        universe[x, y].setGenAlive(universe[x, y].getGenAlive() + 1);
                    }
                    //if is alive and has 2 or 3 neibors it lives, also has logic for all other cases
                    else if (universe[x, y].getIsAlive())
                    {
                        if (neighbors == 2 || neighbors == 3)
                            universe[x, y].setGenAlive(universe[x, y].getGenAlive() + 1);
                        //At this point, the cell is either dead and does not have 3 neighbors,
                        //or is alive with more that 3 or less that 2 neighbors and should die
                        else
                        {
                            universe[x, y].setIsAlive(false);
                            universe[x, y].setGenAlive(0);
                        }
                    }

                }
            }
        }

        public int getLivingNeigbors(int row, int col)
        {
            int neighbours = 0;

            if (row == 0 && col == 0)
            {
                if (checkEast(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
            }
            else if (row == 0 && col == Cols - 1)
            {
                if (checkWest(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
            }
            else if (col == 0 && row == Rows - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
            }
            else if (col == Cols - 1 && row == Rows - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }
            }
            else if (row == 0)
            {
                if (checkSouth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }
            }
            else if (row == Rows -1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }
            }
            else if (col == 0)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
            }
            else if (col == Cols - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }
            }
            else
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }
            }
            return neighbours;
        }


        private bool checkNorth(int row, int col)
        {
            if (universe[row - 1, col].getIsAlive())
                return true;
            return false;
        }
        private bool checkSouth(int row, int col)
        {
            if (universe[row + 1, col].getIsAlive())
                return true;
            return false;
        }
        private bool checkEast(int row, int col)
        {
            if (universe[row, col + 1].getIsAlive())
                return true;
            return false;
        }
        private bool checkWest(int row, int col)
        {
            if (universe[row, col - 1].getIsAlive())
                return true;
            return false;
        }
        private bool checkNE(int row, int col)
        {
            if (universe[row - 1, col + 1].getIsAlive())
                return true;
            return false;
        }
        private bool checkNW(int row, int col)
        {
            if (universe[row - 1, col - 1].getIsAlive())
                return true;
            return false;
        }
        private bool checkSE(int row, int col)
        {
            if (universe[row + 1, col + 1].getIsAlive())
                return true;
            return false;
        }
        private bool checkSW(int row, int col)
        {
            if (universe[row + 1, col - 1].getIsAlive())
                return true;
            return false;
        }
    }
}
