using System;

namespace MatrixLibrary
{
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        public int Rows
        {
            get => _rows;
            set => _rows = value;
        }

        public int Columns
        {
            get => _columns;
            set => _columns = value;
        }

        public double[,] Array
        {
            get => _array;
            set => _array = value;
        }

        private double[,] _array;
        private int _rows;
        private int _columns;

        public Matrix(int rows, int columns)
        {
            this._rows = rows;
            this._columns = columns;
            this._array = new double[_rows,_columns];
        }
        
        public Matrix(double[,] array)
        {
            this._array = array;
            this._rows = _array.GetLength(0);
            this._columns = _array.GetLength(1);
        }
        public double this[int index1, int index2]
        {
            #region CompletedTask
            get
            {
                try
                {
                    return _array[index1, index2];
                }
                catch
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            set
            {
                try
                {
                    _array[index1, index2] = value;
                }
                catch
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            

            #endregion
        }
        
        public object Clone()
        {
            Matrix deepCopy = new Matrix(this._array);

            return deepCopy;
        }
        
        public static Matrix operator +(Matrix first, Matrix second)
        {
            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, first.Columns);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Columns; j++)
                    {
                        result[i, j] = first[i, j] + second[i, j];
                    }
                }

                return result;
            }
            catch
            {
                throw new MatrixException("Dimensions are different.");
            }

            #endregion
        }
        
        public static Matrix operator -(Matrix first, Matrix second)
        {
            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, first.Columns);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Columns; j++)
                    {
                        result[i, j] = first[i, j] - second[i, j];
                    }
                }

                return result;
            }
            catch
            {
                throw new MatrixException("Dimensions are different.");
            }

            #endregion
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, second.Columns);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < second.Columns; j++)
                    {
                        result[i, j] = 0;

                        for (int k = 0; k < first.Rows; k++)
                        {
                            result[i, j] += first[i, k] * second[k, j];
                        }

                    }
                }

                return result;
            }
            catch
            {
                throw new MatrixException("Dimensions are different.");
            }

            #endregion
        }
        
        public static Matrix Sum(Matrix first, Matrix second)
        {
            return first + second;
        }

        public static Matrix Minus(Matrix first, Matrix second)
        {
            return first - second;
        }
        
        public static Matrix Multiply(Matrix first, Matrix second)
        {
            return first * second;
        }
        
        public bool Equals(Matrix other)
        {
            //TODO: переопределить операцию Equals
            // if null -> false, wrong type -> exception
            try
            {
                if (other is null)
                {
                    return false;
                }
                
                if (!(other is Matrix))
                {
                    throw new NotSupportedException();
                }

                if (this._columns != other._columns && this._rows != other._rows)   
                {
                    throw new MatrixException();
                }
                
                for (int i = 0; i < other._rows; i++)
                {
                    for (int j = 0; j < other._columns; j++)
                    {
                        if (_array[i, j] != other.Array[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }
        
        public double[,] ToArray()
        {
            var deepcopy = new double[this._rows, this._columns];

            for (int i = 0; i < this._rows; i++)
            {
                for (int j = 0; j < this._columns; j++)
                {
                    deepcopy[i, j] = this._array[i, j];
                }
            }
            
            return deepcopy;
        }
    }
}