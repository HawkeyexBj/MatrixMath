using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * File - RowVector.cs
 * Author: Jack Cannell
 */
namespace MatrixMath
{
    /// <summary>
    /// The Row Vector that describes data in _a matrix
    /// </summary>
    /// <typeparam name="Node"></typeparam>
    /// <param name=""></param>
    /// <param name=""></param>
    public class RowVector
    {
        /// <summary>
        /// Holds the data for the rows
        /// </summary>
        private Node<(int, int)>? _head;

        /// <summary>
        /// Returns the data from _head
        /// </summary>
        public Node<(int, int)>? Head => _head;

        /// <summary>
        /// Constructor for RowVector
        /// </summary>
        public RowVector()
        {
            _head = null;
        }

        /// <summary>
        /// This appends a cell to the RowVector
        /// </summary>
        /// <param name="col">The column to be appended</param>
        /// <param name="val">The value to add in</param>
        public void Append (int col, int val)
        {
            Node<(int, int)>? holder = _head;
            (int, int) tou = (col, val);
            if (_head != null)
            {
                while (holder!.Next != null)
                {
                    holder = holder.Next;
                }
                holder.Next = new(tou);
            }
            else
                _head = new(tou);
            //_head = holder;
        }

        /// <summary>
        /// Removes the node containing the touple listed
        /// </summary>
        /// <param name="touple">The touple to check for</param>
        /// <returns>A node of the touple listed</returns>
        public Node<(int, int)> Remove ((int, int) touple)
        {
            //If head is null, we want to return that anyway
            if (_head != null) 
            {
                Node<(int, int)> hold = _head!;
                while (hold.Next != null)
                {
                    if (hold.Data.Item1 == touple.Item1)
                    {
                        Node<(int, int)> returner = hold.Next;
                        hold.Next = hold.Next.Next;
                        return returner;
                    }
                    else
                    {
                        hold = hold.Next;
                    }

                }
            }
            
            //We want to return null of we cannot find hold.Next to be the touple
            return null!;
        }

        /// <summary>
        /// Returns _a space separated string containging all the data in this val vector
        /// </summary>
        /// <returns>_a space separated string containging all the data in this val vector</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<(int, int)> holder = _head!;
            if(holder != null)
            {
                while (holder.Next != null)
                {
                    sb.Append("(" + holder.Data.Item1 + ", ");
                    sb.Append(holder.Data.Item2 + ") ");
                    holder = holder.Next;
                }
                sb.Append("(" + holder.Data.Item1 + " ,");
                sb.Append(holder.Data.Item2 + ") ");
            }
            
            return sb.ToString();
        }
    }
}
