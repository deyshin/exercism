using System;
namespace Exercism.DifferenceOfSqures
{
    public class Squares
    {
        private int _max;

        public Squares (int m)
        { _max = m;}


        public int SquareOfSums()
        {
            var sum = (int)0;

            for (int i = 1; i <= _max; i++)
            { sum += i; }

            var square = (int)Math.Pow(sum, 2);

            return square;
        }

        public int SumOfSquares()
        {
            return (int)0;
        }

        public int DifferenceOfSquares()
        {
            return (int)0;
        }
    }
}