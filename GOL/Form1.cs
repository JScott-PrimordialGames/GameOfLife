using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //default size for the universe
        int Rows = 10;
        int Colls = 10;

        // Drawing colors
        Color backgroundColor = Color.White;
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();
        int timescale = 100;
        bool timerStopped = true;

        // Generation count
        int generations = 0;
        int LivingCells = 0;

        //view settings
        bool showGrid = true;
        bool showNeighborCount = true;
        bool showHUD = true;

        public Form1()
        {
            InitializeComponent();
            // Setup the timer
            timer.Interval = timescale; // milliseconds
            timer.Tick += Timer_Tick;
            if (showHUD)
            {
                lb_UniverseSize.Text = "Universe Size: " + Rows.ToString() + "X" + Colls.ToString();
                if (board.getInfiniteUniverse())
                {
                    lb_BoundaryRules.Text = "Universe Rules: Infinite";
                }
                else
                {
                    lb_BoundaryRules.Text = "Universe Rules: Finite";
                }
            }
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // Increment generation count
            generations++;
            board.nextGeneration();
            // Update status strip generations
            lb_Generations.Text = "Generations = " + generations.ToString();
            int LivingCells = 0;
            foreach (Cell cell in board.universe)
            {
                if (cell.getIsAlive())
                    LivingCells++;
            }
            lb_LivingCells.Text = "Living Cells = " + LivingCells.ToString();
            graphicsPanel1.Refresh();
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

            BackColor = backgroundColor;

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
                    cellRect.Y = y * cellHeight;
                    cellRect.X = x * cellWidth;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (board.universe[y, x].getIsAlive())
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                        if (showNeighborCount)
                        {
                            Font drawFont = new Font("Arial", 16);
                            SolidBrush drawBrush = new SolidBrush(Color.Black);
                            e.Graphics.DrawString(board.universe[y, x].getGenAlive().ToString(), drawFont, drawBrush, cellRect.X, cellRect.Y);
                        }
                    }

                    if (showGrid)
                    {
                        // Outline the cell with a pen
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }
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

                if (board.universe[x, y].getIsAlive())
                {
                    board.universe[x, y].setGenAlive(1);
                    LivingCells++;
                }
                else
                {
                    LivingCells--;
                    board.universe[x, y].setGenAlive(0);
                }

                lb_LivingCells.Text = "Living Cells = " + LivingCells.ToString();
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        //start the universe
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            timerStopped = false;
        }

        //pause the universe
        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerStopped = true;
        }

        //Reset the universe, the Darkness wins
        private void newUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            generations = 0;
            board.newUniverse(Rows, Colls);
            lb_Generations.Text = "Generations = " + generations.ToString();
            lb_LivingCells.Text = "Living Cells = " + LivingCells.ToString();
            graphicsPanel1.Refresh();
        }

        //advance one genertation in the universe
        private void nextGenerationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (timerStopped)
                NextGeneration();
        }

        //enter a seed to randomize the universe
        private void seedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleInput newSeedForm = new SingleInput();
            newSeedForm.lbl_Message.Text = "Seed for random Populatoin";
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

        // randomize the universe based on the curent time
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.newUniverse(Rows, Colls);
            DateTime dTime = DateTime.Now;
            board.randomUniverse((int)dTime.TimeOfDay.TotalSeconds);
            graphicsPanel1.Refresh();
        }

        // This is the Dialog and controles to resize the Universe
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
                lb_UniverseSize.Text = "Universe Size: " + Rows.ToString() + "X" + Colls.ToString();
            }
            else 
            { 
            }
            graphicsPanel1.Refresh();
            newSizeDialog.Dispose();
        }

        // This is the Dialog and controles to adjust the timescale
        private void timescaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleInput newTimefraim = new SingleInput();
            newTimefraim.lbl_Message.Text = "Please enter a new timeframe(milliseconds) as an intiger";
            if(newTimefraim.ShowDialog(this) == DialogResult.OK)
            {
                string timeframe = newTimefraim.txb_NewSeed.Text;
                timescale = Convert.ToInt32(timeframe);
                timer.Interval = timescale;
            }
            else { }
            newTimefraim.Dispose();
        }

        // This is the checkbox and controles to show/hide the grid
        private void chb_ShowGrid_Click(object sender, EventArgs e)
        {
            showGrid = !showGrid;
            chb_ShowGrid.Checked = showGrid;
            graphicsPanel1.Refresh();
        }

        // This is the checkbox and controles to show or hide neighbor count
        private void neighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showNeighborCount = !showNeighborCount;
            chb_ShowNeiborCount.Checked = showNeighborCount;
            graphicsPanel1.Refresh();
        }

        // This is the checkbox and controles show or hid the hud
        private void chb_ShowHUD_Click(object sender, EventArgs e)
        {
            showHUD = !showHUD;
            chb_ShowHUD.Checked = showHUD;
            statusHUD.Visible = showHUD;
            graphicsPanel1.Refresh();
        }

        // Save the current universe to a file
        private void saveUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerStopped = true;
            StreamWriter saveStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveStream = new StreamWriter(saveFileDialog.OpenFile())) != null)
                {
                    saveStream.WriteLine(Rows.ToString());
                    saveStream.WriteLine(Colls.ToString());
                    for (int y = 0; y < board.getHeight(); y++)
                    {
                        // Iterate through the universe in the x, left to right
                        for (int x = 0; x < board.getWidth(); x++)
                        {
                            saveStream.Write(board.universe[y, x].getGenAlive().ToString() + " ");
                        }
                        saveStream.WriteLine();
                    }
                            saveStream.Close();
                }
            }

        }

        // load a universe from a file
        private void loadUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerStopped = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            string filePath;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                StreamReader fileStream = new StreamReader(openFileDialog.OpenFile());

                Rows = Convert.ToInt32(fileStream.ReadLine());
                Colls = Convert.ToInt32(fileStream.ReadLine());

                board.newUniverse(Rows, Colls);

                for (int y = 0; y < board.getHeight(); y++)
                {
                    string[] cells = fileStream.ReadLine().Split(' ');
                    // Iterate through the universe in the x, left to right
                    for (int x = 0; x < board.getWidth(); x++)
                    {
                        int cellLife = Convert.ToInt32(cells[x]);
                        if(cellLife > 0)
                        {
                            board.universe[y, x].setIsAlive(true);
                            board.universe[y, x].setGenAlive(cellLife);
                        }
                        else
                        {
                            board.universe[y, x].setIsAlive(false);
                            board.universe[y, x].setGenAlive(cellLife);
                        }
                    }
                }
                fileStream.Close();
            }
            graphicsPanel1.Refresh();
        }

        //open the color context menu
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorControl colorControl = new ColorControl();

            //set the text for the color controls
            colorControl.lbl_gridColor.Text = "Grid Color: " + gridColor.ToString();
            colorControl.lbl_BackgroundColor.Text = "Background Color: " + backgroundColor.ToString();
            colorControl.lbl_CellColor.Text = "Cell Color: " + cellColor.ToString();

            if (colorControl.ShowDialog(this) == DialogResult.OK)
            {
                backgroundColor = colorControl.newBackgroundColor;
                gridColor = colorControl.newGridColor;
                cellColor = colorControl.newCellColor;
                graphicsPanel1.Refresh();
            }
            else { }
            colorControl.Dispose();
        }

        // Toggle between infinite and finite universes
        private void finiteUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.setInfiniteUniverse(!board.getInfiniteUniverse());
            chb_universeRules.Checked = board.getInfiniteUniverse();
            if (board.getInfiniteUniverse())
            {
                lb_BoundaryRules.Text = "Universe Rules: Infinite";
            }
            else
            {
                lb_BoundaryRules.Text = "Universe Rules: Finite";
            }
        }
    }
}
