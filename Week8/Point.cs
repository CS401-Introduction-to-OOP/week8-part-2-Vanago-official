namespace Week8;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
// TODO: print coordinates
        Console.WriteLine($"X: {X}\nY: {Y}");
    }
}