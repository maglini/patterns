namespace FluentBuilder;

internal class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee()
            .BuildFirstName("Oleg")
            .BuildLastName("Serebryanikov")
            .BuildStartTime(DateTime.Parse("2008-10-01"))
            .BuildEndTime(DateTime.Parse("2012-05-26"))
            .BuildDepartment("Business analytics");
        
    }
}