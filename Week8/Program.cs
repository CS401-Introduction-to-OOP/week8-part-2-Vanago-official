namespace Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();

        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        
        using (var res = new FileResource("report.txt"))
        {
            res.Open();
        }
        

        manager.CloseAll();
// TODO:
// 1. Add resources to manager
// 2. Open all resources
// 3. Demonstrate using with one disposable resource
// 4. Close all resources
        Console.WriteLine("Done.");
    }
}