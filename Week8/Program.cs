namespace Week8;

class Program
{
    public static void Main()
    {
        // Value type demo
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        
        // TODO: modify p2 and print both p1 and p2
        p2.X = 5;
        p2.Y = 3;

        p1.Print();
        p2.Print();
        
        // Reference type demo
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        
        // TODO: modify r2 and print both r1 and r2
        r2.X = 3;
        r2.Y = 67;
        
        r1.Print();
        r2.Print();
        
        // struct зберігається в stack, коли class в heap, в p1 робиться повна копія, а в r1 лише копіюється посилання
        // Boxing demo
        BoxingTester.Test();
    }
}