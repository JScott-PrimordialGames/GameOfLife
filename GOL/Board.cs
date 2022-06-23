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

        bool infiniteUniverse;

        public Board()
        {
            newUniverse(10, 10);
            infiniteUniverse = false;
        }

        //setters and getters
        public int getHeight() { return Rows; }
        public int getWidth() { return Cols; }

        public bool getInfiniteUniverse() { return infiniteUniverse; }
        public void setInfiniteUniverse(bool newRules) { infiniteUniverse = newRules; }

        //create a new universe based on parameters
        public void newUniverse(int row, int col)
        {
            Rows = row;
            Cols = col;
            universe = new Cell[row, col];
            for (int x = 0; x < Cols; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    universe[y, x] = new Cell();
                }
            }
        }

        // randomize a universe
        public void randomUniverse(int seed)
        {
            Random rnd = new Random(seed);

            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    if(rnd.Next(0,2) == 1)
                    {
                        universe[y, x].setIsAlive(true);
                        universe[y, x].setGenAlive(1);
                    }
                    else
                    {
                        universe[y, x].setIsAlive(false);
                        universe[y, x].setGenAlive(0);
                    }
                }
            }
        }

        //Board function for advancing the generations
        public void nextGeneration()
        {
            for(int y = 0; y < Rows; y++ )
            {
                for (int x = 0; x < Cols; x++)
                {
                    int neighbors = getLivingNeigbors(y, x);
                    //is dead and has 3 living neigbors, it lives
                    if (!universe[y, x].getIsAlive() && neighbors == 3)
                    {
                        universe[y, x].setIsAlive(true);
                        universe[y, x].setGenAlive(universe[y, x].getGenAlive() + 1);
                    }
                    //if is alive and has 2 or 3 neibors it lives, also has logic for all other cases
                    else if (universe[y, x].getIsAlive())
                    {
                        if (neighbors == 2 || neighbors == 3)
                            universe[y, x].setGenAlive(universe[y, x].getGenAlive() + 1);
                        //At this point, the cell is either dead and does not have 3 neighbors,
                        //or is alive with more that 3 or less that 2 neighbors and should die
                        else
                        {
                            universe[y, x].setIsAlive(false);
                            universe[y, x].setGenAlive(0);
                        }
                    }

                }
            }
        }

        // this will cycle throught based on position and check all the applicable neighbors, running additional checks if infiniteUniverse is true
        public int getLivingNeigbors(int row, int col)
        {
            int neighbours = 0;

            if (row == 0 && col == 0)
            {
                if (checkEast(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkNorth(Rows, col)) { neighbours++; }
                    if (checkWest(row, Cols)) { neighbours++; }
                    if (checkNW(Rows, Cols)) { neighbours++; }
                    if (checkSW(row, Cols)) { neighbours++; }
                    if (checkNE(Rows, col)) { neighbours++; }
                }
            }
            else if (row == 0 && col == Cols - 1)
            {
                if (checkWest(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkNorth(Rows, col)) { neighbours++; }
                    if (checkEast(row, -1)) { neighbours++; }
                    if (checkNE(Rows, -1)) { neighbours++; }
                    if (checkNW(Rows, col)) { neighbours++; }
                    if (checkSE(row , -1)) { neighbours++; }
                }
            }
            else if (col == 0 && row == Rows - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkWest(row, Cols)) { neighbours++; }
                    if (checkNW(row, Cols)) { neighbours++; }
                    if (checkSW(-1, Cols)) { neighbours++; }
                    if (checkSE(-1, col)) { neighbours++; }
                    if (checkSouth(-1, col)) { neighbours++; }
                }
            }
            else if (col == Cols - 1 && row == Rows - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkSouth(-1, col)) { neighbours++; }
                    if (checkEast(row, -1)) { neighbours++; }
                    if (checkNE(row, -1)) { neighbours++; }
                    if (checkSE(-1, -1)) { neighbours++; }
                    if (checkSW(-1, col)) { neighbours++; }
                }
            }
            else if (row == 0)
            {
                if (checkSouth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkNorth(Rows, col)) { neighbours++; }
                    if (checkNE(Rows, col)) { neighbours++; }
                    if (checkNW(Rows, col)) { neighbours++; }
                }
            }
            else if (row == Rows -1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkSouth(-1, col)) { neighbours++; }
                    if (checkSE(-1, col)) { neighbours++; }
                    if (checkSW(-1, col)) { neighbours++; }
                }
            }
            else if (col == 0)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
                if (checkEast(row, col)) { neighbours++; }
                if (checkNE(row, col)) { neighbours++; }
                if (checkSE(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkWest(row, Cols)) { neighbours++; }
                    if (checkNW(row, Cols)) { neighbours++; }
                    if (checkSW(row, Cols)) { neighbours++; }
                }
            }
            else if (col == Cols - 1)
            {
                if (checkNorth(row, col)) { neighbours++; }
                if (checkSouth(row, col)) { neighbours++; }
                if (checkWest(row, col)) { neighbours++; }
                if (checkNW(row, col)) { neighbours++; }
                if (checkSW(row, col)) { neighbours++; }

                if (infiniteUniverse)
                {
                    if (checkEast(row, -1)) { neighbours++; }
                    if (checkNE(row, -1)) { neighbours++; }
                    if (checkSE(row, -1)) { neighbours++; }
                }
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


        //check the neighbors
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
