namespace ExceptionsHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinValueProblemSolved = 0;
        private const int MaxValueProblemSolved = 10;
        private const int BadGrade = 2;
        private const int AverageGrade = 5;
        private const int GoodGrade = 8;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < MinValueProblemSolved || value > MaxValueProblemSolved)
                {
                    throw new ArgumentOutOfRangeException("problemsSolved", string.Format("Value of the solved problems must be between [{0}, {1}]!", MinValueProblemSolved, MaxValueProblemSolved));
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            string comments;

            if (this.ProblemsSolved <= BadGrade)
            {
                comments = "Bad result";
            }
            else if (this.ProblemsSolved <= AverageGrade)
            {
                comments = "Average result";
            }
            else if (this.ProblemsSolved <= GoodGrade)
            {
                comments = "Good result";
            }
            else
            {
                comments = "Excellent result";
            }

            return new ExamResult(this.ProblemsSolved, MinValueProblemSolved, MaxValueProblemSolved, comments);
        }
    }
}