using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_3
{
    class Class2
    {
        public static void InitArray(out double[,] matr, int column, int row)
        {
            Random Rnd; Rnd = new Random();
            matr = new Double[row, column];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Math.Round(Rnd.Next(-20, 20) + Rnd.NextDouble(),2);
                }
            }
        }
        
        public static void CreateArray(out double[,] matr, int column, int row)
        {
            matr = new double[row, column];
        }
        public static void Raschet(double[,] matr, out string num)
        {
            int i, j, kol = 0;
            num = "";
            for (j = 0; j < matr.GetLength(1); j++)
            {
                for (i = 0; i < matr.GetLength(0); i++)
                {

                   double a = matr[i, j];
                    if (a < 0)
                    {
                        kol++;
                    }
                    
                }
                if (kol == i)
                {
                    num=num+Convert.ToString(j+1)+",";
                    
                }
                kol = 0;
            }
        }
    }
}
