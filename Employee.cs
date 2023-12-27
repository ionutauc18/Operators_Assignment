namespace OperatorsAssignment
{
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // This is the overloaded "==" operator. It checks if the Id of two Employee objects are equal
        public static bool operator ==(Employee e1, Employee e2)
        {
            // If both objects are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(e1, e2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)e1 == null) || ((object)e2 == null))
            {
                return false;
            }

            // Return true if the fields match
            return e1.Id == e2.Id;
        }

        // This is the overloaded "!=" operator. It checks if the Id of two Employee objects are not equal
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }
    }
}
