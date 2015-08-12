namespace Student
{
    using System;

    /// <summary>
    /// A class that tests <see cref="Student"/> class.
    /// </summary>
    public class StudentMain
    {
        /// <summary>
        /// A method that tests the methods in <see cref="Student"/> class.
        /// </summary>
        public static void Main()
        {
            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));
            Student stella = new Student("Stela", "Markova", "Vidin", new DateTime(1993, 3, 11), "gamer,high results");

            Console.WriteLine("{0} is older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}