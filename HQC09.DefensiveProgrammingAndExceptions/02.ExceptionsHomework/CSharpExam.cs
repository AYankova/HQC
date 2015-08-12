namespace ExceptionsHomework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore || value > MaxScore)
                {
                    throw new ArgumentOutOfRangeException("score", string.Format("The score should be in the range [{0}, {1}]", MinScore, MaxScore));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            if (this.Score < MinScore || this.Score > MaxScore)
            {
                throw new InvalidOperationException("Property Score has invalid value!");
            }

            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}