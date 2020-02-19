using System;

namespace MatrixLibrary
{
    [Serializable]
    public struct Matrix : ICloneable
    {
        public readonly int Rows;
        public readonly int Columns;
        private double[,] array;
        
        public Matrix(int rows, int columns, double[,] array)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.array = array;
        }

        public object Clone()
        {
            //TODO: Реализовать интерфейс
            
            #region CompletedTask
            double[,] temparray = new double[this.Rows, this.Columns];
            temparray = (double[,])array.Clone();

            return new Matrix(this.Rows, this.Columns, temparray);
            #endregion
        }

        public double this[int index1, int index2]
        {
            //TODO: создать индексатор
            
            #region CompletedTask
            get
            {
                try
                {
                    return array[index1, index2];
                }
                catch
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            private set
            {
                try
                {
                    array[index1, index2] = value;
                }
                catch
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            

            #endregion
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            //TODO: Перегрузить оператор 
            
            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, first.Columns, new double[first.Rows, first.Columns]);
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
                throw new MatrixDimensionExeption("Dimensions are different.");
            }

            #endregion
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            //TODO: Перегрузить оператор 

            
            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, first.Columns, new double[first.Rows, first.Columns]);
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
                throw new MatrixDimensionExeption("Dimensions are different.");
            }

            #endregion
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            //TODO: Перегрузить оператор 

            #region CompletedTask

            try
            {
                Matrix result = new Matrix(first.Rows, second.Columns, new double[first.Rows, first.Columns]);
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
                throw new MatrixDimensionExeption("Dimensions are different.");
            }

            #endregion
        }

        public override bool Equals(Object obj)
        {
            //TODO: переопределить операцию Equals

            #region CompletedTask

            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;

            Matrix matrix = (Matrix)obj;

            for (int i = 0; i < matrix.Rows; i++)

            for (int j = 0; j < matrix.Columns; j++)

                if (matrix[i, j] != this[i, j])
                    return false;

            return true;

            #endregion
            
        }
    }
}