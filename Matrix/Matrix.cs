using System;

namespace MatrixLib
{
    //TODO: Create custom exception "MatrixException"
    
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        /// <summary>
        /// Rows property
        /// </summary>
        /// <value>
        /// Gets the row count
        /// </value>
        public int Rows
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Columns property
        /// </summary>
        /// <value>
        /// Gets the column count
        /// </value>
        public int Columns
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Array property
        /// </summary>
        /// <value>
        /// Gets the 2D array 
        /// </value>
        public double[,] Array
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="rows">Matrix row count</param>
        /// <param name="columns">Matrix column count</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when at least one of the parameters is negative.
        /// </exception>
        public Matrix(int rows, int columns)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Matrix"/> class.
        /// </summary>
        /// <param name="array">2D array to create <see cref="Matrix"/> instance on it.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Matrix(double[,] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Indexer to allow client code to use [] notation.
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public double this[int index1, int index2]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new instance of a <see cref="Matrix"/> class with the same value as an existing instance.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public object Clone()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds two matrices and returns the result.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>New <see cref="Matrix"/> object which is sum of two matrices.</returns>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator +(Matrix first, Matrix second)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subtracts two matrices and returns the result.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>New <see cref="Matrix"/> object which is subtraction of two matrices</returns>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator -(Matrix first, Matrix second)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Multiplies two matrices and returns the result.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>New <see cref="Matrix"/> object which is multiplication of two matrices.</returns>
        /// <exception cref="MatrixException"></exception>
        public static Matrix operator *(Matrix first, Matrix second)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Adds <see cref="Matrix"/> object from params to the current object.
        /// </summary>
        /// <param name="other"><see cref="Matrix"/> object for adding.</param>
        /// <exception cref="MatrixException"></exception>
        public void Add(Matrix other)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Subtracts from current object <see cref="Matrix"/> from params.
        /// </summary>
        /// <param name="other"><see cref="Matrix"/> object to subtract.</param>
        /// <exception cref="MatrixException"></exception>
        public void Subtract(Matrix other)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Multiply current object on <see cref="Matrix"/> object from params.
        /// </summary>
        /// <param name="other"><see cref="Matrix"/> object for multiplying.</param>
        /// <exception cref="MatrixException"></exception>
        public void Multiply(Matrix other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a boolean indicating if the <see cref="Matrix"/> from params is equal to the current object.
        /// </summary>
        /// <param name="other"><see cref="Matrix"/> object to compare with. (Can be null)</param>
        /// <returns>True if matrices are equal, false if are not equal.</returns>
        /// <exception cref="MatrixException">Thrown when matrices are incomparable.</exception>
        public bool Equals(Matrix other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates 2D array that representing current <see cref="Matrix"/> object. 
        /// </summary>
        /// <returns>2D array with the same value as current <see cref="Matrix"/> object.</returns>
        public double[,] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}