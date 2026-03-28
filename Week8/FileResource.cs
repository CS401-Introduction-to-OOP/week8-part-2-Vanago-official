namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
// TODO: implement
        IsOpen = true;
        Console.WriteLine($"відкрито | {Name}");
        
    }

    public override void Close()
    {
// TODO: implement
        IsOpen = false;
        Console.WriteLine($"закрито | {Name}");
    }

    public void Dispose()
    {
// TODO: call Close() and print diagnostic message
        Close();
        Console.WriteLine($"disposed | {Name}");
    }
}