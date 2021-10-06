using System;

namespace MatrixLibrary
{
  class MatrixException : Exception
  {
    public MatrixException() { }
    public MatrixException(string message) : base(message) { }
    public MatrixException(string message, Exception inner) : base(message, inner) { }
  }

  public class Matrix : ICloneable
  {
    /// <summary>
    /// Number of rows.
    /// </summary>
    public int Rows
    {
      get { return Array.GetLength(0); }
    }

    /// <summary>
    /// Number of columns.
    /// </summary>
    public int Columns
    {
      get { return Array.GetLength(1); }
    }

    /// <summary>
    /// Gets an array of floating-point values that represents the elements of this Matrix.
    /// </summary>
    public double[,] Array
    {
      get;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Matrix"/> class.
    /// </summary>
    /// <param name="rows"></param>
    /// <param name="columns"></param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Matrix(int rows, int columns)
    {
      if (rows < 0 || columns < 0) throw new ArgumentOutOfRangeException();
      Array = new double[rows, columns];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Matrix"/> class with the specified elements.
    /// </summary>
    /// <param name="array">An array of floating-point values that represents the elements of this Matrix.</param>
    /// <exception cref="ArgumentNullException"></exception>
    public Matrix(double[,] array)
    {
      if (array == null) throw new ArgumentNullException();
      Array = array;
    }

    /// <summary>
    /// Allows instances of a Matrix to be indexed just like arrays.
    /// </summary>
    /// <param name="row"></param>
    /// <param name="column"></param>
    /// <exception cref="ArgumentException"></exception>
    public double this[int row, int column]
    {
      get
      {
        if (row < 0 || row > Rows || column < 0 || column > Columns)
          throw new ArgumentException();
        return Array[row, column];
      }
      set
      {
        if (row < 0 || row > Rows || column < 0 || column > Columns)
          throw new ArgumentException();
        Array[row, column] = value;
      }
    }

    /// <summary>
    /// Creates a deep copy of this Matrix.
    /// </summary>
    /// <returns>A deep copy of the current object.</returns>
    public object Clone()
    {
      return this.MemberwiseClone();
    }

    /// <summary>
    /// Adds two matrices.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>New <see cref="Matrix"/> object which is sum of two matrices.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public static Matrix operator +(Matrix matrix1, Matrix matrix2)
    {
      if (matrix1 == null || matrix2 == null)
        throw new ArgumentNullException();
      if(!matrix1.Equals(matrix2))
        throw new MatrixException("Matrices must be the same size");
      Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
      for (int i = 0; i < matrix1.Rows; i++)
      {
        for (int j = 0; j < matrix1.Columns; j++)
        {
          result.Array[i, j] = matrix1.Array[i, j] + matrix2.Array[i, j];
        }
      }
      return result;
    }

    /// <summary>
    /// Subtracts two matrices.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>New <see cref="Matrix"/> object which is subtraction of two matrices</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
      if (matrix1 == null || matrix2 == null)
        throw new ArgumentNullException();
      if (!matrix1.Equals(matrix2))
        throw new MatrixException("Matrices must be the same size");
      Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
      for (int i = 0; i < matrix1.Rows; i++)
      {
        for (int j = 0; j < matrix1.Columns; j++)
        {
          result.Array[i, j] = matrix1.Array[i, j] - matrix2.Array[i, j];
        }
      }
      return result;
    }

    /// <summary>
    /// Multiplies two matrices.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>New <see cref="Matrix"/> object which is multiplication of two matrices.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {
      if (matrix1 == null || matrix2 == null)
        throw new ArgumentNullException();
      if (matrix1.Columns != matrix2.Rows)
        throw new MatrixException("The number of columns in the" +
          " first matrix must be equal to the number of rows in the second matrix");
      Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);
      for (int i = 0; i < matrix1.Rows; i++)
      {
        for (int j = 0; j < matrix2.Columns; j++)
        {
          result.Array[i, j] = 0;
          for (int k = 0; k < matrix1.Columns; k++)
          {
            result.Array[i, j] += matrix1.Array[i, k] * matrix2.Array[k, j];
          }
        }
      }
      return result;
    }

    /// <summary>
    /// Adds <see cref="Matrix"/> to the current matrix.
    /// </summary>
    /// <param name="matrix"><see cref="Matrix"/> for adding.</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public Matrix Add(Matrix matrix)
    {
      if (matrix == null)
        throw new ArgumentNullException();
      if (!Equals(matrix))
        throw new MatrixException("Matrices must be the same size");
      return this + matrix;
    }

    /// <summary>
    /// Subtracts <see cref="Matrix"/> from the current matrix.
    /// </summary>
    /// <param name="matrix"><see cref="Matrix"/> for subtracting.</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public Matrix Subtract(Matrix matrix)
    {
      if (matrix == null)
        throw new ArgumentNullException();
      if (!Equals(matrix))
        throw new MatrixException("Matrices must be the same size");
      return this - matrix;
    }

    /// <summary>
    /// Multiplies <see cref="Matrix"/> on the current matrix.
    /// </summary>
    /// <param name="matrix"><see cref="Matrix"/> for multiplying.</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="MatrixException"></exception>
    public Matrix Multiply(Matrix matrix)
    {
      if (matrix == null)
        throw new ArgumentNullException();
      if (Columns != matrix.Rows)
        throw new MatrixException("The number of columns in the" +
          " first matrix must be equal to the number of rows in the second matrix");
      return this * matrix;
    }

    /// <summary>
    /// Tests if <see cref="Matrix"/> is identical to this Matrix.
    /// </summary>
    /// <param name="obj">Object to compare with. (Can be null)</param>
    /// <returns>True if matrices are equal, false if are not equal.</returns>
    public override bool Equals(object obj)
    {
      Matrix other = obj as Matrix;
      return (Rows == other.Rows && Columns == other.Columns);
    }

    public override int GetHashCode() => base.GetHashCode();
  }
}
