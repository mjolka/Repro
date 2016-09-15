using System.Threading.Tasks;

public static class Foo
{
    public static async Task<int> GetAsync()
    {
        return await Task.FromResult(0);
    }
}
