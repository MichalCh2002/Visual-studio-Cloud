using System.Text;

namespace GameOfLife
{
    class Life
    {
        private static int[][] neighbours = new[]
        {
            new[] { -1, -1 },
            new[] { -1, 0 },
            new[] { -1, 1 },
            new[] { 0, -1 },
            new[] { 0, 1 },
            new[] { 1, -1 },
            new[] { 1, 0 },
            new[] { 1, 1 }
        };

        private bool[,] cells;

        public Life(bool[,] cells)
        {
            this.cells = cells;
        }

        public void Draw(char live, out string str)
        {
            str = "";

            for (var y = 0; y < cells.GetLength(0); y++)
            {
                for (var x = 0; x < cells.GetLength(1); x++)
                {
                    if (cells[y, x])
                    {
                        str += live;
                    }
                    else
                    {
                        str += ' ';
                    }
                }

                str += '\n';
            }
        }

        private int GetLNCount(int y, int x)
        {
            var count = 0;

            foreach (var n in neighbours)
            {
                try
                {
                    if (cells[y + n[0], x + n[1]]) count++;
                }
                catch { }
            }

            return count;
        }

        public void NextGen()
        {
            var h = cells.GetLength(0);
            var v = cells.GetLength(1);

            var arr = new bool[h, v];

            for (var y = 0; y < h; y++)
            {
                for (var x = 0; x < v; x++)
                {
                    var ln = GetLNCount(y, x);

                    if (cells[y, x])
                    {
                        arr[y, x] = ln == 2 || ln == 3;
                    }
                    else
                    {
                        arr[y, x] = ln == 3;
                    }
                }
            }

            cells = arr;
        }
    }
}
