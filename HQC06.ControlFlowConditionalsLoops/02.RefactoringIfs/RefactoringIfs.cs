namespace RefactoringIfs
{
    using System;

    public class RefactoringIfs
    {
        public static void Main()
        {
            /*
            Potato potato;
            //... 
            if (potato != null)
               if(!potato.HasNotBeenPeeled && !potato.IsRotten)
                Cook(potato);
            */

            Potato potato = new Potato();

            if (potato != null)
            {
                var notPeeled = !potato.IsPeeled;
                var notRotten = !potato.IsRotten;

                if (notPeeled && notRotten)
                {
                    potato.Cook();
                }
            }

            /*
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
                VisitCell();
            }
            */

            const int MinX = 1;
            const int MaxX = 100;
            const int MinY = 1;
            const int MaxY = 100;

            int x = 5;
            int y = 10;
            bool shouldVisitCell = true;

            if (shouldVisitCell && InRange(x, MinX, MaxX) && InRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        public static bool InRange(int value, int min, int max)
        {
            bool inRange = min <= value && value <= max;

            return inRange;
        }

        public static void VisitCell()
        {
            Console.WriteLine("Hello there!");
        }
    }
}
