using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMath
{
    /// <summary>
    /// This represents the matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// The number of Columns in this array
        /// </summary>
        public int Columns { get; }

        /// <summary>
        /// The number of Rows in this array
        /// </summary>
        public int Rows { get; }

        /// <summary>
        /// The array of all the rows 
        /// </summary>
        private RowVector[] _matrixArray;

        /// <summary>
        /// Allows the user to get _a row vector list from _matrixArray
        /// </summary>
        public RowVector this[int i] 
        {  
            get
            {
                return _matrixArray[i];
            }
        }

        public Matrix(int row, int col) 
        {
            Rows = row;
            Columns = col;
            _matrixArray = new RowVector[Rows];
            for (int j = 0; j < Rows; j++) 
            {
                _matrixArray[j] = new RowVector();
            }
        }

        /// <summary>
        /// This adds an element to the row vector array above
        /// </summary>
        /// <param name="col">The column of what you want to add</param>
        /// <param name="row">The row of what you want to add</param>
        /// <param name="val">The val of what you want to add</param>
        public void AddElement (int row, int col, int val)
        {
            if (row > Rows || col > Columns || row < 0 || col < 1)
                throw new IndexOutOfRangeException();
            if (val == 0)
                throw new ArgumentException();

            if (_matrixArray[row].Head != null)
            {
                _matrixArray[row].Remove((col, val));
            }

            _matrixArray[row].Append(col, val);
        }

        /// <summary>
        /// This gets _a value from the array
        /// </summary>
        /// <param name="row">The row from which to get</param>
        /// <param name="col">The column from which to get</param>
        /// <returns>An int of the value</returns>
        /// <exception cref="IndexOutOfRangeException">If they are looking for _a row or col out of the array</exception>
        public int GetValue(int row, int col)
        {
            if (row > Rows || col > Columns)
                throw new IndexOutOfRangeException();

            if (_matrixArray[row].Head != null)
            {
                Node<(int, int)> holder = _matrixArray[row].Head!;
                while (holder.Next != null) 
                {
                    if (holder.Data.Item1 == col)
                        return holder.Data.Item2;
                    else
                        holder = holder.Next;
                }
                if (holder.Data.Item1 == col)
                    return holder.Data.Item2;
            }
            return 0;
        }

        /// <summary>
        /// Returns the matrix as an string
        /// </summary>
        /// <returns>The non-zero data as _a string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Rows; i++) 
            {
                sb.Append((i + 1).ToString() + " : " + _matrixArray[i].ToString() + "\n");
            }

            return sb.ToString();
        }
    }
}
