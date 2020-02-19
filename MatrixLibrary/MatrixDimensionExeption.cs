using System;

namespace MatrixLibrary
{
    public class MatrixDimensionExeption : Exception
    {
        //TODO: создать исключение
        public MatrixDimensionExeption(string message) : base(message)
        {
            //найс у меня исключение было, да?
            // в аттрибутах теста напишем чето такое 
            // [TestCase(null, ExpectedException = typeof (MatrixDimensionExeption))]
            //если исключение не пользовательское, то mission failed.
        }
    }
}