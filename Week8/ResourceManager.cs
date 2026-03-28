namespace Week8;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
// TODO: add resource to list
        _resources.Add(resource);
    }
    public void OpenAll()
    {
// TODO: open every resource
        foreach (var resource in _resources)
        {
            resource.Open();
        }
    }
    public void CloseAll()
    {
// TODO: close every resource
        foreach (var resource in _resources)
        {
            resource.Close();
        }
    }
}