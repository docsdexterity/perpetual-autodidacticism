using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {   
        static void Main(string[] args)
        {
            // 2D Arrays
            // A 2D Array looks like this:
            // [[1,2,3],
            //  [4,5,6]]
            // So, basically every element inside a 2D array is an array.

            // [,] tells C# that it is a two dimensional array (basically, it's the number of commas)
            // so, for instance, one comma means 2D array
            int[,] arr2D =
            {
                {1,3,7,9},
                {2,4,5,6},
                {0,1,0,1}
            };

            // for declaring specific rows and columns
            int[,] myArr = new int[2, 3];
            // no of rows is 2 i.e. there are 2 elements in 2D array
            // and no of cols is 3 i.e. each element of 2D array will have 3 values

            // Console.WriteLine(arr2D[0,3]); 
            // arr2D[row, col] so basically if row is 0, then it's the first element of 2D array
            // and column value specifies the index of the element that we want to access in the first element of 2D array

            // Print out elements of 2D array
            int numRows = arr2D.GetLength(0);
            int numCols = arr2D.GetLength(1);

            for (int i = 0; i < numRows; i++) // For each value of i, the inner loop (the j loop) will execute.
            {
                for (int j = 0; j < numCols; j++) // iterates over the columns within the current row.
                {
                    // For each value of j,
                    // the code accesses and prints the element at the current row i and column j using arr2D[i, j].
                    Console.Write(arr2D[i, j] + " "); // " " is appended with arr2D[i, j] to add space between elements
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
