using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // X and Y units starting base for Universe
        const int xUniBase = 6;
        const int yUniBase = 5;

        // Creating Universe and ScratchPad arrays to be used throughout
        bool[,] universe = new bool[xUniBase, yUniBase];
        bool[,] scratchPad = new bool[xUniBase, yUniBase];

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Changable X and Y coordinates for universe
        int xUni = Properties.Settings.Default.UniverseWidth;
        int yUni = Properties.Settings.Default.UniverseHeight;

        // Bool values to choose what kind universe it is
        bool infiniteUniverse = Properties.Settings.Default.UniverseType;
        bool isHUDVisible = Properties.Settings.Default.HUDVisible;
        bool isNeighborCountVisible = Properties.Settings.Default.NeighborCountVisible;
        bool isGridVisible = Properties.Settings.Default.GridVisible;

        // Count how many cells were born
        int cellCount = 0;

        // Generation count
        int generations = 0;

        public Form1()
        {
            InitializeComponent();

            // Read Current Saved Settings to apply to created Universe and Scratchpad arrays
            universe = new bool[xUni, yUni];
            scratchPad = new bool[xUni, yUni];

            // Read Current Saved Settings for the Form App Apperance
            graphicsPanel1.BackColor = Properties.Settings.Default.BackgroundColor;
            cellColor = Properties.Settings.Default.CellColor;
            gridColor = Properties.Settings.Default.GridColor;

            // Checks to see if a menu item should be checked or not, based on last saved form
            toroidalUniverseToolStripMenuItem.Checked = infiniteUniverse;
            finiteUniverseToolStripMenuItem.Checked = !infiniteUniverse;
            viewHUDHeadsUpDisplayToolStripMenuItem.Checked = isHUDVisible;
            viewHUDHeadsUpDisplayToolStripMenuItem1.Checked = isHUDVisible;
            viewNeighborCountToolStripMenuItem.Checked = isNeighborCountVisible;
            viewNeighborCountToolStripMenuItem1.Checked = isNeighborCountVisible;
            viewGridToolStripMenuItem.Checked = isGridVisible;
            viewGridToolStripMenuItem1.Checked = isGridVisible;

            // Setup the timer
            timer.Interval = Properties.Settings.Default.TimeInterval; // milliseconds, reads from current saved settings
            TimerIntervalStatus.Text = "Timer Interval = " + timer.Interval;
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    if (infiniteUniverse)
                    {
                        int count = CountNeighborsToroidal(x, y);

                        DetermineCellState(x, y, count);
                    }
                    else
                    {
                        int count = CountNeighborsFinite(x, y);

                        DetermineCellState(x, y, count);
                    }
                }
            }

            // Copy scratchpad to universe
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;
            scratchPad = new bool[xUni, yUni];

            // Increment generation count
            generations++;

            // Update status strip generations and Cell Count
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelCellCount.Text = "Cell Count = " + cellCount.ToString();
            graphicsPanel1.Invalidate();
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
            float cellWidth = ((float) graphicsPanel1.ClientSize.Width) /  ((float) universe.GetLength(0));
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = ((float)graphicsPanel1.ClientSize.Height) / ((float)universe.GetLength(1));

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            Font font = new Font("Times New Roman", 16f);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRectF = RectangleF.Empty;
                    cellRectF.X = x * cellWidth;
                    cellRectF.Y = y * cellHeight;
                    cellRectF.Width = cellWidth;
                    cellRectF.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRectF);
                    }

                    // Show the count within the cell block
                    if (isNeighborCountVisible)
                    {
                        int neighbors;
                        if (infiniteUniverse)
                        {
                            neighbors = CountNeighborsToroidal(x, y);
                        }
                        else
                        {
                            neighbors = CountNeighborsFinite(x, y);
                        }

                        if (neighbors < 2 || neighbors > 3)
                        {
                            e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Red, cellRectF, stringFormat);
                        }
                        else
                        {
                            e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Green, cellRectF, stringFormat);
                        }
                    }

                    // Outline the cell with a pen
                    if (isGridVisible)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRectF.X, cellRectF.Y, cellRectF.Width, cellRectF.Height);
                    }
                }
            }

            // Display HUD
            if (isHUDVisible)
            {
                e.Graphics.DrawString("Heads Up Display!", font, Brushes.Black, 100, 50, stringFormat);
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
                float cellWidth = ((float)graphicsPanel1.ClientSize.Width) / ((float)universe.GetLength(0));
                float cellHeight = ((float)graphicsPanel1.ClientSize.Height) / ((float)universe.GetLength(1));

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = (int) (e.X / cellWidth);
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = (int) (e.Y / cellHeight);

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                if (universe[x,y] == true)
                {
                    cellCount++;
                }
                else if (!universe[x,y])
                {
                    cellCount--;
                }

                toolStripStatusLabelCellCount.Text = "Cell Count = " + cellCount.ToString();
                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        // Count Neighbors Functions
        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    // if xOffset and yOffset are both equal to 0 then continue
                    // if xCheck is less than 0 then continue
                    // if yCheck is less than 0 then continue
                    // if xCheck is greater than or equal too xLen then continue
                    // if yCheck is greater than or equal too yLen then continue
                    if ((xOffset == 0 && yOffset == 0) || (xCheck < 0) || (yCheck < 0) || (xCheck >= xLen) || (yCheck >= yLen))
                        continue;

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }

        private int CountNeighborsToroidal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset =-1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    // if xOffset and yOffset are both equal to 0 then continue
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    // if xCheck is less than 0 then set to xLen - 1
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    // if yCheck is less than 0 then set to yLen - 1
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    // if xCheck is greater than or equal too xLen then set to 0
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    // if yCheck is greater than or equal too yLen then set to 0
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }

        // Reuseable Functions
        private void DetermineCellState(int x, int y, int countNeighbor)
        {
            bool isAliveState = universe[x, y];
            
            // Living cells with 2 or 3 living, live next gen
            // Dead cells with exactly 3 living neighbors, live next gen
            if ((countNeighbor == 3 && isAliveState) || (countNeighbor == 2 && isAliveState) || (countNeighbor == 3 && !universe[x, y]))
            {
                // Cell with live and so will be saved into scratchPad
                scratchPad[x, y] = true;
                cellCount++;
            }
            // If living cells are less than 2 living OR If living cells more than 3 living, die next gen, die next gen
            else
            {
                // Cell will die and so will not be saved into scratchPad
                scratchPad[x, y] = false;
                if (cellCount != 0)
                    cellCount--;

            }
        }

        private int Randomize()
        {
            return 5;
        }

        private void ResetValues()
        {
            // Reset values
            universe = new bool[xUni, yUni];
            scratchPad = new bool[xUni, yUni];
            generations = 0;
            cellCount = 0;
            timer.Enabled = false;

            // Reset Text
            toolStripStatusLabelGenerations.Text = "Generations = " + generations;
            toolStripStatusLabelCellCount.Text = "Cell Count = " + cellCount;
            TimerIntervalStatus.Text = "Timer Interval = " + timer.Interval;
        }

        private void UniverseSettings()
        {
            CustomizeUniverse uniDialog = new CustomizeUniverse();

            int previousUniverseWidth = xUni;
            int previousUniverseHeight = yUni;

            if (DialogResult.OK == uniDialog.ShowDialog())
            {
                timer.Interval = uniDialog.MillSeconds;
                bool didWidthChange = previousUniverseWidth != uniDialog.UniverseWidth;
                bool didHeightChange = previousUniverseHeight != uniDialog.UniverseHeight;

                if (didWidthChange || didHeightChange)
                {
                    xUni = uniDialog.UniverseWidth;
                    yUni = uniDialog.UniverseHeight;
                    ResetValues();
                }

                TimerIntervalStatus.Text = "Timer Interval = " + timer.Interval;
                graphicsPanel1.Invalidate();
            }
        }

        private void BackgroundColorSettings()
        {
            ColorDialog background = new ColorDialog
            {
                Color = graphicsPanel1.BackColor
            };

            if (DialogResult.OK == background.ShowDialog())
            {
                graphicsPanel1.BackColor = background.Color;

                graphicsPanel1.Invalidate();
            }
        }

        private void CellColorSettings()
        {
            ColorDialog newCellColor = new ColorDialog
            {
                Color = cellColor
            };

            if (DialogResult.OK == newCellColor.ShowDialog())
            {
                cellColor = newCellColor.Color;

                graphicsPanel1.Invalidate();
            }
        }

        private void GridColorSettings()
        {
            ColorDialog newGridColor = new ColorDialog
            {
                Color = gridColor
            };

            if (DialogResult.OK == newGridColor.ShowDialog())
            {
                gridColor = newGridColor.Color;

                graphicsPanel1.Invalidate();
            }
        }

        private void ViewHUDSettings()
        {
            isHUDVisible = !isHUDVisible;
            viewHUDHeadsUpDisplayToolStripMenuItem.Checked = isHUDVisible;
            viewHUDHeadsUpDisplayToolStripMenuItem1.Checked = isHUDVisible;
            graphicsPanel1.Invalidate();
        }
        
        private void ViewNeighborCountSettings()
        {
            isNeighborCountVisible = !isNeighborCountVisible;
            viewNeighborCountToolStripMenuItem.Checked = isNeighborCountVisible;
            viewNeighborCountToolStripMenuItem1.Checked = isNeighborCountVisible;
            graphicsPanel1.Invalidate();
        }

        private void viewGridSettings()
        {
            isGridVisible = !isGridVisible;
            viewGridToolStripMenuItem.Checked = isGridVisible;
            viewGridToolStripMenuItem1.Checked = isGridVisible;
            graphicsPanel1.Invalidate();
        }

        // Every Click Events
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ResetValues();

            graphicsPanel1.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetValues();

            graphicsPanel1.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
           if (!timer.Enabled)
            {
               NextGeneration();
            }
        }

        private void NextButton_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Blank
        }

        private void backColoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundColorSettings();
        }

        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CellColorSettings();
        }

        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridColorSettings();
        }

        private void viewHUDHeadsUpDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHUDSettings();
        }

        private void viewNeighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewNeighborCountSettings();
        }

        private void viewGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewGridSettings();
        }

        private void universeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UniverseSettings();
        }

        private void finiteUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (infiniteUniverse == true)
            {
                toroidalUniverseToolStripMenuItem.Checked = false;
            }
            infiniteUniverse = false;
            finiteUniverseToolStripMenuItem.Checked = true;
        }

        private void toroidalUniverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (infiniteUniverse == false)
            {
                finiteUniverseToolStripMenuItem.Checked = false;
            }
            infiniteUniverse = true;
            toroidalUniverseToolStripMenuItem.Checked = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            // Revert Universe Settings to original base values
            xUni = Properties.Settings.Default.UniverseWidth;
            yUni = Properties.Settings.Default.UniverseHeight;
            infiniteUniverse = Properties.Settings.Default.UniverseType;
            timer.Interval = Properties.Settings.Default.TimeInterval;
            toroidalUniverseToolStripMenuItem.Checked = infiniteUniverse;
            finiteUniverseToolStripMenuItem.Checked = !infiniteUniverse;
            ResetValues();

            // Revert colors of Form to original base values
            graphicsPanel1.BackColor = Properties.Settings.Default.BackgroundColor;
            cellColor = Properties.Settings.Default.CellColor;
            gridColor = Properties.Settings.Default.GridColor;

            graphicsPanel1.Invalidate();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            // Revert Universe Settings to last saved settings
            xUni = Properties.Settings.Default.UniverseWidth;
            yUni = Properties.Settings.Default.UniverseHeight;
            infiniteUniverse = Properties.Settings.Default.UniverseType;
            timer.Interval = Properties.Settings.Default.TimeInterval;
            toroidalUniverseToolStripMenuItem.Checked = infiniteUniverse;
            finiteUniverseToolStripMenuItem.Checked = !infiniteUniverse;
            ResetValues();

            // Revert colors of Form to last saved settings
            graphicsPanel1.BackColor = Properties.Settings.Default.BackgroundColor;
            cellColor = Properties.Settings.Default.CellColor;
            gridColor = Properties.Settings.Default.GridColor;

            graphicsPanel1.Invalidate();
        }

        // Context Menu Click Events
        private void universeSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UniverseSettings();
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundColorSettings();
        }

        private void cellColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CellColorSettings();
        }

        private void gridColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GridColorSettings();
        }

        private void viewHUDHeadsUpDisplayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewHUDSettings();
        }

        private void viewNeighborCountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewNeighborCountSettings();
        }

        private void viewGridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewGridSettings();
        }

        // When Form is closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Saves current Forms appereance settings
            Properties.Settings.Default.BackgroundColor = graphicsPanel1.BackColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.GridColor = gridColor;

            // Saves current Universe Settings
            Properties.Settings.Default.UniverseHeight = xUni;
            Properties.Settings.Default.UniverseWidth = yUni;
            Properties.Settings.Default.TimeInterval = timer.Interval;
            Properties.Settings.Default.UniverseType = infiniteUniverse;

            Properties.Settings.Default.HUDVisible = isHUDVisible;
            Properties.Settings.Default.NeighborCountVisible = isNeighborCountVisible;
            Properties.Settings.Default.GridVisible = isGridVisible;

            Properties.Settings.Default.Save();
        }
    }
}
