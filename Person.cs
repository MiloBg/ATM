using System;

namespace ATM
{
    public class Person
    {
        // Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Type UserType { get; set; }
        // Constructor
        public Person(string firstName, string lastName, Type userType)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            UserType = userType;
        }
        // Methods
        public void ChangeLastName(string newLastName) {
            LastName = newLastName;
        }
    }
    public enum Type
    {
        LegalEntity,
        Individual
    }
}