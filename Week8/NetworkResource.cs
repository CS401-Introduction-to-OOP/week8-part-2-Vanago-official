namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
// TODO: implement
        IsOpen = true;
        Console.WriteLine("відкрито");
    }

    public override void Close()
    {
// TODO: implement
        IsOpen = false;
        Console.WriteLine("закрито");
    }

    public void Dispose()
    {
// TODO: call Close() and print diagnostic message
        Close();
    }
}