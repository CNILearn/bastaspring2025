
Person person = new () { FirstName = "Bruce", LastName = "Wayne" };
Console.WriteLine(person);

public partial class Person
{
    public required string FirstName
    {

        get => field;
        set => field = value;
    }

    public required string LastName
    {
        get;
        set => field = value;
    }

    public override string ToString() => $"{FirstName} {LastName}";
}
