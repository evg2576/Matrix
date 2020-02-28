using System;

namespace MatrixLibrary
{
    public class MatrixException
    {
        //TODO: создать исключение
    }
    
    public class Matrix : ICloneable, IEquatable<Matrix>
    {
        public int Rows
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int Columns
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public double[,] Array
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        
        public Matrix(int rows, int columns)
        {
            throw new NotImplementedException();
        }
        
        public Matrix(double[,] array)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Matrix matrix)
        {
            throw new NotImplementedException();
        }
    }
}