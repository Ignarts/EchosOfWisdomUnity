/// <summary>
/// Interface to define the methods that a copyable object should have.
/// </summary>
public interface ICopyable
{
    bool IsInRange();
    bool CanBeCopied();
    void SaveObject();
}
