namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private ICollection<string> students;

        protected Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        protected Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string name, string teacherName, ICollection<string> students)
            : this(name, teacherName)
        {
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateName(value, "name");
                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            private set
            {
                Validator.ValidateName(value, "Teacher name");
                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }

            private set
            {
                Validator.ValidateIfNotNull(value, "students");
                this.students = value.ToList();
            }
        }

        public void AddStudent(params string[] students)
        {
            foreach (var student in students)
            {
                Validator.ValidateName(student, "new student");
                this.students.Add(student);
            }
        }

        public string GetStudentsAsString()
        {
            string result = string.Format("{{ {0} }}", string.Join(", ", this.Students));
            return result;
        }

        public override string ToString()
        {
            string course = this.GetType().Name;
            string courseName = string.Format("Name = {0}", this.Name);
            string teacherName = string.Format("Teacher = {0}", this.TeacherName);
            string students = string.Format("Students = {0}", this.GetStudentsAsString());

            StringBuilder result = new StringBuilder();

            result.AppendLine(course)
                .AppendLine(courseName)
                .AppendLine(teacherName)
                .AppendLine(students);

            return result.ToString().TrimEnd();
        }
    }
}
