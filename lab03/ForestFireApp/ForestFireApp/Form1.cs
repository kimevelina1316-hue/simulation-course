using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForestFireApp
{
    public partial class Form1 : Form
    {
        enum CellState { Empty = 0, Tree = 1, Fire = 2, Barrier = 3 }

        int size = 50;
        int cellSize = 10;
        int[,] grid;
        int[,] nextGrid;
        Random rand = new Random();
        bool isRunning = false;

        // Флаги активных правил
        bool useWind = false;
        bool useLightning = false;
        bool useBarrier = false;

        // Параметры
        double probGrowth = 0.01;
        double probLightning = 0.005;   // Увеличил для заметности
        int windDirection = 1;
        double windFactor = 0.7;        // Увеличил для эффекта

        public Form1()
        {
            InitializeComponent();
            SetupGrid();
            DrawGrid();
            timerSim.Tick += TimerSim_Tick;

            // Инициализация RadioButton
            rbNoRules.Checked = true;
            UpdateRulesFromRadioButtons();
        }

        // === Обновление правил из RadioButton ===
        private void UpdateRulesFromRadioButtons()
        {
            useWind = rbWind.Checked || rbAllRules.Checked;
            useLightning = rbLightning.Checked || rbAllRules.Checked;
            useBarrier = rbBarrier.Checked || rbAllRules.Checked;

            // Пересоздаём сетку с учётом преград
            if (useBarrier)
                CreateBarrier();
            else if (grid != null)
                SetupGrid(); // Пересоздать без преград

            DrawGrid();
        }

        // === Обработчики RadioButton ===
        private void rbNoRules_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoRules.Checked) UpdateRulesFromRadioButtons();
        }

        private void rbWind_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWind.Checked) UpdateRulesFromRadioButtons();
        }

        private void rbLightning_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLightning.Checked) UpdateRulesFromRadioButtons();
        }

        private void rbBarrier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBarrier.Checked) UpdateRulesFromRadioButtons();
        }

        private void rbAllRules_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllRules.Checked) UpdateRulesFromRadioButtons();
        }

        void SetupGrid()
        {
            grid = new int[size, size];
            nextGrid = new int[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    grid[x, y] = rand.NextDouble() < 0.7 ? (int)CellState.Tree : (int)CellState.Empty;
                }
            }

            // Преграды создаются только если выбрано соответствующее правило
            if (useBarrier)
                CreateBarrier();
        }

        void CreateBarrier()
        {
            int mid = size / 2;
            for (int i = 0; i < size; i++)
            {
                grid[i, mid] = (int)CellState.Barrier;
            }
        }

        void DrawGrid()
        {
            Bitmap bmp = new Bitmap(pbGrid.Width, pbGrid.Height);
            Graphics g = Graphics.FromImage(bmp);

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Color color = Color.Black;
                    switch ((CellState)grid[x, y])
                    {
                        case CellState.Tree: color = Color.Green; break;
                        case CellState.Fire: color = Color.Red; break;
                        case CellState.Barrier: color = Color.Blue; break;
                        case CellState.Empty: color = Color.Black; break;
                    }

                    g.FillRectangle(new SolidBrush(color),
                        x * cellSize, y * cellSize, cellSize, cellSize);
                }
            }
            pbGrid.Image = bmp;
        }

        void UpdateGrid()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    int state = grid[x, y];

                    // Преграда не меняется
                    if (state == (int)CellState.Barrier)
                    {
                        nextGrid[x, y] = (int)CellState.Barrier;
                        continue;
                    }

                    if (state == (int)CellState.Fire)
                    {
                        nextGrid[x, y] = (int)CellState.Empty;
                    }
                    else if (state == (int)CellState.Tree)
                    {
                        int fireNeighbors = 0;
                        bool hasWindSideFire = false;

                        for (int dx = -1; dx <= 1; dx++)
                        {
                            for (int dy = -1; dy <= 1; dy++)
                            {
                                if (dx == 0 && dy == 0) continue;

                                int nx = x + dx;
                                int ny = y + dy;

                                if (nx >= 0 && nx < size && ny >= 0 && ny < size)
                                {
                                    if (grid[nx, ny] == (int)CellState.Fire)
                                    {
                                        fireNeighbors++;

                                        // ПРАВИЛО 1: ВЕТЕР (только если включено)
                                        if (useWind && dx == windDirection && dy == 0)
                                        {
                                            hasWindSideFire = true;
                                        }
                                    }
                                }
                            }
                        }

                        // ПРАВИЛО 3: МОЛНИЯ (только если включено)
                        if (useLightning && rand.NextDouble() < probLightning)
                        {
                            nextGrid[x, y] = (int)CellState.Fire;
                        }
                        else if (fireNeighbors > 0)
                        {
                            if (useWind && hasWindSideFire)
                            {
                                // С ветром загорается точно
                                nextGrid[x, y] = (int)CellState.Fire;
                            }
                            else
                            {
                                // Без ветра или против ветра - с вероятностью
                                double catchFireProb = useWind ? (1 - windFactor) : 0.8;
                                nextGrid[x, y] = rand.NextDouble() < catchFireProb
                                    ? (int)CellState.Fire
                                    : (int)CellState.Tree;
                            }
                        }
                        else
                        {
                            nextGrid[x, y] = (int)CellState.Tree;
                        }
                    }
                    else if (state == (int)CellState.Empty)
                    {
                        nextGrid[x, y] = rand.NextDouble() < probGrowth
                            ? (int)CellState.Tree
                            : (int)CellState.Empty;
                    }
                }
            }

            Array.Copy(nextGrid, grid, grid.Length);
        }

        private void TimerSim_Tick(object sender, EventArgs e)
        {
            UpdateGrid();
            DrawGrid();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                timerSim.Enabled = true;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            timerSim.Enabled = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            SetupGrid();
            DrawGrid();
        }

        private void btnIgnite_Click(object sender, EventArgs e)
        {
            int centerX = size / 2;
            int centerY = size / 2;

            for (int dx = -2; dx <= 2; dx++)
            {
                for (int dy = -2; dy <= 2; dy++)
                {
                    int nx = centerX + dx;
                    int ny = centerY + dy;
                    if (nx >= 0 && nx < size && ny >= 0 && ny < size)
                    {
                        if (grid[nx, ny] == (int)CellState.Tree)
                        {
                            grid[nx, ny] = (int)CellState.Fire;
                        }
                    }
                }
            }
            DrawGrid();
        }

        private void pbGrid_Click(object sender, EventArgs e)
        {
            Point mousePos = pbGrid.PointToClient(Cursor.Position);
            int x = mousePos.X / cellSize;
            int y = mousePos.Y / cellSize;

            if (x >= 0 && x < size && y >= 0 && y < size)
            {
                if (grid[x, y] == (int)CellState.Tree)
                {
                    grid[x, y] = (int)CellState.Fire;
                    DrawGrid();
                }
            }
        }

        private void rbWind_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}