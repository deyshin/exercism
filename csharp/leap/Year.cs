namespace Exercism.Year
{
    public class Year
    {
        public Year() { }

        public bool IsLeap(int i)
        {
            if ( i % 400 == 0)
            { return true; } 
            else if ( i % 100 == 0 )
            { return false; }
            else if ( i % 4 == 0)
            { return true; }
            else
            { return false; }
        }
    }
}