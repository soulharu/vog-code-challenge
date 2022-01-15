namespace VogCodeChallenge.Domain.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string MailingAddress { get; set; }
        public long DepartmentId { get; set; }

        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            } 
        }
    }
}