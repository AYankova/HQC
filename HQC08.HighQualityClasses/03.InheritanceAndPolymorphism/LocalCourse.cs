namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name, string teacherName, ICollection<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            private set
            {
                Validator.ValidateName(value, "Lab");
                this.lab = value;
            }
        }

        public override string ToString()
        {
            string newFeatures = string.Format("\nLab = {0}", this.Lab);
            return base.ToString() + newFeatures;
        }
    }
}