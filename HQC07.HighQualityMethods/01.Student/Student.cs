namespace Student
{
    using System;

    /// <summary>
    /// A public class that holds an information for students' first name, last name, hometown, date of birth and option for additional comments.
    /// Provides method for comparing two students by birthdate.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">First name of the student.</param>
        /// <param name="lastName">Last name of the student.</param>
        /// <param name="town">Hometown of the student.</param>
        /// <param name="birthDate">The date of birth of the student.</param>
        /// <param name="comments">Optional comments for every student.</param>
        public Student(string firstName, string lastName, string town, DateTime birthDate, string comments = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Town = town;
            this.BirthDate = birthDate;
        }

        /// <summary>
        /// Gets or sets the first name of the student.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the hometown of the student.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the student.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets comments for the student.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// A method for comparing two students by birthdate.
        /// </summary>
        /// <param name="otherStudent">Parameter of type <see cref="Student"/></param>
        /// <returns>Boolean value - true if first student is older than the second and false if second is older than the first or they are the same age.</returns>
        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate < otherStudent.BirthDate;
        }
    }
}