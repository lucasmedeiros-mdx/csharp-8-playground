using System;

namespace Playground.Core
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public int GetNameLength()
        {
            return this.FirstName.Length + (this.MiddleName?.Length ?? 0) + this.LastName.Length;
        }
    }
}
