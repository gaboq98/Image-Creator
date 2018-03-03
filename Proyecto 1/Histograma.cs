using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1
{
    class Histograma
    {

        public static void Main()
        {
            Bitmap bmp = new Bitmap("C:\\Users\\gaboq\\Desktop\\Gabo\\7.png");
            int x = 0;
        }

        private int[,] Divide(int row, int column, int[,] matrix)
        {
            int auxRow = matrix.Length / 3;
            int auxColumn = matrix.GetLength(0) / 3;
            int[,] auxMatrix = new int[auxColumn, auxRow];

            int indexI = 0;
            int indexJ = 0;
            int stop = auxColumn * (column + 1);

            if (column == 2 && (auxColumn % 3) == 0)
            {
                auxMatrix = new int[auxColumn + 2, auxRow];
            }
            for (int i = auxRow * row; i < auxRow * (row + 1); i++)
            {
                for (int j = auxRow * row; j < auxRow * (row + 1); j++)
                {
                    auxMatrix[indexI, indexJ] = matrix[i, j];
                    indexJ++;
                }
                indexI++;
                indexJ = 0;
            }

            return auxMatrix;
        }


        private int[,] Histogram(Bitmap bitmap)
        {
            int[,] histogram = new int[3, 255];

            byte red = 0;
            byte green = 0;
            byte blue = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    red = bitmap.GetPixel(i, j).R;
                    green = bitmap.GetPixel(i, j).G;
                    blue = bitmap.GetPixel(i, j).B;

                    histogram[0, red] += 1;
                    histogram[0, green] += 1;
                    histogram[0, blue] += 1;
                }
            }
            

            return histogram;
        }



    }
}
