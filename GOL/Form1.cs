﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOL
{
    public partial class Form1 : Form
    {
        // The universe array
        Board board = new Board();

        int Rows = 10;
        int Colls = 10;

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();
        int timescale = 100;
        bool timerStopped = true;

        // Generation count
        int generations = 0;

        int LivingCells = 0;

        public Form1()
        {
            InitializeComponent();
            // Setup the timer
            timer.Interval = timescale; // milliseconds
            timer.Tick += Timer_Tick;
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // Increment generation count
            generations++;
            board.nextGeneration();
            graphicsPanel1.Refresh();
            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            int LivingCells = 0;
            foreach (Cell cell in board.universe)
            {
                if (cell.getIsAlive())
                    LivingCells++;
            }
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + LivingCells.ToString();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / board.getWidth();
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / board.getHeight();

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < board.getHeight(); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < board.getWidth(); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (board.universe[y, x].getIsAlive())
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        Font drawFont = new Font("Arial", 16);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        e.Graphics.DrawString(board.universe[x, y].getGenAlive().ToString(), drawFont, drawBrush, cellRect.X, cellRect.Y);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / board.getWidth();
                int cellHeight = graphicsPanel1.ClientSize.Height / board.getHeight();

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                board.universe[x, y].setIsAlive(!board.universe[x, y].getIsAlive());

                if(board.universe[x, y].getIsAlive())
                    LivingCells++;
                else
                    LivingCells--;

                toolStripStatusLabelLivingCells.Text = "Living Cells = " + LivingCells.ToString();
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            timerStopped = false;
        }

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerStopped = true;
        }

        private void newUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            generations = 0;
            board.newUniverse(Rows, Colls);
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLivingCells.Text = "Living Cells = " + LivingCells.ToString();
            graphicsPanel1.Refresh();
        }

        private void nextGenerationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (timerStopped)
                NextGeneration();
        }

        private void seedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rndSeed newSeedForm = new rndSeed();
            if(newSeedForm.ShowDialog(this) == DialogResult.OK)
            {
                board.newUniverse(Rows, Colls);
                string seed = newSeedForm.txb_NewSeed.Text;
                int seedNum = Convert.ToInt32(seed);
                board.randomUniverse(seedNum);
                graphicsPanel1.Refresh();
            }
            else { }
            newSeedForm.Dispose();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.newUniverse(Rows, Colls);
            DateTime dTime = DateTime.Now;
            board.randomUniverse((int)dTime.TimeOfDay.TotalSeconds);
            graphicsPanel1.Refresh();
        }

        private void universeSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSizeForm newSizeDialog = new NewSizeForm();

            if (newSizeDialog.ShowDialog(this) == DialogResult.OK)
            {
                string rows = newSizeDialog.txb_NewRows.Text;
                string cols = newSizeDialog.txb_NewCols.Text;
                Rows = Convert.ToInt32(rows);
                Colls = Convert.ToInt32(cols);
                board.newUniverse(Rows , Colls);
                graphicsPanel1.Refresh();
            }
            else 
            { 
            }
            newSizeDialog.Dispose();
        }
    }
}
