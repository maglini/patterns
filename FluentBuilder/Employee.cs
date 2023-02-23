namespace FluentBuilder;

public class Employee 
{
    private string FirstName;
    private string LastName;
    private DateTime StartTime;
    private DateTime EndTime;
    private string Department;

    public Employee BuildFirstName(string firstName) {
        FirstName = firstName;
        return this;
    }

    public Employee BuildLastName(string lastName) {
        LastName = lastName;
        return this;
    }

    public Employee BuildStartTime(DateTime startTime) {
        StartTime = startTime;
        return this;
    }

    public Employee BuildEndTime(DateTime endTime) {
        EndTime = endTime;
        return this;
    }

    public Employee BuildDepartment(string department) {
        Department = department;
        return this;
    }

    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, StartTime: {StartTime}, EndTime: {EndTime}, Department: {Department}";
    }
}