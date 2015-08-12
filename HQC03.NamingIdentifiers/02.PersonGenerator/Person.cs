namespace PersonGenerator
{
    using System;

    public class Person
    {
        private const string MaleName = "Pesho";
        private const string FemaleName = "Petranka";
        private Gender gender;
        private string name;
        private int age;

        public Person()
        {
        }

        public Person(string name, int age, Gender gender)
            : this()
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                this.gender = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public Person MakePerson(int age)
        {
            var person = new Person();

            person.Age = age;

            int ageRemainder = age % 2;

            if (ageRemainder == 0)
            {
                person.Name = MaleName;
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = FemaleName;
                person.Gender = Gender.Female;
            }

            return person;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.Age, this.Gender);
        }
    }
}