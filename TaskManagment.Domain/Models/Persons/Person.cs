namespace TaskManagement.Application.Models.Persons;

public class Person : BaseEntity
{
    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    private Person()
    {

    }

    public Person(
        string firstName,
        string lastName,
        string email,
        string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }
}
