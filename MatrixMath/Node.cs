
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * File - Node.cs
 * Author: Jack Cannell
 */
namespace MatrixMath
{
    /// <summary>
    /// The individual nodes
    /// </summary>
    /// <typeparam name="T">The type for this node</typeparam>
    public class Node<T> where T : notnull
    {
        /// <summary>
        /// The data we want to store in this node
        /// </summary>
        public T Data { get; }
        /// <summary>
        /// Get's the next node in the list
        /// </summary>
        public Node<T>? Next {get; set;}

        /// <summary>
        /// The constructor for _a new node
        /// </summary>
        /// <param name="d">The data we want to put in</param>
        public Node(T d)
        {
            Data = d;
        }
        /// <summary>
        /// Takes the data from Node and makes it _a string
        /// </summary>
        /// <returns>A string containing the data</returns>
        public override string ToString()
        {
            return Data.ToString()!;
        }

    }
}
