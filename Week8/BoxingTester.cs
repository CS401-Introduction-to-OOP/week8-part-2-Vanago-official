namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; // запакував
        int c = (int)b; // розпакував
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c); // прінтанув все
        
        // коли запакував, то я значення з системного стеку додав в купу, це дуже дорого бо купа дозволяє зберігати данні в необмеженному обсязі.
        
// TODO:
// 1. box a into object
// 2. unbox back into int
// 3. print all values
// 4. add comments explaining what happens
    }
}