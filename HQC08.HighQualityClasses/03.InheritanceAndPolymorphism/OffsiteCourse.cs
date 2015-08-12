namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name, string teacherName, ICollection<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            private set
            {
                Validator.ValidateName(value, "Town");
                this.town = value;
            }
        }

        public override string ToString()
        {
            string newFeatures = string.Format("\nTown = {0}", this.Town);
            return base.ToString() + newFeatures;
        }
    }
}