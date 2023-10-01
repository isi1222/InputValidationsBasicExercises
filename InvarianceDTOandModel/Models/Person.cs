namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            isFirstNameValid(firstName);
            isLastNameValid(lastName);

            this.firstName = firstName; 
            this.lastName = lastName;
        }

        private void isFirstNameValid(string firstname)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
        }
        private void isLastNameValid(string lastname)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
        }
    }
}
