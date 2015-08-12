namespace PersonGenerator
{
    using System;

    public class PersonGenerator
    {
        public static void Main()
        {
            Person female = new Person();
            female = female.MakePerson(21);
            Person male = new Person();
            male = male.MakePerson(22);

            Console.WriteLine(female);
            Console.WriteLine(male);
        }
    }
}