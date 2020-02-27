using System;

namespace MatrixLibrary
{
    public class MatrixException : Exception
    {
        //TODO: создать исключение

        public MatrixException() : base()
        {
            
        }
        public MatrixException(string message) : base(message)
        {
            // в аттрибутах теста напишем чето такое 
            // [TestCase(null, ExpectedException = typeof (MatrixDimensionExeption))]
            //если исключение не пользовательское, то mission failed.
        }
    }
}