using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * File - MatrixMath.cs
 * Author: Jack Cannell
 */
namespace MatrixMath
{
    /// <summary>
    /// This houses all the math needed to be done on matrixes
    /// </summary>
    public class MatrixMath
    {
        /// <summary>
        /// Adds two matrecies together
        /// </summary>
        /// <param name="a">The first matrix to add</param>
        /// <param name="b">The second matrix to add</param>
        /// <returns>The added matrix</returns>
        public Matrix Add (Matrix a, Matrix b)
        {
            Matrix holder = new Matrix(a.Rows, a.Columns);

            if ((a.Rows == b.Rows) && (a.Columns == b.Columns))
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        int val = a.GetValue(i, j + 1) + b.GetValue(i, j + 1);
                        if (val != 0)
                        {
                            holder.AddElement(i, j + 1, val);
                        }
                    }
                }
            }


            return holder;
        }

        /// <summary>
        /// This subtracts B from A
        /// </summary>
        /// <param name="a">The base matrix from which B gets subtracted</param>
        /// <param name="b">The matrix which does the subtracting</param>
        /// <returns>A new matrix of _a - _b</returns>
        public Matrix Subtract (Matrix a, Matrix b) 
        {
            Matrix holder = new Matrix(a.Rows, a.Columns);

            if ((a.Rows == b.Rows) && (a.Columns == b.Columns))
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        int val = a.GetValue(i, j+1) - b.GetValue(i, j+1);
                        if (val != 0)
                        {
                            holder.AddElement(i, j+1, val);
                        }
                    }
                }
            }


            return holder;
        }

        /// <summary>
        /// Transposes _a matrix
        /// </summary>
        /// <param name="a">The matrix to be transposed</param>
        /// <returns>_a new matrix (holder) which is A’s transpose</returns>
        public Matrix Transpose (Matrix a)
        {
            Matrix holder = new Matrix(a.Columns, a.Rows);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    if (a.GetValue(i, j + 1) != 0)
                        holder.AddElement(j, i+1, a.GetValue(i, j + 1));
                }
            }

            return holder;
        }



        /// <summary>
        /// This multiplies two matrixes together
        /// </summary>
        /// <param name="a">The first matrix to be multiplied</param>
        /// <param name="b">The second matrix to be multiplied</param>
        /// <returns>A new matrix consisting of A * B</returns>
        public Matrix Multiply (Matrix a, Matrix b) 
        {
            Matrix holder = new Matrix(a.Rows, b.Columns);

            if (a.Columns == b.Rows)
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    if (a[i].Head != null)
                    {
                        for (int k = 0; k < b.Columns; k++)
                        {
                            int cellTotal = 0;
                            for (int j = 0; j < b.Rows; j++) 
                            {
                                cellTotal += a.GetValue(i, j + 1) * b.GetValue(j, k + 1);
                                if (cellTotal != 0 && j == b.Rows - 1)
                                {
                                    holder.AddElement(i, k+1, cellTotal);
                                }
                            }
                        }
                    }
                }
            }

            return holder;
        }

    }
}
