namespace WeakEvents;

public partial class Subject(int id)
{
    public int Id { get; } = id;

    // this is in progress - C# 14
    // public partial event EventHandler<SubjectEventArgs> SomeEvent;

    private readonly WeakEvent<SubjectEventArgs> _weakEvent = new();
    public event EventHandler<SubjectEventArgs> SomeEvent
    {
        add
        {
            _weakEvent.AddHandler(value);
        }
        remove
        {
            _weakEvent.RemoveHandler(value);
        }
    }

    public void RaiseEvent()
    {
        _weakEvent.RaiseEvent(this, new SubjectEventArgs(Id));
    }
}
